using System.Threading.Tasks;
using System.Web;

namespace BL.BL.Interfaces
{
    public interface IFileService
    {
        Task<string> UploadFileAsync(HttpPostedFileBase imageToUpload);
    }
}
