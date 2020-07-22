using System;  
using System.ComponentModel.DataAnnotations;  
  
namespace inventory.core.Models  
{  
    public class EmployeeViewModel  
    {  
        public int Id { get; set; }
        [Display(Name = "First Name")]  
        public string FirstName { get; set; }  
        [Display(Name = "Last Name")]  
        public string LastName { get; set; }
        [Display(Name = "Email Address")]  
        public string Email { get; set; }
        [Display(Name = "Phone Number")]  
        public string PhoneNumber { get; set; }  
        [Display(Name = "Pasword")]  
        public string Password { get; set; }  
 
    }  
} 