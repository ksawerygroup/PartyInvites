﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			int hour = DateTime.Now.Hour;
			int minutes = DateTime.Now.Minute;
			ViewBag.Hour = hour + ":" + minutes;
			ViewBag.Greeting = hour < 17 ? "Dzień dobry" : "Dobry wieczór";
			return View("MyView");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}