using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;

// Added a NuGet Package  "NewtonSoft.Json"
namespace ClassNotes
{
    class Program
    {
        public static void Main(string[] args)
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