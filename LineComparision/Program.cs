using System;

namespace LineComparision
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Line Comparision problem in Master Branch");
            Console.WriteLine("Enter 1 to find length \nEnter 2 to find equal or not \nEnter 3 to do comparision");
            int key = Convert.ToInt32(Console.ReadLine());
            switch(key)
            {
                case 1:
                    LineComparision.Program.CalculateLength();
                    break;
                case 2:
                    LineComparision.Program.EqualOrNot();
                    break;
                case 3:
                    LineComparision.Program.CompareLines();
                    break;
                default:
                    Console.WriteLine("Not a valid key. Try once more");
                    LineComparision.Program.Main();
                    break;
            }
        }
        static double CallingMethod()
        {
            Console.WriteLine("Enter x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double lineLength = LineComparision.Program.CalLength(x1, x2, y1, y2); 
            return lineLength;
        }
        static void CalculateLength()
        {
            double len = LineComparision.Program.CallingMethod();
            Console.WriteLine("Line Length is "+ len);
        }
        static void EqualOrNot()
        {
            Console.WriteLine("Enter Values for first line ");
            double len1 = LineComparision.Program.CallingMethod();
            Console.WriteLine("\nEnter Values for second line ");
            double len2 = LineComparision.Program.CallingMethod();
            if (len1 == len2)
            {
                Console.WriteLine("Both Lines are equal in length");
            }
            else
            {
                Console.WriteLine("Both Lines are not equal in length");
            }
        }
        static void CompareLines()
        {
            Console.WriteLine("Enter Values for first line ");
            double len1 = LineComparision.Program.CallingMethod();
            Console.WriteLine("\nEnter Values for second line ");
            double len2 = LineComparision.Program.CallingMethod();
            if (len1>len2)
            {
                Console.WriteLine("First Line has more length");
            }
            else if(len1>len2)
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
