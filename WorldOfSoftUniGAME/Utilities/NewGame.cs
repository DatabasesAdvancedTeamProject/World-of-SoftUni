namespace WorldOfSoftuniRPG.Utilities
{
    using System.Linq;

    using WorldOfSoftuniRPG.Models.Fields;

    using WorldOfSoftUniRPG.Data;
    using WorldOfSoftUniRPG.Models;

    public class NewGame
    {
        public static void NewHero()
        {
            var context = new WorldOfSoftUniContext();
            var currentUser = context.Users.FirstOrDefault(u => u.IsLogged);

            if (currentUser.Hero == null)
            {
                var hero = new Hero() { User = currentUser };
                currentUser.Hero = hero;
                context.SaveChanges();
                var inventory = new Inventory() { Hero = currentUser.Hero };
                currentUser.Hero.Inventory = inventory;
                context.SaveChanges();
            }
            else
            {
                var items = currentUser.Hero.Inventory.Items.ToArray();
                foreach (var item in items)
                {
                    currentUser.Hero.Inventory.Items.Remove(item);
                    context.Items.Remove(item);

                    context.SaveChanges();
                }
            }

            currentUser.Hero.HeroType = Field.Hero.GetType().Name;
            currentUser.Hero.Attack = Field.Hero.Attack;
            currentUser.Hero.Deffence = Field.Hero.Defence;
            currentUser.Hero.Experience = Field.Hero.Experience;
            currentUser.Hero.Gold = Field.Hero.Gold;
            currentUser.Hero.Health = Field.Hero.Health;
            currentUser.Hero.Kills = Field.Hero.Kills;
            currentUser.Hero.Level = Field.Hero.Level;

            context.SaveChanges();
        }
    }
}