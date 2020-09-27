using System;
using System.Dynamic;
using System.Numerics;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1 ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1 ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2 ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double lineLength = LineComparision.Program.CalLength(x1, x2, y1, y2);
            Console.WriteLine("Line length is " + lineLength);
        }
        static double CalLength(double x1,double x2,double y1,double y2)
        {
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return length;
        }
    }
}
