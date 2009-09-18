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
    
    public partial class FrmCadCli : Form
    {
       private FrmPrinc princ = null;

        public FrmCadCli(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            princ = parent;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbpCadCli_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
