using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Railway.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Railway.Controllers
{
    public class AdminController : Controller
    {
        private RailwayContext context;
        public AdminController(RailwayContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewCus()
        {
            return View(context.Stations.ToList());
        }
        public IActionResult CreateTrain(Station r)
        {
            //var rt = db.Routes.ToList();
            ////ViewData["list"] = new SelectList(rt, "RouteID", "RouteID");
            //ViewBag.list = new SelectList(rt, "RouteID", "RouteID");

            List<Station> sta = context.Stations.ToList();
            SelectList RouteList = new SelectList(sta, "StationID", "StationID");//SelectList tu dat = new SelectList(route, "gia tri lay tu bang khac", "gia tri hien tren view")
            ViewBag.sta = RouteList;
            return View();
        }
        [HttpPost]
        // done
        public IActionResult CreateTrain(Station sta, Train train)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    context.Trains.Add(train);
                    context.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Fail!");
                }
            }
            catch (Exception e)
            {

                ModelState.AddModelError("", e.Message);
            }
            return View();
        }
    }
}
