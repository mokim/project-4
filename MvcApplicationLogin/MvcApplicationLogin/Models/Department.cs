using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcApplicationLogin.Models
{
   
        [Table("Department")]
        public class Department
        {
            public int DepartmentID { get; set; }

            public string DeptName { get; set; }

        }
    }
