using System;

namespace ClassNotes
{
    class Program
    {
        static int AddNumbersFrom1ToN(int n) // the reusable algorithm for adding numbers from ONE to N. 
        {
            int total = 0;
            for(int i = 1; i <= n; i++)
            {
                total = total + i;
            }
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            string favoriteNumberAsAString = Console.ReadLine();
            int favoriteNumber = int.Parse(favoriteNumberAsAString);

            int total = AddNumbersFrom1ToN(favoriteNumber); //this is calling the method of AddNumbersFrom1ToN using the value given by user for favoriteNumber 
            //for (int i = 1; i <= 10; i++) because of the line above, this for(loop) is no longer needed.
            //{      
            //    total = total + i; 
            //}
            Console.WriteLine("If you add all the numbers from 1-" + favoriteNumber + ", the total is " + total); 

            Console.WriteLine("What is your favorite year?");
            string favoriteYearAsAString = Console.ReadLine();
            int favoriteYear = int.Parse(favoriteNumberAsAString);
            //instead of using a for(loop) we can just call the AddNumbersFrom1ToN method.
            int totalYears = AddNumbersFrom1ToN(favoriteYear);

            Console.WriteLine("If you add all the numbers from 1-" + favoriteYear + ", the total is " + totalYears);

        }
    }
}
