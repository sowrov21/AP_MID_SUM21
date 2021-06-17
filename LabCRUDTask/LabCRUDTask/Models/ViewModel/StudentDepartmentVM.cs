using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabCRUDTask.Models.ViewModel
{
    public class StudentDepartmentVM
    {
        public Student Student { get; set; }

        public List<Department> Departments { get; set; }

        public List<Student> StudentsList { get; set; }

        public StudentDepartmentVM()
        {
            Departments = new List<Department>();
            StudentsList = new List<Student>();
        }
    }
}