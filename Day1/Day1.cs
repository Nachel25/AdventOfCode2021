using System;
using System.IO;

namespace Day1
{
    class Day1
    {
        private readonly int[] lines;
        private int increases;
        private int threePointMeasureIncreases;

        public Day1(string filepath)
        {
            lines = Array.ConvertAll(File.ReadAllLines(filepath), int.Parse);
        }

        // Part 1
        public int Increases
        {
            get
            {
                increases = 0;
                var oldvalue = 0;
                foreach (var line in lines)
                {
                    var value = line;
                    if (value > oldvalue)
                    {
                        if (!(oldvalue == 0))
                        {
                            increases++;
                        }
                    }
                    oldvalue = value;
                }
                return increases;
            }
        }

        // Part 2
        public int ThreePointMeasureIncreases
        {
            get
            {
                threePointMeasureIncreases = 0;
                var oldvalue = 0;
                for (int i = 0; i < lines.Length - 2; i++)
                {
                    var value = lines[i] + lines[i + 1] + lines[i + 2];
                    if (value > oldvalue)
                    {
                        if (!(oldvalue == 0))
                        {
                            threePointMeasureIncreases++;
                        }
                    }
                    oldvalue = value;
                }
                return threePointMeasureIncreases;
            }
        }
    }
}