using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Hepsiburada_Marketplace
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            config.Routes.MapHttpRoute(
                name: "ActionApi",
                routeTemplate: "api/{controller}/{action}"
                //defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "ActionApi1",
                routeTemplate: "api/{controller}/{action}/{page}/{size}",
                defaults: new { action = "GetAllCategory", page = RouteParameter.Optional, size = RouteParameter.Optional }
            );
        }
    }
}
