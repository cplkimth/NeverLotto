#region
using System.Collections.Generic;
using System.Windows.Forms;
using NeverLotto.Engine;

#endregion

namespace NeverLotto.Controls
{
    public partial class GridControl : UserControl
    {
        public GridControl()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<Result> list)
        {
            list.Sort((x, y) => y.No.CompareTo(x.No));

            bdsList.DataSource = new SortableBindingList<Result>(list);
        }
    }
}