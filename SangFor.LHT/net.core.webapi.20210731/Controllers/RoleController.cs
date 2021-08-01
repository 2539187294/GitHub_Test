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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService = null;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpPost]
        public IActionResult Create(Role role)
        {
            var count = _roleService.Create(role);
            return Ok(count);
        }

        [HttpPost]
        public IActionResult Update(Role role)
        {
            var count = _roleService.Update(role);
            return Ok(count);
        }

        [HttpGet]
        public IActionResult GetById(int Id)
        {
            var role = _roleService.GetById(Id);
            return Ok(role);
        }

        [HttpGet]
        public IActionResult GetByName(string name)
        {
            var model = _roleService.GetByName(name);
            return Ok(model);
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var list = _roleService.GetList();
            return Ok(list);
        }

    }
}
