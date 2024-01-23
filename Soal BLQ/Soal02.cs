using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_BLQ
{
    public class Soal02
    {
        public Soal02()
        {
            Console.WriteLine("=== Soal 02. kalkulasi Denda peminjaaman buku ===");
            DateTime peminjamanA = DateTime.Parse("2016-02-28");
            DateTime pengembalianA = DateTime.Parse("2016-03-07");
            DateTime peminjamanB = DateTime.Parse("2018-04-29");
            DateTime pengembalianB = DateTime.Parse("2018-05-30");

            TimeSpan selisihHariA = pengembalianA.Date- peminjamanA.Date;
            TimeSpan selisihHariB = pengembalianB.Date - peminjamanB.Date;
            int durasiBukuA = 14;
            int durasiBukuB = 3;
            int durasiBukuC = 7;
            int durasiBukuD = 7;
            Console.WriteLine("denda bukuA case a {0}, total hari {1}", (selisihHariA.Days - durasiBukuA>0? selisihHariA.Days - durasiBukuA : 0) * 100,selisihHariA.Days-durasiBukuA);
            Console.WriteLine("denda bukuB case a {0}, total hari {1}", (selisihHariA.Days - durasiBukuB > 0 ? selisihHariA.Days - durasiBukuB : 0) * 100, selisihHariA.Days-durasiBukuB);
            Console.WriteLine("denda bukuC case a {0}, total hari {1}", (selisihHariA.Days - durasiBukuC>0? selisihHariA.Days - durasiBukuC : 0) * 100, selisihHariA.Days - durasiBukuC);
            Console.WriteLine("denda bukuD case a {0}, total hari {1}", (selisihHariA.Days - durasiBukuD>0? selisihHariA.Days - durasiBukuD : 0) * 100, selisihHariA.Days - durasiBukuD);
            Console.WriteLine();
            Console.WriteLine("denda bukuA case b {0}, total hari {1}", (selisihHariB.Days - durasiBukuA>0? selisihHariB.Days - durasiBukuA : 0) * 100,selisihHariB.Days-durasiBukuA);
            Console.WriteLine("denda bukuB case b {0}, total hari {1}", (selisihHariB.Days - durasiBukuB>0? selisihHariB.Days - durasiBukuB : 0) * 100, selisihHariB.Days - durasiBukuB);
            Console.WriteLine("denda bukuC case b {0}, total hari {1}", (selisihHariB.Days - durasiBukuC>0? selisihHariB.Days - durasiBukuC : 0) * 100, selisihHariB.Days - durasiBukuC);
            Console.WriteLine("denda bukuD case b {0}, total hari {1}", (selisihHariB.Days - durasiBukuD>0? selisihHariB.Days - durasiBukuD : 0) * 100, selisihHariB.Days - durasiBukuD);
        }
    }
}
