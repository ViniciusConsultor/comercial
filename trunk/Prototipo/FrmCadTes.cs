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
    public partial class FrmCadTes : Form
        {
       private FrmPrinc princ = null;

        public FrmCadTes(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            princ = parent;
        }

        private void Form5_Load(object sender, EventArgs e)
            {

            }
        }
    }
