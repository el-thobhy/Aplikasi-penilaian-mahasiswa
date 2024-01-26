using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Soal_BLQ
{
    internal class Soal10
    {
        public Soal10()
        {
            Console.WriteLine("=== Soal 10 ===");
            Console.Write("Masukkan Nama : ");
            string input = Console.ReadLine();
            string output;

            string[] kata = input.Split(' ');

            for (int i = 0; i < kata.Length; i++)
            {
                if (kata[i].Length > 1)
                {
                    char[] chars = kata[i].ToCharArray();
                    for (int j = 1; j < chars.Length - 1; j++)
                    {
                        chars[j] = '*';
                    }
                    kata[i] = new string(chars);
                }
            }

            output = string.Join(" ", kata);

            Console.WriteLine("Output: " + output);

        }

    }
}
