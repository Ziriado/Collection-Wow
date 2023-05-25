using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DisplayMounts.Pages
{
    public class PrivacyModel : PageModel
    {
        [BindProperty]
        public Models.Mounts NewMount { get; set; }
        public List<Models.Mounts> Mounts { get; set; }
        [BindProperty]
        public string FactionName { get; set; }

        public async Task<IActionResult>OnGetAsync(int editid,int deleteindex)
        {
            Mounts = await DAL.MountData.GetMounts();

            if (editid != 0)
            {
                NewMount = await DAL.MountData.GetMount(editid);
            }

            if (deleteindex != 0)
            {
                await DAL.MountData.DeleteMount(deleteindex - 1);
                Mounts = await DAL.MountData.GetMounts();
            }

            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                await DAL.MountData.SaveMount(NewMount);
            }
            Mounts = await DAL.MountData.GetMounts();
            return Page();

        }
    }
}