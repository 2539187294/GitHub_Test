using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebcCoreEntrtyFramment.CommentTool;

namespace WebcCoreEntrtyFramment.Controllers
{
    [CustomControllerFilterAttribute(Order = 8)]
    public class TestController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public TestController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [CustomActionFilterAttribute(Order = 6)]
        public IActionResult Index()
        {
            Console.WriteLine("this is index");
            Console.WriteLine(this._configuration["Today"]);
            Console.WriteLine(this._configuration["Say"]);
            Console.WriteLine(this._configuration["ConnectionStrings:Write"]);
            Console.WriteLine(this._configuration["ConnectionStrings:Read:0"]);
            Console.WriteLine(this._configuration["ConnectionStrings:Read:1"]);
            Console.WriteLine(this._configuration["ConnectionStrings:Read:2"]);
            Console.WriteLine(this._configuration["ConnectionStrings:Read:3"]);


            return View();
        }
    }
}
