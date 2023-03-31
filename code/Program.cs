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
            Console.WriteLine("Enter System.Double:");
            double real = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(WordFormat(real));


            Console.ReadLine();

            string WordFormat(double num)
            {
                string[] words = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "point", "minus" };

                string output = "";
                string s = num.ToString();
                for (int i = 0; i < s.Length; i++)
                {
                    switch (s[i])
                    {
                        case '-':
                            output += words[11] + " ";
                            break;
                        case '.':
                            output += words[10] + " ";
                            break;
                        case '0':
                            output += words[0] + " ";
                            break;
                        case '1':
                            output += words[1] + " ";
                            break;
                        case '2':
                            output += words[2] + " ";
                            break;
                        case '3':
                            output += words[3] + " ";
                            break;
                        case '4':
                            output += words[4] + " ";
                            break;
                        case '5':
                            output += words[5] + " ";
                            break;
                        case '6':
                            output += words[6] + " ";
                            break;
                        case '7':
                            output += words[7] + " ";
                            break;
                        case '8':
                            output += words[8] + " ";
                            break;
                        case '9':
                            output += words[9] + " ";
                            break;
                        default:
                            break;
                    }
                }

                // first letter is big
                string firstLetter = output.Substring(0, 1);
                firstLetter = firstLetter.ToUpper();
                output = firstLetter + output.Substring(1, output.Length - 1);

                return output;
            }
        }
    }
}
