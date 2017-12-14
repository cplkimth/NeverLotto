#region
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NeverLotto.Engine;

#endregion

namespace NeverLotto.Controls
{
    public partial class AnalysisControl : UserControl
    {
        public AnalysisControl()
        {
            InitializeComponent();

            _radioButtons = new[] {rdbButton0, rdbButton1, rdbButton2, rdbButton3, rdbButton4, rdbButton5, rdbButton6, rdbButton7, rdbButton8, rdbButton9, rdbButton10};
        }

        private readonly RadioButton[] _radioButtons;

        public void SetNoCount(int noCount)
        {
            nudNo.Maximum = noCount;
            nudNo.Value = noCount;
            nudNo.ValueChanged += nudNo_ValueChanged;

            RaiseChartShowing();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton) sender;

            if (radioButton.Checked == false)
                return;

            RaiseChartShowing();
        }

        private void nudNo_ValueChanged(object sender, EventArgs e)
        {
            RaiseChartShowing();
        }

        private void RaiseChartShowing()
        {
            int noCount = Convert.ToInt32(nudNo.Value);

            AnalysisType analysisType = AnalysisType.TotalSum;
            foreach (var radioButton in _radioButtons)
            {
                if (radioButton.Checked)
                {
                    analysisType = (AnalysisType)int.Parse((string)radioButton.Tag);
                    break;
                }
            }

            var args = OnChartShowingWithReturn(noCount, analysisType, null);
            bdsList.DataSource = args.Bars;
            chtChart.DataBind();
        }

        #region ChartShowing event things for C# 3.0
        public event EventHandler<ChartShowingEventArgs> ChartShowing;

        protected virtual void OnChartShowing(ChartShowingEventArgs e)
        {
            if (ChartShowing != null)
                ChartShowing(this, e);
        }

        protected virtual void OnChartShowing(int noCount, AnalysisType analysisType, List<Bar> bars)
        {
            OnChartShowing(new ChartShowingEventArgs(noCount, analysisType, bars));
        }

        protected virtual ChartShowingEventArgs OnChartShowingWithReturn(int noCount, AnalysisType analysisType, List<Bar> bars)
        {
            ChartShowingEventArgs args = new ChartShowingEventArgs(noCount, analysisType, bars);
            OnChartShowing(args);

            return args;
        }

        public class ChartShowingEventArgs : EventArgs
        {
            public int NoCount { get; set; }
            public AnalysisType AnalysisType { get; set; }
            public List<Bar> Bars { get; set; }

            public ChartShowingEventArgs()
            {
            }

            public ChartShowingEventArgs(int noCount, AnalysisType analysisType, List<Bar> bars)
            {
                NoCount = noCount;
                AnalysisType = analysisType;
                Bars = bars;
            }
        }
        #endregion
    }
}