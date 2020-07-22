using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using inventory.core.Models;
using inventory.data.Repositories;

namespace inventory.business.Services.Impl
{
    public class WarehouseService : IWarehouseService
    {
        private IUnitOfWork _unitOfWork;

        public WarehouseService(IUnitOfWork unitOfWork)
        { _unitOfWork = unitOfWork; }

        public IEnumerable<Warehouse> GetAllWarehouses() => _unitOfWork.WarehouseRepository.GetAll();
        public Warehouse GetWarehouseById(int warehouseId) => _unitOfWork.WarehouseRepository.GetById(warehouseId);
        public void CreateWarehouse(Warehouse warehouse)
        {
            _unitOfWork.WarehouseRepository.Insert(warehouse);
            _unitOfWork.Commit();
            return;
        }

        public void DeleteWarehouse(int warehouseId)
        {
            _unitOfWork.WarehouseRepository.Delete(warehouseId);
            _unitOfWork.Commit();

        }
    }
}