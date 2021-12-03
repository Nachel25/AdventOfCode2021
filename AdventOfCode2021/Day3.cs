using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2021
{
    class Day3
    {
        private readonly string[] lines;
        private int gammaRate;
        private string gammaRateAsString;
        private List<string> gammaRateAsList = new List<string>();
        private int epsilonRate;
        private string epsilonRateAsString;

        public Day3(string filepath)
        {
            lines = File.ReadAllLines(filepath);
        }

        // Part 1
        public int GammaRate
        {
            get
            {
                gammaRate = 0;
                var countOnes = new int[12];
                var countZeroes = new int[12];
                gammaRateAsList.Clear();
                foreach (var line in lines)
                {
                    var charArray = line.ToCharArray();
                    for (int i = 0; i < charArray.Length; i++)
                    {
                        if (charArray[i] == '0')
                        {
                            countZeroes[i]++;
                        }
                        else
                        {
                            countOnes[i]++;
                        }
                    }
                }

                for (int i = 0; i < 12; i++)
                {
                    if (countZeroes[i] > countOnes[i])
                    {
                        gammaRateAsList.Add("0");
                    }
                    else
                    {
                        gammaRateAsList.Add("1");
                    }
                }

                gammaRateAsString = String.Join("", gammaRateAsList.ToArray());
                //Console.WriteLine($"Gamma rate as binary:{gammaRateAsString}");

                var binaryBase = 2;
                gammaRate = Convert.ToInt32(gammaRateAsString, binaryBase);
                return gammaRate;
            }
        }

        public int EpsilonRate
        {
            get
            {
                string BinaryInverted(string input) => string.Concat(input.Select(x => x == '0' ? '1' : '0'));
                epsilonRateAsString = BinaryInverted(gammaRateAsString);
                //Console.WriteLine($"Epsilon rate as binary:{epsilonRateAsString}");

                var binaryBase = 2;
                epsilonRate = Convert.ToInt32(epsilonRateAsString, binaryBase);
                return epsilonRate;
            }
        }

        //Part 2

    }
}





