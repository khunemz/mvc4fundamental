using System.Linq;
using System.Web.Mvc;
using Mvc4Fundamental.DataAccessLayer;
using Mvc4Fundamental.Models;

namespace Mvc4Fundamental.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly DepartmentDb _db;

        public EmployeeController(DepartmentDb db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult Create(int departmentId)
        {
            var model = new CreateEmployeeViewModel();
            model.DepartmentId = departmentId;
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(CreateEmployeeViewModel viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);
            // Save
            var department = _db.Departments.Single(d => d.Id == viewModel.DepartmentId);
            var employee = new Employee
            {
                Name = viewModel.Name,
                HireDate = viewModel.HireDate
            };
            department.Employees.Add(employee);

            _db.SaveChanges();
            return RedirectToAction("Detail", "Department", new {id = viewModel.DepartmentId});
        }
    }
}