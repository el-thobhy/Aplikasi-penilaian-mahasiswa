using Soal_BLQ;

namespace Program
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("=== Assesment Soal BLQ ===");
            new Program();
        }

        public Program()
        {
            string answer = "t";
            Console.WriteLine("1. Soal 01");
            Console.WriteLine("2. Soal 02");
            Console.WriteLine("2. Soal 03");
            Console.WriteLine("2. Soal 04");

            while (answer.ToLower() == "t")
            {

                Console.Write("Masukkan no Soal: ");
                int soal = int.Parse(Console.ReadLine());
                switch (soal)
                {
                    case 1:
                        new Soal01();
                        break;
                    case 2:
                        new Soal02();
                        break;
                    case 3:
                        new Soal03();
                        break;
                    case 4:
                        new Soal04();
                        break;
                    default:
                        Console.WriteLine("Soal tidak ditemukan");
                        break;
                }

                Console.Write("Keluar? [y/t]: ");
                answer = Console.ReadLine();
            }
        }
    }
}