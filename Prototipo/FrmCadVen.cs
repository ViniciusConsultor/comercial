using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

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

            if (!string.IsNullOrEmpty(txtUsu.Text) && !string.IsNullOrEmpty(txtSenha.Text))
            {
                COMERCIALDataSetTableAdapters.USUARIOTableAdapter usu = new Comercial.COMERCIALDataSetTableAdapters.USUARIOTableAdapter();
                usu.Insert(txtUsu.Text, txtSenha.Text, "N", "S");
            }

            string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;


             SqlConnection conn = new SqlConnection(c);
                conn.Open();
               
                SqlCommand cmd = new SqlCommand("select * from usuario where usuario = @usu", conn);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@usu";
                param.Value = txtUsu.Text;
                cmd.Parameters.Add(param);
                SqlDataReader reader = cmd.ExecuteReader();
                
                reader.Read();

            DataRowView x;

            x = (DataRowView) vENDEDORBindingSource.Current;

            x["CEP"] = txtcep.getText;
            x["ATIVO"] = "S";
            x["CodUSUARIO"] = reader["codusuario"];

            reader.Dispose();
            reader.Close();

            if (radioButton1.Checked)
            {

                x["SEXO"] = "M";
            }
            else
            {
                x["SEXO"] = "F";
            }

            conn.Close();
            conn.Dispose();

            return 0;
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
            if (vENDEDORBindingSource.Current != null)
            {

                DataRowView v = (DataRowView)vENDEDORBindingSource.Current;

                txtcep.getText = v["CEP"].ToString();

                if (v["SEXO"].ToString() == "M")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
               /* if (!string.IsNullOrEmpty(v["codregiao"].ToString()))
                    cmBxRegiao.SelectedValue = v["codregiao"].ToString();
                else
                    cmBxRegiao.SelectedValue = -1; */
            }
            else
            {
                txtcep.getText = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                cmBxRegiao.SelectedValue = -1;
            }
        }

        
        private void FrmCadVen_Shown(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.REGIAO' table. You can move, or remove it, as needed.
            this.rEGIAOTableAdapter.Fill(this.cOMERCIALDataSet.REGIAO);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.VENDEDOR' table. You can move, or remove it, as needed.
            this.vENDEDORTableAdapter.Fill(this.cOMERCIALDataSet.VENDEDOR);

            cpfToolStripTextBox.Enabled = true;
            nomeToolStripTextBox.Enabled = true;
            toolStripButton1.Enabled = true;
            toolStripButton2.Enabled = true;
            cnsltTlStrpConsulta.Enabled = true;
        }

     
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
           try
            {
                this.vENDEDORTableAdapter.Consulta(this.cOMERCIALDataSet.VENDEDOR, cpfToolStripTextBox.Text, nomeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.vENDEDORTableAdapter.Fill(this.cOMERCIALDataSet.VENDEDOR);

                cnsltTlStrpConsulta.Visible = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            cpfToolStripTextBox.Clear();
            nomeToolStripTextBox.Clear();
        }

    }

}
