using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;

namespace BLL
{
    public class DepartmentService
    {
        public static List<string> GetDepartmentName()
        {
            return DepartmentRepo.GetDepartmentNames();
        }
        public static List<DepartmentModel> GetDepartments()
        {
            var Departments = DepartmentRepo.GetDepartments();

            List<DepartmentModel> data = new List<DepartmentModel>();

            foreach (var d in Departments)
            {
                var dm = new DepartmentModel()
                {
                    Id = d.Id,
                    Name = d.Name
                };
                data.Add(dm);
            }
            return data;
        }

        public static void AddDepartment( DepartmentModel dept)
        {
            var d = new Department()
            {
                Id = dept.Id,
                Name = dept.Name
            };
            DepartmentRepo.AddDepartment(d);
        }
    }
}
