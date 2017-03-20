using System;
using Newtonsoft.Json;

namespace csl1
{
    public class Say
    {
        public class Movie
        {
            public string Name { get; set; }
            public int Year { get; set; }
        }

        public static void Hello(string name) => Console.WriteLine($"Hello {name}");

        public static void JsonStuff()
        {
            var movies = new[] {
                new Movie() { Name = "Bad Boys", Year = 1995 },
                new Movie() { Name = "Bad Boys2", Year = 2003 }
            };
            var json = JsonConvert.SerializeObject(movies);
            Console.WriteLine(json);
        }
    }
}