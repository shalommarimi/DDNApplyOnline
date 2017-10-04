using System.Web.Http;
using System.Web.Http.Cors;

namespace ApplyOnlineAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",

               defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "ApplicantApi",
                routeTemplate: "api/{controller}/{id}",

                defaults: new { controller = "Applicant", action = "RegisterP", id = RouteParameter.Optional }
            );



        }
    }
}
