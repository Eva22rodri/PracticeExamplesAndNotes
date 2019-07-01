using System;
using System.Collections.Generic; 


namespace ClassNotes
{
    class Program
    {
        public class Cat
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public int Age { get; set; }
            public void MeetTheCat() // Void is not returning anything it is simply "writing" something.
            {
                Console.WriteLine("Hello, I'm " + Name + " the " + Color + " colored cat!");
            }

        }

        public static void Main(string[] args)
        {
            var cat = new Cat();
            cat.Name = "Oscar";
            cat.Color = "brown";
            cat.MeetTheCat();

            // Another way to define variable (Syntax Sugar)

            var cat2 = new Cat()
            {
                Name = "Sebastian",
                Color = "gray",

            };
            cat2.MeetTheCat();
        }
        
    }
}