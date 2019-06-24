using System;

namespace ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfAdditions = GetIntegerFromUser("How many numbers would you like to add?");

            int grandTotal = 0;
            for (int i = 0; i < numberOfAdditions; i++)
            {
                int number = GetIntegerFromUser("What is number " + (i + 1) + "?"); //Calling 'GetIntegerFromUser' method > writing message + i increased value by 1)
                grandTotal = grandTotal + number; 
            }

            Console.WriteLine("The total is " + grandTotal);
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