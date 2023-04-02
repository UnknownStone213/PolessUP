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
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());

            List<int> list = new List<int>();

            int k1 = Convert.ToString(num).Length;

            //getS(num.ToString(), k1);

            Console.ReadLine();

            //void getS(string s, int k) 
            //{
            //    if (k == 1)
            //    {
            //        list.Add(Convert.ToInt32(s));
            //    }
            //    else 
            //    {
            //        for (int i = 0; i < 3; i++)
            //        {
            //            getS(s, k - 1);
            //            if (k % 2 == 0)
            //            {
            //                char s2 = s[i];
            //                s[i-1] = s2;

            //            }
            //        }
            //    }
            //}
        }
    }
}
