using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Calc",
                url: "{controller}/{action}/{x}/{y}",
                defaults: new { controller = "Calc", action = "Add", x = 0, y = 0}
            );
        }
    }
}
