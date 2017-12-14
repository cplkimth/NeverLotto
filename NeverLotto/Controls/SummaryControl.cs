#region
using System.Collections.Generic;
using System.Windows.Forms;
using NeverLotto.Engine;
using System.Linq;
using NeverLotto.Properties;

#endregion

namespace NeverLotto.Controls
{
    public partial class SummaryControl : UserControl
    {
        public SummaryControl()
        {
            InitializeComponent();

            _summaryItems = new[] {uscItem6, uscItem1, uscItem2, uscItem3, uscItem4, uscItem5};

            for (int i = 0; i < _ranks.Capacity; i++)
                _ranks.Add(0);

            SetCount();

            ClearSummaryLabel();
        }

        private readonly List<int> _ranks = new List<int>(6);

        private readonly SummaryItemControl[] _summaryItems;

        public void AddCount(List<Result> results)
        {
            foreach (var result in results)
                _ranks[result.Rank]++;
        }

        public void SetCount()
        {
            int totalCount = _ranks.Sum();

            lblTotalCount.Text = string.Format("{0:N0} 회", totalCount);

            for (int i = 0; i < _ranks.Count; i++)
            {
                decimal percent = totalCount == 0 ? 0 : _ranks[i] / ((decimal) totalCount);
                _summaryItems[i].SetCount(_ranks[i], percent);
            }
        }

        public void ShowSummary()
        {
            int totalCount = _ranks.Sum();

            decimal totalSales = totalCount * Settings.Default.PaperPrice;

            decimal prize5 = _ranks[5] * Settings.Default.Rank5Prize;
            decimal prize4 = _ranks[4] * Settings.Default.Rank4Prize;

            decimal priceSeed = (totalSales / 2) - prize5 - prize4;

            decimal prize3Each = priceSeed * 0.125M / (_ranks[3] == 0 ? 1 : _ranks[3]);
            decimal prize3 = _ranks[3] * prize3Each;

            decimal prize2Each = priceSeed * 0.125M / (_ranks[2] == 0 ? 1 : _ranks[2]);
            decimal prize2 = _ranks[2] * prize2Each;

            decimal prize1Each = priceSeed * 0.75M / (_ranks[1] == 0 ? 1 : _ranks[1]);
            decimal prize1 = _ranks[1] * prize1Each;

            decimal totalPrize = prize1 + prize2 + prize3 + prize4 + prize5;
            decimal margin = totalSales - totalPrize;

            lblTotalSales.Text = totalSales.ToString("C0");
            lblTotalPrize.Text = totalPrize.ToString("C0");
            lblMargin.Text = margin.ToString("C0");

            uscItem1.SetPrize(prize1Each, prize1);
            uscItem2.SetPrize(prize2Each, prize2);
            uscItem3.SetPrize(prize3Each, prize3);
            uscItem4.SetPrize(50000, prize4);
            uscItem5.SetPrize(5000, prize5);
        }

        public void ClearResult()
        {
            for (int i = 0; i < _ranks.Count; i++)
                _ranks[i] = 0;

            SetCount();
            ClearSummaryLabel();
        }

        private void ClearSummaryLabel()
        {
            lblTotalSales.Text = string.Empty;
            lblTotalPrize.Text = string.Empty;
            lblMargin.Text = string.Empty;

            foreach (var summaryItem in _summaryItems)
                summaryItem.ClearLabels();
        }
    }
}