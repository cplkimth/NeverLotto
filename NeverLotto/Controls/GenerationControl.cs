#region
using System;
using System.Windows.Forms;
using NeverLotto.Properties;

#endregion

namespace NeverLotto.Controls
{
    public partial class GenerationControl : UserControl
    {
        public GenerationControl()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            nudBatch.Maximum = Settings.Default.MaxGenerationCount;
        }

        public int EachProgress
        {
            get { return prbEach.Value; }
            set { prbEach.Value = value; }
        }

        public int BatchProgress
        {
            get { return prbBatch.Value; }
            set { prbBatch.Value = value; }
        }

        public void MakeUIEnable(bool enabled)
        {
            tbcTab.Enabled = enabled;
            btnClear.Enabled = enabled;
            btnCancel.Enabled = !enabled;
        }

        private void btnOnce_Click(object sender, EventArgs e)
        {
            OnOnceClicked(null);
        }

        private void btnEach_Click(object sender, EventArgs e)
        {
            prbEach.Value = 0;

            OnEachClicked(Convert.ToInt32(nudMilliSecond.Value), Convert.ToInt32(nudEach.Value));
        }

        private void btnBatch_Click(object sender, EventArgs e)
        {
            prbBatch.Value = 0;

            OnBatchClicked(Convert.ToInt32(nudBatch.Value));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("생성 기록을 초기화 합니다. 계속 할까요?", "질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                OnClearClicked(null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnCancelClicked(null);
        }

        #region ClearClicked event things for C# 3.0
        public event EventHandler<ClearClickedEventArgs> ClearClicked;

        protected virtual void OnClearClicked(ClearClickedEventArgs e)
        {
            if (ClearClicked != null)
                ClearClicked(this, e);
        }

        protected virtual void OnClearClicked(object dymmy)
        {
            OnClearClicked(new ClearClickedEventArgs(dymmy));
        }

        protected virtual ClearClickedEventArgs OnClearClickedWithReturn(object dymmy)
        {
            ClearClickedEventArgs args = new ClearClickedEventArgs(dymmy);
            OnClearClicked(args);

            return args;
        }

        public class ClearClickedEventArgs : EventArgs
        {
            public object Dymmy { get; set; }

            public ClearClickedEventArgs()
            {
            }

            public ClearClickedEventArgs(object dymmy)
            {
                Dymmy = dymmy;
            }
        }
        #endregion

        #region OnceClicked event things for C# 3.0
        public event EventHandler<OnceClickedEventArgs> OnceClicked;

        protected virtual void OnOnceClicked(OnceClickedEventArgs e)
        {
            if (OnceClicked != null)
                OnceClicked(this, e);
        }

        protected virtual void OnOnceClicked(object dymmy)
        {
            OnOnceClicked(new OnceClickedEventArgs(dymmy));
        }

        protected virtual OnceClickedEventArgs OnOnceClickedWithReturn(object dymmy)
        {
            OnceClickedEventArgs args = new OnceClickedEventArgs(dymmy);
            OnOnceClicked(args);

            return args;
        }

        public class OnceClickedEventArgs : EventArgs
        {
            public object Dymmy { get; set; }

            public OnceClickedEventArgs()
            {
            }

            public OnceClickedEventArgs(object dymmy)
            {
                Dymmy = dymmy;
            }
        }
        #endregion

        #region EachClicked event things for C# 3.0
        public event EventHandler<EachClickedEventArgs> EachClicked;

        protected virtual void OnEachClicked(EachClickedEventArgs e)
        {
            if (EachClicked != null)
                EachClicked(this, e);
        }

        protected virtual void OnEachClicked(int milliSecond, int count)
        {
            OnEachClicked(new EachClickedEventArgs(milliSecond, count));
        }

        protected virtual EachClickedEventArgs OnEachClickedWithReturn(int milliSecond, int count)
        {
            EachClickedEventArgs args = new EachClickedEventArgs(milliSecond, count);
            OnEachClicked(args);

            return args;
        }

        public class EachClickedEventArgs : EventArgs
        {
            public int MilliSecond { get; set; }
            public int Count { get; set; }

            public EachClickedEventArgs()
            {
            }

            public EachClickedEventArgs(int milliSecond, int count)
            {
                MilliSecond = milliSecond;
                Count = count;
            }
        }
        #endregion

        #region BatchClicked event things for C# 3.0
        public event EventHandler<BatchClickedEventArgs> BatchClicked;

        protected virtual void OnBatchClicked(BatchClickedEventArgs e)
        {
            if (BatchClicked != null)
                BatchClicked(this, e);
        }

        protected virtual void OnBatchClicked(int count)
        {
            OnBatchClicked(new BatchClickedEventArgs(count));
        }

        protected virtual BatchClickedEventArgs OnBatchClickedWithReturn(int count)
        {
            BatchClickedEventArgs args = new BatchClickedEventArgs(count);
            OnBatchClicked(args);

            return args;
        }

        public class BatchClickedEventArgs : EventArgs
        {
            public int Count { get; set; }

            public BatchClickedEventArgs()
            {
            }

            public BatchClickedEventArgs(int count)
            {
                Count = count;
            }
        }
        #endregion

        #region CancelClicked event things for C# 3.0
        public event EventHandler<CancelClickedEventArgs> CancelClicked;

        protected virtual void OnCancelClicked(CancelClickedEventArgs e)
        {
            if (CancelClicked != null)
                CancelClicked(this, e);
        }

        protected virtual void OnCancelClicked(object dummy)
        {
            OnCancelClicked(new CancelClickedEventArgs(dummy));
        }

        protected virtual CancelClickedEventArgs OnCancelClickedWithReturn(object dummy)
        {
            CancelClickedEventArgs args = new CancelClickedEventArgs(dummy);
            OnCancelClicked(args);

            return args;
        }

        public class CancelClickedEventArgs : EventArgs
        {
            public object Dummy { get; set; }

            public CancelClickedEventArgs()
            {
            }

            public CancelClickedEventArgs(object dummy)
            {
                Dummy = dummy;
            }
        }
        #endregion
    }
}