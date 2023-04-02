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
            Console.WriteLine("Enter string:");
            string s = Console.ReadLine();

            List<char> letters = new List<char>(); // exclusive letters
            List<int> amount = new List<int>(); // amount of those letters

            bool same = false;

            // counting all letters
            for (int i = 0; i < s.Length; i++)
            {
                same = false;
                for (int i2 = 0; i2 < letters.Count; i2++) // same letter detected (+1)
                {
                    if (letters[i2] == s[i])
                    {
                        amount[i2]++;
                        same = true;
                    }
                }

                if (!same) // new letter
                {
                    letters.Add(s[i]);
                    amount.Add(1);
                }
            }

            int output = amount.Max() - amount.Min();
            Console.WriteLine("Output: " + output);


            Console.ReadLine();
        }
    }
}
