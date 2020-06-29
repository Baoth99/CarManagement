using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tool.checkinput
{
    public static class Check
    {
        public static bool getString(string text)
        {
            if (text.Equals("") || text.Length == 0 || text == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool getFloat(string num)
        {
            try
            {
                float number = float.Parse(num);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static bool checkPhone(string num)
        {
            Regex regex = new Regex(@"^[0]{1}[0-9]{9,15}$");
            return regex.IsMatch(num);
        }
        public static bool checkEmail(String email)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9_-]{3,20}@[a-zA-Z]{3,10}([.][a-z]{2,5}){1,2}$");
            return regex.IsMatch(email);
        }
    }
}
