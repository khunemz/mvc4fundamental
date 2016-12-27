using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Mvc4Fundamental.Models;

namespace Mvc4Fundamental.DataAccessLayer
{
    public class DepartmentDb : DbContext
    {
        public DepartmentDb() : base("name=DefaultConnection")
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public System.Data.Entity.DbSet<Mvc4Fundamental.Models.CreateEmployeeViewModel> CreateEmployeeViewModels { get; set; }
    }
}