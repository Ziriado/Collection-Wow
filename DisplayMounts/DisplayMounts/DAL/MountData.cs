using System.Text.Json;
namespace DisplayMounts.DAL
{
    public class MountData
    {
        private static Uri BaseAdress = new Uri("https://localhost:7091/");
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
    }
}
