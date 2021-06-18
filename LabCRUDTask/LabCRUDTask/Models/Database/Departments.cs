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

        public void Insert(Department dpt)
        {
            string query = "Insert into Departments values(@name)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", dpt.Name);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Department Get(int id)
        {
            Department dpt = null;
            string query = $"select * from departments Where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dpt = new Department()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                };
            }
            conn.Close();
            return dpt;
        }

        public void Update(Department dpt)
        {
            string query = $"Update departments Set Name='{dpt.Name}' Where Id = {dpt.Id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int dpt)
        {
            string query = $"DELETE FROM Departments Where Id = {dpt}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}