using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

                for (int i = 0; i < split.Length; i++)
                {
                    if (Convert.ToInt32(split[i]) < 0 || Convert.ToInt32(split[i]) > 255)
                    {
                        return false;
                    }
                }
                return true;
            }

            bool checkIPv6(string s) 
            {
                char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

                int colons = -1;
                string[] split = s.Split(':');
                colons = split.Length;
                if (colons != 8) { return false; }

                bool checkNumbers = true;
                for (int i = 0; i < split.Length; i++)
                {
                    if (split[i].Length < 1 && split[i].Length > 4)
                    {
                        return false;
                    }
                }

                for (int i = 0; i < split.Length; i++) // each sequence
                {
                    for (int i2 = 0; i2 < split[i].Length; i2++) // each letter
                    {
                        bool check = false;
                        for (int i3 = 0; i3 < chars.Length; i3++)
                        {
                            if (chars[i3] == split[i][i2])
                            {
                                check = true;
                            }
                        }
                        if (!check)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
        }
    }
}
