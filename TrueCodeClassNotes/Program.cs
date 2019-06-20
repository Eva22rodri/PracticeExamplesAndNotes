using System;

namespace ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Types of loops
            // An if-statement is not a loop.

            int exampleNumberForWhileLoop = 0;

            //while Loop
            while (exampleNumberForWhileLoop < 10)
            {
                Console.WriteLine("This loop will print this Consol.WriteLine while exampleNumberForWhileLoop is less than ten is true");
                exampleNumberForWhileLoop++; //We place this here so that the number above does not print infinitly being that we began exampleNumberForWhileLoop as having a static value of Zero. Now it will only print Ten times. 
            }
            
            //Another Example of while loop
            string userResp = "no";  
            while (userResp == "no")
            {
                Console.WriteLine("Please say yes"); // this can be dont as many times as the user keeps saying no
                userResp = Console.ReadLine();
            }

            //Do while loop
            int numberForDoWhileLoop = 0;
            do
            {
                Console.WriteLine("This prints numberForDoWhileLoop once but then does not continue because the number is not less than zero. If it was equal to the conditional in the while (true) then it would keep running till it becomes false.");
            } while (numberForDoWhileLoop < 0);

            //for loop
            for (int i = 0; i > 1; i++) // ( We can declare value of I here; this is the conditional true/false; this is the ammount of times for it to increment)
            {
                Console.WriteLine(i); // for loops do things a specific number of times. 
            }

            //foreach loop
            string[] names = { "Chip", "Zee", "Dan", "Brandon" };//names is the name of the collection
            foreach (string name in names) // for every one of the strings inside of the collection we are going to call it name.
            {
                Console.WriteLine(name); // this will print the collection of strings so all the names will appear on the Console.
            } //name declares a string for each item inside the this loop // example using real life situation.. for each email in emails send marketing email.
        }
    }
}
