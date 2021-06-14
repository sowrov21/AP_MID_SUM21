using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DatabaseCRUD.Models.Database
{
    public class Database
    {
        public Students Students { get; set; }
        public Database()
        {
            string connString = @"Data Source=SOWROV-PC;Database=University;User ID=sa;Password=def111283;";
            SqlConnection conn = new SqlConnection(connString);
            Students = new Students(conn);
        }
    }
}