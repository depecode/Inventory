using Microsoft.EntityFrameworkCore;
using inventory.core.Models;

namespace inventory.data
{
    public class InventoryContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=../inventory.app/inventory.db");
        }

        // public InventoryContext (DbContextOptions<InventoryContext> options)
        //     : base(options)
        // {
        // }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
    }
}