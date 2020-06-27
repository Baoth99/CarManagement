using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
