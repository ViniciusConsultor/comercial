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
    public partial class FrmCadConPag : Form
        {
         private FrmPrinc princ = null;

        public FrmCadConPag(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            princ = parent;
        }

        private void tabPage1_Click(object sender, EventArgs e)
            {

            }
        }
    }
