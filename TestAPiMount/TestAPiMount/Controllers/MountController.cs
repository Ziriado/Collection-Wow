using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAPiMount.DAL;

namespace TestAPiMount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MountController : ControllerBase
    {

        private readonly MountManager _mountManager;

        public MountController(MountManager mountManager)
        {
            _mountManager = mountManager;
        }

        [HttpGet]
        public async Task<IEnumerable<Models.Mount>> GetMounts()
        {
            return await _mountManager.GetMounts();
        }
        [HttpGet("{id}")]
        public async Task<Models.Mount>Get(int id)
        {

            return await _mountManager.GetOneMount(id);
        }
        [HttpPost]
        public async Task Post([FromBody]Models.Mount mount)
        {
            await _mountManager.CreateMount(mount);
        }
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody]Models.Mount mount)
        {
            await _mountManager.UpdateMount(mount, id);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _mountManager.DeleteMount(id);
        }
    }
}
