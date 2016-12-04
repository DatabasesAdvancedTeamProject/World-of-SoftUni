namespace WorldOfSoftUniRPG.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WorldOfSoftUniRPG.Models;

    public class WorldOfSoftUniContext : DbContext
    {
        public WorldOfSoftUniContext()
            : base("name=WorldOfSoftUniContext")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}