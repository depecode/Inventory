using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using inventory.core.Models;

namespace inventory.business.Services
{
    public interface IInventoryService
    {
        IEnumerable<Inventory> GetAllInventories();
        Inventory GetInventoryById(int inventoryId);
        void CreateInventory(Inventory inventory);
        void DeleteInventory(int inventoryId);
    }
}