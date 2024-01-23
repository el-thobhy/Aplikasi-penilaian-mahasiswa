using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_BLQ
{
    internal class Soal06
    {
        public Soal06()
        {
            Console.WriteLine("=== Soal 06. mengecek sebuah kata adalah palindrom atau tidak ===");
            Console.Write("Masukkan kata: ");
            //ka t ak, nab a ban, malam
            //01234, 0123456

            string kata = Console.ReadLine();
            bool isPal = false;

            Console.WriteLine($"penggalan setengah kata terakhir: {kata.Substring((kata.Length/2)+1)} ");
            Console.WriteLine($"penggalan setengah kata pertama: {kata.Substring(0,(kata.Length / 2))} ");
            Console.WriteLine();

            string penggalanPertama = kata.Substring((kata.Length / 2) + 1);
            string penggalanKedua = kata.Substring(0, kata.Length / 2);

            for(int i = 0; i < penggalanPertama.Length; i++)
            {
                char awalStr = penggalanKedua[i];
                char akhirStr = penggalanPertama[(penggalanPertama.Length - 1) - i];
                if (awalStr == akhirStr)
                {
                    isPal = true;
                }
                else
                {
                    isPal = false;
                    break;
                }
            }

            Console.WriteLine(isPal? "iya": "tidak");

            Console.WriteLine();
        }
    }
}
