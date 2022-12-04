using System;
using System.IO;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Class Day1
            var day3 = new Day3(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\input.txt"));

            // Day3 Part 1
            Console.WriteLine("\nBeginning Day 3 Part 1");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Gamma rate: {day3.GammaRate}");
            Console.WriteLine($"Epsilon rate: {day3.EpsilonRate}");
            Console.WriteLine($"Product: {day3.GammaRate * day3.EpsilonRate}");

            // Day3 Part 2
            Console.WriteLine("\nBeginning Day 3 Part 2");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Oxygen generator rating:{day3.OxygenGeneratorRating}");
            Console.WriteLine($"CO2 scrubber rating:{day3.CO2ScrubberRating}");
            Console.WriteLine($"Product:{day3.CO2ScrubberRating * day3.OxygenGeneratorRating}");
        }
    }
}
