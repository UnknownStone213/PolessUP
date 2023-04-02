using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Console.WriteLine("Enter version1:");
            string version1 = Console.ReadLine();
            Console.WriteLine("Enter version2:");
            string version2 = Console.ReadLine();

            version1 += "."; version2 += "."; // artificial point in the end (w/o it 1.1 and 1.11 not working properly because of the length)

            // finding the amount of revisions
            int amountRevisions = 0;
            int buffer = 0;
            for (int i = 0; i < version1.Length; i++)
            {
                if (version1[i] == '.')
                {
                    buffer++;
                }
            }
            if (buffer > amountRevisions)
            {
                amountRevisions = buffer;
            }

            buffer = 0;
            for (int i = 0; i < version2.Length; i++)
            {
                if (version2[i] == '.')
                {
                    buffer++;
                }
            }
            if (buffer > amountRevisions)
            {
                amountRevisions = buffer;
            }
            amountRevisions++;

            int output = 0;
            int pointer = 0, pointer2 = 0; // position of current revision at string
            int num1 = 0, num2 = 0;
            bool end = false;
            for (int i = 0; i < amountRevisions; i++)
            {
                num1 = 0; num2 = 0;
                if (pointer != 0)
                {
                    pointer++;
                }
                pointer2 = pointer;

                Console.WriteLine("pointer = " + pointer);

                for (int i2 = pointer; i2 < version1.Length; i2++)
                {
                    try
                    {
                        if (version1[i2] == '.')
                        {
                            num1 = Convert.ToInt32(version1.Substring(pointer, i2 - pointer));
                            pointer = i2;
                            break;
                        }
                        else
                        {
                            if (pointer == version1.Length - 1)
                            {
                                num1 = Convert.ToInt32(version1.Substring(pointer, version1.Length - pointer));
                                pointer = version1.Length;
                                break;
                            }
                        }
                    }
                    catch (Exception) // 2.5 and 2.5.1 exception because OutOfRange pointer
                    {
                        try
                        {
                            num1 = Convert.ToInt32(version1.Substring(pointer, version1.Length - pointer));
                            pointer = version1.Length;
                            break;
                        }
                        catch (Exception)
                        {
                            num1 = 0;
                        }
                    }

                }

                for (int i2 = pointer2; i2 < version2.Length; i2++)
                {
                    try
                    {
                        if (version2[i2] == '.')
                        {
                            num2 = Convert.ToInt32(version2.Substring(pointer2, i2 - pointer2));
                            pointer2 = i2;
                            break;
                        }
                        else
                        {
                            if (pointer2 == version2.Length - 1)
                            {
                                num2 = Convert.ToInt32(version2.Substring(pointer2, version2.Length - pointer2));
                                pointer2 = version2.Length;
                                break;
                            }
                        }
                    }
                    catch (Exception) // 2.5 and 2.5.1 exception because OutOfRange pointer
                    {
                        try
                        {
                            num2 = Convert.ToInt32(version2.Substring(pointer2, version2.Length - pointer2));
                            pointer2 = version2.Length;
                            break;
                        }
                        catch (Exception)
                        {
                            num2 = 0;
                        }
                    }
                }

                pointer = Math.Max(pointer, pointer2);
                pointer2 = pointer;

                if (num1 != num2)
                {
                    Console.WriteLine("num1 = " + num1 + ", num2 = " + num2);
                    end = true;
                    if (num1 < num2)
                    {
                        output = -1;
                    }
                    else if (num1 > num2)
                    {
                        output = 1;
                    }
                }

                if (end) 
                {
                    break;
                }
            }

            Console.WriteLine("\nOutput: " + output);

            Console.ReadLine();
        }
    }
}
