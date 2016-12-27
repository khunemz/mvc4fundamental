using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Mvc4Fundamental.Models
{
    public class CreateEmployeeViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [HiddenInput]
        public int DepartmentId { get; set; }
    }
}