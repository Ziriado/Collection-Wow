using Microsoft.EntityFrameworkCore;
using TestAPiMount.Models;

namespace TestAPiMount.DAL
{
    public class MountManager
    {
        public static List<Models.Mount>Mounts { get; set; }
        private readonly MyDBContext _context;
        public MountManager(MyDBContext context)
        {
            _context = context;
        }
        public  async Task<List<Mount>> GetMounts()
        {
            List<Models.Mount> mounts = await _context.Mount.ToListAsync();
            if(mounts == null)
            {
                mounts=Models.Mount.AddMountToDb();
                await _context.AddRangeAsync(mounts);
                await _context.SaveChangesAsync();
            }
            return mounts;
        }

        public  async Task<Models.Mount>GetOneMount(int id)
        {
            if (Mounts == null || !Mounts.Any())
            {
                Mounts = await GetMounts() ;
            }

            var existingProd = Mounts.Where(p => p.Id == id).SingleOrDefault();

            if (existingProd != null)
            {
                return existingProd;
            }
            else
            {
                return null;
            }
        }
        public  async Task CreateMount(Models.Mount mount)
        {
            if (Mounts is null)
            {
                Mounts = await GetMounts();
            }
            var tempId = Mounts.LastOrDefault();
            mount.Id = tempId.Id + 1;
            Mounts.Add(mount);

        }
        public  async Task UpdateMount(Models.Mount mount, int id)
        {
            if (Mounts is null)
            {
                Mounts = await GetMounts();
            }

            var existingMount = Mounts.Where(p => p.Id == id).SingleOrDefault();

            if (existingMount != null)
            {
                existingMount.WebLink = mount.WebLink;
                existingMount.ImgLink = mount.ImgLink;
                existingMount.Expansion = mount.Expansion;
                existingMount.Class = mount.Class;
                existingMount.Faction = mount.Faction;
                existingMount.Name = mount.Name;
            }

        }
        public  async Task DeleteMount(int id)
        {
            if (Mounts is null)
            {
                Mounts = await GetMounts();
            }

            Mounts.RemoveAt(id);
        }
    }
}
