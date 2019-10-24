using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using property_master.Models;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;
namespace property_master.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {   
            PropertyInfo properties=new PropertyInfo();
               
            var list= properties.getproperty();
             ViewData["list"] = list;
            
            return View();
        }
        public IActionResult Search(string province, double minprice, double maxprice)
        {   
            PropertyInfo properties=new PropertyInfo();
              
            var list= properties.searchpropertybyprov(province,minprice,maxprice);


             ViewData["list"] = list;
            
            return View("Index");
        }
        public IActionResult Profile()
        {

            UserInfo user=new UserInfo();
            var us= HttpContext.Session.GetString("user");
            ViewData["profile_photo"] = user.getuser(us).profile_photo;
            ViewData["firstname"] = user.getuser(us).firstName;
            ViewData["lastname"] = user.getuser(us).lastName;
            ViewData["email"] = user.getuser(us).email;
             ViewData["password"] = user.getuser(us).password;
            return View();
        }
        public IActionResult MyAds()
        {
            PropertyInfo properties=new PropertyInfo();
            var us= HttpContext.Session.GetString("user");     
            var list= properties.getproperty(us);
             ViewData["list"] = list;
            return View();
        }
        public IActionResult view_property(string property_id)
        {
            PropertyInfo property = new PropertyInfo();
            var list= property.getpropertyview(property_id);
            ViewData["list"] = list;
            ViewData["property_name"]=list.property_name;
            ViewData["address"]=list.address;
            ViewData["city"]=list.city;
            ViewData["province"]=list.province;
            ViewData["postalcode"]=list.postalcode;
            ViewData["description"]=list.description;
            ViewData["bedroom"]=list.bedrooms;
            ViewData["bath"]=list.bathroom;
            ViewData["size"]=list.land_size;
            ViewData["price"]=String.Format("{0:n}", list.price);
            ViewData["photos"]=list.photos;
            ViewData["firstname"]=list.owner.firstName;
            ViewData["lastname"]=list.owner.lastName;
            ViewData["email"]=list.owner.email;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
