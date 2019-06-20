using System;

namespace ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");

            string response = Console.ReadLine();

            int favoriteNumber = int.Parse(response); //parce method takes the string entered and transforms it into the integer that is equal to that string.

            Console.WriteLine("Your favorite number is " + favoriteNumber);
        }
    }
}
