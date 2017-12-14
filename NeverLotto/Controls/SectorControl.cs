#region
using System.ComponentModel;
using System.Windows.Forms;
using NeverLotto.Engine;

#endregion

namespace NeverLotto.Controls
{
    public partial class SectorControl : UserControl
    {
        public SectorControl()
        {
            InitializeComponent();
        }

        [DefaultValue(0)]
        public int AnalysisTypeIndex { get; set; }

        public Analyzer Analyzer { get; set; }

        public void SetCheckBox(bool @checked)
        {
            chbName.Checked = @checked;
        }

        public void SelectMaximum()
        {
            rdbMaximum.Checked = true;
        }

        public void SelectMinimum()
        {
            rdbMinimum.Checked = true;
        }

        public void SetCheckBoxText(string text)
        {
            chbName.Text = text;
        }

        public void SetMaximumText(string text)
        {
            rdbMaximum.Text = string.Format("최다 ({0})", text);
        }

        public void SetMinimumText(string text)
        {
            rdbMinimum.Text = string.Format("최소 ({0})", text);
        }

        private void chbName_CheckedChanged(object sender, System.EventArgs e)
        {
            rdbMaximum.Enabled = chbName.Checked;
            rdbMinimum.Enabled = chbName.Checked;
        }

        public ResultCriteria GetResultCriteria()
        {
            if (chbName.Checked == false)
                return null;

            ResultCriteria resultCriteria = new ResultCriteria((AnalysisType) AnalysisTypeIndex);
            resultCriteria.BarIndex = (rdbMaximum.Checked) ? Analyzer.MaximumBar.Index : Analyzer.MinimumBar.Index;

            return resultCriteria;
        }
    }
}