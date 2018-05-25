using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContosoApp.Models;
using ContosoApp.ViewModels;

namespace ContosoApp.Controllers
{
    public class HomeController : Controller
    {
        public ContosoDbContext ContosoDbContext { get; }

        public HomeController(ContosoDbContext contosoDbContext)
        {
            ContosoDbContext = contosoDbContext;
        }
        public IActionResult Index()
        {           
            return View();
        }

        public IActionResult About()
        {
           
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }        

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
