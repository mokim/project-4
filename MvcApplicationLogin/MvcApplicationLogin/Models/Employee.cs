using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplicationLogin.Models
{
   

        [Table("Employee")]
        public class Employee
        {

            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public String MiddleName { get; set; }
            public string LastName { get; set; }
            public decimal Salary { get; set; }
            public int DepartmentID { get; set; }
            public Department Department { get; set; }
        }

        public class EmployeeContext : DbContext
        {
            public EmployeeContext()
                : base("DefaultConnection")
            {
            }

            public DbSet<Employee> Employees { get; set; }
            public DbSet<Department> Departments { get; set; }



        }
    }
