using BL;
using BL.Services;
using DAL.Entities;
using System.Web.Http;
using System.Web.Mvc;

namespace API.Controllers
{
    public class RegisterController : ApiController
    {

        private readonly ISubscribe _ISubscribe;
        private readonly IEncryptPassword _IEncryptPassword;
        private readonly INotification _INotification;

        public RegisterController()
        {

            _ISubscribe = DependencyResolver.Current.GetService<ISubscribe>();
            _IEncryptPassword = DependencyResolver.Current.GetService<IEncryptPassword>();
            _INotification = DependencyResolver.Current.GetService<INotification>();
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
            _INotification.SendEmail(subscriber);
            return Json("Thank you. You have been sucessufully subscibed to Dynamic DNA ");
        }

    }
}
