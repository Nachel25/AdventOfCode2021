using System;
using System.IO;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Class Day1
            var day1 = new Day1(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\input.txt"));

            // Part 1
            Console.WriteLine("\nBeginning Day 1 Part 1");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"There were {day1.Increases} increases with single measure point comparison.");

            // Part 2
            Console.WriteLine("\nBeginning Day 1 Part 2");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"There were {day1.ThreePointMeasureIncreases} increases with three measure point comparison.");
        }
    }
}
