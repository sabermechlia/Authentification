using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Authentification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Login :");
            string Login = Console.ReadLine().ToString();
            Console.WriteLine("Password :");
            string pwd = Console.ReadLine().ToString();
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            HashWithSaltPassword hashResultSha256 = pwHasher.HashWithSalt(pwd, 64, SHA256.Create());
            LoginUuid loginUuid = new LoginUuid();
            string uuid = loginUuid.getUuid();

            Console.WriteLine("id :" + uuid);
            Console.WriteLine("Login :" + Login);
            Console.WriteLine("salt : "+ hashResultSha256.Salt);
            Console.WriteLine("Hashed_password :" + hashResultSha256.Digest);
            Console.ReadKey();
        }
    }
}
