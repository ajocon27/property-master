using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using property_master.Models;

namespace property_master.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Property_list()
        {
            return View();
        }
        
        public IActionResult add_listing()
        {
            return View();
        }
        public IActionResult add_description(string property_name,int category)
        {
        //   var con = this.CreateConnection();
        //   string cText = $"select * from products where id = {id}";
        //   MySqlCommand cm = new MySqlCommand(cText, con);
        //   var result = cm.ExecuteReader();
        //   while(result.Read())
        //   {
        //     Product p = new Product();
        //     p.id = Convert.ToInt32(result["id"]);
        //     p.name = result["name"].ToString();
        //     p.price = Convert.ToDouble(result["price"]);
        //     p.pictureUrl = result["pictureUrl"].ToString();
        //     ViewBag.Product = p;
        //   }
                ViewData["ad_name"]=property_name;
                ViewData["category"]=category;

          return View();
        }
        [HttpPost]
        public IActionResult add_description(IFormFile outside,string property_name)
        {
        //   var con = this.CreateConnection();
        //   string cText = $"select * from products where id = {id}";
        //   MySqlCommand cm = new MySqlCommand(cText, con);
        //   var result = cm.ExecuteReader();
        //   while(result.Read())
        //   {
        //     Product p = new Product();
        //     p.id = Convert.ToInt32(result["id"]);
        //     p.name = result["name"].ToString();
        //     p.price = Convert.ToDouble(result["price"]);
        //     p.pictureUrl = result["pictureUrl"].ToString();
        //     ViewBag.Product = p;
        //   }
 

          return View();
        }


    }
}