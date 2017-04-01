using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreemanFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }
    }
}