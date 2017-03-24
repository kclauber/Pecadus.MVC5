using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Pecadus.MVC4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home",
                url: "{controller}/{action}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index"
                }
            );

            routes.MapRoute(
                name: "Categoria",
                url: "{controller}/{id}/{titulo}",
                defaults: new
                {
                    controller = "Categoria",
                    action = "Index",
                    id = UrlParameter.Optional,
                    titulo = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Produto",
                url: "{controller}/{id}/{titulo}",
                defaults: new
                {
                    controller = "Produto",
                    action = "Index",
                    id = UrlParameter.Optional,
                    titulo = UrlParameter.Optional
                }
            );
        }
    }
}
