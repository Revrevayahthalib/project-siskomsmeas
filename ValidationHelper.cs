using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_ITSoftware
{
    public static class ValidationHelper
    {
        private static string GetInputText(Control ctrl)
        {
            if(ctrl is TextBox txt) return txt.Text;
            if (ctrl is RichTextBox rtb) return rtb.Text;
            if (ctrl is NumericUpDown num) return num.Text;
            if (ctrl is ComboBox cmb) return cmb.Text;
            if(ctrl is DateTimePicker dtp) return dtp.Text;

            return null;
        }

        public static bool ValidateAllRequired(Control.ControlCollection controls, List<Control> exclude=null)
        {
            foreach(Control ctrl in controls)
            {
                if (exclude != null && exclude.Contains(ctrl))
                    continue;
                string text = GetInputText(ctrl);
                if(text != null && string.IsNullOrWhiteSpace(text))
                {
                    string label = string.IsNullOrEmpty(ctrl.Tag?.ToString())
                        ? ctrl.Name
                        : ctrl.Tag.ToString();
                    MessageBox.Show($"{label} belum terisi, mohon lengkapi");
                    ctrl.Focus();
                    return false;
                }
                if(ctrl.HasChildren)
                {
                    if (!ValidateAllRequired(ctrl.Controls))
                        return false;
                }
            }
            return true;
        }
    }
}
