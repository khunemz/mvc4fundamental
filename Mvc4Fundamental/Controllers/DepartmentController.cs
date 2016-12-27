using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4Fundamental.DataAccessLayer;

namespace Mvc4Fundamental.Controllers
{
    public class DepartmentController : Controller
    {
        private DepartmentDb _db;

        public DepartmentController(DepartmentDb db)
        {
            _db = db;
        }
        public ActionResult Detail(int id)
        {
            var model = this._db.Departments.Single( d => d.Id == id);
            return View(model);
        }
    }
}