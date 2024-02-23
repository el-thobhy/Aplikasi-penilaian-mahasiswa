using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Soal_BLQ
{
    internal class Soal11
    {
        public Soal11()
        {
            Console.WriteLine("=== Soal 11 ===\ninput: afrika\noutput:\n***a***\n***k***\n***i***\n***r***\n***f***\n***A***");
            //01 02 03 04 05 06 07
            //11 12 13 14 15 16 17
            //21 22 23 24 24 26 27
            //31 32 33 34 35 36 37
            //41 42 43 44 45 46 47
            //
            //


            Console.Write("Input: ");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input.Length % 2 == 0)
                {
                    for(int j = 0; j < input.Length+1; j++)
                    {
                        if (j == (input.Length+1) / 2)
                        {
                            Console.Write(input[input.Length - 1 - i]);
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (j == (input.Length) / 2)
                        {
                            Console.Write(input[input.Length - 1 - i]);
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
