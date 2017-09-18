using BL;
using BL.Services;
using DAL.Entities;
using System.Web.Http;

namespace API.Controllers
{
    public class RegisterController : ApiController
    {

        private ISubscribe _ISubscribe;
        private IEncryptPassword _IEncryptPassword;



        public RegisterController(ISubscribe iSubscribe, IEncryptPassword iEncryptPassword)
        {
            _ISubscribe = iSubscribe;
            _IEncryptPassword = iEncryptPassword;

        }



        //  [HttpPost]

        public IHttpActionResult RegisterSubscriber(SubscriberInformation subscriber)
        {

            if (ModelState.IsValid)
            {
                //var repo = DependencyResolver.Current.GetService<ISubscribe>();
                //  repo.RegisterSubscriber(subscriber);
                _ISubscribe.RegisterSubscriber(subscriber);


            }
            else
            {
                return BadRequest(ModelState);
            }
            return Ok("Sucessfully Subscribed!");
        }

    }
}
