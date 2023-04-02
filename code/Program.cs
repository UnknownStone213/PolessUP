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
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            List<int> list = new List<int>(); // primt numbers

            for (int i = 2; i < num; i++)
            {
                bool prime = true;
                for (int i2 = i - 1; i2 > 1; i2--) // dividing the number i by i2 that is less than i by 1 and more than 1 (not including itself and 1)
                {
                    if (i % i2 == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime)
                {
                    list.Add(i);
                }
            }

            Console.WriteLine("Output: " + list.Count);

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + ", ");
            }


            Console.ReadLine();
        }
    }
}
