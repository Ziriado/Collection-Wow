using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DisplayTestApi.Pages
{
    public class IndexModel : PageModel
    {
        public List<Models.Mounts> Mounts { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            Mounts = await DAL.MountData.GetMounts();

            return Page();
        }
    }
}