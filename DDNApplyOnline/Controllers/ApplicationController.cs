using System.Web.Mvc;

namespace DDNApplyOnline.Controllers
{
    public class ApplicationController : Controller
    {
        // GET: Application
        public ActionResult Apply()
        {
            return View();
        }

    }
}