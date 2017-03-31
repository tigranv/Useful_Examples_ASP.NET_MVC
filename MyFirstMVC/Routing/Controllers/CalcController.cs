using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    public class CalcController : Controller
    {

        // GET: Calc

        public ActionResult View(int? x, int? y)
        {
           
            return View();
        }
        public ActionResult Add(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.Result = x + y;

            }
            return View();
        }

        public ActionResult Mul(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.Result = x*y;

            }
            return View();
        }

        public ActionResult Sub(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.Result = x - y;

            }
            return View();
        }

        public ActionResult Div(int? x, int? y)
        {
            if (x != null && y != null && y != 0)
            {
                ViewBag.Result = x/y;

            }
            return View();
        }
    }
}