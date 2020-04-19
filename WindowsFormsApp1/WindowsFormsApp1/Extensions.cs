using System;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Extensions
    {
        public static bool IsEmail(this string email)
        {
			try
			{
				MailAddress mail = new MailAddress(email);
				return true;
			}
			catch (Exception)
			{

				return false;
			}
        }

		public static string HashPassword(this string password)
		{
			byte[] bytePassword = Encoding.ASCII.GetBytes(password);
			MD5CryptoServiceProvider mD5 = new MD5CryptoServiceProvider();
			byte[] hashBytePassword = mD5.ComputeHash(bytePassword);
			return Encoding.ASCII.GetString(hashBytePassword);
		}
    }
}
