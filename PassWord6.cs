using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPractice
{
    public class PassWord6
    {

        // public static string REGEX_PASSWORD = "^[A-Z]{1}[a-z]{5}$";
        public static string REGEX_PASSWORD = "^[A-Z]{1}[a-z0-9]{5}$";  //USECASE_6&7


        public bool validatePassWord(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
