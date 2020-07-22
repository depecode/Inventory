using System;  
using System.ComponentModel.DataAnnotations;  
  
namespace inventory.core.Models  
{  
    public class WarehouseViewModel  
    {  
         public int Id { get; set; }
        [Display(Name = "Product Category")]  
        public string ProductCategory { get; set; }  
        [Display(Name = "product Name")]  
        public string ProductName { get; set; }
        [Display(Name = "product Cost")]   
        public decimal PurchaseCost { get; set; }  
        [Display(Name = "Supplier Name")]  
        public string Supplier { get; set; }
        [Display(Name = "Product Quantity")]   
        public Int32 ProductQuantity { get; set; }
         [Display(Name = "Product Shelf Number")]   
        public Int32 ShelfNumber { get; set; } 
    }  
} 