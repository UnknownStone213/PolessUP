using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            int index = 0;
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                    index = i;
                }
            }
            Console.WriteLine("Output (position of max element) = " + index);


            Console.ReadLine();
        }
    }
}
