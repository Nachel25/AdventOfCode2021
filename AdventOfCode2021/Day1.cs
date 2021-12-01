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
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "input01.txt");
            string[] lines = File.ReadAllLines(filepath);
            int[] linesAsInt = Array.ConvertAll(lines, int.Parse);

            var oldvalue = 0;
            foreach (var line in linesAsInt)
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
            for (int i = 0; i < linesAsInt.Length - 2; i++)
            {
                var value = linesAsInt[i] + linesAsInt[i + 1] + linesAsInt[i + 2];
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
