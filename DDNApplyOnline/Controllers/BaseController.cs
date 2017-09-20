using ApplyOnline.DataContext;
using System.Web.Http;

namespace DDNApplyOnline.Controllers
{
    public class BaseController : ApiController
    {
        ApplicantsDbContext DbContext = new ApplicantsDbContext();
    }
}
