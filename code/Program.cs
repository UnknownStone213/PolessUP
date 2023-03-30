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

            // sorting the array
            int min = nums[0];
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                min = nums[i];
                index = i;
                for (int i2 = i + 1; i2 < nums.Length; i2++)
                {
                    if (min > nums[i2])
                    {
                        min = nums[i2];
                        index = i2;
                    }
                }
                nums[index] = nums[i];
                nums[i] = min;
            }

            Console.WriteLine("Array has been sorted:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            bool check = false;
            index = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (target == nums[i])
                {
                    index = i;
                    check = true;
                }
            }

            if (check) // target has been found?
            {
                Console.WriteLine("Output = " + index);
            }
            else
            {
                index = nums.Length - 1; // since the array is sorted, if there is no number bigger then its gonna be last index
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] >= target)
                    {
                        index = i;
                        break;
                    }
                }
                Console.WriteLine("Output = " + index);
            }


            Console.ReadLine();
        }
    }
}
