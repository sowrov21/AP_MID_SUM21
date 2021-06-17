using DatabaseCRUD.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabCRUDTask.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            Database db = new Database();
            var departments = db.Departments.FetchAll();
            return View(departments);
        }
    }
}