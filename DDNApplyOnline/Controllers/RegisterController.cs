using BL;
using BL.Services;
using DAL.Entities;
using System.Web.Http;
using System.Web.Mvc;

namespace API.Controllers
{
    public class RegisterController : ApiController
    {

        private ISubscribe _ISubscribe;
        private IEncryptPassword _IEncryptPassword;

        public RegisterController()
        {

            _ISubscribe = DependencyResolver.Current.GetService<ISubscribe>();
            _IEncryptPassword = DependencyResolver.Current.GetService<IEncryptPassword>();
        }

        public IHttpActionResult Subscribe(SubscriberInformation subscriber)
        {

            if (ModelState.IsValid)
            {
                _ISubscribe.RegisterSubscriber(subscriber);
            }
            else
            {
                return Json("Unable to Subscribe User");

            }
            return Json("Thank you. You have been sucessufully subscibed to Dynamic DNA " + subscriber.FirstName + " " + subscriber.LastName);
        }

    }
}
