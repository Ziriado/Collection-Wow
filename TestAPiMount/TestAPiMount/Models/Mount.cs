namespace TestAPiMount.Models
{
    public class Mount
    {
        public int ID { get; set; }
        public string ImgLink { get; set; }
        public string Name { get; set; }

        public string Faction { get; set; }
        public string WebLink { get; set; }

        public string Class { get; set; }

        public string Expansion { get; set; }

        public static List<Mount> GetMounts()
        {
            List<Mount>mounts= new List<Mount>();

            string[] faction = new string[]
            {
                "Neutral","Aliance","Horde"
            };

            string[] playerClass = new string[]
            {
                "Neutral","Priest","Warlock","Mage","Druid","Rogue","Shaman","Hunter","Warrior","Paladin","Death Knight"
            };

            string[] expansion = new string[]
            {
                "Vanilla","Burning Crusade","Wrath of the Lich King"
            };

            mounts.Add(new Mount
            {
                Name = "Pinto Bridle",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/76990.jpg",
                Faction = faction[1],Class = playerClass[0],
                Expansion = expansion[0],WebLink = "https://www.wowhead.com/classic/item=2414/pinto-bridle" });
          

            for (int i = 0; i < mounts.Count; i++) 
            {
                mounts[i].ID = i + 1;
            }
            return mounts;
        }
    }
}
