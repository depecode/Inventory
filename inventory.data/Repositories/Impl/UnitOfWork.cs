using inventory.core.Models;

namespace inventory.data.Repositories.Impl
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InventoryContext _inventoryContext;
        private IRepository<Employee> _employeeRepository;
        private IRepository<Inventory> _inventoryRepository;
        private IRepository<Warehouse> _warehouseRepository;

        public UnitOfWork(InventoryContext inventoryContext)
            { _inventoryContext = inventoryContext; }

        public IRepository<Employee> EmployeeRepository
        {
            get { return _employeeRepository = _employeeRepository ?? new Repository<Employee>(_inventoryContext); }
        }

        public IRepository<Inventory> InventoryRepository
        {
            get { return _inventoryRepository = _inventoryRepository ?? new Repository<Inventory>(_inventoryContext); }
        }

        public IRepository<Warehouse> WarehouseRepository
        {
            get { return _warehouseRepository = _warehouseRepository ?? new Repository<Warehouse>(_inventoryContext); }
        }

        public void Commit()
            { _inventoryContext.SaveChanges(); }

        public void Rollback()
            { _inventoryContext.Dispose(); }
    }
}