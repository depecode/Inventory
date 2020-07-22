using inventory.core.Models;

namespace inventory.data.Repositories
{
    public interface IUnitOfWork
    {
        IRepository<Employee> EmployeeRepository { get; }
        IRepository<Inventory> InventoryRepository { get; }
        IRepository<Warehouse> WarehouseRepository { get; }
        void Commit();
        void Rollback();
    }
}