using System;
using System.Collections.Generic;

namespace spaceshipPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> planetList2 = new List<string>() { "Jupiter", "Saturn" };
            planetList.AddRange(planetList2);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");

            var probes = new Dictionary<string, List<string>>();
            probes.Add("Bob the probe", new List<string> { "Mercury", "Mars"});
            probes.Add("Tediousness", new List<string> { "Earth", "Mars", "Jupiter", "Saturn" });
            probes.Add("Apathy", new List<string> { "Jupiter", "Uranus" });

            List<string> probesNStuff = new List<string>();
            foreach (var planet in planetList)
            {
                string probesVisited = planet + ": ";
                foreach (var (probe, planets) in probes)
                {
                    if (planets.Contains(planet))
                    {
                        probesVisited += probe + " ";
                    }
                }
                probesNStuff.Add(probesVisited);
            }
            foreach(var probeList in probesNStuff)
            {
                Console.WriteLine(probeList);
            }
            Console.ReadLine();
        }
    }
}
