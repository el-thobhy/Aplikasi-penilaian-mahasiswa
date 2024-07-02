using System.Security.Cryptography;
using System.Text;

namespace Framework.Auth
{
    public class Encryption
    {
        public static string HashSha256(string rawData)
        {
            using (SHA256 sHA256 = SHA256.Create())
            {
                //computeHash - return byte array
                byte[] bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                //convert byte to array
                StringBuilder builder = new StringBuilder();
                for(int i = 0;i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}