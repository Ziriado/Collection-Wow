using TestAPiMount.DAL;
using static System.Net.WebRequestMethods;

namespace TestAPiMount.Models
{
    public class Mount
    {
        public int Id { get; set; }
        public string ImgLink { get; set; }
        public string Name { get; set; }

        public string Faction { get; set; }
        public string WebLink { get; set; }

        public string Class { get; set; }

        public string Expansion { get; set; }
       
     
        public static List<Mount> AddMountToDb()
        {
            List<Mount> mounts = new List<Mount>();

            string[] faction = new string[]
            {
                "Neutral","Alliance","Horde"
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
            mounts.Add(new Mount
            {
                Name = "Black Hawkstrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/79155.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=29221/black-hawkstrider"
            });
            mounts.Add(new Mount
            {
                Name = "Purple Hawkstrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/15436.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=29222/purple-hawkstrider"
            });
            mounts.Add(new Mount
            {
                Name = "Red Hawkstrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/81725.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=28927/red-hawkstrider"
            });
            mounts.Add(new Mount
            {
                Name = "Blue Hawkstrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/76231.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=29220/blue-hawkstrider"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Pink Hawkstrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/83186.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=28936/swift-pink-hawkstrider"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Purple Hawkstrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/68734.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=29224/swift-purple-hawkstrider"
            });

            mounts.Add(new Mount
            {
                Name = "Swift Green Hawkstrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/68398.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=29223/swift-green-hawkstrider"
            });
            mounts.Add(new Mount
            {
                Name = "Brown Elekk",
                ImgLink = "https://wow.zamimg.com/modelviewer/tbc/webthumbs/npc/167/17063.webp",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=28481/brown-elekk"
            });
            mounts.Add(new Mount
            {
                Name = "Gray Elekk",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/65326.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=29744/gray-elekk"
            });
            mounts.Add(new Mount
            {
                Name = "Purple Elekk",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/80163.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=29743/purple-elekk"
            });
            mounts.Add(new Mount
            {
                Name = "Great Blue Elekk",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/73823.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=29745/great-blue-elekk"
            });
            mounts.Add(new Mount
            {
                Name = "Great Purple Elekk",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1025795.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=29747/great-purple-elekk"
            });
            mounts.Add(new Mount
            {
                Name = "Great Green Elekk",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/68606.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=29746/great-green-elekk"
            });
            mounts.Add(new Mount
            {
                Name = "Snowy Gryphon",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/85191.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=25472/snowy-gryphon"
            });
            mounts.Add(new Mount
            {
                Name = "Ebon Gryphon",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/70366.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=25471/ebon-gryphon"
            });
            mounts.Add(new Mount
            {
                Name = "Golden Gryphon",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/66883.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=25470/golden-gryphon"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Purple Gryphon",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/67486.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=25529/swift-purple-gryphon"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Blue Gryphon",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/82872.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=25473/swift-blue-gryphon"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Red Gryphon",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/73901.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=25527/swift-red-gryphon"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Green Gryphon",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/67485.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=25528/swift-green-gryphon"
            });
            mounts.Add(new Mount
            {
                Name = "Blue Windrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/80304.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=25475/blue-windrider"
            });
            mounts.Add(new Mount
            {
                Name = "Green Windrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/70921.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=25476/green-windrider"
            });
            mounts.Add(new Mount
            {
                Name = "Tawny Windrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/61647.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=25474/tawny-windrider"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Red Windrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/62131.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=25477/swift-red-windrider"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Green Windrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/80047.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=25531/swift-green-windrider"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Yellow Windrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/78653.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=25532/swift-yellow-windrider"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Purple Windrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/59874.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=25533/swift-purple-windrider"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Warstrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/82265.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=34129/swift-warstrider"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Black War Elekk",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/79242.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=35906/reins-of-the-black-war-elekk"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Dark Riding Talbuk",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/22150.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=28915/reins-of-the-dark-riding-talbuk"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Dark War Talbuk",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/30155.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=29228/reins-of-the-dark-war-talbuk"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Raven Lord",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/84670.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=32768/reins-of-the-raven-lord"
            });
            mounts.Add(new Mount
            {
                Name = "Swift White Hawkstrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/84475.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=35513/swift-white-hawkstrider"
            });
            mounts.Add(new Mount
            {
                Name = "Amani War Bear",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1056610.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=33809/amani-war-bear"
            });
            mounts.Add(new Mount
            {
                Name = "Ashes of Al'ar",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/78616.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=32458/ashes-of-alar#screenshots"
            });
            mounts.Add(new Mount
            {
                Name = "Fiery Warhorse's Reins",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1031624.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=30480/fiery-warhorses-reins"
            });
            mounts.Add(new Mount
            {
                Name = "The Horseman's Reins",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1036490.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=37012/the-horsemans-reins"
            });
            mounts.Add(new Mount
            {
                Name = "Great Brewfest Kodo",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1034793.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=37828/great-brewfest-kodo"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Brewfest Ram",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/74239.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=33977/swift-brewfest-ram"
            });
            mounts.Add(new Mount
            {
                Name = "Brewfest Ram",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/83527.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=33976/brewfest-ram"
            });
            mounts.Add(new Mount
            {
                Name = "Flying Machine Control",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/87206.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=34060/flying-machine-control"
            });
            mounts.Add(new Mount
            {
                Name = "Turbo-Charged Flying Machine Control",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/85469.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=34061/turbo-charged-flying-machine-control"
            });
            mounts.Add(new Mount
            {
                Name = "Cenarion War Hippogryph",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/82700.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=33999/cenarion-war-hippogryph"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Azure Netherwing Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/56256.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=32858/reins-of-the-azure-netherwing-drake"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Onyx Netherwing Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/78834.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=32857/reins-of-the-onyx-netherwing-drake"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Violet Netherwing Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/66999.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=32862/reins-of-the-violet-netherwing-drake"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Purple Netherwing Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/82060.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=32860/reins-of-the-purple-netherwing-drake"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Veridian Netherwing Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/79694.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=32861/reins-of-the-veridian-netherwing-drake"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Cobalt Netherwing Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1051366.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=32859/reins-of-the-cobalt-netherwing-drake"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Cobalt Riding Talbuk",
                ImgLink = "https://wow.zamimg.com/modelviewer/tbc/webthumbs/npc/81/21073.webp",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=31830/reins-of-the-cobalt-riding-talbuk"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the White Riding Talbuk",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/57442.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=31835/reins-of-the-white-riding-talbuk"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Tan Riding Talbuk",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/57440.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=31833/reins-of-the-tan-riding-talbuk"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Silver Riding Talbuk",
                ImgLink = "https://wow.zamimg.com/modelviewer/tbc/webthumbs/npc/83/21075.webp",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=31832/reins-of-the-silver-riding-talbuk"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Silver Riding Talbuk",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1038969.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=29227/reins-of-the-cobalt-war-talbuk"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Silver Riding Talbuk",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/86883.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=29103/reins-of-the-white-war-talbuk"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Tan War Talbuk",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/57441.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=29105/reins-of-the-tan-war-talbuk"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Silver War Talbuk",
                ImgLink = "https://wow.zamimg.com/modelviewer/tbc/webthumbs/npc/178/19378.webp",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=29229/reins-of-the-silver-war-talbuk"
            });
            mounts.Add(new Mount
            {
                Name = "Blue Riding Nether Ray",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/31262.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=32319/blue-riding-nether-ray"
            });
            mounts.Add(new Mount
            {
                Name = "Red Riding Nether Ray",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/55001.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=32317/red-riding-nether-ray"
            });
            mounts.Add(new Mount
            {
                Name = "Green Riding Nether Ray",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/83573.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=32314/green-riding-nether-ray"
            });
            mounts.Add(new Mount
            {
                Name = "Silver Riding Nether Ray",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1061832.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=32318/silver-riding-nether-ray"
            });
            mounts.Add(new Mount
            {
                Name = "Purple Riding Nether Ray",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/78412.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=32316/purple-riding-nether-ray"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Nether Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1051299.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=30609/swift-nether-drake"
            });
            mounts.Add(new Mount
            {
                Name = "Vengeful Nether Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/86979.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=37676/vengeful-nether-drake"
            });
            mounts.Add(new Mount
            {
                Name = "Merciless Nether Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/73914.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=34092/merciless-nether-drake"
            });
            mounts.Add(new Mount
            {
                Name = "Argent Charger",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/169920.jpg",
                Faction = faction[0],
                Class = playerClass[9],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=47179/argent-charger"
            });
            mounts.Add(new Mount
            {
                Name = "Argent Warhorse",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/168069.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=47180/argent-warhorse"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Armored Brown Bear",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/124339.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44225/reins-of-the-armored-brown-bear"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Armored Brown Bear",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/168588.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44226/reins-of-the-armored-brown-bear"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Black War Mammoth",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/138040.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=43956/reins-of-the-black-war-mammoth"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Black War Mammoth",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/167715.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44077/reins-of-the-black-war-mammoth"
            });
            mounts.Add(new Mount
            {
                Name = "Darkspear Raptor",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/158689.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=45593/darkspear-raptor"
            });
            mounts.Add(new Mount
            {
                Name = "Darnassian Nightsaber",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/133768.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=45591/darnassian-nightsaber"
            });
            mounts.Add(new Mount
            {
                Name = "Exodar Elekk",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/170794.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=45590/exodar-elekk"
            });
            mounts.Add(new Mount
            {
                Name = "Forsaken Warhorse",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/131348.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=45597/forsaken-warhorse"
            });
            mounts.Add(new Mount
            {
                Name = "Gnomeregan Mechanostrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/131354.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=45589/gnomeregan-mechanostrider"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Grand Ice Mammoth",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/135357.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=43961/reins-of-the-grand-ice-mammoth"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Grand Ice Mammoth",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/167316.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44086/reins-of-the-grand-ice-mammoth"
            });
            mounts.Add(new Mount
            {
                Name = "Great Golden Kodo",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/168292.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46750/great-golden-kodo"
            });
            mounts.Add(new Mount
            {
                Name = "Great Red Elekk",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/167541.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46745/great-red-elekk"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Ice Mammoth",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/142961.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=43958/reins-of-the-ice-mammoth"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Ice Mammoth",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/140010.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44080/reins-of-the-ice-mammoth"
            });
            mounts.Add(new Mount
            {
                Name = "Ironforge Ram",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/131075.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=45586/ironforge-ram"
            });
            mounts.Add(new Mount
            {
                Name = "Orgrimmar Wolf",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/143772.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=45595/orgrimmar-wolf"
            });
            mounts.Add(new Mount
            {
                Name = "Quel'dorei Steed",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/168554.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46815/queldorei-steed"
            });
            mounts.Add(new Mount
            {
                Name = "Silvermoon Hawkstrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/158691.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=45596/silvermoon-hawkstrider"
            });
            mounts.Add(new Mount
            {
                Name = "Stormwind Steed",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/131352.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=45125/stormwind-steed"
            });
            mounts.Add(new Mount
            {
                Name = "Sunreaver Hawkstrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/150240.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46816/sunreaver-hawkstrider"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Burgundy Wolf",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/168277.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46749/swift-burgundy-wolf"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Gray Steed",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/131225.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46752/swift-gray-steed"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Moonsaber",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/164141.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46744/swift-moonsaber"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Purple Raptor",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/158688.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46743/swift-purple-raptor"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Red Hawkstrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/145663.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46751/swift-red-hawkstrider"
            });
            mounts.Add(new Mount
            {
                Name = "Swift Violet Ram",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/131273.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46748/swift-violet-ram"
            });
            mounts.Add(new Mount
            {
                Name = "Thunder Bluff Kodo",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/158693.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=45592/thunder-bluff-kodo"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Traveler's Tundra Mammoth",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/163916.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44235/reins-of-the-travelers-tundra-mammoth"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Traveler's Tundra Mammoth",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/169342.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44234/reins-of-the-travelers-tundra-mammoth"
            });
            mounts.Add(new Mount
            {
                Name = "Turbostrider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/141453.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46747/turbostrider"
            });

            mounts.Add(new Mount
            {
                Name = "White Skeletal Warhorse",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/168502.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46746/white-skeletal-warhorse"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Wooly Mammoth",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/162056.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44230/reins-of-the-wooly-mammoth"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Wooly Mammoth",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/127412.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44231/reins-of-the-wooly-mammoth"
            });
            mounts.Add(new Mount
            {
                Name = "Argent Hippogryph",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/165275.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=45725/argent-hippogryph"
            });
            mounts.Add(new Mount
            {
                Name = "Armored Blue Wind Rider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/168280.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44690/armored-blue-wind-rider"
            });
            mounts.Add(new Mount
            {
                Name = "Armored Snowy Gryphon",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/167132.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44689/armored-snowy-gryphon"
            });
            mounts.Add(new Mount
            {
                Name = "Reins of the Red Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/169646.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=43955/reins-of-the-red-drake"
            });
            mounts.Add(new Mount
            {
                Name = "Silver Covenant Hippogryph",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/160284.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46813/silver-covenant-hippogryph"
            });
            mounts.Add(new Mount
            {
                Name = "Sunreaver Dragonhawk",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/168261.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46814/sunreaver-dragonhawk"
            });
            mounts.Add(new Mount
            {
                Name = "Winged Steed of the Ebon Blade",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/168983.jpg",
                Faction = faction[0],
                Class = playerClass[10],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=40775/winged-steed-of-the-ebon-blade"
            });
            mounts.Add(new Mount
            {
                Name = "Summon Dreadsteed",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/4449.jpg",
                Faction = faction[0],
                Class = playerClass[2],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/spell=23161/summon-dreadsteed"
            });

            mounts.Add(new Mount
            {
                Name = "Summon Felsteed",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1087775.jpg",
                Faction = faction[0],
                Class = playerClass[2],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/spell=5784/summon-felsteed"
            });

            mounts.Add(new Mount
            {
                Name = "Black Qiraji Resonating Crystal",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/984540.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=21176/black-qiraji-resonating-crystal"
            });

            mounts.Add(new Mount
            {
                Name = "Red Qiraji Resonating Crystal",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/81945.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=21321/red-qiraji-resonating-crystal"
            });

            mounts.Add(new Mount
            {
                Name = "Yellow Qiraji Resonating Crystal",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/67824.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=21324/yellow-qiraji-resonating-crystal"
            });

            mounts.Add(new Mount
            {
                Name = "Green Qiraji Resonating Crystal",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/86148.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=21323/green-qiraji-resonating-crystal"
            });

            mounts.Add(new Mount
            {
                Name = "Blue Qiraji Resonating Crystal",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/78061.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=21218/blue-qiraji-resonating-crystal"
            });

            mounts.Add(new Mount
            {
                Name = "Swift Zulian Tiger",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/958635.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=19902/swift-zulian-tiger"
            });

            mounts.Add(new Mount
            {
                Name = "Swift Razzashi Raptor",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/926592.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=19872/swift-razzashi-raptor"
            });

            mounts.Add(new Mount
            {
                Name = "Deathcharger's Reins",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/86980.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[0],
                WebLink = "https://www.wowhead.com/classic/item=13335/deathchargers-reins"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Grand Black War Mammoth",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/120075.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=43959/reins-of-the-grand-black-war-mammoth"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Grand Black War Mammoth",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/157006.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44083/reins-of-the-grand-black-war-mammoth"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Black Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/170571.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=43986/reins-of-the-black-drake"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Azure Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/168761.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=43952/reins-of-the-azure-drake"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Blue Proto-Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/169540.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44151/reins-of-the-blue-proto-drake"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Blue Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/167293.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=43953/reins-of-the-blue-drake"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Twilight Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1081663.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=43954/reins-of-the-twilight-drake"
            });

            mounts.Add(new Mount
            {
                Name = "Mimiron's Head",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1106288.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=45693/mimirons-head"
            });

            mounts.Add(new Mount
            {
                Name = "Invincible's Reins",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/171750.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=50818/invincibles-reins"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the White Polar Bear",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/168504.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=43962/reins-of-the-white-polar-bear"
            });

            mounts.Add(new Mount
            {
                Name = "X-45 Heartbreaker",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/168182.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=50250/x-45-heartbreaker"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Time-Lost Proto-Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1081254.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44168/reins-of-the-time-lost-proto-drake"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Green Proto-Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/170112.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44707/reins-of-the-green-proto-drake"
            });

            mounts.Add(new Mount
            {
                Name = "Sea Turtle",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1081413.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46109/sea-turtle"
            });

            mounts.Add(new Mount
            {
                Name = "Magnificent Flying Carpet",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/168513.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44558/magnificent-flying-carpet"
            });

            mounts.Add(new Mount
            {
                Name = "Frosty Flying Carpet",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/168162.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=54797/frosty-flying-carpet"
            });

            mounts.Add(new Mount
            {
                Name = "Flying Carpet",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/167026.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44554/flying-carpet"
            });

            mounts.Add(new Mount
            {
                Name = "Mechano-hog",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/170083.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=41508/mechano-hog"
            });

            mounts.Add(new Mount
            {
                Name = "Mekgineer's Chopper",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/159820.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44413/mekgineers-chopper"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Violet Proto-Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/170570.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44177/reins-of-the-violet-proto-drake"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Rusted Proto-Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/161712.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=45802/reins-of-the-rusted-proto-drake"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Red Proto-Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1081204.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44160/reins-of-the-red-proto-drake"
            });

            mounts.Add(new Mount
            {
                Name = "Red Dragonhawk Mount",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/150914.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44842/red-dragonhawk-mount"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Plagued Proto-Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/133059.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44175/reins-of-the-plagued-proto-drake"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Ironbound Proto-Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/166998.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=45801/reins-of-the-ironbound-proto-drake"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Icebound Frostbrood Vanquisher",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/170141.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=51955/reins-of-the-icebound-frostbrood-vanquisher"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Bronze Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/166969.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=43951/reins-of-the-bronze-drake"
            });

            mounts.Add(new Mount
            {
                Name = "Blue Dragonhawk Mount",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/166048.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44843/blue-dragonhawk-mount"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Bloodbathed Frostbrood Vanquisher",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/171926.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=51954/reins-of-the-bloodbathed-frostbrood-vanquisher"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Black Proto-Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/154361.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44164/reins-of-the-black-proto-drake"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Albino Drake",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1085642.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44178/reins-of-the-albino-drake"
            });

            mounts.Add(new Mount
            {
                Name = "Swift Horde Wolf",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/149245.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=49046/swift-horde-wolf"
            });

            mounts.Add(new Mount
            {
                Name = "Swift Alliance Steed",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/151644.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=49044/swift-alliance-steed"
            });

            mounts.Add(new Mount
            {
                Name = "Crusader's White Warhorse",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/169230.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=49096/crusaders-white-warhorse"
            });

            mounts.Add(new Mount
            {
                Name = "Crusader's Black Warhorse",
                ImgLink = "https://wow.zamimg.com/modelviewer/wrath/webthumbs/npc/242/29938.webp",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=49098/crusaders-black-warhorse"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Black War Bear",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/155538.jpg",
                Faction = faction[2],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44224/reins-of-the-black-war-bear"
            });

            mounts.Add(new Mount
            {
                Name = "Reins of the Black War Bear",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/167765.jpg",
                Faction = faction[1],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=44223/reins-of-the-black-war-bear"
            });

            mounts.Add(new Mount
            {
                Name = "Wrathful Gladiator's Frost Wyrm",
                ImgLink = "https://wow.zamimg.com/modelviewer/wrath/webthumbs/npc/71/31047.webp",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=50435/wrathful-gladiators-frost-wyrm"
            });

            mounts.Add(new Mount
            {
                Name = "Relentless Gladiator's Frost Wyrm",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/168910.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=47840/relentless-gladiators-frost-wyrm"
            });

            mounts.Add(new Mount
            {
                Name = "Furious Gladiator's Frost Wyrm",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/155542.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46171/furious-gladiators-frost-wyrm"
            });

            mounts.Add(new Mount
            {
                Name = "Deadly Gladiator's Frost Wyrm",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/166920.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=46708/deadly-gladiators-frost-wyrm"
            });
            mounts.Add(new Mount
            {
                Name = "Acherus Deathcharger",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/124002.jpg",
                Faction = faction[0],
                Class = playerClass[10],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/spell=48778/acherus-deathcharger"
            });
            mounts.Add(new Mount
            {
                Name = "Reawakened Phase-Hunter",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1048615.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[1],
                WebLink = "https://www.wowhead.com/tbc/item=184865/reawakened-phase-hunter"
            });
            mounts.Add(new Mount
            {
                Name = "Kalu'ak Whalebone Glider",
                ImgLink = "https://wow.zamimg.com/uploads/screenshots/small/1075958.jpg",
                Faction = faction[0],
                Class = playerClass[0],
                Expansion = expansion[2],
                WebLink = "https://www.wowhead.com/wotlk/item=192455/kaluak-whalebone-glider"
            });

            for (int i = 0; i < mounts.Count; i++)
            {
                mounts[i].Id = i + 1;
            }
            return mounts;
        }
    }
}
