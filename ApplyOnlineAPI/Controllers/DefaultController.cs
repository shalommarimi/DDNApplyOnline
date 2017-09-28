using ApplyOnlineAPI.Filters;
using BL.Services;
using DAL.Entities;
using System.Web.Http;

namespace ApplyOnlineAPI.Controllers
{
    public class DefaultController : BaseController
    {

        public DefaultController(ISubscribe _ISubscribe) : base(_ISubscribe)
        {

        }


        [HttpPost]
        [ModelValidator]
        public IHttpActionResult Subscribe(Subscriber _Subscriber)
        {
            ISubscribe.RegisterSubscriber(_Subscriber);
            return Ok("Thank you. You have been sucessufully subscribed to Dynamic DNA");
        }
    }
}
