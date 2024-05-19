using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Đồ_án_mới.DAO
{
    public class PasswordHelper
    {
        // Phương thức băm chuỗi đầu vào bằng SHA1
        public static string HashString(string input)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha1.ComputeHash(inputBytes);
                return ConvertToHexString(hashBytes);
            }
        }

        // Phương thức chuyển đổi mảng byte sang chuỗi hex
        private static string ConvertToHexString(byte[] bytes)
        {
            StringBuilder hex = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }
    }
}
