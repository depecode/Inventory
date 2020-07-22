using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using inventory.core.Models;
using inventory.data.Repositories;

namespace inventory.business.Services.Impl
{
    public class EmployeeService : IEmployeeService
    {
        private IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        { _unitOfWork = unitOfWork; }

        public IEnumerable<Employee> GetAllEmployees() => _unitOfWork.EmployeeRepository.GetAll();
        public Employee GetEmployeeById(int employeeId) => _unitOfWork.EmployeeRepository.GetById(employeeId);
        public void CreateEmployee(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Insert(employee);
            _unitOfWork.Commit();
            return;
        }

        public void DeleteEmployee(int employeeId)
        {
            _unitOfWork.EmployeeRepository.Delete(employeeId);
            _unitOfWork.Commit();

        }
    }
}