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
    public partial class FrmConVen : Form
    {
       private FrmPrinc _princ = null;

        public FrmConVen(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmConVen_Leave(object sender, EventArgs e)
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
