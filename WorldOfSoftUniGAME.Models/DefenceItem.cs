namespace WorldOfSoftUniRPG.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DefenceItems")]
    public class DefenceItem : Item
    {
        public int Defence { get; set; }
    }
}