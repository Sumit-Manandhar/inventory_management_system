using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace inventory_management_system
{
    public static class RouteConfig
    {
        public static object UrlParameter { get; private set; }

        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);

            //routes.MapHttpRoute(
            //    name: "Default",
            //    routeTemplate: "api/{controller}/{action}/{id}",
            //    defaults: new { action = "index", id = UrlParameter.Optional }


            //    );
            routes.MapHttpRoute(
                name: "MyAPI",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new
                {
                    id = RouteParameter.Optional,
                    action = RouteParameter.Optional
                }
            );
        }
    }
}
