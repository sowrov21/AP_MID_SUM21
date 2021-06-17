using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabCRUDTask.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Department cannot be Empty")]
        public string Name { get; set; }
    }
}