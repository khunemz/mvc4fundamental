using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4Fundamental.Models
{
    public class Employee
    {
        //public Employee(int id, string name, Department department)
        //{
        //    Id = id;
        //    Name = name;
        //    Department = department;
        //}
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime? HireDate { get; set; }
        public virtual Department Department { get; set; }
    }
}