using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using inventory.core.Models;
using inventory.data.Repositories;

namespace inventory.business.Services.Impl
{
    public class InventoryService : IInventoryService
    {
        private IUnitOfWork _unitOfWork;

        public InventoryService(IUnitOfWork unitOfWork)
        { _unitOfWork = unitOfWork; }

        public IEnumerable<Inventory> GetAllInventories() => _unitOfWork.InventoryRepository.GetAll();
        public Inventory GetInventoryById(int inventoryId) => _unitOfWork.InventoryRepository.GetById(inventoryId);
        public void CreateInventory(Inventory inventory)
        {
            _unitOfWork.InventoryRepository.Insert(inventory);
            _unitOfWork.Commit();
            return;
        }

        public void DeleteInventory(int inventoryId)
        {
            _unitOfWork.InventoryRepository.Delete(inventoryId);
            _unitOfWork.Commit();

        }
    }
}