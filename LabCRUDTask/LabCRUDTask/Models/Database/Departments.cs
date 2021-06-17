using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LabCRUDTask.Models.Database
{
    public class Departments
    {
        SqlConnection conn;

        public Departments(SqlConnection conn)
        {
            this.conn = conn;
        }

        public List<Department> FetchAll()
        {
            List<Department> departments = new List<Department>();
            string query = "select * from Departments";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Department dpt = new Department()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                };
                departments.Add(dpt);
            }
            conn.Close();
            return departments;
        }
    }
}