using ApplyOnlineAPI.Filters;
using BL.DTO;
using BL.Services;
using DAL.DBContext;
using DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ApplyOnlineAPI.Controllers
{
    [RoutePrefix("api/Default")]
    public class DefaultController : BaseController
    {

        public DefaultController(ISubscribe _ISubscribe) : base(_ISubscribe) { }


        [HttpPost]
        [ModelValidator]
        [Route("Subscribe")]
        public IHttpActionResult Subscribe(SubscriberDTO _SubscriberDTO)
        {
            try
            {
                ISubscribe.RegisterSubscriber(_SubscriberDTO);
                return Ok("Thank you. You have been sucessufully subscribed to Dynamic DNA");
            }
            catch (System.Exception)
            {
                return BadRequest("Opps! Unable to Subscribe User");
            }

        }

        [HttpGet]
        [Route("getList")]
        public IEnumerable<Gender> getList()
        {
            var db = new ApplyDbContext();

            return db.Gender.ToList();
        }




    }
}
