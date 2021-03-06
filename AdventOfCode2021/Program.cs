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
            Console.WriteLine($"Oxygen generator rating:{day3.OxygenGeneratorRating}");
            Console.WriteLine($"CO2 scrubber rating:{day3.CO2ScrubberRating}");
            Console.WriteLine($"Product:{day3.CO2ScrubberRating * day3.OxygenGeneratorRating}");

            // Call Class Day4
            var day4 = new Day4(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\inputDay04.txt"));

            // Day4 Part 1
            Console.WriteLine("\nBeginning Day 4 Part 1");
            Console.WriteLine("----------------------------------------------------------------");

            // Call Class Day5
            var day5 = new Day5(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\inputDay05.txt"));

            // Day4 Part 1
            Console.WriteLine("\nBeginning Day 5 Part 1");
            Console.WriteLine("----------------------------------------------------------------");

            // stall console window
            Console.ReadLine();
        }
    }
}
