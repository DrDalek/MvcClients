using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcClients.Controllers
{
	public class ProcedureController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult RJ45()
		{
			return View();
		}

		public IActionResult CPL()
		{
			return View();
		}

		public IActionResult Wifi()
		{
			return View();
		}

	}
}
