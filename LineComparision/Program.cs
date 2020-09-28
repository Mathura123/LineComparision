using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            LineComparision.Program.CompareLines();
        }
        static void CompareLines()
        {
            Console.WriteLine("Enter x1 for First Line ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 for First Line ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1 for First Line ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2 for First Line ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter x1 for Second Line ");
            double x12 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 for Second Line ");
            double x22 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1 for Second Line ");
            double y12 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2 for Second Line ");
            double y22 = Convert.ToDouble(Console.ReadLine());
            double len1 = LineComparision.Program.CalLength(x1, x2, y1, y2);
            double len2 = LineComparision.Program.CalLength(x12, x22, y12, y22);
            if(len1>len2)
            {
                Console.WriteLine("First Line has more length");
            }
            else if(len2>len1)
            {
                Console.WriteLine("Second Line has more length");
            }
            else
            {
                Console.WriteLine("Both are equal");
            }

        }
        static double CalLength(double x1, double x2,double y1, double y2)
        {
            double Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 -y1), 2));
            return Length;
        }
    }
}
