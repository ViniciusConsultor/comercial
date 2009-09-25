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
    public partial class FrmCadVen : Form
    {
        private FrmPrinc _princ = null;

        public FrmCadVen(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
            _princ.bindingNavigator1.BindingSource = vENDEDORBindingSource;
            _princ.setdataSet(cOMERCIALDataSet);
        }
        /*
         * SALVAR RETORNA:
         * 0 - OK
         * 1 - ERRO
         */
        public int salvar()
        {
            //Valida CPF

            Validacoes valida = new Validacoes();
            int cpf = valida.ValidaCPF(txtCPF.Text);

            if (cpf == 1)
            {
                MessageBox.Show("CPF Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
/*
            if (!string.IsNullOrEmpty(txtUsu.Text) && !string.IsNullOrEmpty(txtSenha.Text))
            {
                COMERCIALDataSetTableAdapters.USUARIOTableAdapter usu = new Comercial.COMERCIALDataSetTableAdapters.USUARIOTableAdapter();
                usu.Insert(txtUsu.Text, txtSenha.Text, "N", "S");
            }

            COMERCIALDataSet c = new COMERCIALDataSet();

            if (radioButton1.Checked)
            {
                x.SEXO = "M";
            }
            else
            {
                x.SEXO = "F";
            } */
            return 0;
        }

        private void FrmCadVen_Load(object sender, EventArgs e)
        {



        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblUF_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textButton1_Click(object sender, EventArgs e)
        {

        }

        private void textButton1_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

        private void vENDEDORBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vENDEDORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void vENDEDORBindingSource_PositionChanged(object sender, EventArgs e)
        {
            // COMERCIALDataSet dt = (COMERCIALDataSet) vENDEDORBindingSource.Current;

            /*  txtcep.getText = vENDEDORTableAdapter.GetData().Columns["CEP"];



              if (vENDEDORTableAdapter.Container.Components["SEXO"].ToString() == "M")
              {
                  radioButton1.Checked = true;
              }
              else
              {
                  radioButton2.Checked = true;
              }
              if (!string.IsNullOrEmpty(vENDEDORTableAdapter.Container.Components["codregiao"].ToString()))
                  cmBxRegiao.SelectedValue = vENDEDORTableAdapter.Container.Components["codregiao"].ToString();
              else
                  cmBxRegiao.SelectedValue = -1;
              */
        }

        private void cpfToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void FrmCadVen_Shown(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.REGIAO' table. You can move, or remove it, as needed.
            this.rEGIAOTableAdapter.Fill(this.cOMERCIALDataSet.REGIAO);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.VENDEDOR' table. You can move, or remove it, as needed.
            this.vENDEDORTableAdapter.Fill(this.cOMERCIALDataSet.VENDEDOR);

            cpfToolStripTextBox.Enabled = true;
            consultaCPFToolStrip.Enabled = true;
        }

        private void consultaCPFToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.vENDEDORTableAdapter.consultaCPF(this.cOMERCIALDataSet.VENDEDOR, cpfToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void consultaNomeToolStripButton_Click(object sender, EventArgs e)
        {


        }

    }

}
