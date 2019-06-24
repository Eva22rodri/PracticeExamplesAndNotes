using System;

namespace ClassNotes
{
    class Program
    {
        static int AddNumbersFrom1ToN(int n) 
        {
            int total = 0;
            for(int i = 1; i <= n; i++)
            {
                total = total + i;
            }
            return total;
        }

        static void AskNumericQuestionThenDisplayTotal(string question)//this method is not really doing anything just returning something so we are making this a "void"
        {
            Console.WriteLine(question); // "question" has to be made a parameter because we have multiple questions
            string responseAsAString = Console.ReadLine();
            int response = int.Parse(responseAsAString);

            int total = AddNumbersFrom1ToN(response);// will add all the numbers given using Calling AddNumbersFrom1ToN

            Console.WriteLine("If you add all the numbers from 1-" + response + ", the total is " + total);
        }
        static void Main(string[] args)
        {
            //    Console.WriteLine("What is your favorite number?");
            //    string favoriteNumberAsAString = Console.ReadLine();
            //    int favoriteNumber = int.Parse(favoriteNumberAsAString);
            //    int total = AddNumbersFrom1ToN(favoriteNumber); 
            //    Console.WriteLine("If you add all the numbers from 1-" + favoriteNumber + ", the total is " + total); 
            //**** The following line replaces all the code commented out from above. *****

            AskNumericQuestionThenDisplayTotal("What is your favorite number?");

            //Console.WriteLine("What is your favorite year?");
            //string favoriteYearAsAString = Console.ReadLine();
            //int favoriteYear = int.Parse(favoriteNumberAsAString);
            //int totalYears = AddNumbersFrom1ToN(favoriteYear);
            //Console.WriteLine("If you add all the numbers from 1-" + favoriteYear + ", the total is " + totalYears);
            //***** The following line replaces all the code commented out from above. *****

            AskNumericQuestionThenDisplayTotal("what is your favorite year?");
        }
    }
}
