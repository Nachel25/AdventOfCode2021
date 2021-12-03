using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2021
{
    class Day3
    {
        private readonly string[] lines;
        private readonly List<string> gammaRateAsList = new();
        private readonly int bitLength;
        private int gammaRate;
        private string gammaRateAsString;
        private int epsilonRate;
        private string epsilonRateAsString;
        

        public Day3(string filepath)
        {
            lines = File.ReadAllLines(filepath);
            bitLength = lines[0].Length;
        }

        // Part 1
        public int GammaRate
        {
            get
            {
                gammaRate = 0;
                var countOnes = new int[bitLength];
                var countZeroes = new int[bitLength];
                gammaRateAsList.Clear();
                foreach (var line in lines)
                {
                    var charArray = line.ToCharArray();
                    for (int i = 0; i < bitLength; i++)
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

                for (int i = 0; i < bitLength; i++)
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

                var binaryBase = 2;
                gammaRate = Convert.ToInt32(gammaRateAsString, binaryBase);
                return gammaRate;
            }
        }

        public int EpsilonRate
        {
            get
            {
                static string BinaryInverted(string input) => string.Concat(input.Select(x => x == '0' ? '1' : '0'));
                epsilonRateAsString = BinaryInverted(gammaRateAsString);

                var binaryBase = 2;
                epsilonRate = Convert.ToInt32(epsilonRateAsString, binaryBase);
                return epsilonRate;
            }
        }

        //Part 2

    }
}





