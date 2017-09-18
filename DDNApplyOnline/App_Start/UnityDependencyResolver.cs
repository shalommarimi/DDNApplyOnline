using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DDNApplyOnline.App_Start
{
    public class UnityDependencyResolver : IDependencyResolver
    {
        private IUnityContainer _UnityContainer;

        public UnityDependencyResolver(IUnityContainer UnityContainer)
        {
            _UnityContainer = UnityContainer;
        }

        public object GetService(Type serviceType)
        {
            try
            {

                return _UnityContainer.Resolve(serviceType);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {

            try
            {

                return _UnityContainer.ResolveAll(serviceType);
            }
            catch (Exception)
            {

                return new List<object>();
            }
        }
    }
}