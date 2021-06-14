using LabCRUDTask.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DatabaseCRUD.Models.Database
{
    public class Students
    {
        SqlConnection conn;

        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Insert(Student st)
        {
            //string query = String.Format(@"insert into students values ('{0}','{1}','{2}', {3} ,{4},'{5}')", st.Name,st.Dept,st.Gender,st.DOB,st.CGPA,st.Address);
          string query = "Insert into Students values(@name,@dob,@credit,@cgpa,@dept_id)";
            SqlCommand cmd = new SqlCommand(query, conn);
           cmd.Parameters.AddWithValue("@name",st.Name );
            cmd.Parameters.AddWithValue("@dept_id", st.Dept_id);
            cmd.Parameters.AddWithValue("@credit", st.Credit);
            cmd.Parameters.AddWithValue("@cgpa",st.CGPA);
            cmd.Parameters.AddWithValue("@dob",st.DOB);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Student> FetchAll()
        {
            List<Student> students = new List<Student>();
            string query = "select * from students";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student std = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Dept_id = reader.GetInt32(reader.GetOrdinal("Dept_id")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    DOB = reader.GetDateTime(reader.GetOrdinal("DOB")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                };
                students.Add(std);
            }
            conn.Close();
            return students;
        }


        public Student Get(int id)
        {
            Student std = null;
            string query = $"select * from students Where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                std = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Dept_id = reader.GetInt32(reader.GetOrdinal("Dept_id")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    DOB = reader.GetDateTime(reader.GetOrdinal("DOB")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                };
            }
            conn.Close();
            return std;
        }


        public void Update(Student std)
        {
            string query = $"Update students Set Name='{std.Name}', DOB={std.DOB} ,Credit={std.Credit}, CGPA='{std.CGPA}' Where Id = {std.Id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int std)
        {
            string query = $"DELETE FROM Students Where Id = {std}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}