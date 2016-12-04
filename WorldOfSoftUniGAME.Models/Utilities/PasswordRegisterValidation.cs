namespace WorldOfSoftUniRPG.Models.Utilities
{
    using System.Text.RegularExpressions;

    public class PasswordRegisterValidation
    {
        public enum PasswordType
        {
            Empty, Lenght, Success, InvalidFormat
        }

        public static PasswordType IsValid(string password)
        {
            if (password == string.Empty)
            {
                return PasswordType.Empty;
            }
            else if (password.Length < 5 || password.Length > 20)
            {
                return PasswordType.Lenght;
            }

            string regularExpressinString = @"^(?=.{5,20}$)([a-zA-Z0-9]+)$";
            Regex regex = new Regex(regularExpressinString);
            if (!regex.IsMatch(password))
            {
                return PasswordType.InvalidFormat;
            }

            return PasswordType.Success;
        }
    }
}