using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF.Model.Models;
using IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace WebcCoreEntrtyFramment.Controllers
{
	public class UserinfoController : Controller
	{
		private readonly ILogger<UserinfoController> _logger;
		private readonly IUserinfoService _userinfoService;


		public UserinfoController(ILogger<UserinfoController> logger, IUserinfoService userinfoService)
		{
			_logger = logger;
			_userinfoService = userinfoService;
		}

		[HttpGet]
		public IActionResult Index()
		{
			var userinfos = this._userinfoService.Query(m => !string.IsNullOrWhiteSpace(m.UserId.ToString()));
			return View(userinfos);
		}

		[HttpPost]
		public IActionResult Index(string SearchString)
		{
			if (string.IsNullOrWhiteSpace(SearchString))
			{
				var userinfostemp = this._userinfoService.Query(m => !string.IsNullOrWhiteSpace(m.UserId.ToString()));
				return View(userinfostemp);

			}
			var userinfos = this._userinfoService.Query(m => m.UserName.Contains(SearchString)).ToList();
			base.ViewBag.SearchString = SearchString;
			return View(userinfos);
		}

		public IActionResult Create()
		{
			return View();
		}

		public IActionResult Details(string id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var userinfo = this._userinfoService.Query(m => m.UserId.ToString() == id).FirstOrDefault();
			return View(userinfo);
		}
		[HttpPost]
		public IActionResult Create([Bind("UserId,UserName,Address")] User userinfo)
		{
			this._userinfoService.Insert(userinfo);

			return RedirectToAction(nameof(Index));
		}
		public IActionResult Edit(string id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var userinfo = this._userinfoService.Query(m => m.UserId.ToString() == id).FirstOrDefault();
			return View(userinfo);
		}
		[HttpPost]
		public IActionResult Edit(User userinfo)
		{
			this._userinfoService.Update(userinfo);
			return RedirectToAction(nameof(Index));
		}


		public IActionResult Delete(string id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var userinfo = this._userinfoService.Query(m => m.UserId.ToString() == id).FirstOrDefault();
			return View(userinfo);
		}

		[HttpPost, ActionName("Delete")]
		public IActionResult DeleteConfirmed(string id)
		{
			this._userinfoService.Delete(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
