using DatabaseCRUD.Models.Database;
using LabCRUDTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabCRUDTask.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            Student st = new Student();
            return View(st);
        }
       
        [HttpPost]
        public ActionResult Create(Student std)
        {
            Database db = new Database();
            db.Students.Insert(std);

            return RedirectToAction("Dashboard","Login");
        }
        public ActionResult PopulateTable(Student std)
        {
            Database db = new Database();
            var students = db.Students.FetchAll();
            return View(students);
        }


        public ActionResult Edit(int id)
        {

            Database db = new Database();
            var std = db.Students.Get(id);

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            //update to db
            Database db = new Database();
            db.Students.Update(std);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {

            Database db = new Database();
            db.Students.Delete(id);
            return RedirectToAction("PopulateTable");

        }

    }
}