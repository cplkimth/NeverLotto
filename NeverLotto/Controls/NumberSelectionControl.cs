#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#endregion

namespace NeverLotto.Controls
{
    public partial class NumberSelectionControl : UserControl
    {
        public NumberSelectionControl()
        {
            InitializeComponent();

            _checkBoxes = new[]
                              {
                                  chb01, chb02, chb03, chb04, chb05, chb06, chb07, chb08, chb09,
                                  chb10, chb11, chb12, chb13, chb14, chb15, chb16, chb17, chb18, chb19,
                                  chb20, chb21, chb22, chb23, chb24, chb25, chb26, chb27, chb28, chb29,
                                  chb30, chb31, chb32, chb33, chb34, chb35, chb36, chb37, chb38, chb39,
                                  chb40, chb41, chb42, chb43, chb44, chb45
                              };

            foreach (var checkBox in _checkBoxes)
            {
                checkBox.Number = int.Parse(checkBox.Name.Substring(3, 2));
                checkBox.Text = checkBox.Number.ToString();
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
            }
        }

        public int MaxCheckableCount
        {
            get { return _maxCheckableCount; }
            
            set
            {
                _maxCheckableCount = value;
                nudMaximum.Maximum = value;
                nudMinimum.Maximum = value;

                lblMaxCheckableCount.Text = value.ToString();
            }
        }

        private int CheckedCount
        {
            get { return _checkBoxes.Count(x => x.Checked); }
        }

        public List<int> GetCheckedNumbers()
        {
            return _checkBoxes.Where(x => x.Checked).Select(x => x.Number).ToList();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox) sender;

            if (checkBox.Checked == false)
                return;

            if (CheckedCount > MaxCheckableCount)
                checkBox.Checked = false;
        }

        private readonly CheckBoxEx[] _checkBoxes;
        private int _maxCheckableCount;

        private void btnMaximum_Click(object sender, EventArgs e)
        {
            var args = OnSelectClickedWithReturn(true, Convert.ToInt32(nudMaximum.Value), null);

            foreach (var checkBox in _checkBoxes)
                if (args.Numbers.Contains(checkBox.Number))
                    checkBox.Checked = true;
        }

        private void btnMinimum_Click(object sender, EventArgs e)
        {
            var args = OnSelectClickedWithReturn(false, Convert.ToInt32(nudMinimum.Value), null);

            foreach (var checkBox in _checkBoxes)
                if (args.Numbers.Contains(checkBox.Number))
                    checkBox.Checked = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var checkBox in _checkBoxes)
                checkBox.Checked = false;
        }

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