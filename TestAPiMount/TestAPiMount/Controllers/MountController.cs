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
        [HttpGet("{id}")]
        public async Task<Models.Mount>Get(int id)
        {
            var mount = await DAL.MountManager.GetOneMount(id);

            return mount;
        }
        [HttpPost]
        public async Task Post([FromBody]Models.Mount mount)
        {
            await DAL.MountManager.CreateMount(mount);
        }
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody]Models.Mount mount)
        {
            await DAL.MountManager.UpdateMount(mount, id);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await DAL.MountManager.DeleteMount(id);
        }
    }
}
