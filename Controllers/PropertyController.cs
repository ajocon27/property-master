using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using property_master.Models;
using MySql.Data.MySqlClient;

namespace property_master.Controllers
{
    public class PropertyController : Controller
    {

        private MySqlConnection CreateConnection()
        {
            string connection = "server=localhost;database=property-master;user=root;password=1234;port=3306"; // declaring a connection string
            MySqlConnection con = new MySqlConnection(connection); // creating the connection
            con.Open(); // openning the connection
            return con; // return the created connection
        }
        public IActionResult Property_list()
        {
            return View();
        }
        
        public IActionResult add_listing()
        {
            return View();
        }
        public IActionResult add_description(string property_name,string category)
        {

                ViewData["ad_name"]=property_name;
                ViewData["category"]=category;

          return View();
        }
        [HttpPost]
        public IActionResult add_description(string bedrooms,string bathrooms,double property_size,string property_name,double price,string description,string address,string address2,string city,string province, string postalcode,string category)
        {
   
            var con = this.CreateConnection();
            UserInfo user = new UserInfo();
            var us = HttpContext.Session.GetString("user");
            ViewData["profile_photo"] = user.getuser(us).profile_photo;
            ViewData["firstname"] = user.getuser(us).firstName;
            ViewData["lastname"] = user.getuser(us).lastName;
            ViewData["email"] = user.getuser(us).email;
            ViewData["password"] = user.getuser(us).password;
            //get properties
            string userid=user.getuser(us).id.ToString();
            
           

            string cmdText = $"insert into properties(property_name, price, address, city,province,land_size,description,bathrooms,bedrooms,address2,postalcode,user_id,category,photo_group_id,likes) values('{property_name}', {price}, '{address}', '{city}', '{province}', {property_size}, '{description}', '{bathrooms}', '{bedrooms}', '{address2}', '{postalcode}',{userid},'{category}','0',0);select last_insert_id();";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            cmd.ExecuteNonQuery();
            int photo_group_id=Convert.ToInt32(cmd.LastInsertedId);
             
            ViewData["photo_group_id"]=photo_group_id;
            return View("add_photo");               

        }


    }
}