using System;

namespace ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            //****  Arrays ****

            // The size of an array is set once established it can not be grown nor made smaller. Size is fixed once created.
            string[] names = ["Ted", "Jill", "Joe"]; // this is an array of names.
            string name1 = names[0]; // this is telling which name i want 
            names[0] = "Jane"; // this will change the name at index Zero to Jane.

            // making a shift to make each name in names its own individual string.
            // note: almost always working with individual elevments, not the entire array. ex: ted... or jill... not ted jill and joe.

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]); // this will print whatever string is at the 'i' value. 
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);  // does the same thing as for loop above. 
            }
        }
    }
}