using BL.Services;
using DAL.Entities;
using System.Web.Http;

namespace ApplyOnlineAPI.Controllers
{
    public class ApplyController : ApiController
    {

        private ISubscribe _ISubscribe;

        public ApplyController(ISubscribe iSubscribe, IEncryptPassword iEncryptPassword)
        {
            _ISubscribe = iSubscribe;
        }


        [HttpPost]
        public IHttpActionResult Subscribe(Subscriber _Subscriber)
        {
            if (ModelState.IsValid)
            {
                _ISubscribe.RegisterSubscriber(_Subscriber);
                return Json("Thank you. You have been sucessufully subscibed to Dynamic DNA");
            }
            else
            {
                return Json("Unable to Subscribe User");

            }

        }
    }
}
