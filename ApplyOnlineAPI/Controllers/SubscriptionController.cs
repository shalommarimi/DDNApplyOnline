using ApplyOnlineAPI.Filters;
using BL.Services;
using DAL.Entities;
using System.Web.Http;

namespace ApplyOnlineAPI.Controllers
{
    public class SubscriptionController : BaseController
    {

        public SubscriptionController(ISubscribe _ISubscribe) : base(_ISubscribe)
        {

        }


        [HttpPost]
        [ModelValidator]
        public IHttpActionResult Subscribe(Subscriber _Subscriber)
        {
            ISubscribe.RegisterSubscriber(_Subscriber);
            return Ok("Thank you. You have been sucessufully subscibed to Dynamic DNA");
        }
    }
}
