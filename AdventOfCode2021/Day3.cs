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
        private int oxygenGeneratorRating;
        private List<string> oxygenGeneratorRatingList = new();
        private int cO2ScrubberRating;
        private List<string> cO2ScrubberRatingList = new();

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
                gammaRate = BinaryStringToInt(gammaRateAsString);
                return gammaRate;
            }
        }

        public int EpsilonRate
        {
            get
            {
                static string BinaryInverted(string input) => string.Concat(input.Select(x => x == '0' ? '1' : '0'));
                epsilonRateAsString = BinaryInverted(gammaRateAsString);

                epsilonRate = BinaryStringToInt(epsilonRateAsString);
                return epsilonRate;
            }
        }

        private int BinaryStringToInt(string binaryString)
        {
            var binaryBase = 2;
            return Convert.ToInt32(binaryString, binaryBase);
        }

        //Part 2
        public int OxygenGeneratorRating
        {
            get
            {
                oxygenGeneratorRatingList = new List<string>(lines);
                var countOnes = new int[bitLength];
                var countZeroes = new int[bitLength];
                CountZeroesAndOnes(countOnes, countZeroes);

                foreach (var item in oxygenGeneratorRatingList.ToList())
                {
                    if (oxygenGeneratorRatingList.Count == 1)
                    { break; }
                    for (int i = 0; i < bitLength; i++)
                    {
                        if (countZeroes[i] > countOnes[i] && item.StartsWith('1'))
                        {
                            oxygenGeneratorRatingList.Remove(item);
                        }
                        else if (countOnes[i] > countZeroes[i] && item.StartsWith('0'))
                        {
                            oxygenGeneratorRatingList.Remove(item);
                        }
                    }
                }
                var oxygenGeneratorRatingString = String.Join("", oxygenGeneratorRatingList.ToArray());

                oxygenGeneratorRating = BinaryStringToInt(oxygenGeneratorRatingString);
                return oxygenGeneratorRating;
            }
        }

        public int CO2ScrubberRating
        {
            get
            {
                cO2ScrubberRatingList = new List<string>(lines);
                var countOnes = new int[bitLength];
                var countZeroes = new int[bitLength];
                CountZeroesAndOnes(countOnes, countZeroes);

                foreach (var item in cO2ScrubberRatingList.ToList())
                {
                    if (cO2ScrubberRatingList.Count == 1)
                    { break; }
                    for (int i = 0; i < bitLength; i++)
                    {
                        if (countZeroes[i] > countOnes[i] && item.StartsWith('1'))
                        {
                            cO2ScrubberRatingList.Remove(item);
                        }
                        else if (countOnes[i] > countZeroes[i] && item.StartsWith('0'))
                        {
                            cO2ScrubberRatingList.Remove(item);
                        }
                    }
                }
                var oxygenGeneratorRatingString = String.Join("", oxygenGeneratorRatingList.ToArray());

                cO2ScrubberRating = BinaryStringToInt(oxygenGeneratorRatingString);
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





