using System;
using System.IO;

namespace AdventOfCode2021
{
    class Day2
    {
        private readonly string[] lines;
        private string direction;
        private int units;
        private int horizontalPosition;
        private int depth;
        private int depthCorrected;
        private int aim;

        public Day2(string filepath)
        {
            lines = File.ReadAllLines(filepath);
        }
        // Part 1
        public int HorizontalPosition
        { get
            {
                horizontalPosition = 0;
                foreach (var line in lines)
                {
                    SplitLine(line);
                    if (direction.Contains("forward"))
                    {
                        horizontalPosition += units;
                    }
                }
                return horizontalPosition;
            }
        }

        public int Depth
        {
            get
            {
                depth = 0;
                foreach (var line in lines)
                {
                    SplitLine(line);
                    if (direction.Contains("down"))
                    {
                        depth += units;
                    }
                    else if (direction.Contains("up"))
                    {
                        depth -= units;
                    }
                }
                return depth;
            }
        }

        // Part 2
        public int DepthCorrected
        {
            get
            {
                depthCorrected = 0;
                aim = 0;
                foreach (var line in lines)
                {
                    SplitLine(line);
                    if (direction.Contains("down"))
                    {
                        aim += units;
                    }
                    else if (direction.Contains("up"))
                    {
                        aim -= units;
                    }
                    if (direction.Contains("forward"))
                    {
                        depthCorrected += units * aim;
                    }
                }
                return depthCorrected;
            }
        }

        private void SplitLine(string line)
        {
            var splittedLines = line.Split(" ");
            direction = splittedLines[0];
            units = Convert.ToInt32(splittedLines[1]);
        }
    }
}
