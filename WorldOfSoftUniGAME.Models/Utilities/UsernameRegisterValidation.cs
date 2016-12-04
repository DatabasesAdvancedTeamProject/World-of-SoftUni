namespace WorldOfSoftUniRPG.Models.Utilities
{
    using System;
    using System.Text.RegularExpressions;

    public class UsernameRegisterValidation
    {
        public enum UsernameType
        {
            Empty,Lenght,Success,InvalidFormat
        }

        public static UsernameType IsValid(string username)
        {
            if (username == string.Empty)
            {
                return UsernameType.Empty;
            }
            else if (username.Length < 5 || username.Length > 20)
            {
                return UsernameType.Lenght;
            }

            string regularExpressinString = @"^(?=.{5,20}$)([a-zA-Z]+[a-zA-Z0-9_]+)$";
            Regex regex = new Regex(regularExpressinString);
            if (!regex.IsMatch(username))
            {
                return UsernameType.InvalidFormat;
            }

            return UsernameType.Success;
        }
    }
}