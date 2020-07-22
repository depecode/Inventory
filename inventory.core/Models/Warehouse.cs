using System;
using System.ComponentModel.DataAnnotations;

namespace inventory.core.Models
{
    public class Warehouse : BaseEntity
    {
        public string ProductCategory { get; set; }
        public string ProductName { get; set; }
        public decimal PurchaseCost { get; set; }
        public string Supplier { get; set; }
        public Int32 ProductQuantity { get; set; }
        public Int32 ShelfNumber {get; set;}

    }
}