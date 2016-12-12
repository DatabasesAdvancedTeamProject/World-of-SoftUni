namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using WorldOfSoftuniRPG.Models.Fields;
    using WorldOfSoftuniRPG.Models.Players;

    using WorldOfSoftUniRPG.Data;
    using WorldOfSoftUniRPG.Models;

    public class Program
    {
        private static void Main(string[] args)
        {
            // var sword = new Pants();
            // sword.ItemType = ItemType.Legendary;
            // Console.WriteLine(sword.ToString());
            var n = new List<int>() { 1, 2, 3, 4, 5 };
            n.Clear();
            //foreach (var i in n)
            //{
            //    n.Remove(i);
            //}
            Console.WriteLine(n.Count);
            //var context = new WorldOfSoftUniContext();
            //context.Database.Initialize(true);
            //var currentUser = context.Users.FirstOrDefault(u => u.IsLogged);
            //var items = currentUser.Hero.Inventory.Items.ToArray();
            //foreach (var item in items)
            //{
            //    currentUser.Hero.Inventory.Items.Remove(item);
            //    context.Items.Remove(item);
            //}
            //context.SaveChanges();

            //var hero = new Hero() { User = currentUser };
            //currentUser.Hero = hero;
            //context.SaveChanges();

            //var inventory = new Inventory() { Hero = currentUser.Hero };
            //currentUser.Hero.Inventory = inventory;
            //context.SaveChanges();


            // currentUser.Hero.Attack = Field.Hero.Attack;
            // currentUser.Hero.Deffence = Field.Hero.Defence;
            // currentUser.Hero.Experience = Field.Hero.Experience;
            // currentUser.Hero.Gold = Field.Hero.Gold;
            // currentUser.Hero.Health = Field.Hero.Experience;
            // currentUser.Hero.Kills = Field.Hero.Kills;
            // currentUser.Hero.Level = Field.Hero.Level;
            // var items = Field.Hero.Inventory.Items;

            // var item = new Sword(ItemType.Default);
            // GetItem(item, currentUser, context);

            // foreach (var itemDto in items)
            // {
            // GetItem(itemDto, currentUser, context);
            // }
            //Field.Hero = new Mage();
            //var type = Field.Hero.GetType().Name;
            //Console.WriteLine(type);


            //var context = new WorldOfSoftUniContext();
            //context.Database.Initialize(true);
        }
    }
}