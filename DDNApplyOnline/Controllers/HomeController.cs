using System.Web.Mvc;

namespace DDNApplyOnline.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Subscribe()
        {
            return View();
        }
    }
}