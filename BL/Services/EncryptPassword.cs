﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class EncryptPassword : IEncryptPassword
    {
        public string EncryptUserPassword(string userId)
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
