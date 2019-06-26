using System;

namespace ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;

            Console.WriteLine("Please guess a number");
            string strGuess = Console.ReadLine();
            int guess = int.Parse(strGuess);

            if (guess == secretNumber)
            {
                Console.WriteLine("You got it!");
            }
            else
            {
                Console.WriteLine("You missed it! You lose!");
            }
        }
    }
}