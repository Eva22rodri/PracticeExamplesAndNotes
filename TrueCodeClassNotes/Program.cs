using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;

// Added a NuGet Package  "NewtonSoft.Json"
namespace TrueCodeClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Comedian myComedian = new Comedian();
            Singer mySinger = new Singer();

            DoYourPerformance(myComedian);
            DoYourPerformance(mySinger);
        }

        static void DoYourPerformance(IPerform performer)
        {
            performer.Perform();
        }
    }
}