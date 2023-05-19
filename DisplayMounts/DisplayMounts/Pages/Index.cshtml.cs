using DisplayMounts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DisplayMounts.Pages
{
    public class IndexModel : PageModel
    {

        public IndexModel()
        {
            Mounts = new List<Models.Mounts>();
            ShowMounts = new List<Models.Mounts>();
        }

        [BindProperty]
        public PreferencesModel Preferences { get; set; }

        public static List<Models.Mounts> Mounts { get; set; }
        public List<Models.Mounts> ShowMounts { get; set; }
        public Models.Mounts OneMount { get; set; }

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

            if (id != 0)
            {
                OneMount = await DAL.MountDataOne.GetOne(Mounts, id);

            }
            if (moreInfo != null)
            {
                Response.Redirect(moreInfo);
            }

            return Page();
        }
    }
}