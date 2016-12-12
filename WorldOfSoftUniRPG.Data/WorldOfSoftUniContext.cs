namespace WorldOfSoftUniRPG.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Security.AccessControl;

    using WorldOfSoftUniRPG.Models;

    public class WorldOfSoftUniContext : DbContext
    {
        public WorldOfSoftUniContext()
            : base("name=WorldOfSoftUniContext")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Hero> Heroes { get; set; }

        public DbSet<Inventory> Inventories { get; set; }

        public DbSet<Item> Items { get; set; }
    }
}