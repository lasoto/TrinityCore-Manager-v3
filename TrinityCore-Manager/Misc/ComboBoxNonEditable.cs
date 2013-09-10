using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace TrinityCore_Manager.Misc
{
    class ComboBoxNonEditable : ComboBoxEx
    {
        public ComboBoxNonEditable()
        {
            DrawMode = DrawMode.Normal;
            KeyPress += ComboBoxNonEditable_KeyPress;
        }

        private void ComboBoxNonEditable_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
