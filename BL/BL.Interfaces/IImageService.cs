using System.Threading.Tasks;
using System.Web;

namespace BL.BL.Interfaces
{
    public interface IImageService
    {
        Task<string> UploadImageAsync(HttpPostedFileBase imageToUpload);
    }
}
