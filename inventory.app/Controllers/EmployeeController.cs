using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

using inventory.core.Models;
using inventory.business.Services;

namespace inventory.app.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
            { this.employeeService = employeeService; }
       
        public IActionResult Index()
        {
            List<EmployeeViewModel> model = new List<EmployeeViewModel>(); 
            employeeService.GetAllEmployees().ToList().ForEach( e => {
                EmployeeViewModel employee = new EmployeeViewModel {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Email = e.Email,
                    PhoneNumber = e.PhoneNumber,
                    Password = e.Password,
                };
                model.Add(employee);
            });  
  
            return View(model);
            // return View();
        }

        [HttpGet]  
        public ActionResult AddEmployee()  
        {  
           Employee model = new Employee();  
  
            return PartialView("_AddEmployee", model);  
        }  
  
        [HttpPost]  
        public ActionResult AddEmployee(Employee model)  
        {  
            Employee employeeEntity = new Employee  
            {  
                FirstName = model.FirstName,  
                LastName = model.LastName,  
                Email = model.Email,
                PhoneNumber = model.PhoneNumber, 
                Password = model.Password,  
            };  
            employeeService.CreateEmployee(employeeEntity);  
            if (employeeEntity.Id > 0)  
            {  
                return RedirectToAction("index");  
            }  
            return View(model);  
        }

    }
}