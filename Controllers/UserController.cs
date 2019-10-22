using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using property_master.Models;

namespace property_master.Controllers
{
    public class UserController : Controller
    {
        private MySqlConnection CreateConnection()
        {
            string connection = "server=localhost;database=property-master;user=root;password=1234;port=3306"; // declaring a connection string
            MySqlConnection con = new MySqlConnection(connection); // creating the connection
            con.Open(); // openning the connection
            
            return con; // return the created connection
        }
        

        [HttpPost]
        public IActionResult upload(IFormFile picture)
        {
            var con = this.CreateConnection();   
            string pictureUrl = null;

            
            
          
            UserInfo user=new UserInfo();
            var us= HttpContext.Session.GetString("user");
            string userid=user.getuser(us).id.ToString();

            string dir="wwwroot/images/profile/"+userid;
            string dir2;
           
            string url;

            if(picture!=null)
            {
   
                    var fileName = Path.GetFileName(picture.FileName);
                    Directory.CreateDirectory(dir);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), @dir, fileName);
                    
                    var stream = new FileStream(filePath, FileMode.Create);
                    picture.CopyTo(stream);
                    pictureUrl = dir + fileName;
                    
                    dir2="https://localhost:5001/images/profile/"+userid+"/"+fileName;
                    url="https://localhost:5001/images/profile/"+userid+"/"+fileName;
                    string cmdText = $"update users SET profile_photo= '{url}' where id={userid}";
                    MySqlCommand cmd = new MySqlCommand(cmdText, con);

                    cmd.ExecuteNonQuery();


                
            }
            return Redirect("/home/profile");
        }
        [HttpPost]
        public IActionResult update(string firstname,string lastname, string email, string password)
        {
            var con = this.CreateConnection();
            UserInfo user=new UserInfo();
            var us= HttpContext.Session.GetString("user");
            int userid=user.getuser(us).id;
            string cmdText = $"update users SET firstname= '{firstname}', lastname='{lastname}',email='{email}', password='{password}' where id={userid}";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            HttpContext.Session.SetString("user", email);
            return Redirect("/home/profile");
        }
    } 
}