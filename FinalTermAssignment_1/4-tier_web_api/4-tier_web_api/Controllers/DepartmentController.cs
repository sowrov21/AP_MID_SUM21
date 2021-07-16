using System;
using BLL;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;

namespace _4_tier_web_api.Controllers
{
    public class DepartmentController : ApiController
    {
        [Route("api/Department/Names")]
        [HttpGet]
        public List<string> GetName()
        {
            return DepartmentService.GetDepartmentName();
        }

        [Route("api/Department/GetAll")]
        [HttpGet]
        public List<DepartmentModel> GetAllDepartments()
        {
            return DepartmentService.GetDepartments();
        }


        [Route("api/Department/Add")]
        [HttpPost]
        public void Add(DepartmentModel dept)
        {
             DepartmentService.AddDepartment(dept);
        }
    }
}
