#region
using System.Collections.Generic;
using System.Linq;
#endregion

namespace NeverLotto.Engine
{
    public class Analyzer
    {
        internal Analyzer(int minimum, int maximum, int barCount, AnalysisType analysisType)
        {
            _analysisType = analysisType;

            _bars = new List<Bar>(barCount);

            int interval = (maximum - minimum + 1) / barCount;

            int[] barValues = new int[barCount];
            for (int i = 0; i < barCount; i++)
                barValues[i] = minimum + interval * i;

            for (int i = 0; i < barValues.Length; i++)
            {
                int? nextValue = (i == barValues.Length - 1) ? (int?)null : barValues[i + 1];

                Bar bar = new Bar(i, barValues[i], GetBarName(analysisType, barValues[i], nextValue));

                _bars.Add(bar);
            }
        }

        private readonly AnalysisType _analysisType;

        private readonly List<Bar> _bars;

        private string GetBarName(AnalysisType analysisType, int value, int? nextValue)
        {
            switch (analysisType)
            {
                case AnalysisType.LowHighRate:
                case AnalysisType.OddEvenRate:
                    return TextConverter.Instance[(Rate)value];
                case AnalysisType.SeriesCount:
                    return TextConverter.Instance.GetSeriesCountText(value);
                case AnalysisType.Number:
                    return value.ToString();
                default:
                    if (nextValue.HasValue)
                        return string.Format("{0} - {1}", value, nextValue - 1);
                    else
                        return string.Format("{0} - ", value);
            }
        }

        public int GetBarIndex(int barValue)
        {
            for (int i = 0; i < _bars.Count - 1; i++)
                if (barValue >= _bars[i].Value && barValue < _bars[i + 1].Value)
                    return i;

            return _bars.Count - 1;
        }

        public List<Bar> CountBars(List<Result> results)
        {
            _bars.ForEach(x => x.Count = 0);

            foreach (var result in results)
            {
                if (_analysisType == AnalysisType.Number)
                {
                    foreach (var number in result.Numbers)
                    {
                        _bars[number - 1].Count++;
                    }
                }
                else
                {
                    int barValue = result.GetBarValue(_analysisType);
                    int barIndex = GetBarIndex(barValue);
                    _bars[barIndex].Count++;
                }
            }

            return _bars;
        }

        public Bar MaximumBar { get; set; }
        
        public Bar MinimumBar { get; set; }

        public void SetMaximumAndMinimumBars()
        {
            var bars = _bars.OrderBy(x => x.Count);
            MinimumBar = bars.First();
            MaximumBar = bars.Last();
        }
    }
}