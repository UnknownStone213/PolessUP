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
            Console.WriteLine("Enter ip:");
            string ip = Console.ReadLine();

            bool ipv4 = checkIPv4(ip);
            bool ipv6 = checkIPv6(ip);

            if (ipv4)
            {
                Console.WriteLine("Output: IPv4");
            }
            else if (ipv6) 
            {
                Console.WriteLine("Output: IPv6");
            }
            else 
            {
                Console.WriteLine("Output: Neither");
            }

            Console.ReadLine();

            bool checkIPv4(string s) 
            {
                int points = -1;
                string[] split = s.Split('.');
                points = split.Length;
                if (points != 4) { return false; }

                bool checkNumbers = true;
                for (int i = 0; i < split.Length; i++)
                {
                    if (Convert.ToInt32(split[i]) < 0 || Convert.ToInt32(split[i]) > 255)
                    {
                        checkNumbers = false;
                    }
                }
                if (checkNumbers) 
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool checkIPv6(string s) 
            {



                return false;
            }
        }
    }
}
