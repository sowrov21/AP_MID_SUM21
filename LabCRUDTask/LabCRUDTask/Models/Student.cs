using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabCRUDTask.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide the name field")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Please the Date Of Birth field")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please provide the credit field")]
        public int Credit { get; set; }

        [Required(ErrorMessage = "Please provide the CGPA field")]
        [Range(1.00,4.00, ErrorMessage = "Please enter correct value. Range 1.00 to 4.00")]
        public double CGPA { get; set; }

        [Required(ErrorMessage = "Please the Department field")]
        public int Dept_id { get; set; }

    }
}