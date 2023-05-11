using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAPiMount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MountController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<Models.Mount>> GetMounts()
        {
            return Models.Mount.GetMounts();
        }
    }
}
