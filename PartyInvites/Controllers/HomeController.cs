using System;
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
		public ViewResult Index()
		{
			int hour = DateTime.Now.Hour;
			int minutes = DateTime.Now.Minute;
			ViewBag.Hour = hour + ":" + minutes;
			ViewBag.Greeting = hour < 17 ? "Dzień dobry" : "Dobry wieczór";
			return View("MyView");
		}

		[HttpGet]
		public ViewResult RsvpForm()
		{
			return View();
		}

		[HttpPost]
		public ViewResult RsvpForm(GuestResponse guestResponse)
		{
			if (ModelState.IsValid) // sprawdzanie poprawności danych zwraca true lub false
			{
				Repository.AddResponse(guestResponse);
				return View("Thanks", guestResponse);
			}
			else
			{
				// Błąd kontroli poprawności danych
				return View();
			}
		}

		public ViewResult ListResponses()
		{
			return View(Repository.Responses.Where(r => r.WillAttend == true));
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}