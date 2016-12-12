namespace WorldOfSoftUniRPG.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DefenceAttackItems")]
    public class DefenceAttack : Item
    {
        public int Attack { get; set; }

        public int Defence { get; set; }
    }
}