using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace TrueCodeClassNotes
{
    //The Comedian class is supposed to conform to Iperform interface
    class Comedian : IPerform // More interfaces can be added, just separate them witha comma.
    {
        public void Perform()
        {
            Console.WriteLine("Welcome, here is a joke!");
            TellChuckNorrisJoke();
            Console.WriteLine("You've been a great audiencem goodnight!");
        }
        public void TellChuckNorrisJoke()
        {   

            //This is not best practice, but it demonstrates making an API
            //call and parseing a Json response

            string url = "https://api.chucknorris.io/jokes/random";
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(url).Result;
            string joke = JObject.Parse(response).GetValue("value").ToString();

            Console.WriteLine(joke);
        }
    }
}

