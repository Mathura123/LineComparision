using System;
using System.Dynamic;
using System.Numerics;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1 for first line ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 for first line ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1 for first line ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2 for first line ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x1 for second line ");
            double x12 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 for second line ");
            double x22 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1 for second line ");
            double y12 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2 for second line ");
            double y22 = Convert.ToDouble(Console.ReadLine());
            double lineLength1 = LineComparision.Program.CalLength(x1, x2, y1, y2);
            double lineLength2 = LineComparision.Program.CalLength(x12, x22, y12, y22);
            if(lineLength1==lineLength2)
            {
                Console.WriteLine("Both Lines are equal in length");
            }
            else
            {
                Console.WriteLine("Both Lines are not equal in length");
            }
        }
        static double CalLength(double x1,double x2,double y1,double y2)
        {
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return length;
        }
    }
}
