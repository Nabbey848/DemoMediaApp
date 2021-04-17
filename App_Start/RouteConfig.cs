using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VidlyTutorial
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Customers",
               url: "{controller}/{action}",
               defaults: new { controller = "Customers", action = "Index"}
           );
            
            routes.MapRoute(
               name: "CustomerDetails",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Customers", action = "Details", id = UrlParameter.Optional }
           );

            routes.MapRoute(
              name: "EditCustomer",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Customers", action = "Edit", id = UrlParameter.Optional }
          );

            routes.MapRoute(
               name: "NewCustomer",
               url: "{controller}/{action}",
               defaults: new { controller = "Customers", action = "New" }
           );


            routes.MapRoute(
               name: "Movies",
               url: "{controller}/{action}",
               defaults: new { controller = "Movies", action = "Index" }
           );

            routes.MapRoute(
                name: "MovieDetails",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Movies", action = "Details", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "EditMovie",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Movies", action = "Edit", id = UrlParameter.Optional }
          );

            routes.MapRoute(
               name: "NewMovie",
               url: "{controller}/{action}",
               defaults: new { controller = "Movies", action = "New" }
           );
        }
    }
}
