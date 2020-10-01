using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    class CompareLen
    {
        public static double CalculateLength()
        {
            Console.WriteLine("Enter x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Lines line = new Lines(x1, x2, y1, y2);
            double lineLength = line.length;
            Console.WriteLine("Line Length is " + lineLength);
            return lineLength;
        }
        public static void CompareLines()
        {
            Console.WriteLine("Enter Values for first line ");
            double len1 = LineComparision.CompareLen.CalculateLength();
            Console.WriteLine("\nEnter Values for second line ");
            double len2 = LineComparision.CompareLen.CalculateLength();
            if (len1.CompareTo(len2) > 0)
            {
                Console.WriteLine("First Line has more length");
            }
            else if (len1.CompareTo(len2) < 0)
            {
                Console.WriteLine("Second Line has more length");
            }
            else
            {
                Console.WriteLine("Both are equal");
            }

        }

    }
}
