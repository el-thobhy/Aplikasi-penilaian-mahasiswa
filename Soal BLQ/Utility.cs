using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_BLQ
{
    public class Printing
    {
        static public void Print2D(int[,] arr2D)
        {
            for (int row = 0; row < arr2D.GetLength(0); row++)
            {
                for (int coll = 0; coll < arr2D.GetLength(1); coll++)
                {
                    Console.Write($"{arr2D[row, coll]}\t");
                }
                Console.WriteLine();
            }
        }
        static public void Print2D(string[,] arr2D)
        {
            for (int row = 0; row < arr2D.GetLength(0); row++)
            {
                for (int coll = 0; coll < arr2D.GetLength(1); coll++)
                {
                    Console.Write($"{arr2D[row, coll]}\t");
                }
                Console.WriteLine();
            }
        }

        static public void Print2DChess(string[,] arr2D)
        {
            for (int row = 0; row < arr2D.GetLength(0); row++)
            {
                for (int coll = 0; coll < arr2D.GetLength(1); coll++)
                {
                    if (String.IsNullOrEmpty(arr2D[row, coll]))
                    {
                        Console.Write("*\t");
                    }
                    else
                        Console.Write($"{arr2D[row, coll]}\t");
                }
                Console.WriteLine();
            }
        }
        static public void Print1D(string[] arr)
        {
            foreach (string val in arr)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
        static public void Print1D(char[] arr)
        {
            foreach (char val in arr)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }

        static public void Print1D(decimal[] arr)
        {
            foreach (decimal val in arr)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
        static public void Print1DChar(char[] arr)
        {
            foreach (char val in arr)
            {
                Console.Write(val);
            }
            Console.WriteLine();
        }

        static public void Print1D(int[] arr)
        {
            foreach (int val in arr)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
        static public void PrintList(List<int> list)
        {
            foreach (int row in list)
            {
                Console.Write(row + " ");
            }
            Console.WriteLine();
        }

        static public void PrintList(List<string> list)
        {
            foreach (string row in list)
            {
                Console.Write(row + " ");
            }
            Console.WriteLine();
        }

        static public void PrintList(List<List<int>> list)
        {
            Console.WriteLine("ListList");
            foreach (List<int> row in list)
            {
                foreach (int i in row)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
