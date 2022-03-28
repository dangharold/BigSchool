using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace _19DTHC2_BigSchool_HaiDang_1911065192
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
