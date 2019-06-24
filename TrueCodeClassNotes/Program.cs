using System;

namespace ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10; instead of this.... the following code will work better for any value. 

            Console.WriteLine("What is your favorite number?");
            string favoriteNumberAsAString = Console.ReadLine();
            int favoriteNumber = int.Parse(favoriteNumberAsAString); // parse is a method that returns an int... favorite number is originally a string.
            //favoriteNumber.ToString(); ***NOTE: this is not part of this method. but this would be making an int into a string. 

            int total = 0; //starting at zero
            for (int i = 1; i <= 10; i++)// add all numbers from 1 to ten
            {
                // we want to have a running total.. so everytime this loop runs, we want to add that values to int total.
                total = total + i; 
            }
            Console.WriteLine("If you add all the numbers from 1-" + favoriteNumber + ", the total is " + total); // total will be 55.

        }

        static int AddNumbers(int n1, int n2, int n3)
        {
            int sum = n1 + n2 + n3;
            return sum;
        }
    }
}
