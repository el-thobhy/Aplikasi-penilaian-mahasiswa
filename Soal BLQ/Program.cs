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
            Console.WriteLine("3. Soal 03");
            Console.WriteLine("4. Soal 04");
            Console.WriteLine("5. Soal 05");
            Console.WriteLine("6. Soal 06");
            Console.WriteLine("7. Soal 07");
            Console.WriteLine("8. Soal 08");
            Console.WriteLine("9. Soal 09");

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
                    case 5:
                        new Soal05();
                        break;
                    case 6:
                        new Soal06();
                        break;
                    case 7:
                        new Soal07();
                        break;
                    case 8:
                        new Soal08();
                        break;
                    case 9:
                        new Soal09();
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