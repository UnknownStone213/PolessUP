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
            // проверь 2.5 и 2.5.1
            Console.WriteLine("Enter version1:");
            string version1 = Console.ReadLine();
            Console.WriteLine("Enter version2:");
            string version2 = Console.ReadLine();

            //version1 += "."; version2 += "."; // artificial point in the end

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

            //
            int output = 0;
            int pointer = 0; // if the revision is the same, then i will start comparing next revision from this position
            int pointer2 = 0; // for the second version
            int num1 = 0, num2 = 0;
            bool end = false;
            for (int i = 0; i < amountRevisions; i++)
            {
                if (pointer != 0) // next cycle FOR will not work w/o it
                {
                    pointer++;
                }
                pointer2 = pointer;

                for (int i2 = pointer; i2 < version1.Length; i2++)
                {
                    try
                    {
                        if (version1[i2] == '.') // 2.5 and 2.5.1 exception because OutOfRange pointer
                        {
                            num1 = Convert.ToInt32(version1.Substring(pointer, i2 - pointer));
                            pointer = i2;
                            break;
                        }
                    }
                    catch (Exception)
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
                    }
                    catch (Exception)
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
                pointer2 = Math.Max(pointer, pointer2);

                if (num1 != num2)
                {
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

            Console.WriteLine("Output: " + output);

            Console.ReadLine();
        }
    }
}
