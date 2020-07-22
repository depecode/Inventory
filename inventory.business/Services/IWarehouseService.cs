using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using inventory.core.Models;

namespace inventory.business.Services
{
    public interface IWarehouseService
    {
        IEnumerable<Warehouse> GetAllWarehouses();
        Warehouse GetWarehouseById(int warehouseId);
        void CreateWarehouse(Warehouse warehouse);
        void DeleteWarehouse(int warehouseId);
    }
}