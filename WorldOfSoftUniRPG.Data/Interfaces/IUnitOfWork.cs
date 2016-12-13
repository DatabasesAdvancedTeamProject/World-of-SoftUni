namespace WorldOfSoftUniRPG.Data.Interfaces
{
    using WorldOfSoftUniRPG.Models;

    public interface IUnitOfWork
    {
        IRepository<Item> Items { get; }

        IRepository<Hero> Heroes { get; }

        IRepository<User> Users { get; }

        IRepository<Inventory> Inventories { get; }
        
        void Commit();
    }
}