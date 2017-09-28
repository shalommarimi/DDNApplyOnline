using ApplyOnlineAPI.Filters;
using BL.BL.Interfaces;
using DAL.Entities;
using System.Data.Entity.Infrastructure;
using System.Web.Http;

namespace ApplyOnlineAPI.Controllers
{
    public class ApplyController : BaseController
    {

        public ApplyController(IRegister iRegister, IImageService iImageService, IUpdate iUpdate)
            : base(iRegister, iImageService, iUpdate) { }


        [HttpPost]
        [ModelValidator]
        public IHttpActionResult Register(Personal _Personal)
        {
            IRegister.RegisterUser(_Personal);
            return Ok("Thank you for applying");
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
            catch (DbUpdateConcurrencyException)
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
