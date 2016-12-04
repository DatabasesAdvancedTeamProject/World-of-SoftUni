using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfSoftUniRPG.Models.Utilities
{
    using System.Text.RegularExpressions;

    public class EmailRegisterValidation
    {
        public enum EmailValidationMsg
        {
            Success, InvalidFormat, Empty
        }

        public static EmailValidationMsg IsValid(string email)
        {
            if (email == string.Empty)
            {
                return EmailValidationMsg.Empty;
            }
            
            string regularExpressinString = @"(^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$)";
            Regex regex = new Regex(regularExpressinString);
            if (!regex.IsMatch(email))
            {
                return EmailValidationMsg.InvalidFormat;
            }

            return EmailValidationMsg.Success;
        }
    }
}
