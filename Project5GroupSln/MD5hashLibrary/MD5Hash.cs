using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5HashLibrary
{
  public static class MD5Hash
  {
    public static string Encrypt(string password)
    {

      // initilize MD5CryptoServiceProvider
      MD5 md5 = new MD5CryptoServiceProvider();

      //compute hash value from the bytes array 
      md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));

      //get the value of computed  hash code
      byte[] result = md5.Hash;

      StringBuilder strBuilder = new StringBuilder();
      for (int i = 0; i < result.Length; i++)
      {
        //change it into 2 hexadecimal   
        strBuilder.Append(result[i].ToString("x2"));
      }

      return strBuilder.ToString();
    }

  }
}
