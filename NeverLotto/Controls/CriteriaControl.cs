#region
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NeverLotto.Engine;

#endregion

namespace NeverLotto.Controls
{
    public partial class CriteriaControl : UserControl
    {
        public CriteriaControl()
        {
            InitializeComponent();

            _sectorControls = new List<SectorControl>
                                  {
                                      uscSecotr0,
                                      uscSecotr1,
                                      uscSecotr2,
                                      uscSecotr3,
                                      uscSecotr4,
                                      uscSecotr5,
                                      uscSecotr6,
                                      uscSecotr7,
                                      uscSecotr8,
                                      uscSecotr9
                                  };

#if DEBUG
            tbcTab.SelectedTab = tbpInclude;
#endif
        }

        private readonly List<SectorControl> _sectorControls;

        public void SetNoCount(int noCount)
        {
            nudNo.Maximum = noCount;
            nudNo.Value = noCount;
            nudNo.ValueChanged += nudNo_ValueChanged;

            RaiseSummaryShowing();
        }

        public List<int> NumbersToInclude
        {
            get {return uscInclude.GetCheckedNumbers();}
        }

        public List<int> NumbersToExclude
        {
            get {return uscExclude.GetCheckedNumbers();}
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            _sectorControls.ForEach(x => x.SetCheckBox(true));
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            _sectorControls.ForEach(x => x.SetCheckBox(false));
        }

        private void btnMaximum_Click(object sender, EventArgs e)
        {
            _sectorControls.ForEach(x => x.SelectMaximum());
        }

        private void btnMinimum_Click(object sender, EventArgs e)
        {
            _sectorControls.ForEach(x => x.SelectMinimum());
        }

        private void nudNo_ValueChanged(object sender, EventArgs e)
        {
            RaiseSummaryShowing();
        }

        private void RaiseSummaryShowing()
        {
            var args = OnSummaryShowingWithReturn(Convert.ToInt32(nudNo.Value), null);

            foreach (var sectorControl in _sectorControls)
            {
                Analyzer analyzer = args.Analyzers[(AnalysisType) sectorControl.AnalysisTypeIndex];

                sectorControl.Analyzer = analyzer;

                sectorControl.SetCheckBoxText(TextConverter.Instance.GetAnalysisTypeText((AnalysisType) sectorControl.AnalysisTypeIndex));
                sectorControl.SetMaximumText(analyzer.MaximumBar.Name);
                sectorControl.SetMinimumText(analyzer.MinimumBar.Name);
            }
        }

        public List<ResultCriteria> GetCriteria()
        {
            List<ResultCriteria> list = new List<ResultCriteria>();

            foreach (var sectorControl in _sectorControls)
            {
                var resultCriteria = sectorControl.GetResultCriteria();

                if (resultCriteria == null)
                    continue;

                list.Add(resultCriteria);
            }

            return list;
        }

        private void uscIncludeNumber_SelectClicked(object sender, NumberSelectionControl.SelectClickedEventArgs e)
        {
            var args = OnSelectClickedWithReturn(e.IsMaximum, e.Count, null);
            e.Numbers = args.Numbers;
        }

        private void uscExclude_SelectClicked(object sender, NumberSelectionControl.SelectClickedEventArgs e)
        {
            var args = OnSelectClickedWithReturn(e.IsMaximum, e.Count, null);
            e.Numbers = args.Numbers;
        }

        #region SummaryShowing event things for C# 3.0
        public event EventHandler<SummaryShowingEventArgs> SummaryShowing;

        protected virtual void OnSummaryShowing(SummaryShowingEventArgs e)
        {
            if (SummaryShowing != null)
                SummaryShowing(this, e);
        }

        protected virtual void OnSummaryShowing(int noCount, Dictionary<AnalysisType, Analyzer> analyzers)
        {
            OnSummaryShowing(new SummaryShowingEventArgs(noCount, analyzers));
        }

        protected virtual SummaryShowingEventArgs OnSummaryShowingWithReturn(int noCount, Dictionary<AnalysisType, Analyzer> analyzers)
        {
            SummaryShowingEventArgs args = new SummaryShowingEventArgs(noCount, analyzers);
            OnSummaryShowing(args);

            return args;
        }

        public class SummaryShowingEventArgs : EventArgs
        {
            public int NoCount { get; set; }
            public Dictionary<AnalysisType, Analyzer> Analyzers { get; set; }

            public SummaryShowingEventArgs()
            {
            }

            public SummaryShowingEventArgs(int noCount, Dictionary<AnalysisType, Analyzer> analyzers)
            {
                NoCount = noCount;
                Analyzers = analyzers;
            }
        }
        #endregion

        #region SelectClicked event things for C# 3.0
        public event EventHandler<SelectClickedEventArgs> SelectClicked;

        protected virtual void OnSelectClicked(SelectClickedEventArgs e)
        {
            if (SelectClicked != null)
                SelectClicked(this, e);
        }

        protected virtual void OnSelectClicked(bool isMaximum, int count, List<int> numbers)
        {
            OnSelectClicked(new SelectClickedEventArgs(isMaximum, count, numbers));
        }

        protected virtual SelectClickedEventArgs OnSelectClickedWithReturn(bool isMaximum, int count, List<int> numbers)
        {
            SelectClickedEventArgs args = new SelectClickedEventArgs(isMaximum, count, numbers);
            OnSelectClicked(args);

            return args;
        }

        public class SelectClickedEventArgs : EventArgs
        {
            public bool IsMaximum { get; set; }
            public int Count { get; set; }
            public List<int> Numbers { get; set; }

            public SelectClickedEventArgs()
            {
            }

            public SelectClickedEventArgs(bool isMaximum, int count, List<int> numbers)
            {
                IsMaximum = isMaximum;
                Count = count;
                Numbers = numbers;
            }
        }
        #endregion
    }
}