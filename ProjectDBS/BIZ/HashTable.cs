using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BIZ
{
    public class HashTable
    {
        //classs definition: has user passwords and any other designatated fields

        //method 1 = encrypt user password
        public string EncryptPassword(string data)
        {
            SHA1 sha = SHA1.Create();

            byte[] pwdHashData = sha.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder returnHashValue = new StringBuilder();
            for (int i = 0; i < pwdHashData.Length; i++)
            {
                returnHashValue.Append(pwdHashData[i].ToString());
            }

            return returnHashValue.ToString();
        }
    }
}
