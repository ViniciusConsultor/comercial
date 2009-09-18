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
    public partial class FrmAltSen : Form
    {
          private FrmPrinc _princ = null;

        public FrmAltSen(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
