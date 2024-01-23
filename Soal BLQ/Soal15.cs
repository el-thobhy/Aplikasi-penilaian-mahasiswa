using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_BLQ
{
    internal class Soal15
    {
        public Soal15()
        {
            //Sample Input 0
            //07:05:45PM
            //Sample Output 0
            //19:05:45
            /*Console.WriteLine("02. Time Conversion");
            Console.Write("Masukkan waktu (contoh: 07:05:45PM): ");
            string time = Console.ReadLine();
            var id = new CultureInfo("id-ID");
            DateTime input = DateTime.Parse(time, id);
            Console.WriteLine(input.ToString("HH:mm:ss", id));*/

            Console.WriteLine("=== Soal 15. mengubah waktu menjadi format 24 jam");
            Console.Write("Masukkan waktu (contoh: 07:05:45PM): ");
            string inputJam = Console.ReadLine();
            string[] arrJam = inputJam.Substring(0, 8).Split(':');

            bool valid = true;

            if (int.Parse(arrJam[0]) < 0 || int.Parse(arrJam[0]) > 12)
                valid = false;

            if (int.Parse(arrJam[1]) < 0 || int.Parse(arrJam[1]) > 59)
                valid = false;

            if (int.Parse(arrJam[2]) < 0 || int.Parse(arrJam[2]) > 59)
                valid = false;

            if (valid)
            {
                if (inputJam.Substring(inputJam.Length - 2, 2) == "PM")
                {
                    if (int.Parse(arrJam[0]) < 12)
                        arrJam[0] = (int.Parse(arrJam[0]) + 12).ToString();
                }
            }
            else
                Console.WriteLine("Input salah...");

            Console.WriteLine($"{arrJam[0]}:{arrJam[1]}:{arrJam[2]}");

        }
    }
}
