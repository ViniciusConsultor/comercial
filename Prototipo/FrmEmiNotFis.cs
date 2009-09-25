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
    public partial class FrmEmiNotFis : Form
        {
        private FrmPrinc _princ = null;

        public FrmEmiNotFis(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

        private void lblNumNotFiscal_Click(object sender, EventArgs e)
            {

            }

        private void groupBox1_Enter_1(object sender, EventArgs e)
            {

            }

        private void FrmEmiNotFis_Leave(object sender, EventArgs e)
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
