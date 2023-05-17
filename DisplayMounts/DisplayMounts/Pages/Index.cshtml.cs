using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DisplayMounts.Pages
{
    public class IndexModel : PageModel
    {
        public List<Models.Mounts> Mounts { get; set; }
        public List <Models.Mounts>WrathMounts { get; set; }
        public List<Models.Mounts> TbcMounts { get; set; }
        public List<Models.Mounts> VanillaMounts { get; set; }
        public List<Models.Mounts> VanillaMountsNeutral { get; set; }
        public List<Models.Mounts> VanillaMountsAliance { get; set; }
        public List<Models.Mounts> VanillaMountsHorde { get; set; }
        public List<Models.Mounts> TbcMountsNeutral { get; set; }
        public List<Models.Mounts> TbcMountsAliance { get; set; }
        public List<Models.Mounts> TbcMountsHorde { get; set; }
        public List<Models.Mounts> WrathMountsNeutral { get; set; }
        public List<Models.Mounts> WrathMountsAliance { get; set; }
        public List<Models.Mounts> WrathMountsHorde { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            Mounts = await DAL.MountData.GetMounts();

            WrathMounts =Mounts.Where(x => x.Expansion == "Wrath of the Lich King").ToList();
            TbcMounts = Mounts.Where(x => x.Expansion == "Burning Crusade").ToList();
            VanillaMounts = Mounts.Where(x => x.Expansion == "Vanilla").ToList();

            VanillaMountsNeutral = VanillaMounts.Where(x => x.Faction == "Neutral").ToList();
            VanillaMountsAliance = VanillaMounts.Where(x => x.Faction == "Aliance").ToList();
            VanillaMountsHorde = VanillaMounts.Where(x => x.Faction =="Horde").ToList();

            TbcMountsNeutral = TbcMounts.Where(x => x.Faction == "Neutral").ToList();
            TbcMountsAliance = TbcMounts.Where(x => x.Faction == "Aliance").ToList();
            TbcMountsHorde = TbcMounts.Where(x => x.Faction == "Horde").ToList();

            WrathMountsNeutral = WrathMounts.Where(x => x.Faction == "Neutral").ToList();
            WrathMountsAliance = WrathMounts.Where(x => x.Faction == "Aliance").ToList();
            WrathMountsHorde = WrathMounts.Where(x => x.Faction == "Horde").ToList();

            return Page();
        }
    }
}