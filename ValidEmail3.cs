using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPractice
{
    public class ValidEmail3
    {
        public static string REGEX_VALIDEMAIL = "^[abc._][-a-z0-3._]+@([co]+.)+[a-z]{2,5}$"; //^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$


        public bool validateValidEmail(string validemail)
        {
            return Regex.IsMatch(validemail, REGEX_VALIDEMAIL);
        }
    }
}
