#region
using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace NeverLotto.Engine
{
    public class Result
    {
        private static int _generatingNo;

        private static readonly Random _random = new Random();

        public Result(List<int> numbersToInclude, List<int> numbersToExclude)
        {
            No = ++_generatingNo;

            Numbers = new List<int>(6);
            Numbers.AddRange(numbersToInclude);

            while (Numbers.Count != Numbers.Capacity)
            {
                int number = _random.Next(1, 45);

                if (Numbers.Contains(number) || numbersToExclude.Contains(number))
                    continue;

                Numbers.Add(number);
            }

            while (true)
            {
                BonusNumber = _random.Next(1, 45);

                if (Numbers.Contains(BonusNumber) == false)
                    break;
            }

            Calculate();
        }

        public Result(params int[] numbers)
        {
            Numbers = new List<int>(numbers);

            Calculate();
        }

        public Result(int no, IEnumerable<int> numbers, int bonusNumber)
        {
            No = no;

            Numbers = new List<int>(numbers);

            BonusNumber = bonusNumber;

            Calculate();
        }

        private void Calculate()
        {
            Numbers.Sort();

            TotalSum = Numbers.Sum();
            LowSum = Numbers[0] + Numbers[1] + Numbers[2];
            HighSum = Numbers[3] + Numbers[4] + Numbers[5];
            EdgeSum = Numbers[0] + Numbers[5];
            EdgeSubtraction = Numbers[5] - Numbers[0];
            FirstDigitSum = Numbers.Sum(x => x / 10);
            LastDigitSum = Numbers.Sum(x => x % 10);

            LowHighRate = (Rate)Numbers.Count(x => x < 23);
            OddEvenRate = (Rate)Numbers.Count(x => x % 2 == 1);

            int i = 0;
            while (i < 5)
            {
                if (Numbers[i + 1] == Numbers[i] + 1)
                {
                    SeriesCount++;
                    i++;
                }

                i++;
            }
        }

        public int No { get; set; }

        public List<int> Numbers { get; set; }

        public int BonusNumber { get; set; }

        public int TotalSum { get; set; }

        public int LowSum { get; set; }

        public int HighSum { get; set; }

        public int EdgeSum { get; set; }

        public int FirstDigitSum { get; set; }

        public int LastDigitSum { get; set; }

        public int EdgeSubtraction { get; set; }

        public Rate LowHighRate { get; set; }

        public Rate OddEvenRate { get; set; }

        public int SeriesCount { get; set; }

        public string NumbersText => string.Join(" ", Numbers);

        public string GeneratedNumbersText => string.Format("{0} ({1})", NumbersText, BonusNumber);

        public string LowHighRateText => TextConverter.Instance[LowHighRate];

        public string OddEvenRateText => TextConverter.Instance[OddEvenRate];

        public int GetBarValue(AnalysisType analysisType)
        {
            switch (analysisType)
            {
                case AnalysisType.TotalSum:
                    return TotalSum;
                case AnalysisType.LowSum:
                    return LowSum;
                case AnalysisType.HighSum:
                    return HighSum;
                case AnalysisType.FirstDigitSum:
                    return FirstDigitSum;
                case AnalysisType.LastDigitSum:
                    return LastDigitSum;
                case AnalysisType.EdgeSum:
                    return EdgeSum;
                case AnalysisType.EdgeSubtraction:
                    return EdgeSubtraction;
                case AnalysisType.LowHighRate:
                    return (int)LowHighRate;
                case AnalysisType.OddEvenRate:
                    return (int)OddEvenRate;
                case AnalysisType.SeriesCount:
                    return SeriesCount;
            }

            throw new NotImplementedException("Result.GetValue");
        }

        public override string ToString()
        {
            return TotalSum + ", " + LowSum + ", " + HighSum + ", " + FirstDigitSum + ", " + LastDigitSum + ", " + EdgeSum + ", " + EdgeSubtraction + ", " + LowHighRate + ", " + OddEvenRate + ", " + SeriesCount;
        }

        public string GetNumberText()
        {
            return string.Join(" ", Numbers);
        }

        public int MatchedCount { get; set; }

        public int Rank { get; set; }

        private int GetMatchedNumberCount(List<int> numbers)
        {
            int count = 0;

            foreach (var number in Numbers)
                if (numbers.Contains(number))
                    count++;

            return count;
        }

        public void CalculateRank(List<int> numbers)
        {
            MatchedCount = GetMatchedNumberCount(numbers);

            switch (MatchedCount)
            {
                case 0:
                case 1:
                case 2:
                    Rank = 0;
                    break;
                case 3:
                    Rank = 5;
                    break;
                case 4:
                    Rank = 4;
                    break;
                case 5:
                    Rank = (numbers.Contains(BonusNumber)) ? 2 : 3;
                    break;
                case 6:
                    Rank = 1;
                    break;
                default:
                    throw new NotImplementedException("Result.CalculateRank");
            }
        }

        public int Number1 => Numbers[0];
        public int Number2 => Numbers[1];
        public int Number3 => Numbers[2];
        public int Number4 => Numbers[3];
        public int Number5 => Numbers[4];
        public int Number6 => Numbers[5];
    }
}