﻿using System.Web.Http;

namespace ApplyOnlineAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            // ControllerBuilder.Current.SetControllerFactory(new NInjectControllerFactory());

        }
    }
}
