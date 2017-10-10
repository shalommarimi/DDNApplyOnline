using BL.BL.Concrete;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DDNApplyOnline.Controllers
{

    public class FilesController : Controller
    {
        // GET: Files
        FileService fileService = new FileService();

        public ActionResult UploadRequiredFiles()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> UploadRequiredFiles(HttpPostedFileBase file)
        {
            var fileUrl = await fileService.UploadFileAsync(file);

            return RedirectToAction("UploadRequiredFiles");
        }
    }
}
