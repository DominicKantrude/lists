using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Uranus");
            planetList.Add("Neptune");

            List<string> planetList2 = new List<string>() { "Jupiter", "Saturn" };
            planetList.AddRange(planetList2);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");

            Console.WriteLine(String.Join("; ", planetList));
            Console.WriteLine(String.Join("; ", rockyPlanets));



            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                    };

            for (int i = 0; i < numbers.Count; i++)
            {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
                if (numbers.Contains(i))
                {
                    Console.WriteLine($"numbers list contains {i}");
                }
                else
                {
                    Console.WriteLine($"numbers list does not contain {i}");
                }
            }
        }
    }
}
