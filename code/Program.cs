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
            Console.WriteLine("Enter year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("true");
            }
            else 
            {
                Console.WriteLine("false");
            }


            Console.ReadLine();
        }
    }
}
