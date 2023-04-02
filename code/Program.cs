using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter codes (separated by spaces):"); // через пробел
            string s = Console.ReadLine();

            string[] amountOfCodes = s.Split(' ');

            List<char> codes = new List<char>(); // exclusive code
            List<int> amount = new List<int>(); // amount of those codes

            bool same = false;

            // counting all codes
            for (int i = 0; i < s.Length; i++)
            {
                same = false;
                for (int i2 = 0; i2 < codes.Count; i2++) // same code detected (+1)
                {
                    if (codes[i2] == s[i])
                    {
                        amount[i2]++;
                        same = true;
                    }
                }

                if (!same) // new code
                {
                    codes.Add(s[i]);
                    amount.Add(1);
                }
            }

            // sorting 
            string output = "";
            char last = ' ';

            for (int i = 0; i < amountOfCodes.Length; i++)
            {
                for (int i2 = 0; i2 < codes.Count; i2++)
                {
                    if (amount.Max() == amount[i2]) // find max
                    {
                        if (last == codes[i2]) // same as last, skip
                        {
                            // get second max amount
                            int max2 = 0;
                            for (int i3 = 0; i3 < codes.Count; i3++)
                            {
                                if (i3 != i2 && max2 < amount[i3])
                                {
                                    max2 = amount[i3];
                                }
                            }

                            // find second max code
                            for (int i3 = 0; i3 < codes.Count; i3++)
                            {
                                if (i3 != i2 && max2 == amount[i3])
                                {
                                    output += codes[i3] + " ";
                                    last = codes[i3];
                                    amount[i3]--;
                                    break;
                                }
                            }
                        }
                        else // not same as last
                        {
                            output += codes[i2] + " ";
                            last = codes[i2];
                            amount[i2]--;
                        }
                    }
                }
            }

            Console.WriteLine("Output: " + output);


            Console.ReadLine();
        }
    }
}
