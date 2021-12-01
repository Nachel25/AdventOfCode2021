using System;
using System.IO;

namespace AdventOfCode2021
{
    class Day1
    {
        static void Main(string[] args)
        {
            var counter = 0;
            var counterThreeMeasurePoints = 0;

            // Part 1
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\input01.txt");
            int[] lines = Array.ConvertAll(File.ReadAllLines(filepath), int.Parse);

            var oldvalue = 0;
            foreach (var line in lines)
            {
                var value = line;
                if (value > oldvalue)
                {
                    if (!(oldvalue == 0))
                    {
                        counter++;
                    }
                }
                oldvalue = value;
            }
            Console.WriteLine($"There were {counter} increases with single measure point comparison.");


            // Part 2
            oldvalue = 0;
            for (int i = 0; i < lines.Length - 2; i++)
            {
                var value = lines[i] + lines[i + 1] + lines[i + 2];
                if (value > oldvalue)
                {
                    if (!(oldvalue == 0))
                    {
                        counterThreeMeasurePoints++;
                    }
                }
                oldvalue = value;
            }
            Console.WriteLine($"There were {counterThreeMeasurePoints} increases with three measure point comparison.");

            Console.ReadLine();
        }
    }
}
