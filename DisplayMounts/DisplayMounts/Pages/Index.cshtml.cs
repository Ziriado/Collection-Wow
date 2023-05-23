using DisplayMounts.Areas.Identity.Data;
using DisplayMounts.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DisplayMounts.Pages
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<DisplayMountsUser> _userManger;
        private readonly Data.DisplayMountsContext _context;
     
        public DisplayMountsUser MyUser { get; set; }
        public IndexModel(UserManager<DisplayMountsUser>userManager,Data.DisplayMountsContext context)
        {
            Mounts = new List<Models.Mounts>();
            ShowMounts = new List<Models.Mounts>();
            _userManger = userManager;
            _context = context;
            
        }

        [BindProperty]
        public PreferencesModel Preferences { get; set; }

        public static List<Models.Mounts> Mounts { get; set; }
        public List<Models.MountCollected> MountsCollected { get; set; }
        [BindProperty]
        public Models.MountCollected MountCollected { get; set; }
        public List<Models.Mounts> ShowMounts { get; set; }
        public Models.Mounts OneMount { get; set; }
        public static int TempId { get; set; }
        public async Task OnPost()
        {
            Mounts = await DAL.MountData.GetMounts();
           
            await ShowUserPreference();

           
            
        }

        public async Task ShowUserPreference()
        {
            List<string> factionlist = new List<string>();
            List<string> expansionlist = new List<string>();
            List<string> playerClassesList = new List<string>();
            if (Preferences.Factions == null)
                factionlist.Add("Neutral");

            else
                factionlist = Preferences.Factions;

            if (Preferences.Expansions == null)
                expansionlist.Add("Vanilla");

            else
                expansionlist = Preferences.Expansions;

            if (Preferences.Classes == null)
                playerClassesList.Add("Neutral");

            else
                playerClassesList = Preferences.Classes;

            ShowMounts = factionlist.SelectMany
                (faction => playerClassesList.SelectMany
                (playerClass => expansionlist.SelectMany
                (expansion => Mounts.Where
                (m => m.Faction == faction && m.PlayerClass == playerClass && m.Expansion == expansion)))).ToList();
            
        }
        public async Task<IActionResult> OnGetAsync(int id, string moreInfo)
        {
            Mounts = await DAL.MountData.GetMounts();
            ShowMounts = await DAL.MountData.GetMounts();

            MyUser = await _userManger.GetUserAsync(User);

            if (id != 0)
            {
                OneMount = await DAL.MountDataOne.GetOne(Mounts, id);
                TempId = id;

            }
            if (moreInfo != null)
            {
                Response.Redirect(moreInfo);
            }
           
            return Page();
        }


        public async Task<IActionResult> OnPostSaveMount([FromForm] int mountId)
        {
            MyUser = await _userManger.GetUserAsync(User);
            MountCollected.MountId = mountId;
            MountCollected.UserId = MyUser.Id;
            _context.Add(MountCollected);
            await _context.SaveChangesAsync();
            
            return Page();
        }


    }
}