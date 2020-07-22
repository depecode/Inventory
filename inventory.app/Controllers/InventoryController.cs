using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

using inventory.core.Models;
using inventory.business.Services;

namespace inventory.app.Controllers
{
     public class InventoryController : Controller
    {
        private IInventoryService inventoryService;

        public InventoryController(IInventoryService inventoryService)
            { this.inventoryService = inventoryService; }
       
        public IActionResult Index()
        {
            List<InventoryViewModel> model = new List<InventoryViewModel>(); 
            inventoryService.GetAllInventories().ToList().ForEach( i => {
                InventoryViewModel inventory = new InventoryViewModel {
                    Id = i.Id,
                    ProductCategory = i.ProductCategory,
                    ProductName = i.ProductName,
                    PurchaseCost = i.PurchaseCost,
                    SellingPrice = i.SellingPrice,
                    ProductQuantity = i.ProductQuantity,
                    Supplier = i.Supplier,
                };
                model.Add(inventory);
            });  
  
            return View(model);
            // return View();
        }

        [HttpGet]  
        public ActionResult AddInventory()  
        {  
           Inventory model = new Inventory();  
  
            return PartialView("_AddInventory", model);  
        }  
  
        [HttpPost]  
        public ActionResult AddInventory(Inventory model)  
        {  
            Inventory inventoryEntity = new Inventory  
            {  
                ProductName = model.ProductName,    
            };  
            inventoryService.CreateInventory(inventoryEntity);  
            if (inventoryEntity.Id > 0)  
            {  
                return RedirectToAction("index");  
            }  
            return View(model);  
        }

    }
}