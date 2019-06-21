using System;

namespace ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {

            // KINDS OF LOOPs

            //for loop
            for(int i = 1; i < 100; i++)
            {
                System.Threading.Thread.Sleep(1000); // this is not needed for the loop, it is extra just to show how to slow down how fast console prints.
                Console.WriteLine(i + 1); ///"This will print the number ONE through ONE HUNDRED"
            }

            //foreach
            int[] numbers = { 4, 7, 3, 2, 5, 1, 9 }; // collection of numbers
            foreach(int xyz in numbers)
            {
                Console.WriteLine(xyz);
            }

            //while loop '
            bool playerIsAlive = true;
            while (playerIsAlive == true)// great as long as something is true
            {
                // play the game
            }

            //do while loop
            do
            {
                // This will always run at else once and depending on the while, it may continue to run.
            } while (2 == 1);
        }
    }
}
