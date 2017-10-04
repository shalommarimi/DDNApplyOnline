using ApplyOnlineAPI;
using DDNApplyOnline.App_Start;
using System;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DDNApplyOnline
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            GlobalConfiguration.Configure(WebApiConfig.Register);


        }


    }
}