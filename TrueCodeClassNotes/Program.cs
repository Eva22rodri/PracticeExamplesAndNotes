using System;

namespace ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            int total1 = AddNumbers(5, 4, 3);
            int total2 = AddNumbers(10, 12, 2);
            int total3 = AddNumbers(total1, total2, 3);
            Console.WriteLine("Grand total is " + total3);

            
        }

        static int AddNumbers(int n1, int n2, int n3)
        {
            int sum = n1 + n2 + n3;
            return sum;
        }
    }
}
,)