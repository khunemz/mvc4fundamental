using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4Fundamental.DataAccessLayer;

namespace Mvc4Fundamental.Controllers
{
    public class HomeController : Controller
    {
        private DepartmentDb _db;

        public HomeController(DepartmentDb db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            var dept = this._db.Departments;
            return View(dept);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}