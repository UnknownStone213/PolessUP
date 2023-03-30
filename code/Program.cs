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
            Console.WriteLine("Enter the length of array:");
            int[] nums = new int[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("Fill the array:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("nums[{0}] = ", i);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array has been filled.");

            int output = nums.Max();
            if (nums.Length < 3)
            {
                Console.WriteLine("Output = " + output);
            }
            else
            {
                int max1 = nums.Min();
                int max2 = nums.Min();
                int max3 = nums.Min();
                for (int i = 0; i < 3; i++) // go through array 3 times and find 3rd max
                {
                    for (int i2 = 0; i2 < nums.Length; i2++)
                    {

                    }
                }
            }


            Console.ReadLine();
        }
    }
}
