using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_BLQ
{
    internal class Soal03
    {
        public Soal03()
        {
            Console.WriteLine("=== Soal 03. menghitung tarif parkir ===");
            //case 1
            DateTime masuk1 = DateTime.ParseExact("2019-01-27 05:00:01", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime keluar1 = DateTime.ParseExact("2019-01-27 17:45:03", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            //case 2
            DateTime masuk2 = DateTime.ParseExact("2019-01-27 07:03:59", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime keluar2 = DateTime.ParseExact("2019-01-27 15:30:06", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            //case 3
            DateTime masuk3 = DateTime.ParseExact("2019-01-27 07:05:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime keluar3 = DateTime.ParseExact("2019-01-28 00:20:21", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            //case 4
            DateTime masuk4 = DateTime.ParseExact("2019-01-27 11:14:23", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime keluar4 = DateTime.ParseExact("2019-01-27 13:20:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);





            Console.WriteLine($"case 1: {HitungTarifParkir(masuk1, keluar1)}");
            Console.WriteLine($"case 2: {HitungTarifParkir(masuk2, keluar2)}");
            Console.WriteLine($"case 3: {HitungTarifParkir(masuk3, keluar3)}");
            Console.WriteLine($"case 4: {HitungTarifParkir(masuk4, keluar4)}");
            Console.WriteLine();

            Console.WriteLine("Coba masukkan tanggal dan jam keluar masuk");
            Console.WriteLine($"masuk (contoh:2018-02-23 22:05:12): ");
            DateTime masuk = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine($"keluar (contoh:2018-02-24 04:05:12): ");
            DateTime keluar = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine($"harga Parkir: {HitungTarifParkir(masuk,keluar)}");

        }

        private int HitungTarifParkir(DateTime masuk, DateTime keluar)
        {
            TimeSpan diff = keluar-masuk;
            int hari = diff.Days;
            Console.WriteLine($"Lama Parkir dalam jam: {diff.TotalHours}, lama parkir: {diff}");
            double jam = diff.TotalHours;
            int detik = diff.Seconds;
            int menit = diff.Minutes;
            int tarif = 0;
            if(detik >= 0)
            {
                if(menit>=0)
                {
                    if (jam > 0 && jam < 8)
                    {
                        tarif = 0;//set tarif ke nol lagi jika lebih satu jam
                        for (int i = 0; i < diff.Hours; i++)
                        {
                            tarif += 1000;
                        }
                    }
                }
                
            }
            
            
            if(jam >= 8 && jam<=24)
            {
                tarif = 8000;
            }
            if (jam>=24)
            {
                tarif = 15000;
                if (jam-24 < 8)
                {
                    for( int i = 0;i < jam-24; i++)
                    {
                        tarif += 1000;
                    }
                }
                else if (jam-24 >= 8 && jam-24 < 24)
                {
                    tarif += 8000;
                }
                else if(hari>=1)
                {
                    tarif = 0;
                    for (int i = 0; i < hari; i++)
                    {
                        tarif += 15000;
                    }
                    if (diff.Hours > 0 && diff.Hours < 8)
                    {
                        tarif += 1000;   
                    }
                    else if (diff.Hours >= 8 && diff.Hours <= 24)
                    {
                        tarif += 8000;
                    }
                }
            }
            return tarif;
        }
    }
}
