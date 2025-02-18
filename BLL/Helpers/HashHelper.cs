using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application.Helpers {
    public static class HashHelper {
        public static string Generate(string password) {

            SHA256 sHA256 = SHA256.Create();

            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashedBytes = sHA256.ComputeHash(passwordBytes);

            return BitConverter.ToString(hashedBytes).Replace("-","").ToLower();
        }
        public static bool Check(string password, string passwordHash) {
             return Generate(password) == passwordHash;
        }
    }
}
