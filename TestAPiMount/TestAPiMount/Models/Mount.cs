using static System.Net.WebRequestMethods;

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
                Name = "Swift Yellow Mechanostrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/3484.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18774/swift-yellow-mechanostrider"
            });

            mounts.Add(new Mount
            {
                Name = "Swift White Mechanostrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/63971.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18773/swift-white-mechanostrider"
            });

            mounts.Add(new Mount
            {
                Name = "Swift Green Mechanostrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/86378.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18772/swift-green-mechanostrider"
            });

            mounts.Add(new Mount
            {
                Name = "Unpainted Mechanostrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/40868.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=13322/unpainted-mechanostrider"
            });

            mounts.Add(new Mount
            {
                Name = "Red Mechanostrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/4504.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=8563/red-mechanostrider"
            });

            mounts.Add(new Mount
            {
                Name = "Green Mechanostrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/2657.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=13321/green-mechanostrider"
            });

            mounts.Add(new Mount
            {
                Name = "Blue Mechanostrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/76763.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=8595/blue-mechanostrider"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Swift Stormsaber",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/871413.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18902/reins-of-the-swift-stormsaber"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Swift Mistsaber",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/83023.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18767/reins-of-the-swift-mistsaber"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Swift Frostsaber",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/80288.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18766/reins-of-the-swift-frostsaber"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Striped Nightsaber",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/87169.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=8629/reins-of-the-striped-nightsaber"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Striped Frostsaber",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/22995.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=8631/reins-of-the-striped-frostsaber"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Spotted Frostsaber",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/66536.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=8632/reins-of-the-spotted-frostsaber"
            });

            mounts.Add(new Mount
            {
                Name = "Swift White Ram",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/68612.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18785/swift-white-ram"
            });

            mounts.Add(new Mount
            {
                Name = "Swift Gray Ram",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/82902.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18787/swift-gray-ram"
            });

            mounts.Add(new Mount
            {
                Name = "Swift Brown Ram",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/70744.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18786/swift-brown-ram"
            });

            mounts.Add(new Mount
            {
                Name = "White Ram",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/50072.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=5873/white-ram"
            });

            mounts.Add(new Mount
            {
                Name = "Gray Ram",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/85164.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=5864/gray-ram"
            });

            mounts.Add(new Mount
            {
                Name = "Brown Ram",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/86481.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=5872/brown-ram"
            });

            mounts.Add(new Mount
            {
                Name = "Black Stallion Bridle",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/50576.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=2411/black-stallion-bridle"
            });

            mounts.Add(new Mount
            {
                Name = "Swift White Steed",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/81211.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18778/swift-white-steed"
            });

            mounts.Add(new Mount
            {
                Name = "Swift Palomino",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/64630.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18776/swift-palomino"
            });

            mounts.Add(new Mount
            {
                Name = "Swift Brown Steed",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/67082.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18777/swift-brown-steed"
            });

            mounts.Add(new Mount
            {
                Name = "Chestnut Mare Bridle",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/71300.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=5655/chestnut-mare-bridle"
            });

            mounts.Add(new Mount
            {
                Name = "Brown Horse Bridle",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/83375.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=5656/brown-horse-bridle"
            });

            mounts.Add(new Mount
            {
                Name = "Pinto Bridle",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/76990.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=2414/pinto-bridle"
            });

            mounts.Add(new Mount
            {
                Name = "Summon Charger",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/892479.jpg",
                Faction = faction[1],
                Class = playerClass[9],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/spell=23214/summon-charger"
            });

            mounts.Add(new Mount
            {
                Name = "Summon Warhorse",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/73903.jpg",
                Faction = faction[1],
                Class = playerClass[9],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/spell=13819/summon-warhorse"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Winterspring Frostsaber",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/85824.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=13086/reins-of-the-winterspring-frostsaber"
            });

            mounts.Add(new Mount
            {
                Name = "Stormpike Battle Charger",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/869575.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=19030/stormpike-battle-charger"
            });

            mounts.Add(new Mount
            {
                Name = "Black Battlestrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/868953.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18243/black-battlestrider"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Black War Tiger",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/78146.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18242/reins-of-the-black-war-tiger"
            });

            mounts.Add(new Mount
            {
                Name = "Black War Ram",
                ImgLink = "https://wow.zamimg.com/modelviewer/classic/webthumbs/npc/241/14577.webp",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18244/black-war-ram"
            });

            mounts.Add(new Mount
            {
                Name = "Black War Steed Bridle",
                ImgLink = "https://wow.zamimg.com/modelviewer/classic/webthumbs/npc/1/14337.webp",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18241/black-war-steed-bridle"
            });

            mounts.Add(new Mount
            {
                Name = "Horn of the Frostwolf Howler",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/909909.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=19029/horn-of-the-frostwolf-howler"
            });

            mounts.Add(new Mount
            {
                Name = "Whistle of the Black War Raptor",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/66225.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18246/whistle-of-the-black-war-raptor"
            });

            mounts.Add(new Mount
            {
                Name = "Black War Kodo",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/2968.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18247/black-war-kodo"
            });

            mounts.Add(new Mount
            {
                Name = "Red Skeletal Warhorse",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/29202.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18248/red-skeletal-warhorse"
            });

            mounts.Add(new Mount
            {
                Name = "Horn of the Black War Wolf",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/66239.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18245/horn-of-the-black-war-wolf"
            });

            mounts.Add(new Mount
            {
                Name = "Swift Orange Raptor",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/83561.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18790/swift-orange-raptor"
            });

            mounts.Add(new Mount
            {
                Name = "Swift Olive Raptor",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/70891.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18789/swift-olive-raptor"
            });

            mounts.Add(new Mount
            {
                Name = "Swift Blue Raptor",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/81634.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18788/swift-blue-raptor"
            });

            mounts.Add(new Mount
            {
                Name = "Whistle of the Violet Raptor",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/70894.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=8592/whistle-of-the-violet-raptor"
            });

            mounts.Add(new Mount
            {
                Name = "Whistle of the Turquoise Raptor",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/58216.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=8591/whistle-of-the-turquoise-raptor"
            });

            mounts.Add(new Mount
            {
                Name = "Whistle of the Emerald Raptor",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/68912.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=8588/whistle-of-the-emerald-raptor"
            });

            mounts.Add(new Mount
            {
                Name = "Great White Kodo",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/27474.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18793/great-white-kodo"
            });

            mounts.Add(new Mount
            {
                Name = "Great Gray Kodo",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/4609.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18795/great-gray-kodo"
            });

            mounts.Add(new Mount
            {
                Name = "Great Brown Kodo",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/5644.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18794/great-brown-kodo"
            });

            mounts.Add(new Mount
            {
                Name = "Gray Kodo",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/78441.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=15277/gray-kodo"
            });

            mounts.Add(new Mount
            {
                Name = "Brown Kodo",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/86526.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=15290/brown-kodo"
            });

            mounts.Add(new Mount
            {
                Name = "Purple Skeletal Warhorse",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/890246.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18791/purple-skeletal-warhorse"
            });

            mounts.Add(new Mount
            {
                Name = "Green Skeletal Warhorse",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/65549.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=13334/green-skeletal-warhorse"
            });

            mounts.Add(new Mount
            {
                Name = "Red Skeletal Horse",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1489.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=13331/red-skeletal-horse"
            });

            mounts.Add(new Mount
            {
                Name = "Brown Skeletal Horse",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/873885.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=13333/brown-skeletal-horse"
            });

            mounts.Add(new Mount
            {
                Name = "Blue Skeletal Horse",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/905464.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=13332/blue-skeletal-horse"
            });

            mounts.Add(new Mount
            {
                Name = "Horn of the Swift Timber Wolf",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/878946.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18797/horn-of-the-swift-timber-wolf"
            });

            mounts.Add(new Mount
            {
                Name = "Horn of the Swift Gray Wolf",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/18463.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18798/horn-of-the-swift-gray-wolf"
            });

            mounts.Add(new Mount
            {
                Name = "Horn of the Swift Brown Wolf",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/66449.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=18796/horn-of-the-swift-brown-wolf"
            });

            mounts.Add(new Mount
            {
                Name = "Horn of the Timber Wolf",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/79526.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=1132/horn-of-the-timber-wolf"
            });

            mounts.Add(new Mount
            {
                Name = "Horn of the Dire Wolf",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/86921.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=5665/horn-of-the-dire-wolf"
            });

            mounts.Add(new Mount
            {
                Name = "Horn of the Brown Wolf",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/876085.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=5668/horn-of-the-brown-wolf"
            });

            for (int i = 0; i < mounts.Count; i++) 
            {
                mounts[i].ID = i + 1;
            }
            return mounts;
        }
    }
}
