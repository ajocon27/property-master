using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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


    }
}