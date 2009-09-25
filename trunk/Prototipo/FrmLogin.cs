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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtusu.Text == "admin" && txtsenha.Text == "123")
            {
                FrmPrinc princ = new FrmPrinc();
                princ.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
