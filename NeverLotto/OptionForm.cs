#region
using System;
using NeverLotto.Properties;

#endregion

namespace NeverLotto
{
    public partial class OptionForm : BaseForm
    {
        public OptionForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            nudCount.Value = Settings.Default.MaxGenerationAttempt;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Settings.Default.MaxGenerationAttempt = Convert.ToInt32(nudCount.Value);
            Settings.Default.Save();

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}