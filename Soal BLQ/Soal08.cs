using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_BLQ
{
    internal class Soal08
    {
        public Soal08()
        {
            Console.WriteLine("=== Soal 06. mencari nilai maksimal dan minimal dari penjumlahan 4 nilai deret ===");
            Console.Write("Masukkan deret bilangan bulat (contoh: 1 2 4 7 8 6 9): ");

            int[] deret = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Array.Sort(deret);

            int min = 0;
            int max = 0;
            for (int i = 0; i < 4; i++)
            {
                min+= deret[i];
            }
            for (int i = deret.Length-1;i >= deret.Length-4; i--)
            {
                max+= deret[i];
            }
            Console.WriteLine($"min: {min}, max: {max}");

            Console.WriteLine();
        }
    }
}
