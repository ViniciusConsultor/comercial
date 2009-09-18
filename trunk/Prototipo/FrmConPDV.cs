using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comercial
{
    public partial class FrmConPDV : Form
    {
        private FrmPrinc _princ = null;

        public FrmConPDV(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        private void txtCodPed_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

        private void txtBtnCodCli_ButtonClick(object sender, EventArgs e)
        {

            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

        private void tbPgConCli_Click(object sender, EventArgs e)
        {

        }

        private void FrmConPDV_Leave(object sender, EventArgs e)
        {
            Control[] z = _princ.Controls.Find("tlStrpPrinc", true);
            ToolStrip strip = (ToolStrip)z[0];

            strip.Visible = true;

            Control[] y = _princ.Controls.Find("tlStrpConsulta", true);
            ToolStrip strip2 = (ToolStrip)y[0];

            strip2.Visible = false;
        }

    }
}
