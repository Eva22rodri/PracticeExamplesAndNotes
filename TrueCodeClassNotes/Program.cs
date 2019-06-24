using System;

namespace ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's add 4 numbers.");

            Console.WriteLine("What is number 1?");
            string response1 = Console.ReadLine();
            int number1 = int.Parse(response1);

            Console.WriteLine("What is number 2?");
            string response2 = Console.ReadLine();
            int number2 = int.Parse(response1);

            Console.WriteLine("What is number 3?");
            string response3 = Console.ReadLine();
            int number3 = int.Parse(response1);

            int total = number1 + number2 + number3;
            Console.WriteLine("The total is " + total);
        }
    }
}