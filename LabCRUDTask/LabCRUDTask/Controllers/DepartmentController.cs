using DatabaseCRUD.Models.Database;
using LabCRUDTask.Models;
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

        public ActionResult Create()
        {
            Department dpt = new Department();
            return View(dpt);
        }

        [HttpPost]
        public ActionResult Create(Department dpt)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Departments.Insert(dpt); 
                return RedirectToAction("Index");
            }
            return View();
        }



        public ActionResult Edit(int id)
        {
            Database db = new Database();
            var students = db.Departments.Get(id);
            return View(students);
        }

        [HttpPost]
        public ActionResult Edit(Department dpt)
        {
            //update to db
            Database db = new Database();
            db.Departments.Update(dpt);
            return RedirectToAction("Index");
        }






    }
}