using System.Web.Http;

namespace ApplyOnlineAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",

               defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Applicant",
                routeTemplate: "api/{controller}/{id}",

                defaults: new { controller = "Applicant", action = "Register", id = RouteParameter.Optional }
            );
        }
    }
}
