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
            Console.WriteLine("Enter ax1 (x-coordinate of bottom left cornet of 1st rectangle):");
            int ax1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ay1 (y-coordinate of bottom left cornet of 1st rectangle):");
            int ay1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter ax2 (x-coordinate of top right cornet of 1st rectangle):");
            int ax2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ay2 (y-coordinate of top right cornet of 1st rectangle):");
            int ay2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter bx1 (x-coordinate of bottom left cornet of 2nd rectangle):");
            int bx1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter by1 (y-coordinate of bottom left cornet of 2nd rectangle):");
            int by1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter bx2 (x-coordinate of top right cornet of 2nd rectangle):");
            int bx2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter by2 (y-coordinate of top right cornet of 2nd rectangle):");
            int by2 = Convert.ToInt32(Console.ReadLine());

            // rectangles' corners 
            (int, int) bottom1 = (ax1, ay1);
            (int, int) top1 = (ax2, ay2);
            (int, int) bottom2 = (bx1, by1);
            (int, int) top2 = (bx2, by2);

            int sum = 0; // amount of pixels that are inside of both rectangles

            // 3rd rectangle that includes 2 other rectangles
            (int, int) bottom3 = (Math.Min(ax1, bx1), Math.Min(ay1, by1));
            (int, int) top3 = (Math.Max(ax2, bx2), Math.Max(ay2, by2));

            // searching for pixels that are inside of both rectangles
            for (int i = bottom3.Item1; i <= top3.Item1; i++) // length
            {
                for (int i2 = bottom3.Item2; i2 <= top3.Item2; i2++) // height
                {
                    if (i >= bottom1.Item1 && i < top1.Item1 && i2 >= bottom1.Item2 && i2 < top1.Item2 && i >= bottom2.Item1 && i < top2.Item1 && i2 >= bottom2.Item2 && i2 < top2.Item2)
                    {
                        Console.WriteLine(i + " " + i2);
                        sum++;
                    }
                }
            }

            int square1 = (top1.Item1 - bottom1.Item1) * (top1.Item2 - bottom1.Item2);
            int square2 = (top2.Item1 - bottom2.Item1) * (top2.Item2 - bottom2.Item2);
            Console.WriteLine("\nOutput: {0}", square1 +  square2 - sum);


            Console.ReadLine();
        }
    }
}
