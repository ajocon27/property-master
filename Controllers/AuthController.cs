using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace property_master.Controllers
{
    public class AuthController : Controller
    {
        private MySqlConnection CreateConnection()
        {
            string connection = "server=localhost;database=property-master;user=root;password=1234;port=3306"; // declaring a connection string
            MySqlConnection con = new MySqlConnection(connection); // creating the connection
            con.Open(); // openning the connection
            
            return con; // return the created connection
        }
        
        [HttpPost]
        // function to execute when user submits the login form
        public IActionResult Login(string email, string password)
        {
            try
            {
                var con = this.CreateConnection(); // call the connection function to get the connection
                string cmdText = $"select * from users where email = '{email}' and password = '{password}'"; // creating the query
                MySqlCommand cmd = new MySqlCommand(cmdText, con); // creating the mysql command
                var result = cmd.ExecuteReader(); // executing the query
                if (result.HasRows) // check whether query result has any rows or not
                {

                    HttpContext.Session.SetString("user", email); // setting the the session in HttpContext
                   
                    ViewData["error"] = false;
                    ViewData["loginSuccessfull"] = true;
                    ViewData["userNotFound"] = false;
                    con.Close();
                    return Redirect("/");

                }
                else
                {
                    ViewData["error"] = false;
                    ViewData["loginSuccessfull"] = false;
                    ViewData["userNotFound"] = true;
                    con.Close();
                    return Redirect("/");
                }

            }
            catch (Exception exception)
            {
                ViewData["error"] = true;
                ViewData["loginSuccessfull"] = false;
                ViewData["userNotFound"] = false;
                
                return Redirect("/");
            }
            
        }
        [HttpPost]
        public IActionResult Register(string firstName, string lastName, string email, string password)
        {
        try
        {
            var con = this.CreateConnection();
            string cmdText = $"insert into users(firstName, lastName, email, password) values('{firstName}', '{lastName}', '{email}', '{password}')";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            cmd.ExecuteNonQuery();
            ViewData["registrationSuccessfull"] = true;
            ViewData["error"] = false;
            return Redirect("/");
        } catch(MySqlException exception)
        {
            ViewData["error"] = true;
            ViewData["registrationSuccessfull"] = false;
            return Redirect("/");
        }

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); // clearout the session
            return Redirect("/");
        }

        
    }
}