using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_BLQ
{
    internal class Soal09
    {
        public Soal09()
        {
            /*
             9.	N = 3 	 3 6 9
                N = 4	 4 8 12 16
                N = 5	 5 10 15 20 25
             */

            Console.WriteLine("=== Soal 09.  ===");
            Console.Write("Masukkan nilai n (contoh: 3): ");

            int n = int.Parse(Console.ReadLine());

            int value = 0;
            for(int i = 0; i < n; i++)
            {
                value += n;
                Console.Write(value+" ");
            }
            Console.WriteLine();
        }
    }
}
