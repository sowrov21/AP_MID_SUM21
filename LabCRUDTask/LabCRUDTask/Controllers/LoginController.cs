using DatabaseCRUD.Models.Database;
using LabCRUDTask.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabCRUDTask.Controllers
{
    public class LoginController : Controller
    {


        string connString = @"Data Source=SOWROV-PC;Database=University;User ID=sa;Password=def111283;";
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin adm)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "select UserName,Password from Admins where UserName=@username and Password=@password";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@username", adm.Username);
                cmd.Parameters.AddWithValue("@password", adm.Password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Session["username"] = adm.Username.ToString();
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ViewData["Message"] = "Username or Password not found";
                    //return RedirectToAction("Index");
                }
                conn.Close();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return View();
        }

    }    
}

       