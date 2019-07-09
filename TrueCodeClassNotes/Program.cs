using System;

namespace TrueCodeClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            int y = x.MultiplyBy3();
            Console.WriteLine(y);
            
        }

    }

    static class IntegerExtensions
    {
        public static int MultiplyBy3(this int number) // Added a method that was NOT available to int's
        {
            return number * 3;
        }
    }
}