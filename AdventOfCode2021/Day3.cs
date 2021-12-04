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
                gammaRateAsList.Clear();
                var linesAsList = new List<string>(lines);
                var countedTemp = CountZeroesAndOnes(linesAsList);

                for (int i = 0; i < bitLength; i++)
                {
                    if (countedTemp[0][i] > countedTemp[1][i])
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
                var keepOxygenGeneratorRatingList = new List<string>();

                for (int j = 0; j < bitLength; j++)
                {
                    var mostCommon = '1';
                    var countedTemp = CountZeroesAndOnes(oxygenGeneratorRatingList);
                    if (countedTemp[0][j] > countedTemp[1][j])
                        { mostCommon = '0'; }
                    for (int i = 0; i < oxygenGeneratorRatingList.Count; i++)
                    {
                        if (i > oxygenGeneratorRatingList.Count)
                        { break; }
                        var test = oxygenGeneratorRatingList[i][j] == mostCommon;
                        if (oxygenGeneratorRatingList[i][j] == mostCommon)
                        {
                            keepOxygenGeneratorRatingList.Add(oxygenGeneratorRatingList[i]);
                        }
                    }
                    oxygenGeneratorRatingList = keepOxygenGeneratorRatingList.ToArray().ToList();
                    if (keepOxygenGeneratorRatingList.Count == 1)
                    { break; }
                    keepOxygenGeneratorRatingList.Clear();
                }
                var oxygenGeneratorRatingString = String.Join("", keepOxygenGeneratorRatingList.ToArray());

                oxygenGeneratorRating = BinaryStringToInt(oxygenGeneratorRatingString);
                return oxygenGeneratorRating;
            }
        }

        public int CO2ScrubberRating
        {
            get
            {
                cO2ScrubberRatingList = new List<string>(lines);
                var keepCO2ScrubberRatingList = new List<string>();

                for (int j = 0; j < bitLength; j++)
                {
                    var leastCommon = '0';
                    var countedTemp = CountZeroesAndOnes(cO2ScrubberRatingList);
                    if (countedTemp[0][j] > countedTemp[1][j])
                    { leastCommon = '1'; }
                    for (int i = 0; i < cO2ScrubberRatingList.Count; i++)
                    {
                        if (i > cO2ScrubberRatingList.Count)
                        { break; }
                        var test = cO2ScrubberRatingList[i][j] == leastCommon;
                        if (cO2ScrubberRatingList[i][j] == leastCommon)
                        {
                            keepCO2ScrubberRatingList.Add(cO2ScrubberRatingList[i]);
                        }
                    }
                    cO2ScrubberRatingList = keepCO2ScrubberRatingList.ToArray().ToList();
                    if (keepCO2ScrubberRatingList.Count == 1)
                    { break; }
                    keepCO2ScrubberRatingList.Clear();
                }
                var cO2ScrubberRatingString = String.Join("", keepCO2ScrubberRatingList.ToArray());

                cO2ScrubberRating = BinaryStringToInt(cO2ScrubberRatingString);
                return cO2ScrubberRating;
            }
        }

        private List<int[]> CountZeroesAndOnes(List<string> inputList)
        {
            var countZeroes = new int[bitLength];
            var countOnes = new int[bitLength];
            foreach (var line in inputList)
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
            var output = new List<int[]>() { countZeroes, countOnes };
            return output;
        }
    }
}





