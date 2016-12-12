namespace WorldOfSoftuniRPG.Utilities
{
    using System;
    using System.Linq;

    using WorldOfSoftuniRPG.Enumerations;
    using WorldOfSoftuniRPG.Interafaces;
    using WorldOfSoftuniRPG.Models.Fields;
    using WorldOfSoftuniRPG.Models.Items.AttackItems;
    using WorldOfSoftuniRPG.Models.Items.DefenseItems;
    using WorldOfSoftuniRPG.Models.Items.UniqueItem;
    using WorldOfSoftuniRPG.Models.Players;

    using WorldOfSoftUniRPG.Data;

    public class LoadGame
    {
        public static bool LoadHero()
        {
            var context = new WorldOfSoftUniContext();
            var currentUser = context.Users.FirstOrDefault(u => u.IsLogged);

            if (currentUser.Hero == null)
            {
                return false;
            }

            if (currentUser.Hero.HeroType == "Mage")
            {
                Field.Hero = new Mage();
                FillHeroProperties(currentUser);
            }
            else
            {
                Field.Hero = new Warrior();
                FillHeroProperties(currentUser);
            }
            

            return true;
        }

        private static void FillHeroProperties(WorldOfSoftUniRPG.Models.User currentUser)
        {
            Field.Hero.Attack = currentUser.Hero.Attack;
            Field.Hero.Defence = currentUser.Hero.Deffence;
            Field.Hero.Experience = currentUser.Hero.Experience;
            Field.Hero.Gold = currentUser.Hero.Gold;
            Field.Hero.Health = currentUser.Hero.Health;
            Field.Hero.Kills = currentUser.Hero.Kills;
            Field.Hero.Level = currentUser.Hero.Level;
            var items = currentUser.Hero.Inventory.Items;

            foreach (var item in items)
            {
                switch (item.Part)
                {
                    case "Sword":
                        IItem sword = new Sword() { ItemType = (ItemType)Enum.Parse(typeof(ItemType), item.ItemType, true) };
                        Field.Hero.Inventory.Items.Add(sword);
                        break;
                    case "Helmet":
                        IItem helmet = new Helmet() { ItemType = (ItemType)Enum.Parse(typeof(ItemType), item.ItemType, true) };
                        Field.Hero.Inventory.Items.Add(helmet);
                        break;
                    case "Belt":
                        IItem belt = new Belt() { ItemType = (ItemType)Enum.Parse(typeof(ItemType), item.ItemType, true) };
                        Field.Hero.Inventory.Items.Add(belt);
                        break;
                    case "Boots":
                        IItem boots = new Boots() { ItemType = (ItemType)Enum.Parse(typeof(ItemType), item.ItemType, true) };
                        Field.Hero.Inventory.Items.Add(boots);
                        break;
                    case "Chest":
                        IItem chest = new Chest() { ItemType = (ItemType)Enum.Parse(typeof(ItemType), item.ItemType, true) };
                        Field.Hero.Inventory.Items.Add(chest);
                        break;
                    case "Pants":
                        IItem pants = new Pants() { ItemType = (ItemType)Enum.Parse(typeof(ItemType), item.ItemType, true) };
                        Field.Hero.Inventory.Items.Add(pants);
                        break;
                }
            }
        }
    }
}