namespace Test
{
    using WorldOfSoftUniRPG.Data;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var context = new WorldOfSoftUniContext();
            context.Database.Initialize(true);
        }
    }
}