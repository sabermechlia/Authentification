using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentification
{
    class LoginUuid
    {
        public string getUuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
