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
            int[] rgb = new int[3];
            Console.WriteLine("Enter red:");
            rgb[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter green:");
            rgb[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter blue:");
            rgb[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Output(rgb));

            Console.ReadLine();

            string Output(int[] input) 
            {
                string output = "";

                for (int i = 0; i < 3; i++)
                {
                    if (input[i] < 0)
                    {
                        output += "00";
                    }
                    else if (input[i] > 255)
                    {
                        output += "FF";
                    }
                    else
                    {
                        int sixteenth = input[i] / 16; // how many times does 16 fit in a number
                        input[i] -= 16 * sixteenth;
                        if (sixteenth < 10)
                        {
                            output += sixteenth;
                        }
                        else 
                        {
                            switch (sixteenth)
                            {
                                case 10:
                                    output += "A";
                                    break;
                                case 11:
                                    output += "B";
                                    break;
                                case 12:
                                    output += "C";
                                    break;
                                case 13:
                                    output += "D";
                                    break;
                                case 14:
                                    output += "E";
                                    break;
                                case 15:
                                    output += "F";
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (input[i] < 10)
                        {
                            output += input[i];
                        }
                        else
                        {
                            switch (input[i])
                            {
                                case 10:
                                    output += "A";
                                    break;
                                case 11:
                                    output += "B";
                                    break;
                                case 12:
                                    output += "C";
                                    break;
                                case 13:
                                    output += "D";
                                    break;
                                case 14:
                                    output += "E";
                                    break;
                                case 15:
                                    output += "F";
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                return output;
            }
        }
    }
}
