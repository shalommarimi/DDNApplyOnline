using BL.BL.Interfaces;
using DAL.Entities;
using System.Web.Http;

namespace ApplyOnlineAPI.Controllers
{
    public class ApplicantController : ApiController
    {
        private IRegister _IRegister;

        public ApplicantController(IRegister iRegister)
        {
            _IRegister = iRegister;
        }

        public IHttpActionResult Register(Personal _Personal)
        {

            if (ModelState.IsValid)
            {
                _IRegister.Apply(_Personal);
                return Ok("Thank you for applying");
            }
            else
            {
                return BadRequest(ModelState);
            }


        }
    }
}
