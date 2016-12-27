using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4Fundamental.Models
{
    public class Department
    {
        //public Department(int id, string name, ICollection<Employee> employees)
        //{
        //    Id = id;
        //    Name = name;
        //    Employees = employees;
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}