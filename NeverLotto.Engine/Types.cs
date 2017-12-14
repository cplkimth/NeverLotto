using System.ComponentModel;

namespace NeverLotto.Engine
{
    public class ResultCriteria
    {
        public ResultCriteria(AnalysisType analysisType)
        {
            AnalysisType = analysisType;
        }

        public AnalysisType AnalysisType { get; set; }

        public int BarIndex { get; set; }
    }

    public class WorkerArgument
    {
        public WorkerArgument(BackgroundWorker worker, DoWorkEventArgs doWorkEventArgs)
        {
            Worker = worker;
            DoWorkEventArgs = doWorkEventArgs;
        }

        public BackgroundWorker Worker { get; set; }
        public DoWorkEventArgs DoWorkEventArgs { get; set; }
    }

    public struct CountItem
    {
        public int Number { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return Number + ":" + Count;
        }
    }
}