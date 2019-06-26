using System;

namespace ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a number guessing game!");
            
            // loop to make sure that the input is an integer
            int maxValueWanted;
            bool success;
            do
            {
                Console.WriteLine("Enter the max for the range you'd like to play with:");
                string strMax = Console.ReadLine();
                success = int.TryParse(strMax, out maxValueWanted);
            } while (success == false);

            Random rnd = new Random();
            int secretNumber = rnd.Next(1, maxValueWanted + 1);

            int guess;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;

                bool successfulGuess;
                do
                {
                    Console.WriteLine("Please guess a number between 1 - " + maxValueWanted + ": ");
                    string strGuess = Console.ReadLine();
                    successfulGuess = int.TryParse(strGuess, out guess);
                } while (successfulGuess == false);


                if (guess == secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You got it!");
                }
                else if(guess > secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You were too high, loser! Guess again..");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You were too low, loser! Guess again..");
                }
            } while (guess != secretNumber);
        }
    }
}