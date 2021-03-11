using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Railway.Models;
namespace Railway.Controllers
{
    public class UserController : Controller
    {
        private RailwayContext context;

        public UserController(RailwayContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
