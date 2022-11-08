using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPractice
{
    public class PasswordSpecialChar
    {
        public static string REGEX_PASSWORD = "^[A-Z]{1}[a-z0-9])(?=.*\\W).{8,8})$";


        public bool validatePassWord(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
