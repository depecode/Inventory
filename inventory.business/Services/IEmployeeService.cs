using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using inventory.core.Models;

namespace inventory.business.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeId);
        void CreateEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
    }
}