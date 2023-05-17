using System.Text.Json.Serialization;

namespace DisplayMounts.Models
{
    public class Mounts
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }
        [JsonPropertyName("imgLink")]
        public string ImgLink { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("faction")]
        public string Faction { get; set; }
        [JsonPropertyName("webLink")]
        public string WebLink { get; set; }
        [JsonPropertyName("class")]
        public string PlayerClass { get; set; }
        [JsonPropertyName("expansion")]
        public string Expansion { get; set; }
    }
}
