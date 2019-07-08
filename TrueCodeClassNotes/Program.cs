using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;

// Added a NuGet Package  "NewtonSoft.Json"
namespace ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Comedian myComedian = new Comedian();
            myComedian.Name = "Mitch Hedberg";

            Singer mySinger = new Singer();
            mySinger.Name = "Bob Smith";
            TellToIntroduce(myComedian);

            myComedian.TellChuckNorrisJoke();
        }

        static void TellToIntroduce(Human myHuman)
        {
            myHuman.Introduce();
            myHuman.TellChuckNorrisJoke(); // Can't be done
        }
    }
}