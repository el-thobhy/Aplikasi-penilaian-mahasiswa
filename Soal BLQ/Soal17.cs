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
            Console.WriteLine("=== Soal 17 ===");
            Console.WriteLine("Contoh Input : N N T N N N T T T T T N T T T N T N");
            Console.Write("Masukkan Perjalanan Hattori : ");
            string input = Console.ReadLine().Replace(" ", "");
            //gunung

            //Menanjak (N) dari ketinggian 0 menjadi 1.
            //Menanjak (N) dari ketinggian 1 menjadi 2.
            //Turun (T) dari ketinggian 2 menjadi 1.
            //Menanjak (N) dari ketinggian 1 menjadi 2.
            //Menanjak (N) dari ketinggian 2 menjadi 3.
            //Menanjak (N) dari ketinggian 3 menjadi 4.
            //Turun (T) dari ketinggian 4 menjadi 3.
            //Turun (T) dari ketinggian 3 menjadi 2.
            //Turun (T) dari ketinggian 2 menjadi 1.
            //Turun (T) dari ketinggian 1 menjadi 0.

            //lembah

            //Menanjak(N) dari ketinggian 0 menjadi 1.
            //Turun(T) dari ketinggian 1 menjadi 0.
            //Turun(T) dari ketinggian 0 menjadi - 1.
            //Turun(T) dari ketinggian -1 menjadi - 2.
            //Turun(T) dari ketinggian -2 menjadi - 3.
            //Menanjak(N) dari ketinggian -3 menjadi - 2.
            //Turun(T) dari ketinggian -2 menjadi - 3.
            //Menanjak(N) dari ketinggian -3 menjadi - 2.

            int gunung = 0;
            int lembah = 0;
            int ketinggian = 0;

            foreach (char langkah in input)
            {
                ketinggian += (langkah == 'N') ? 1 : -1;
                Console.Write(ketinggian+" ");
                if (ketinggian == 0 && langkah == 'N')
                    lembah++;
                if (langkah == 'T' && ketinggian == 0)
                    gunung++;
            }
            Console.WriteLine();
            Console.WriteLine($"Jumlah Gunung: {gunung}");
            Console.WriteLine($"Jumlah Lembah: {lembah}");
        }
    }
}
