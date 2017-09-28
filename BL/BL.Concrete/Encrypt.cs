using BL.Services;
using System.Security.Cryptography;
using System.Text;

namespace BL.BL.Concrete
{
    public class Encrypt : IEncrypt
    {


        public string EncryptPassword(string userId)
        {
            byte[] hash;
            using (var sha1CryptoServiceProvider = new SHA1CryptoServiceProvider())
            {
                hash = sha1CryptoServiceProvider.ComputeHash(Encoding.Unicode.GetBytes(userId + "SHA1"));
            }
            var stringBuilder = new StringBuilder();

            foreach (byte b in hash) stringBuilder.AppendFormat("{0:x2}", b);
            {
                return stringBuilder.ToString();
            }

        }

    }
}
