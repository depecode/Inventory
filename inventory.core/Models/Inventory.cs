using System;
using System.ComponentModel.DataAnnotations;

namespace inventory.core.Models
{
    public class Inventory : BaseEntity
    {
        public string ProductCategory { get; set; }
        public string ProductName { get; set; }
        public decimal PurchaseCost { get; set; }
        public decimal SellingPrice { get; set; }
        public string Supplier { get; set; }
        public Int32 ProductQuantity { get; set; }

    }
}