using System;
using System.IO;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Class Day1
            var day1 = new Day1(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\inputDay01.txt"));

            // Part 1
            Console.WriteLine("\nBeginning Day 1 Part 1");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"There were {day1.Increases} increases with single measure point comparison.");

            // Part 2
            Console.WriteLine("\nBeginning Day 1 Part 2");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"There were {day1.ThreePointMeasureIncreases} increases with three measure point comparison.");

            // Call Class Day2
            var day2 = new Day2(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\inputDay02.txt"));

            // Day2 Part 1
            Console.WriteLine("\nBeginning Day 2 Part 1");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Horizontal pos: {day2.HorizontalPosition}");
            Console.WriteLine($"Depth: {day2.Depth}");
            Console.WriteLine($"Location: {day2.HorizontalPosition * day2.Depth}");

            // Day2 Part 2
            Console.WriteLine("\nBeginning Day 2 Part 2");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Horizontal pos: {day2.HorizontalPosition}");
            Console.WriteLine($"Depth: {day2.DepthCorrected}");
            Console.WriteLine($"Location: {day2.HorizontalPosition * day2.DepthCorrected}");

            // Call Class Day3
            var day3 = new Day3(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\inputDay03.txt"));

            // Day3 Part 1
            Console.WriteLine("\nBeginning Day 3 Part 1");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Gamma rate: {day3.GammaRate}");
            Console.WriteLine($"Epsilon rate: {day3.EpsilonRate}");
            Console.WriteLine($"Product: {day3.GammaRate * day3.EpsilonRate}");

            // Day3 Part 2
            Console.WriteLine("\nBeginning Day 3 Part 2");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Oxigen generator rating:{day3.OxygenGeneratorRating}");

            // stall console window
            Console.ReadLine();
        }
    }
}
