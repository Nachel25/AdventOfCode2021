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

            var oldvalue = 0;
            foreach (string line in lines)
            {
                var value = Convert.ToInt32(line);
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
                var value = Convert.ToInt32(lines[i]) + Convert.ToInt32(lines[i + 1]) + Convert.ToInt32(lines[i + 2]);
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
