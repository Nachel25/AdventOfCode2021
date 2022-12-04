using System;
using System.IO;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Class Day2
            var day2 = new Day2(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\input.txt"));

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
        }
    }
}
