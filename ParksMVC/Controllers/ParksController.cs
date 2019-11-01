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

        public ActionResult Edit(int id)
        {
            var park = Park.GetPark(id);
            return View(park);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Park park)
        {
            await Park.EditPark(park);
            return RedirectToAction("Details", new { id = park.ParkId });
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Park park)
        {
            await Park.CreatePark(park);
            return RedirectToAction("Details", new { id = park.ParkId });
        }

        public async Task<IActionResult> Delete(int id)
        {
            var park = Park.GetPark(id);
            await Park.DeletePark(park);
            return RedirectToAction("Index", "Home");
        }
    }
}