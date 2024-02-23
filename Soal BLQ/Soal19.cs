using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_BLQ
{
    internal class Soal19
    {
        public Soal19()
        {
            Console.WriteLine("==== Soal 19. Pangrams ====\nTentukan apakah kalimat ini adalah Pangram* atau bukan\n“Sphinx of black quartz, judge my vow”\n“Brawny gods just flocked up to quiz and vex him”\n“Check back tomorrow; I will see if the book has arrived.”\n*Pangram adalah kata atau kalimat yang mengandung setiap abjad alphabet, \ncontohnya “A quick brown fox jumps over the lazy dog”");
            Console.Write("\nmasukkan string (contoh: We promptly judged antique ivory buckles for the next prize): ");
            string input = Console.ReadLine().ToLower();
            string lib = " abcdefghijklmnopqrstuvwxyz";
            char[] charIn = input.ToArray();
            Array.Sort(charIn);
            int cursor = 0;
            for (int i = 0; i < lib.Length; i++)
            {
                for (int j = cursor; j < charIn.Length; j++)
                {
                    if (charIn[j] == lib[i])
                    {
                        lib = lib.Remove(i, 1);
                        cursor = j + 1;
                        i--;
                        break;
                    }
                }
            }
            Console.WriteLine("{0}", lib.Length == 0 ? "pangram" : "not pangram");
            Console.WriteLine($"huruf yang tidak ada {lib}");
        }
    }
}
