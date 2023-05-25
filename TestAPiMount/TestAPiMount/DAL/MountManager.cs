namespace TestAPiMount.DAL
{
    public class MountManager
    {
        public static List<Models.Mount>Mounts { get; set; }


        public static async Task<Models.Mount>GetOneMount(int id)
        {
            if (Mounts == null || !Mounts.Any())
            {
                Mounts =  Models.Mount.GetMounts();
            }

            var existingProd = Mounts.Where(p => p.ID == id).SingleOrDefault();

            if (existingProd != null)
            {
                return existingProd;
            }
            else
            {
                return null;
            }
        }
        public static async Task CreateMount(Models.Mount mount)
        {
            if (Mounts is null)
            {
                Mounts = Models.Mount.GetMounts();
            }
            var tempId = Mounts.LastOrDefault();
            mount.ID = tempId.ID + 1;
            Mounts.Add(mount);

        }
        public static async Task UpdateMount(Models.Mount mount, int id)
        {
            if (Mounts is null)
            {
                Mounts = Models.Mount.GetMounts();
            }

            var existingMount = Mounts.Where(p => p.ID == id).SingleOrDefault();

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
        public static async Task DeleteMount(int id)
        {
            if (Mounts is null)
            {
                Mounts = Models.Mount.GetMounts();
            }

            Mounts.RemoveAt(id);
        }
    }
}
