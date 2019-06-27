using System;
using System.Collections.Generic; //needed to be able to use a LIST


namespace ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays size (length) is fixed
            string[] namesArray = new string[3]; //length of three means there are 2 indexes
            namesArray[0] = "Alan";
            namesArray[1] = "Bety";
            namesArray[2] = "Shay";

            //Lists size (count) can change
            List<string> namesList = new List<string>();
            namesList.Add("Alan");
            namesList.Add("Bety");
            namesList.Add("Shay");
        }

    }
}