using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParksMVC.Models;

namespace ParksMVC.Controllers
{
    public class ParksController : Controller
    {
        public ActionResult Details(int id)
        {
            var park = Park.GetPark(id);
            return View(park);
        }
    }
}