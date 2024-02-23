using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_BLQ
{
    internal class Soal12
    {
        public Soal12()
        {
            Console.WriteLine("=== Soal 12. Sorting deret angka ===\nInput: 1 2 1 3 4 7 1 1 5 6 1 8\nOutput: 1 1 1 1 1 2 3 4 5 6 7 8");
            Console.Write("Masukkan deret angka (contoh: 1 2 1 3 4 7 1 1 5 6 1 8): ");

            int[] deret = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

            //
            //5 4 3 2 1
            //4 5 3 2 1
            //3 4 5 2 1
            //2 3 4 5 1
            //1 2 3 4 5
            for (int i = 1; i< deret.Length; i++)
            {
                for(int j = i; j> 0; j--)
                {
                    if (deret[j] < deret[j - 1])
                    {
                        var temp = deret[j - 1];
                        deret[j - 1] = deret[j];
                        deret[j] = temp;
                    }
                }
            }
            Printing.Print1D(deret);
        }
    }
}
