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
            Console.WriteLine("Enter number:");
            double num = Convert.ToInt32(Console.ReadLine());

            List<double> list = new List<double>(); // powers of 3

            // get all powers of 3 that are lower than number
            int power = 1;
            do
            {
                if (Math.Pow(3, power) <= num)
                {
                    list.Add(Math.Pow(3, power));
                    power++;
                }
                else 
                {
                    break; 
                }
            } while (true);

            // check
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("list[{0}] = {1}", i, list[i]);
            }

            // subtract powers of 3 (from higher to lower)
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] <= num)
                {
                    num -= list[i];
                }
            }

            if (num == 0)
            {
                Console.WriteLine("Output: true");
            }
            else
            {
                Console.WriteLine("Output: false");
            }


            Console.ReadLine();
        }
    }
}
