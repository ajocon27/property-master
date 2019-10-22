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
            
            return View();
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
