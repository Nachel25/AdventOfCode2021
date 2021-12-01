using System;
using System.IO;

namespace AdventOfCode2021
{
    class Day1
    {
        static void Main(string[] args)
        {
            int counter = 0;

            // Read the file and display it line by line.
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "input01.txt");
            var file = File.ReadLines(filepath);

            var oldvalue = 0;
            foreach (string line in file)
            {
                var value = Convert.ToInt32(line);
                if (value > oldvalue)
                {
                    counter++;
                }
                Console.WriteLine(line);

                oldvalue = value;
            }

            Console.WriteLine("There were {0} increases.", counter - 1);  
            Console.ReadLine();
        }
    }
}
