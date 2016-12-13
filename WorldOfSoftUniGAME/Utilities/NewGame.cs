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
            var unitOfWork = new UnitOfWork();
            var currentUser = unitOfWork.Users.First(u => u.IsLogged);

            if (currentUser.Hero == null)
            {
                var hero = new Hero() { User = currentUser };
                currentUser.Hero = hero;
                unitOfWork.Commit();
                var inventory = new Inventory() { Hero = currentUser.Hero };
                currentUser.Hero.Inventory = inventory;
                unitOfWork.Commit();
            }
            else
            {
                var items = currentUser.Hero.Inventory.Items.ToArray();
                foreach (var item in items)
                {
                    currentUser.Hero.Inventory.Items.Remove(item);
                    unitOfWork.Items.Remove(item);

                    unitOfWork.Commit();
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

            unitOfWork.Commit();
        }
    }
}