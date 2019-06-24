using System;

namespace ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                DisplayOddsFrom1ToN(i); //same as code vvv
            }

            // This does the same thing as the method above
            //DisplayOddsFrom1ToN(1);
            //DisplayOddsFrom1ToN(2);
            //DisplayOddsFrom1ToN(3);
            //DisplayOddsFrom1ToN(4);
            //DisplayOddsFrom1ToN(5);
            //DisplayOddsFrom1ToN(6);
            //DisplayOddsFrom1ToN(7);
        }

        static void DisplayOddsFrom1ToN(int n)
        {
            for (int i = 1; i < n; i ++)
            {
                if(i % 2 != 0) 
                {
                   Console.Write(i + " "); // this prints ( 1 3 5 7 9 11 13 15 17..etc..) HORIZONTALLY
                }
            }
            Console.WriteLine();
            
        }
    }
}


//**** Other Notes  ****

//static void DisplayOddsFrom1To100()
//{
//for (int i = 1; i < 100; i += 2)
//{
//    if (i % 2 != 0) // (  %  ) runs modulous aka the remainder when divided by 2. 0 means it is even.
//    {
//        // Console.Write(i); // this prints ( 1357911131517..etc..)
//        Console.Write(i + " "); // this prints ( 1 3 5 7 9 11 13 15 17..etc..) HORIZONTALLY.
//                                //Console.WriteLine(i); // this prints vertically, single values.
//                                //dsaf
//    }
//}
//}