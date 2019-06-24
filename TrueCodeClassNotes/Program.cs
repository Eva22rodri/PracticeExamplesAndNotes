using System;

namespace ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's add 4 numbers.");

            int number1 = GetIntegerFromUser("What is number 1");
            int number2 = GetIntegerFromUser("What is number 2");
            int number3 = GetIntegerFromUser("What is number 3");
            int number4 = GetIntegerFromUser("What is number 4?");

            int total = number1 + number2 + number3 + number4;

            Console.WriteLine("The total is " + total);
        }

        static int GetIntegerFromUser(string prompt)
        {
            Console.WriteLine(prompt);
            string response1 = Console.ReadLine();
            int number = int.Parse(response1);
            return number;
        }
    }
}