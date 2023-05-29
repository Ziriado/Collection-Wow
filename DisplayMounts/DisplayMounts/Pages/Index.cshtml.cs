using DisplayMounts.Areas.Identity.Data;
using DisplayMounts.Migrations;
using DisplayMounts.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DisplayMounts.Pages
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<DisplayMountsUser> _userManger;
        private readonly Data.DisplayMountsContext _context;

        public DisplayMountsUser MyUser { get; set; }
        public static List<Models.Mounts> Mounts { get; set; }
        public List<Models.MountCollected> MountsCollected { get; set; }
        public List<Models.Mounts> ShowMounts { get; set; }
        public Models.Mounts OneMount { get; set; }
        public List<Models.Comments> Comments { get; set; }
        [BindProperty]
        public Models.Comments Comment { get; set; }
        [BindProperty]
        public PreferencesModel Preferences { get; set; }

        public IndexModel(UserManager<DisplayMountsUser> userManager, Data.DisplayMountsContext context)
        {
            _userManger = userManager;
            _context = context;
            Mounts = new List<Models.Mounts>();
            ShowMounts = new List<Models.Mounts>();
            Preferences = new PreferencesModel
            {
                Factions = new List<string>(),
                Classes = new List<string>(),
                Expansions = new List<string>(),
                Collected = new List<string>()
            };
        }

        public async Task OnPost()
        {
            await SetUserPreference();
        }
        public async Task<IActionResult> OnPostToggleMount([FromForm] int mountId)
        {
            MyUser = await _userManger.GetUserAsync(User);
            var dbMountCollected = await _context.Collected
                .Where(x => x.UserId == MyUser.Id && x.MountId == mountId)
                .FirstOrDefaultAsync();

            if (dbMountCollected == null)
                _context.Add(new MountCollected { UserId = MyUser.Id, MountId = mountId });
            else
                _context.Remove(dbMountCollected);

            await _context.SaveChangesAsync();

            await ReloadPage(mountId);

            return Page();
        }
        public async Task<IActionResult> OnPostPostComment([FromForm] int mountId)
        {
            MyUser = await _userManger.GetUserAsync(User);
            Comment.CommentCreated = DateTime.Now;
            Comment.UserId = MyUser.Id;
            Comment.UserName = MyUser.CharacterName;
            Comment.MountId = mountId;
            _context.Add(Comment);
            await _context.SaveChangesAsync();

            await ReloadPage(mountId);

            return Page();
        }
        public async Task<IActionResult> OnPostRemoveComment([FromForm] int commentId)
        {
            var dbComments = await _context.Comment.Where(c => c.Id == commentId).FirstOrDefaultAsync();

            if (dbComments != null)
            {
                _context.Remove(dbComments);
                await _context.SaveChangesAsync();
            }

            await ReloadPage(dbComments.MountId);

            return Page();
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Mounts = await DAL.MountData.GetMounts();
            ShowMounts = await DAL.MountData.GetMounts();
            MyUser = await _userManger.GetUserAsync(User);

            if (User.Identity.IsAuthenticated && MyUser != null)
                MountsCollected = await _context.Collected.Where(x => x.UserId == MyUser.Id).ToListAsync();

            if (id != 0)
            {
                Comments = await _context.Comment.Where(c => c.MountId == id).ToListAsync();
                OneMount = Mounts.Where(x => x.Id == id).FirstOrDefault();
            }

            return Page();
        }

        public async Task<IActionResult> ReloadPage(int mountId = 0)
        {
            MyUser = await _userManger.GetUserAsync(User);
            Mounts = await DAL.MountData.GetMounts();

            if (User.Identity.IsAuthenticated && MyUser != null)
                MountsCollected = await _context.Collected.Where(x => x.UserId == MyUser.Id).ToListAsync();

            if (mountId != 0)
            {
                Comments = await _context.Comment.Where(c => c.MountId == mountId).ToListAsync();
                OneMount = Mounts.Where(x => x.Id == mountId).FirstOrDefault();
            }
            return Page();
        }

        public async Task SetUserPreference()
        {
            Mounts = await DAL.MountData.GetMounts();

            List<string> factionList = Preferences.Factions ?? new List<string> { "Neutral" };
            List<string> expansionList = Preferences.Expansions ?? new List<string> { "Vanilla", "Burning Crusade", "Wrath of the Lich King" };
            List<string> playerClassesList = Preferences.Classes ?? new List<string> { "Neutral" };

            if (User.Identity.IsAuthenticated)
            {
                MyUser = await _userManger.GetUserAsync(User);
                MountsCollected = await _context.Collected.Where(x => x.UserId == MyUser.Id).ToListAsync();

                if (Preferences.Factions == null) 
                    factionList.Add(MyUser.Faction);

                if (Preferences.Classes == null)
                    playerClassesList.Add(MyUser.Class);
            }

            ShowMounts = factionList
                .SelectMany(faction => playerClassesList
                    .SelectMany(playerClass => expansionList
                        .SelectMany(expansion => Mounts
                            .Where(m =>
                                m.Faction == faction &&
                                m.PlayerClass == playerClass &&
                                m.Expansion == expansion))))
                .ToList();

            if (Preferences.Collected != null && Preferences.Collected.Count == 1)
            {
                MyUser = await _userManger.GetUserAsync(User);
                var collectedMountId = await _context.Collected
                                        .Where(x => x.UserId == MyUser.Id)
                                        .Select(x => x.MountId)
                                        .ToListAsync();

                if (Preferences.Collected[0] == "Collected")
                    ShowMounts = ShowMounts.Where(m => collectedMountId.Contains(m.Id)).ToList();
                else if (Preferences.Collected[0] == "NotCollected")
                    ShowMounts = ShowMounts.Where(m => !collectedMountId.Contains(m.Id)).ToList();
            }
        }
    }
}