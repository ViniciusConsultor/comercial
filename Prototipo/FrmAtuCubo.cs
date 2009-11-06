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
    public partial class FrmAtuCubo : Form
    {
        private FrmPrinc _princ = null;
        public FrmAtuCubo(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        private void tbPgHistorico_Click(object sender, EventArgs e)
        {

        }

        private void FrmatuCubo_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;

        }
    }
}
