using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using inventory.data;
using inventory.business.Services;
using inventory.business.Services.Impl;
using inventory.data.Repositories;
using inventory.data.Repositories.Impl;

namespace inventory.root
{
    public class CompositionRoot
    {
        public CompositionRoot() { }

        public static void injectDependencies(IServiceCollection services)
        {
            // services.AddDbContext<InventoryContext>(opts => opts.UseInMemoryDatabase("database"));
            services.AddEntityFrameworkSqlite().AddDbContext<InventoryContext>();
            services.AddScoped<InventoryContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IInventoryService, InventoryService>();
            services.AddScoped<IWarehouseService, WarehouseService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
