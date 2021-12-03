﻿using System;
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
        private int oxygenGeneratorRating;
        private List<string> oxygenGeneratorRatingList = new();
        private int cO2ScrubberRating;

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
                CountZeroesAndOnes(countOnes, countZeroes);

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
        public int OxygenGeneratorRating
        {
            get
            {
                oxygenGeneratorRatingList = new List<string>(lines);
                while (oxygenGeneratorRatingList.Count > 1)
                {
                    var countOnes = new int[bitLength];
                    var countZeroes = new int[bitLength];
                    CountZeroesAndOnes(countOnes, countZeroes);
                    var oxygenGeneratorRatingAsArray = new String[lines.Length];

                    for (int i = 0; i < bitLength; i++)
                    {
                        foreach (var item in oxygenGeneratorRatingList.ToList())
                        {
                            if (countZeroes[i] > countOnes[i])
                            {

                                if (oxygenGeneratorRatingList[i]  )
                                oxygenGeneratorRatingList.Remove(item);
                            }
                            else
                            {
                                oxygenGeneratorRatingList.Remove(item);
                            }
                            Console.WriteLine(item);
                        }
                    }
                }

                return oxygenGeneratorRating;
            }
        }

        public int CO2ScrubberRating
        {
            get
            {
                return cO2ScrubberRating;
            }
        }

        private void CountZeroesAndOnes(int[] countOnes, int[] countZeroes)
        {
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
        }
    }
}





