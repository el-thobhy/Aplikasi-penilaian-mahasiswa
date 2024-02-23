using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_BLQ
{
    internal class Soal13
    {
        public Soal13()
        {
            Console.WriteLine("=== Soal 13 ===\nBerapa derajat sudut terkecil yang dibentuk 2 jarum jam?\nJam 3:00  90\nJam 5:30  15\nJam 2.20  50\n*detik tidak dipertimbangkan");
            Console.Write("Masukkan waktu (format: HH:mm): ");
            string input = Console.ReadLine();

            string[] splitInput = input.Split(':');
            double jam = double.Parse(splitInput[0]);
            double menit = double.Parse(splitInput[1]);
            double posisiMenit = (menit / 60) * 12;
            double sudut = 360/12;

            jam += (menit / 60);
            jam = (jam >= 12) ? jam - 12 : jam;

            double output = Math.Abs(jam - posisiMenit) * sudut;
            output = (output > 180) ? 360 - output : output;

            Console.WriteLine($"{Math.Round(output)}");
        }
    }
}
