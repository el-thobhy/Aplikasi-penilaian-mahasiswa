using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_BLQ
{
    internal class Soal04
    {
        public Soal04()
        {
            Console.WriteLine("=== Soal 04. menampilkan n-bilangan prima pertama ===");
            Console.Write("Masukkan nilai n: ");
            //prima = 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, n
            // 1 2 3 4 5 6 7 8 9

            int n = int.Parse(Console.ReadLine()); //5
            int number = 1;
            int maxnumber = n * 3;
            List<int> list = new();
            for (int i = 1; i <= maxnumber; i++)
            {
                number++;
                int factorCount = 0;
                for (int j = 1; j <= maxnumber; j++)
                {
                    if (number % j == 0)
                    {
                        factorCount++;
                    }
                }
                if (factorCount == 2)
                {
                    list.Add(number);
                }
            }
            Printing.PrintList(list.Take(n).ToList());
            Console.WriteLine();
        }
    }
}
