using System;
using System.Web.Mvc;
using FreemanFirstMVC.Models;

namespace FreemanFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greetings = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            //TODO: email verification
            return View("Thanks", guestResponse);
        }
    }
}