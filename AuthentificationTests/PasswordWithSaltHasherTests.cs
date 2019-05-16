using Microsoft.VisualStudio.TestTools.UnitTesting;
using Authentification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;

namespace Authentification.Tests
{
    [TestClass()]
    public class PasswordWithSaltHasherTests
    {
        [TestMethod()]
        public void HashWithSaltTest()
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            HashWithSaltPassword hashResultSha256 = pwHasher.HashWithSalt("password", 64, SHA256.Create());
            

            Debug.WriteLine(hashResultSha256.Salt);
           
        }
    }
}