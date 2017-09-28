using ApplyOnlineAPI.Filters;
using BL.BL.Interfaces;
using DAL.DBContext;
using DAL.Entities;
using System.Linq;
using System.Web.Http;

namespace ApplyOnlineAPI.Controllers
{
    public class ApplicantController : BaseController
    {

        public ApplicantController(IRegister iRegister, IImageService iImageService, IUpdate iUpdate)
            : base(iRegister, iImageService, iUpdate) { }


        [HttpPost]
        [ModelValidator]
        public IHttpActionResult Register(Personal _Personal)
        {
            IRegister.RegisterUser(_Personal);
            return Ok("Thank you for applying");
        }

        public IQueryable<Personal> GetUsers()
        {
            using (var db = new ApplyDbContext())
            {
                return db.Personal;
            }

        }

        [HttpPut]
        [ModelValidator]
        public IHttpActionResult Update(int id, Personal _Personal)
        {

            try
            {
                IUpdate.UpdateUser(id, _Personal);
                return Ok(_Personal);

            }
            catch (System.Exception)
            {

                return BadRequest("Unable to Update");

            }


        }


        //[HttpPost]
        //public async Task<IHttpActionResult> Upload(HttpPostedFileBase photo)
        //{
        //    var imageUrl = await imageService.UploadImageAsync(photo);
        //    TempData["LatestImage"] = imageUrl.ToString();
        //    return RedirectToAction("LatestImage");
        //}
    }
}
