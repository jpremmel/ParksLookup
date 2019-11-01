using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParksMVC.Models;

namespace ParksMVC.Controllers
{
  public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allParks = Park.GetParks();
            return View(allParks);
        }
    }
}