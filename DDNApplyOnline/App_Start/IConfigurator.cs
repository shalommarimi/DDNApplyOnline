using BL.Services;
using DDNApplyOnline.App_Start;
using Microsoft.Practices.Unity;
using System.Web.Mvc;

namespace BL.Configuration
{
    public class IConfigurator
    {
        public static void ConfigureUnityContanier()
        {
            var container = new UnityContainer();

            container.RegisterType<IEncryptPassword, EncryptPassword>();
            container.RegisterType<ISubscribe, Subscribe>();
            container.RegisterType<INotification, Notification>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }


    }
}
