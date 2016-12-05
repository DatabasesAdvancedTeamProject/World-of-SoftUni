namespace WorldOfSoftUniRPG.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Hero
    {
        [Key]
        public int Id { get; set; }

        public string HeroType { get; set; }

        public int Health { get; set; }

        public int Attack { get; set; }

        public int Deffence { get; set; }

        public int Experience { get; set; }

        public int Gold { get; set; }

        public int Kills { get; set; }

        public int Level { get; set; }

        public virtual Inventory Inventory { get; set; }
    }
}