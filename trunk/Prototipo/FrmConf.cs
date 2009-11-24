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
    public partial class FrmConf : Form
    {
        public FrmConf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A aplicação será fechada, entre novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void FrmConf_Load(object sender, EventArgs e)
        {

        }
    }
}
