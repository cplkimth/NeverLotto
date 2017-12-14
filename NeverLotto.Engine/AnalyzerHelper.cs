using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace NeverLotto.Engine
{
    public class AnalyzerHelper
    {
        #region singleton
        private static AnalyzerHelper _instance;

        public static AnalyzerHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AnalyzerHelper();
                return _instance;
            }
        }

        private AnalyzerHelper()
        {
            _analyzers.Add(AnalysisType.TotalSum, new Analyzer(19, 255, 6, AnalysisType.TotalSum));
            _analyzers.Add(AnalysisType.LowSum, new Analyzer(6, 123, 6, AnalysisType.LowSum));
            _analyzers.Add(AnalysisType.HighSum, new Analyzer(15, 132, 6, AnalysisType.HighSum));
            _analyzers.Add(AnalysisType.FirstDigitSum, new Analyzer(0, 24, 6, AnalysisType.FirstDigitSum));
            _analyzers.Add(AnalysisType.LastDigitSum, new Analyzer(2, 52, 6, AnalysisType.LastDigitSum));
            _analyzers.Add(AnalysisType.EdgeSum, new Analyzer(7, 85, 6, AnalysisType.EdgeSum));
            _analyzers.Add(AnalysisType.EdgeSubtraction, new Analyzer(5, 44, 6, AnalysisType.EdgeSubtraction));
            _analyzers.Add(AnalysisType.LowHighRate, new Analyzer(0, 6, 7, AnalysisType.LowHighRate));
            _analyzers.Add(AnalysisType.OddEvenRate, new Analyzer(0, 6, 7, AnalysisType.OddEvenRate));
            _analyzers.Add(AnalysisType.SeriesCount, new Analyzer(0, 3, 4, AnalysisType.SeriesCount));
            _analyzers.Add(AnalysisType.Number, new Analyzer(1, 45, 45, AnalysisType.Number));
        }
        #endregion

        private readonly Dictionary<AnalysisType, Analyzer> _analyzers = new Dictionary<AnalysisType, Analyzer>();

        public List<Bar> GetBars(List<Result> results, AnalysisType analysisType)
        {
            return _analyzers[analysisType].CountBars(results);
        }

        public Dictionary<AnalysisType, Analyzer> GetAnalyzers(List<Result> results)
        {
            AnalysisType[] analysisTypes = (AnalysisType[])Enum.GetValues(typeof(AnalysisType));

            foreach (var analysisType in analysisTypes)
            {
                _analyzers[analysisType].CountBars(results);
                _analyzers[analysisType].SetMaximumAndMinimumBars();
            }

            return _analyzers;
        }

        private bool IsValidResult(Result result, List<ResultCriteria> resultCriteriaList)
        {
            foreach (var resultCriteria in resultCriteriaList)
            {
                Analyzer analyzer = _analyzers[resultCriteria.AnalysisType];

                int barValue = result.GetBarValue(resultCriteria.AnalysisType);
                int barIndex = analyzer.GetBarIndex(barValue);

                if (resultCriteria.BarIndex != barIndex)
                    return false;
            }

            return true;
        }

        public List<Result> Generate(List<ResultCriteria> criteria, int maxAttempt, int count, List<int> latestResultNumbers, List<int> numbersToInclude, List<int> numbersToExclude, Func<WorkerArgument> onCanceled = null, Action<decimal, List<Result>> onAdded = null)
        {
            List<Result> list = new List<Result>(count);

            const int subListSize = 100000;

            for (int i = 0; i <= count / subListSize; i++)
            {
                List<Result> subLIst = new List<Result>(subListSize);

                GenerateCore(criteria, maxAttempt, count, latestResultNumbers, numbersToInclude, numbersToExclude, onCanceled, subListSize, i, list, subLIst);

                if (onAdded != null)
                    onAdded(i * subListSize * 100M / count, subLIst);
            }

            return list;
        }

        private void GenerateCore(List<ResultCriteria> criteria, int maxAttempt, int count, List<int> latestResultNumbers, List<int> numbersToInclude, List<int> numbersToExclude, Func<WorkerArgument> onCanceled, int subListSize, int i, List<Result> list, List<Result> subLIst)
        {
            for (int j = 0; j < subListSize; j++)
            {
                int index = (i * subListSize + j);

                if (index == count)
                    break;

                var result = GenerateSingle(criteria, maxAttempt, latestResultNumbers, numbersToInclude, numbersToExclude);

                if (result == null)
                    continue;

                if (count == 1)
                    list.Add(result);
                else
                    subLIst.Add(result);

                if (onCanceled != null)
                {
                    var argument = onCanceled();
                    if (argument.Worker.CancellationPending)
                    {
                        argument.DoWorkEventArgs.Cancel = true;
                        break;
                    }
                }
            }
        }

        private Result GenerateSingle(List<ResultCriteria> criteria, int maxAttempt, List<int> latestResultNumbers, List<int> numbersToInclude, List<int> numbersToExclude)
        {
            int count = 0;
            Result result = null;

            do
            {
                result = new Result(numbersToInclude, numbersToExclude);

                count++;

                if (count == maxAttempt)
                    return null;

            } while (IsValidResult(result, criteria) == false);

            result.CalculateRank(latestResultNumbers);

            return result;
        }
    }
}
