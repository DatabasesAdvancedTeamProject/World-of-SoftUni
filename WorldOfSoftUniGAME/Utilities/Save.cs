namespace WorldOfSoftuniRPG.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using WorldOfSoftuniRPG.Enumerations;
    using WorldOfSoftuniRPG.Interafaces;
    using WorldOfSoftuniRPG.Models.Fields;
    using WorldOfSoftuniRPG.Models.Items.AttackItems;
    using WorldOfSoftuniRPG.Models.Items.DefenseItems;
    using WorldOfSoftuniRPG.Models.Items.UniqueItem;

    using WorldOfSoftUniRPG.Data;
    using WorldOfSoftUniRPG.Models;

    public class Save
    {
        public static void SaveHeroInformation()
        {
            var context = new WorldOfSoftUniContext();
            var currentUser = context.Users.FirstOrDefault(u => u.IsLogged);

            currentUser.Hero.Attack = Field.Hero.Attack;
            currentUser.Hero.Deffence = Field.Hero.Defence;
            currentUser.Hero.Experience = Field.Hero.Experience;
            currentUser.Hero.Gold = Field.Hero.Gold;
            currentUser.Hero.Health = Field.Hero.Health;
            currentUser.Hero.Kills = Field.Hero.Kills;
            currentUser.Hero.Level = Field.Hero.Level;
            var itemsDto = Field.Hero.Inventory.Items;
            var items = currentUser.Hero.Inventory.Items.ToList();

            ReFillInventory(items, context);

            foreach (var itemDto in itemsDto)
            {
                GetItem(itemDto, currentUser, context);
            }
        }

        private static void ReFillInventory(ICollection<Item> items, WorldOfSoftUniContext context)
        {
            foreach (var item in items)
            {
                context.Items.Remove(item);
                context.SaveChanges();
            }

            items.Clear();
            context.SaveChanges();
        }

        private static void GetItem(IItem itemDto, User currentUser, WorldOfSoftUniContext context)
        {
            var itemArgs = itemDto.ToString().Trim().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var type = itemArgs[0];
            var part = itemArgs[1];
            if (itemArgs.Length == 4)
            {
                switch (part)
                {
                    case "Sword":
                        var sword = new Sword { ItemType = (ItemType)Enum.Parse(typeof(ItemType), type, true) };
                        var attackItem = new AttackItem
                        {
                            ItemType = sword.ItemType.ToString(),
                            Price = sword.Price,
                            Attack = sword.Attack,
                            Part = part
                        };
                        currentUser.Hero.Inventory.Items.Add(attackItem);
                        break;
                    case "Helmet":
                        var helmet = new Helmet { ItemType = (ItemType)Enum.Parse(typeof(ItemType), type, true) };
                        var defenceItem = new DefenceItem
                        {
                            ItemType = helmet.ItemType.ToString(),
                            Price = helmet.Price,
                            Defence = helmet.Defence,
                            Part = part
                        };
                        currentUser.Hero.Inventory.Items.Add(defenceItem);
                        break;
                }
            }
            else
            {
                switch (part)
                {
                    case "Belt":
                        var belt = new Belt { ItemType = (ItemType)Enum.Parse(typeof(ItemType), type, true) };
                        var beltItem = new DefenceAttack
                        {
                            ItemType = belt.ItemType.ToString(),
                            Price = belt.Price,
                            Defence = belt.Defence,
                            Attack = belt.Attack,
                            Part = part
                        };
                        currentUser.Hero.Inventory.Items.Add(beltItem);
                        break;
                    case "Boots":
                        var boots = new Boots { ItemType = (ItemType)Enum.Parse(typeof(ItemType), type, true) };
                        var bootsItem = new DefenceAttack
                        {
                            ItemType = boots.ItemType.ToString(),
                            Price = boots.Price,
                            Defence = boots.Defence,
                            Attack = boots.Attack,
                            Part = part
                        };
                        currentUser.Hero.Inventory.Items.Add(bootsItem);
                        break;
                    case "Chest":
                        var chest = new Chest { ItemType = (ItemType)Enum.Parse(typeof(ItemType), type, true) };
                        var chestItem = new DefenceAttack
                        {
                            ItemType = chest.ItemType.ToString(),
                            Price = chest.Price,
                            Defence = chest.Defence,
                            Attack = chest.Attack,
                            Part = part
                        };
                        currentUser.Hero.Inventory.Items.Add(chestItem);
                        break;
                    case "Pants":
                        var pants = new Pants { ItemType = (ItemType)Enum.Parse(typeof(ItemType), type, true) };
                        var pantsItem = new DefenceAttack
                        {
                            ItemType = pants.ItemType.ToString(),
                            Price = pants.Price,
                            Defence = pants.Defence,
                            Attack = pants.Attack,
                            Part = part
                        };
                        currentUser.Hero.Inventory.Items.Add(pantsItem);
                        break;
                }
            }

            context.SaveChanges();
        }
    }
}
