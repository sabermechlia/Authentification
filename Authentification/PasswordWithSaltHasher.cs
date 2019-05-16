
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
 
namespace Authentification
{
    public class PasswordWithSaltHasher
    {
        public HashWithSaltPassword HashWithSalt(string password, int saltLength, HashAlgorithm hashAlgo)
        {
            RNG rng = new RNG();
            byte[] saltBytes = rng.GenerateRandomCryptographicBytes(saltLength);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            byte[] timestampAsBytes = Encoding.UTF8.GetBytes(ConvertToTimestamp().ToString());
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(timestampAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return new HashWithSaltPassword(Convert.ToBase64String(saltBytes) + Convert.ToBase64String(timestampAsBytes), Convert.ToBase64String(digestBytes));
        }
        private Int32 ConvertToTimestamp()
        {
            
            return (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }
    }
}