using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_BLQ
{
    internal class Soal14
    {
        public Soal14()
        {
            Console.WriteLine("=== Soal 14: Rotasi deret ===\nDeret: 3 9 0 7 1 2 4\nN = 3	 7 1 2 4 3 9 0\nN = 1	 9 0 7 1 2 4 1");
            Console.Write("Masukkan deret (contoh: 5 6 7 0 1): ");
            List<string> list = Console.ReadLine().Split(' ').ToList();
            List<int> nums = list.ConvertAll(int.Parse);

            Console.Write("Masukkan Rotasi: ");
            int rotasi = int.Parse(Console.ReadLine());


            Printing.PrintList(RotationDeret(nums, rotasi));
        }

        private List<int> RotationDeret(List<int> nums, int rotasi)
        {
            int temp = nums[0];
            for (int j = 0; j < nums.Count - 1; j++)
            {
                nums[j] = nums[j + 1];
            }
            rotasi -= 1;
            nums[nums.Count - 1] = temp;
            //Printing.PrintList(nums);
            if (rotasi > 0)
            {
                RotationDeret(nums, rotasi);
            }
            return nums;
        }
    }
}
