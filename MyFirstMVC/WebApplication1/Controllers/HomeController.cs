using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product()
            {
                ID = 1,
                Name = "Computer",
                Price = 1500,
                Description = "Laptop"

            });

            products.Add(new Product()
            {
                ID = 2,
                Name = "Mous",
                Price = 150,
                Description = "bluetooth"

            });


            return View(products);
        }

    }
}
