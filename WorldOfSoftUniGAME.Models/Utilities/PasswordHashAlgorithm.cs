namespace WorldOfSoftUniRPG.Models.Utilities
{
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    public class PasswordHashAlgorithm
    {
        public static string Hash(string input)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Join(string.Empty, hash.Select(b => b.ToString("x2")).ToArray());
        }
    }
}