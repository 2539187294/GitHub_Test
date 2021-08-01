using _06.ServiceCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01.Core.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IUserService _userService = null;

        public TestController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Test()
        {
            var lits = _userService.GetList();
            return Ok(lits);
        }

    }
}
