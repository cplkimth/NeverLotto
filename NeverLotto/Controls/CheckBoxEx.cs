#region
using System.ComponentModel;
using System.Windows.Forms;

#endregion

namespace NeverLotto.Controls
{
    public class CheckBoxEx : CheckBox
    {
        [DefaultValue(0)]
        public int Number { get; set; }
    }
}