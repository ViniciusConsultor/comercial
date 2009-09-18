using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comercial.Util
{
    public class Interface
    {
        public static void ChangeControlStatus(Control c, bool status)
        {
            foreach (Control ctrl in c.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Enabled = status;
                else if (ctrl is Button)
                    ((Button)ctrl).Enabled = status;
                else if (ctrl is RadioButton)
                    ((RadioButton)ctrl).Enabled = status;
                else if (ctrl is CheckBox)
                    ((CheckBox)ctrl).Enabled = status;
                else if (ctrl is ComboBox)
                    ((ComboBox)ctrl).Enabled = status;
                else if (ctrl is MaskedTextBox)
                    ((MaskedTextBox)ctrl).Enabled = status;
                if (ctrl.HasChildren)
                    ChangeControlStatus(ctrl, status);

            }
        }

        public static void ResetControls(Control c)
        {
            foreach (Control ctrl in c.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                else if (ctrl is RadioButton)
                    ((RadioButton)ctrl).Checked = false;
                else if (ctrl is CheckBox)
                    ((CheckBox)ctrl).Checked = false;
                else if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedIndex = -1;
                //else if (ctrl is Label)
                //    ((Label)ctrl).Text = string.Empty;
                else if (ctrl is MaskedTextBox)
                    ((MaskedTextBox)ctrl).Text = string.Empty;
                if (ctrl.HasChildren)
                    ResetControls(ctrl);
            }
        }

    }
}
