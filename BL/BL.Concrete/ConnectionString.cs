using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;

namespace BL.BL.Concrete
{
    public class ConnetionString
    {

        static string account = CloudConfigurationManager.GetSetting("StorageAccountName");
        static string key = CloudConfigurationManager.GetSetting("StorageAccountKey");

        public static CloudStorageAccount GetConnectionString()
        {
            string connectionString = string.Format("DefaultEndpointsProtocol=https;AccountName={0};AccountKey={1}", account, key);
            return CloudStorageAccount.Parse(connectionString);
        }
    }
}
