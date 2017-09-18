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
            IUnityContainer _UnityContainer = new UnityContainer();
            RegisterServices(_UnityContainer);
            DependencyResolver.SetResolver(new UnityDependencyResolver(_UnityContainer));
        }


        public static void RegisterServices(IUnityContainer _UnityContainer)
        {
            _UnityContainer.RegisterType<IEncryptPassword, EncryptPassword>();
            _UnityContainer.RegisterType<ISubscribe, Subscribe>();

        }


    }
}
