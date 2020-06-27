using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.encrypt
{
    public class Encryption
    {
        public static String EncryptString(String msg)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(msg);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }
    }
}
