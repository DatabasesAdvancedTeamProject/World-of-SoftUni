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
            var unitOfWork = new UnitOfWork();
            var currentUser = unitOfWork.Users.First(u => u.IsLogged);

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

            LoadEnemies(currentUser.Hero.Kills);  

            return true;
        }

        private static void LoadEnemies(int kills)
        {
            if (kills >= 1 && kills <= 3)
            {
                var ghoulToAdd = 0;
                if (kills == 3)
                {
                    ghoulToAdd = 3;
                }
                else
                {
                   ghoulToAdd  = kills % 3;
                }
               
                BattleField.AttackedEnemies[EnemyType.Ghoul] += ghoulToAdd;
            }
            else if (kills >= 4 && kills <= 6)
            {
                var hydraToAdd = 0;
                if (kills == 6)
                {
                    hydraToAdd = 6;
                }
                else
                {
                    hydraToAdd = kills % 3;
                }

                BattleField.AttackedEnemies[EnemyType.Ghoul] += 3;
                BattleField.AttackedEnemies[EnemyType.Hydra] += hydraToAdd;
            }
            else if (kills >= 7 && kills <= 9)
            {
                var supToAdd = 0;
                if (kills == 9)
                {
                    supToAdd = 9;
                }
                else
                {
                    supToAdd = kills % 3;
                }

                BattleField.AttackedEnemies[EnemyType.Ghoul] += 3;
                BattleField.AttackedEnemies[EnemyType.Hydra] += 3;
                BattleField.AttackedEnemies[EnemyType.Supremus] += supToAdd;
            }
            else if (kills >= 10 && kills <= 12)
            {
                var rotfaceToAdd = 0;
                if (kills == 12)
                {
                    rotfaceToAdd = 12;
                }
                else
                {
                    rotfaceToAdd = kills % 3;
                }

                BattleField.AttackedEnemies[EnemyType.Ghoul] += 3;
                BattleField.AttackedEnemies[EnemyType.Hydra] += 3;
                BattleField.AttackedEnemies[EnemyType.Supremus] += 3;
                BattleField.AttackedEnemies[EnemyType.Rotface] += rotfaceToAdd;
            }
            else if (kills >= 13 && kills <= 15)
            {
                var lichKingToAdd = 0;
                if (kills == 15)
                {
                    lichKingToAdd = 15;
                }
                else
                {
                    lichKingToAdd = kills % 3;
                }

                BattleField.AttackedEnemies[EnemyType.Ghoul] += 3;
                BattleField.AttackedEnemies[EnemyType.Hydra] += 3;
                BattleField.AttackedEnemies[EnemyType.Supremus] += 3;
                BattleField.AttackedEnemies[EnemyType.Rotface] += 3;
                BattleField.AttackedEnemies[EnemyType.Lichking] += lichKingToAdd;
            }
            else
            {
                BattleField.AttackedEnemies[EnemyType.Ghoul] += 3;
                BattleField.AttackedEnemies[EnemyType.Hydra] += 3;
                BattleField.AttackedEnemies[EnemyType.Supremus] += 3;
                BattleField.AttackedEnemies[EnemyType.Rotface] += 3;
                BattleField.AttackedEnemies[EnemyType.Lichking] += 3;
                BattleField.AttackedEnemies[EnemyType.Deathwing]++;
            }
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