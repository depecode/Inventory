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
     public class WarehouseController : Controller
    {
       private IWarehouseService warehouseService;

        public WarehouseController(IWarehouseService warehouseService)
            { this.warehouseService = warehouseService; }
       
        public IActionResult Index()
        {
            List<WarehouseViewModel> model = new List<WarehouseViewModel>(); 
            warehouseService.GetAllWarehouses().ToList().ForEach( w => {
                WarehouseViewModel warehouse = new WarehouseViewModel {
                    Id = w.Id,
                    ProductCategory = w.ProductCategory,
                    ProductName = w.ProductName,
                    PurchaseCost = w.PurchaseCost,
                    Supplier = w.Supplier,
                    ProductQuantity = w.ProductQuantity,
                    ShelfNumber = w.ShelfNumber,
                };
                model.Add(warehouse);
            });  
  
            return View(model);
            // return View();
        }

        [HttpGet]  
        public ActionResult AddWarehouse()  
        {  
           Warehouse model = new Warehouse();  
  
            return PartialView("_AddWarehouse", model);  
        }  
  
        [HttpPost]  
        public ActionResult AddWarehouse(Warehouse model)  
        {  
            Warehouse warehouseEntity = new Warehouse  
            {  
                ProductName = model.ProductName,  
                
            };  
            warehouseService.CreateWarehouse(warehouseEntity);  
            if (warehouseEntity.Id > 0)  
            {  
                return RedirectToAction("index");  
            }  
            return View(model);  
        }

    }
}