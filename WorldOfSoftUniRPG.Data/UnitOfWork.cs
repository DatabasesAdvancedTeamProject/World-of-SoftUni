namespace WorldOfSoftUniRPG.Data
{
    using WorldOfSoftUniRPG.Data.Interfaces;
    using WorldOfSoftUniRPG.Models;

    public class UnitOfWork : IUnitOfWork
    {
        private WorldOfSoftUniContext context;
        private IRepository<User> users;
        private IRepository<Item> items;
        private IRepository<Inventory> inventories;
        private IRepository<Hero> heroes;

        public UnitOfWork()
        {
            this.context = new WorldOfSoftUniContext();
        }

        public IRepository<User> Users => this.users ?? (this.users = new Repository<User>(this.context.Users));


        public IRepository<Item> Items => this.items ?? (this.items = new Repository<Item>(this.context.Items));

        public IRepository<Inventory> Inventories => this.inventories ?? (this.inventories = new Repository<Inventory>(this.context.Inventories));

        public IRepository<Hero> Heroes => this.heroes ?? (this.heroes = new Repository<Hero>(this.context.Heroes));

        public void Commit()
        {
            this.context.SaveChanges();
        }
    }
}
