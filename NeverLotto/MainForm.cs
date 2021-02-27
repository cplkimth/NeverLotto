#region
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using NeverLotto.Controls;
using NeverLotto.Engine;
using NeverLotto.Properties;

#endregion

namespace NeverLotto
{
    public partial class MainForm : BaseForm
    {
        private List<Result> _results;

        private List<CountItem> _countItems;

        private Result _latestResult;

        private BackgroundWorker _worker;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            _results = ResultDownloader.Instance.Download();

            _countItems = Utility.CountNumbers(_results);

            int noCount = _results.Select(x => x.No).Max();
            uscAnalysis.SetNoCount(noCount);
            uscCriteria.SetNoCount(noCount - 1);

            _latestResult = _results.OrderByDescending(x => x.No).First();
            uscResultView.SetResult(_latestResult);

            uscList.SetDataSource(_results);

#if DEBUG
            tbcTab.SelectedTab = tabPage2;
#endif
        }

        private void uscAnalysis_ChartShowing(object sender, AnalysisControl.ChartShowingEventArgs e)
        {
            var results = _results.OrderByDescending(x => x.No).Take(e.NoCount).ToList();
            e.Bars = AnalyzerHelper.Instance.GetBars(results, e.AnalysisType);
        }

        private void uscSimulatorCriteria_SummaryShowing(object sender, CriteriaControl.SummaryShowingEventArgs e)
        {
            var results = _results.OrderByDescending(x => x.No).Take(e.NoCount).ToList();
            e.Analyzers = AnalyzerHelper.Instance.GetAnalyzers(results);
        }

        private void uscGeneration_ClearClicked(object sender, GenerationControl.ClearClickedEventArgs e)
        {
            uscResultView.ClearResult();
            uscSummary.ClearResult();
        }

        private void uscGeneration_OnceClicked(object sender, GenerationControl.OnceClickedEventArgs e)
        {
            var results = AnalyzerHelper.Instance.Generate(uscCriteria.GetCriteria(), Settings.Default.MaxGenerationAttempt, 1, _latestResult.Numbers, uscCriteria.NumbersToInclude, uscCriteria.NumbersToExclude);

            if (results.Count == 0)
            {
                MessageBox.Show("조건에 맞는 번호를 생성할 수 없습니다.");
                return;
            }

            uscResultView.AddResults(results);
            uscSummary.AddCount(results);
            uscSummary.SetCount();
            uscSummary.ShowSummary();
        }

        private void uscGeneration_EachClicked(object sender, GenerationControl.EachClickedEventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += bgwEach_DoWork;
            worker.ProgressChanged += bgwEach_ProgressChanged;
            worker.RunWorkerCompleted += bgwEach_RunWorkerCompleted;

            _worker = worker;

            MakeUIEnable(false);

            worker.RunWorkerAsync(e);
        }

        private void bgwEach_DoWork(object sender, DoWorkEventArgs e)
        {
            GenerationControl.EachClickedEventArgs args = (GenerationControl.EachClickedEventArgs) e.Argument;

            for (int i = 0; i < args.Count; i++)
            {
                if (((BackgroundWorker) sender).CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                var results = AnalyzerHelper.Instance.Generate(uscCriteria.GetCriteria(), Settings.Default.MaxGenerationAttempt, 1, _latestResult.Numbers, uscCriteria.NumbersToInclude, uscCriteria.NumbersToExclude);

                int percent = (int) ((i + 1) * 100m / args.Count);

                ((BackgroundWorker) sender).ReportProgress(percent, results);

                Thread.Sleep(args.MilliSecond);
            }
        }

        private void bgwEach_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            List<Result> results = (List<Result>) e.UserState;

            uscGeneration.EachProgress = e.ProgressPercentage;

            if (results.Count > 0)
            {
                uscResultView.AddResults(results);
                uscSummary.AddCount(results);
                uscSummary.SetCount();
                uscSummary.ShowSummary();
            }
        }

        private void bgwEach_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            uscGeneration.EachProgress = 0;
            MakeUIEnable(true);
        }

        private void uscGeneration_BatchClicked(object sender, GenerationControl.BatchClickedEventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += bgwBatch_DoWork;
            worker.ProgressChanged += bgwBatch_ProgressChanged;
            worker.RunWorkerCompleted += bgwBatch_RunWorkerCompleted;

            _worker = worker;

            MakeUIEnable(false);

            worker.RunWorkerAsync(e.Count);
        }

        private void bgwBatch_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker) sender;

            int count = (int) e.Argument;

            AnalyzerHelper.Instance.Generate(
                uscCriteria.GetCriteria(),
                Settings.Default.MaxGenerationAttempt,
                count,
                _latestResult.Numbers,
                uscCriteria.NumbersToInclude, 
                uscCriteria.NumbersToExclude,
                () => new WorkerArgument(worker, e),
                (percent, subResults) =>
                    {
                        uscSummary.AddCount(subResults);
                        if (percent.IsInteger())
                            worker.ReportProgress(Convert.ToInt32(percent), subResults);
                    });
        }

#if DEBUG
        private int _index;
#endif
        private void bgwBatch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
                uscGeneration.BatchProgress = e.ProgressPercentage;
#if DEBUG
//            Text = string.Format("{0:N0}", Process.GetCurrentProcess().WorkingSet64 / 1024);
            Text = ++_index + " : " + ((List<Result>) e.UserState).Count.ToString("N0");
#endif
        }

        private void bgwBatch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            uscSummary.SetCount();
            uscSummary.ShowSummary();

            uscGeneration.BatchProgress = 0;
            MakeUIEnable(true);
        }

        private void uscGeneration_CancelClicked(object sender, GenerationControl.CancelClickedEventArgs e)
        {
            if (_worker == null)
                return;

            _worker.CancelAsync();
        }

        private void MakeUIEnable(bool enabled)
        {
            uscCriteria.Enabled = enabled;
            uscGeneration.MakeUIEnable(enabled);
        }

        private void uscCriteria_SelectClicked(object sender, CriteriaControl.SelectClickedEventArgs e)
        {
            if (e.IsMaximum)
                _countItems.Sort((x, y) => y.Count.CompareTo(x.Count));
            else
                _countItems.Sort((x, y) => x.Count.CompareTo(y.Count));

            e.Numbers = _countItems.Take(e.Count).Select(x => x.Number).ToList();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuExport_Click(object sender, EventArgs e)
        {
            uscResultView.ExportToExcel();
        }

        private void mnuOption_Click(object sender, EventArgs e)
        {
            using (var form = new OptionForm())
            {
                form.ShowDialog();
            }
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            Process.Start(Settings.Default.HelpUrl);
        }
    }
}