using System;
using System.Windows.Forms;

namespace Comercial
{
    public partial class FrmMinCon : Form
    {
        private FrmPrinc _princ = null;

        public FrmMinCon(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        private void FrmMinCon_Leave(object sender, EventArgs e)
        {
            Control[] z = _princ.Controls.Find("bindingNavigator1", true);
            ToolStrip strip = (ToolStrip)z[0];

            strip.Visible = true;

            Control[] y = _princ.Controls.Find("tlStrpProcesso", true);
            ToolStrip strip2 = (ToolStrip)y[0];

            strip2.Visible = false;

            foreach (ToolStripButton x in strip2.Items)
            {
                x.Visible = false;
            }
        }
    }
}
