using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace inventory.core.Models
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }

    }
}