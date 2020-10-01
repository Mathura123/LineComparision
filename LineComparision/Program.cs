using System;

namespace LineComparision
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Line Comparision problem in Master Branch");
            Console.WriteLine("Enter 1 to do comparision of lengths of two lines");
            int key = Convert.ToInt32(Console.ReadLine());
            switch(key)
            {
                case 1:
                    LineComparision.CompareLen.CompareLines();
                    break;
                default:
                    Console.WriteLine("Not a valid key. Try once more");
                    LineComparision.Program.Main();
                    break;
            }
        }
    }
}
