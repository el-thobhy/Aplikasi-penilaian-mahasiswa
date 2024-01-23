using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_BLQ
{
    internal class Soal05
    {
        public Soal05()
        {
            Console.WriteLine("=== Soal 05. menampilkan n-bilangan fibonacci pertama ===");
            Console.Write("Masukkan nilai n: ");
            //fibonacci = 0, 1, 1, 2, 3, 5, 8, ..., n


            int n = int.Parse(Console.ReadLine()); //5
            Console.Write("Masukkan angka pertama: ");
            int seq1 = int.Parse(Console.ReadLine()); //1
            Console.Write("Masukkan angka kedua: ");
            int seq2 = int.Parse(Console.ReadLine()); //1


            for(int i = 0; i < n; i++)
            {
                Console.Write(seq1+" ");
                int nextSeq = seq1+seq2;
                seq1 = seq2;
                seq2 = nextSeq;
            }
            Console.WriteLine();
        }
    }
}
