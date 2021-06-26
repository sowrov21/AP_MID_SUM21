﻿using DatabaseCRUD.Models.Database;
using LabCRUDTask.Models;
using LabCRUDTask.Models.ViewModel;
using LabCRUDTask.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LabCRUDTask.Controllers
{
    [CustomSessionCheck]
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            /* Student st = new Student();
            return View(st);*/
            Student st = new Student();
            Department dpt = new Department();
            Database db = new Database();
            //ViewModel
            StudentDepartmentVM comboData = new StudentDepartmentVM();
            comboData.Student = st;
            comboData.Departments = db.Departments.FetchAll();

            return View(comboData);
        }
       
        [HttpPost]
        public ActionResult Create(Student std)
        {
            if (ModelState.IsValid) 
            {
                Database db = new Database();
                db.Students.Insert(std);
                return RedirectToAction("Dashboard", "Login");
            }

            Database dtb = new Database();
            //ViewModel
            StudentDepartmentVM comboData = new StudentDepartmentVM();
            comboData.Student = std;
            comboData.Departments = dtb.Departments.FetchAll();

            return View(comboData);

        }
        public ActionResult PopulateTable(Student std)
        {
            /* Database db = new Database();
             var students = db.Students.FetchAll();*/

            StudentDepartmentVM comboData = new StudentDepartmentVM();
            Database db = new Database();
            comboData.StudentsList = db.Students.FetchAll();
            comboData.Departments = db.Departments.FetchAll();
            return View(comboData);
        }


        public ActionResult Edit(int id)
        {
            //ViewModel
                StudentDepartmentVM comboData = new StudentDepartmentVM();
                Database db = new Database();
                comboData.Student = db.Students.Get(id);
                comboData.StudentsList = db.Students.FetchAll();
                comboData.Departments = db.Departments.FetchAll();
                return View(comboData);
        }   

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            if (ModelState.IsValid)
            {
                //update to db
                Database db1 = new Database();
                db1.Students.Update(std);
                return RedirectToAction("PopulateTable");
            }

            Database dtb = new Database();
            //ViewModel
            StudentDepartmentVM comboData = new StudentDepartmentVM();
            comboData.Student = std;
            comboData.Departments = dtb.Departments.FetchAll();

            return View(comboData);
        }

        public ActionResult Delete(int id)
        {

            Database db = new Database();
            db.Students.Delete(id);
            return RedirectToAction("PopulateTable");

        }

        public ActionResult Details(int id)
        {
            //ViewModel
            StudentDepartmentVM comboData = new StudentDepartmentVM();
            Database db = new Database();
            comboData.Student = db.Students.Get(id);
            comboData.StudentsList = db.Students.FetchAll();
            comboData.Departments = db.Departments.FetchAll();

            return View(comboData);
        }


    }
}