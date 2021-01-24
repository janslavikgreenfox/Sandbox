using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

namespace CreateHttpRequest
{
    class Program
    {
        public static object JsonConvert { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var client = new HttpClient();
            //var wiki = new Uri("https://www.google.com/");
            var simple = new Uri("https://www.fi.muni.cz/~xjanu/about-website.html");

            var result = client.GetAsync(simple).Result;
            var content = result.Content.ReadAsStringAsync().Result;
            
            //var res = JsonSerializer.Deserialize<List<string>>(content);
            foreach(var item in content.Split("\n"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
