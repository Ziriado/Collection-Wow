using DisplayMounts.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DisplayMounts.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly UserManager<DisplayMountsUser> _userManger;
        [BindProperty]
        public Models.Mounts NewMount { get; set; }
        public List<Models.Mounts> Mounts { get; set; }
        public DisplayMountsUser MyUser { get; set; }
        public PrivacyModel(UserManager<DisplayMountsUser> userManager)
        {
            _userManger = userManager; 
        }

        public async Task<IActionResult>OnGetAsync(int editid,int deleteindex)
        {
            Mounts = await DAL.MountData.GetMounts();
                MyUser = await _userManger.GetUserAsync(User);

            if (editid != 0)
            {
                NewMount = await DAL.MountData.GetMount(editid);
            }

            if (deleteindex != 0)
            {
                await DAL.MountData.DeleteMount(deleteindex );
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

            if (NewMount != null) NewMount.Id = 0;
            MyUser = await _userManger.GetUserAsync(User);
            return Page();

        }
    }
}