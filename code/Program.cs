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
                int max = nums.Min();
                for (int i = 0; i < 3; i++) // going through array 3 times and find 3rd max (changing biggest max to min every time)
                {
                    max = nums.Max();
                    for (int i2 = 0; i2 < nums.Length; i2++)
                    {
                        if (nums[i2] == max)
                        {
                            nums[i2] = nums.Min();
                            break;
                        }
                    }
                }
                Console.WriteLine("Output = " + max);
            }


            Console.ReadLine();
        }
    }
}
