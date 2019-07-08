using System;
using System.Collections.Generic;
using System.Net.Http;


namespace ClassNotes
{
    class Program
    {
        public static void Main(string[] args)
        {
            string url = "https://api.chucknorris.io/jokes/random"; //Chuck Norris API website.
            HttpClient client = new HttpClient();          
            string response = client.GetStringAsync(url).Result;

            int jokeStartIndex = response.IndexOf("value") + 8; //The joke is going to start at the word value
            int jokeLength = response.Length - jokeStartIndex - 2;
            string joke = response.Substring(jokeStartIndex, jokeLength);

            Console.WriteLine(joke);
        }    
    }
}