using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPractice
{
    public class MobileFormat
    {
        public static string REGEX_PHONENUMBER = "^(91)?[6-9]{1}[0-9]{9}$";

        public bool validatePhoneNumber(string phonenumber)

        {
            return Regex.IsMatch(phonenumber, REGEX_PHONENUMBER);
        }
    }
}
