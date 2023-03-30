using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter target:");
            int target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of array:");
            int[] nums = new int[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("Fill the array:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("nums[{0}] = ", i);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array has been filled.");

            int index = 0, index2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int i2 = i + 1; i2 < nums.Length; i2++)
                {
                    if (nums[i] + nums[i2] == 9)
                    {
                        index = i;
                        index2 = i2;
                        break;
                    }
                }
            }
            Console.WriteLine("Output: [{0},{1}]", index, index2);

            Console.ReadLine();
        }
    }
}
