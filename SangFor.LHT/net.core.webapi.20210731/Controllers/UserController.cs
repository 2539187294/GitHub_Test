using _02.应用服务.IService;
using _03.领域.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net.core.webapi._20210731.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _serService;
        public UserController(IUserService userService)
        {
            _serService = userService;
        }

        [HttpGet]
        [Route("get")]
        public ActionResult<IEnumerable<string>> Get()
        {
            Console.WriteLine(_serService.GetHashCode());
            return new string[] { "values1","values2"};
        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            var model = _serService.GetById(id);
            return Ok(model);
        }

        [HttpGet]
        [Route("Getlist")]
        public IActionResult Getlist()
        {
            var list = _serService.GetList();
            return Ok(list);
        }

        [HttpPost]
        [Route("Reginter")]
        public IActionResult Reginter(User user)
        {
            bool result = _serService.Reg(user);
            return Ok(result);
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(User user)
        {
            bool result = _serService.Login(user);
            return Ok(result);
        }



    }
}
