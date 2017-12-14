#region
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace NeverLotto.Controls
{
    public partial class SummaryItemControl : UserControl
    {
        private string _rank;

        public SummaryItemControl()
        {
            InitializeComponent();
        }

        public string Rank
        {
            get { return _rank; }
            set
            {
                _rank = value;

                if (_rank.Length == 0)
                    return;

                lblRank.Text = value;

                switch (value[0])
                {
                    case '1':
                        lblRank.BackColor = Color.Gold;
                        break;
                    case '2':
                        lblRank.BackColor = Color.Coral;
                        break;
                    case '3':
                        lblRank.BackColor = Color.LightBlue;
                        break;
                    case '4':
                        lblRank.BackColor = Color.RoyalBlue;
                        break;
                    case '5':
                        lblRank.BackColor = Color.BurlyWood;
                        break;
                    default:
                        lblRank.BackColor = Color.White;
                        break;
                }
            }
        }

        public void SetCount(int count, decimal percent)
        {
            lblCount.Text = string.Format("{0:N0} 회 ({1:P5})", count, percent);
        }

        public void SetPrize(decimal prizeEach, decimal prize)
        {
            lblPrizeEach.Text = string.Format("{0:C0}", prizeEach);
            lblPrize.Text = string.Format("{0:C0}", prize);
        }

        public void ClearLabels()
        {
            SetCount(0, 0);
            lblPrizeEach.Text = string.Empty;
            SetPrize(0, 0);
        }
    }
}