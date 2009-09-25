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
    public partial class frmConCli : Form
    {
        private FrmPrinc _princ = null;

        public frmConCli(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chckdLstBxColunas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tipo_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void chckBxTudo_CheckStateChanged(object sender, EventArgs e)
        {
            
    }

        private void chckBxIE_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chckBxRazaoSocial_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void chckBxEndereco_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chckBxBairro_CheckedChanged(object sender, EventArgs e)
        {
          

        }

        private void chckBxMunicipio_CheckedChanged(object sender, EventArgs e)
        {
  
        }

        private void chckBxCep_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void chckBxUf_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void chckBxTelefone_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chckBxFax_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chckBxEmail_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chckBxPerfil_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chckBxPotencialanual_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chckBxAreaatuacao_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chckBxTudo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtCodPed_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();

        }

        private void txtCodCli_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAreaAtu_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

        private void frmConCli_Leave(object sender, EventArgs e)
        {
            Control[] z = _princ.Controls.Find("bindingNavigator1", true);
            ToolStrip strip = (ToolStrip)z[0];

            strip.Visible = true;

            Control[] y = _princ.Controls.Find("tlStrpConsulta", true);
            ToolStrip strip2 = (ToolStrip)y[0];

            strip2.Visible = false;

        }
        }
    }
