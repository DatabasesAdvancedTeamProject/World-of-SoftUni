namespace WorldOfSoftUniRPG.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AttackItems")]
    public class AttackItem : Item
    {
        public int Attack { get; set; }
    }
}