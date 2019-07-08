using System;

namespace TrueCodeClassNotes
{
    class Human
    {
        public string Name { get; set; }

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + Name + ".");
        }
    }
}
