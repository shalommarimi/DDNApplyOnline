using BL.BL.Interfaces;
using DAL.DBContext;
using DAL.Entities;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.Http;

namespace ApplyOnlineAPI.Controllers
{
    public class ApplicantController : BaseAPIController
    {

        public ApplicantController(IRegister iRegister, IImageService iImageService, IApplicantUpdate iApplicantUpdate) : base(iRegister, iImageService, iApplicantUpdate)
        {
        }



        public IHttpActionResult Register(Personal _Personal)
        {

            if (ModelState.IsValid)
            {
                IRegister.Apply(_Personal);
                return Ok("Thank you for applying");
            }
            else
            {
                return BadRequest(ModelState);
            }

        }

        private bool UserExists(int id)
        {
            using (var _db = new ApplyDbContext())
            {
                return _db.Personal.Count(p => p.PkApplicantId == id) > 0;
            }

        }



        [HttpPut]
        public IHttpActionResult Update(int id, Personal _Personal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != _Personal.PkApplicantId)
            {
                return BadRequest();
            }


            try
            {
                IApplicantUpdate.Update(id, _Personal);
                return Ok("User Successfully Updated!");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
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
