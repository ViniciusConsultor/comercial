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
    public partial class FrmPesPedNF : Form
        {
         private FrmPrinc princ = null;

        public FrmPesPedNF(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            princ = parent;
        }
       

        private void GrpBxPesPedNF_Enter(object sender, EventArgs e)
            {

            }
        }
    }
