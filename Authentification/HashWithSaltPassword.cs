using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentification
{
    public class HashWithSaltPassword
    {
        public string Salt { get; }
        public string Digest { get; set; }

        public HashWithSaltPassword(string salt, string digest)
        {
            Salt = salt;
            Digest = digest;
        }
    }
}
