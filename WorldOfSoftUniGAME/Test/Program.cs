using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    using System.Security.Cryptography;

    using WorldOfSoftUniRPG.Data;
    using WorldOfSoftUniRPG.Models;

    class Program
    {
        static void Main(string[] args)
        {
            WorldOfSoftUniContext context = new WorldOfSoftUniContext();
            User user = context.Users.FirstOrDefault(u => u.UserName == "bobi");
            Console.WriteLine(user.PasswordHash);
        }
    }
}
