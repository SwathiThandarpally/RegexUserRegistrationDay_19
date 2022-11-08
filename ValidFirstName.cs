using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPractice
{
    public class ValidFirstName
    {

        public static string REGEX_VALIDFIRSTNAME = "^[A-Z]{1}[a-z]{5}$";


        public bool validateValidfirstName(string validfirstname)
        {
            return Regex.IsMatch(validfirstname, REGEX_VALIDFIRSTNAME);
        }
    }
}

