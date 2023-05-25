namespace DisplayMounts.DAL
{
    public class MountDataOne
    {
        public static async Task<Models.Mounts> GetOne(List<Models.Mounts> mounts, int id)
        {
            var oneMount = mounts.Where(x => x.Id == id).FirstOrDefault();

            return oneMount;
        }
    }
}
