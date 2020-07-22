using System;  
using System.ComponentModel.DataAnnotations;  
  
namespace inventory.core.Models  
{  
    public class InventoryViewModel  
    {  
        public int Id { get; set; }
        [Display(Name = "Product Category")]  
        public string ProductCategory { get; set; }  
        [Display(Name = "Product Name")]  
        public string ProductName { get; set; }
        [Display(Name = "Product Cost")]   
        public decimal PurchaseCost { get; set; } 
        [Display(Name = "Product Price")]  
        public decimal SellingPrice { get; set; }  
        [Display(Name = "Supplier Name")]  
        public string Supplier { get; set; }
        [Display(Name = "Product Quantity")]   
        public Int32 ProductQuantity { get; set; }   
    }  
} 