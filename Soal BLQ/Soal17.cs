using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_BLQ
{
    internal class Soal17
    {
        public Soal17()
        {
            Console.WriteLine("=== SOal 17 ===");
            Console.WriteLine("Contoh Input : N N T N N N T T T T T N T T T N T N");
            Console.Write("Masukkan Perjalanan Hattori : ");
            string input = Console.ReadLine().Replace(" ", "");

            int gunung = 0;
            int lembah = 0;
            int ketinggian = 0;

            foreach (char langkah in input)
            {
                ketinggian += (langkah == 'N') ? 1 : -1;

                if (ketinggian == 0 && langkah == 'N')
                    lembah++;
                else if (ketinggian == 0 && langkah == 'T')
                    gunung++;
            }

            Console.WriteLine($"Jumlah Gunung: {gunung}");
            Console.WriteLine($"Jumlah Lembah: {lembah}");
        }
    }
}
