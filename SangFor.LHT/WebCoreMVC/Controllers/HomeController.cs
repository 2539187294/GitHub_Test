using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebCoreMVC.Models;

namespace WebCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public UptimeService uptime;

        public Syudent sync;


        public HomeController(UptimeService up, Syudent syncx)
        {
            uptime = up;
            sync = syncx;
        }




        public IActionResult Index()
        {

            var count = sync.sum();

            return View(count);
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
