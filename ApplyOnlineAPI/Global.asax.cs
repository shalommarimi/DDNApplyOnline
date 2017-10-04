using System.Web.Http;

namespace ApplyOnlineAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //    if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            //    {
            //        HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
            //        HttpContext.Current.Response.AddHeader("Cache-Control", "no-cache");
            //        HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET,POST,PUT,DELETE,OPTIONS");
            //        HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept");
            //        HttpContext.Current.Response.End();
            //    }

            GlobalConfiguration.Configure(WebApiConfig.Register);

        }
    }
}
