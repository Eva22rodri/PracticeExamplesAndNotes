using System;
using System.Collections.Generic; 


namespace ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you have any pets?");
            string response = Console.ReadLine();

            bool success = int.TryParse(response, out int numberOfPets); //This tells us if the user gave us a numbe or not.

            List<string> petNames = new List<string>();
            List<string> affirmativeResponses = new List<string>() { "y", "yes", "yeah", "yep", "uh huh", "si" };

            while (affirmativeResponses.Contains(response.ToLower()) == true)
            {
                Console.WriteLine("What is the name of one of your pets?");
                string petName = Console.ReadLine();
                petNames.Add(petName); //Add the petName that is given to us into the petNames list.

                Console.WriteLine("Do you have any more pets?");
                response = Console.ReadLine();

            }
            // **** other code that almost did the same thing. Included number input and different steps
            //    while (ShouldAskForPetName(response, success))
            //    {
            //        Console.WriteLine("What is the name of one of your pets?");
            //        string petName = Console.ReadLine();
            //        petNames.Add(petName); //Add the petName that is given to us into the petNames list.

            //        Console.WriteLine("Do you have any more pets?");
            //        response = Console.ReadLine();

            //    }
            //}

            //static bool ShouldAskForPetName(string response, bool parseSuccess)
            //{
            //    bool result = response.ToLower() == "yes" || (parseSuccess == true && response.ToLower() != "no");
            //    return result;
            //}
        }
    }
}