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

        [Required(ErrorMessage = "Please provide the Name field")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Please provide the Date Of Birth field")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please provide the credit field")]
        [Range(1, 148, ErrorMessage = "Please enter correct value. Range 1 to 148")]
        public int Credit { get; set; }

        [Required(ErrorMessage = "Please provide the CGPA field")]
        [Range(1.00,4.00, ErrorMessage = "Please enter correct value. Range 1.00 to 4.00")]
        public double CGPA { get; set; }

        [Range(1, Double.PositiveInfinity, ErrorMessage = "Department Required")]
        public int Dept_id { get; set; }

    }
}