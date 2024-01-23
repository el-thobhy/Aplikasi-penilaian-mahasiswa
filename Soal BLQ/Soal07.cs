using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_BLQ
{
    internal class Soal07
    {
        public Soal07()
        {
            Console.WriteLine("=== Soal 06. mencari mead, median, dan modus ===");
            Console.Write("Masukkan deret bilangan bulat (contoh: 8 7 0 2 7 1 7 6 3 0 7 1 3 4 6 1 6 4 3): ");

            int[] deret = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Array.Sort(deret);
            Printing.Print1D(deret);
            Console.WriteLine();
            Console.WriteLine($"mean: {Math.Round(CariMean(deret),2)}");
            Console.WriteLine($"median: {CariMedian(deret)}");
            Console.WriteLine($"modus: {CariModus(deret)}");


            Console.WriteLine();

        }

        private int CariModus(int[] deret)
        {
            int count = 1;
            //1 1 1 1 2 2 3 3 4 
            List<int> list = new();
            List<int> newList = deret.ToList();
            for(int i = 1;i<= newList.Count; i++)
            {
                for(int j = i; j <= newList.Count-1; j++)
                {
                    if (newList[i - 1] == newList[j])
                    {
                        count++;
                        newList.RemoveAt(i - 1);
                        j--;
                    }
                }
                list.Add(count);
                count = 1;
            }
            int modus = newList[list.IndexOf(list.Max())];

            Console.WriteLine();
            Printing.PrintList(list);
            Printing.PrintList(newList);
            return modus;
        }

        private double CariMean(int[] deret)
        {
            int sum = 0;
            for (int i = 0; i < deret.Length; i++)
            {
                sum += deret[i];
            }

            double mean = (double)sum / deret.Length;
            return mean;
        }

        private double CariMedian(int[] deret)
        {

            double median;
            if (deret.Length % 2 == 0)
            {
                median = (double)((double)(deret[(deret.Length - 1) / 2] + deret[((deret.Length - 1) / 2) + 1]) / 2);
            }
            else
            {
                median = deret[deret.Length / 2];
            }

            return median;
        }
    }
}
