namespace WorldOfSoftUniRPG.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public abstract class Item
    {
        public Item()
        {
            this.Inventories = new List<Inventory>();
        }

        [Key]
        public int Id { get; set; }

        public int Price { get; set; }

        public string Part { get; set; }

        public string ItemType { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}