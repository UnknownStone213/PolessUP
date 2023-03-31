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
            Console.WriteLine("Enter n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter r:");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Calculate(n, a, r));

            Console.ReadLine();

            int Calculate(int amount, int first, int second) 
            {
                int sum = 0;
                for (int i = 0; i < amount; i++)
                {
                    sum += first + second * i;
                }
                return sum;
            }
        }
    }
}
