using ApplyOnlineAPI.Filters;
using BL.BL.Interfaces;
using BL.DTO;
using DAL.DBContext;
using DAL.Entities;
using System.Collections.Generic;
using System.Web.Http;

namespace ApplyOnlineAPI.Controllers
{
    public class ApplicantController : BaseController
    {

        public ApplicantController(IRegister iRegister, IImageService iImageService, IUpdate iUpdate)
            : base(iRegister, iImageService, iUpdate) { }


        [HttpPost]
        [ModelValidator]
        public IHttpActionResult RegisterP(PersonalDTO _PersonalDTO)
        {
            try
            {
                IRegister.RegisterUser(_PersonalDTO);
                return Ok("Thank you for applying");
            }
            catch (System.Exception)
            {

                return BadRequest("Unable to Send Application");
            }


        }

        public IEnumerable<Personal> GetAll()
        {
            var db = new ApplyDbContext();

            return db.Personal;
        }



        [HttpPost]
        [ModelValidator]
        public IHttpActionResult Update(PersonalDTO _PersonalDTO)
        {
            try
            {
                IUpdate.UpdateUser(_PersonalDTO);
                return Ok(_PersonalDTO);
            }
            catch (System.Exception)
            {
                return BadRequest("Unable to Update");
            }

        }

    }
}
