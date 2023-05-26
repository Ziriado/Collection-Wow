using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Security.Claims;
using TestAPiMount.Models;

namespace TestAPiMount.DAL
{
    public class MountManager
    {
        public static List<Models.Mount> Mounts { get; set; }
        private readonly MyDBContext _context;
        public MountManager(MyDBContext context)
        {
            _context = context;
        }
        public async Task<List<Mount>> GetMounts()
        {
            List<Models.Mount> mounts = await _context.Mount.ToListAsync();


            if (mounts.Count == 0)
            {
                mounts = Models.Mount.AddMountToDb();
                foreach (var mount in mounts)
                {
                    _context.Add(mount);
                }
                _context.SaveChanges();
            }
            return mounts;
        }

        public async Task<Models.Mount> GetOneMount(int id)
        {
            Mounts = await GetMounts();

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

        public async Task CreateMount(Models.Mount mount)
        {
            await _context.AddAsync(mount);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMount(Models.Mount mount, int id)
        {
            Mounts = await GetMounts();

            var existingMount = Mounts.Where(p => p.Id == id).FirstOrDefault();

            if (existingMount != null)
            {
                existingMount.WebLink = mount.WebLink;
                existingMount.ImgLink = mount.ImgLink;
                existingMount.Expansion = mount.Expansion;
                existingMount.Class = mount.Class;
                existingMount.Faction = mount.Faction;
                existingMount.Name = mount.Name;
                
            }
            await _context.SaveChangesAsync();
        }
        public async Task DeleteMount(int id)
        {
            if (Mounts is null)
            {
                Mounts = await GetMounts();
            }
            var existingMount = Mounts.Where(p => p.Id == id).FirstOrDefault();
            _context.Remove(existingMount);
            await _context.SaveChangesAsync();
        }
    }
}
