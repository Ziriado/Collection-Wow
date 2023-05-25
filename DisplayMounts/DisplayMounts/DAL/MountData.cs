using System.Text.Json;
namespace DisplayMounts.DAL
{
    public class MountData
    {
        private static Uri BaseAdress = new Uri("https://localhost:44305/");
        public static async Task<List<Models.Mounts>> GetMounts()
        {
            List<Models.Mounts> mounts = new();

            using (var client = new HttpClient())
            {
                client.BaseAddress = BaseAdress;
                HttpResponseMessage response = await client.GetAsync("api/Mount");
                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    mounts = JsonSerializer.Deserialize<List<Models.Mounts>>(responseString);
                }
                return mounts;
            }
        }
        public static async Task DeleteMount(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = BaseAdress;
                HttpResponseMessage response = await client.DeleteAsync("api/Mount/" + id);
            }
        }

        public static async Task<Models.Mounts> GetMount(int id)
        {
            Models.Mounts mount = new();

            using (var client = new HttpClient())
            {
                client.BaseAddress = BaseAdress;
                HttpResponseMessage response = await client.GetAsync("api/Mount/"+id);
                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    mount = JsonSerializer.Deserialize<Models.Mounts>(responseString);
                }
                return mount;
            }
        }
        public static async Task SaveMount(Models.Mounts mount)
        {
            var onemount = (await GetMounts()).Where(p => p.Id == mount.Id).FirstOrDefault();

            if (onemount != null)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = BaseAdress;
                    var json = JsonSerializer.Serialize(mount);
                    StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync("api/Mount/" + mount.Id, httpContent);

                }
            }
            else
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = BaseAdress;

                    var json = JsonSerializer.Serialize(mount);
                    StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync("api/Mount/", httpContent);

                }
            }
        }
    }
}
