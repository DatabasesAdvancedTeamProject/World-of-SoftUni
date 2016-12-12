namespace WorldOfSoftUniRPG.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics;

    public class Inventory
    {
        public Inventory()
        {
            this.Items = new List<Item>();
        }

        [Key, ForeignKey("Hero")]
        public int Id { get; set; }
       
        public virtual Hero Hero { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}