using BL.BL.Interfaces;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Web;

namespace BL.BL.Concrete
{
    public class FileService : IFileService
    {

        public async Task<string> UploadFileAsync(HttpPostedFileBase fileToUpload)
        {
            string imageFullPath = null;
            if (fileToUpload == null || fileToUpload.ContentLength == 0)
            {
                return null;
            }
            try
            {
                CloudStorageAccount cloudStorageAccount = ConnetionString.GetConnectionString();
                CloudBlobClient cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();
                CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference("profileimages");
                if (await cloudBlobContainer.CreateIfNotExistsAsync())
                {
                    await cloudBlobContainer.SetPermissionsAsync(
                       new BlobContainerPermissions
                       {
                           PublicAccess = BlobContainerPublicAccessType.Blob
                       }
                       );
                }

                string fileName = Guid.NewGuid().ToString() + "-" + Path.GetExtension(fileToUpload.FileName);

                CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(fileName);
                cloudBlockBlob.Properties.ContentType = fileToUpload.ContentType;
                await cloudBlockBlob.UploadFromStreamAsync(fileToUpload.InputStream);

                imageFullPath = cloudBlockBlob.Uri.ToString();
            }
            catch (System.Exception)
            {

                throw;
            }
            return imageFullPath;
        }

    }
}
