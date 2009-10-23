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
            _princ.novo();
        }
        /*
         * SALVAR RETORNA:
         * 0 - OK
         * 1 - ERRO
         */
        public int salvar(bool edit)
        {

            #region Validaçoes

            //Valida CPFe email

            string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

            Validacoes valida = new Validacoes();

            if (!string.IsNullOrEmpty(txtCPF.Text))
            {
                int cpf = valida.ValidaCPF(txtCPF.Text);

                bool email = true;
                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    email = valida.ValidaEmail(txtEmail.Text);
                }
                

                if (cpf == 1)
                {
                    MessageBox.Show("CPF Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }


                if (email == false)
                {
                    MessageBox.Show("E-mail Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
            }
            else
            {
                throw new Exception("campo vazio");
            }
            #endregion

            DataRowView x;
            x = (DataRowView)vENDEDORBindingSource.Current;

            #region Salva Usuario
            if (edit == false)
            {

                if (!string.IsNullOrEmpty(txtUsu.Text) && !string.IsNullOrEmpty(txtSenha.Text))
                {

                    SqlConnection conn = new SqlConnection(c);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("select * from usuario where usuario = @usu", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@usu";
                    param.Value = txtUsu.Text;
                    cmd.Parameters.Add(param);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("Usuário ja cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 1;
                    }
                    else
                    {
                        COMERCIALDataSetTableAdapters.USUARIOTableAdapter usu = new Comercial.COMERCIALDataSetTableAdapters.USUARIOTableAdapter();
                        usu.Insert(txtUsu.Text, txtSenha.Text, "N", "S");
                    }

                    reader.Dispose();
                    reader.Close();
                    conn.Close();
                    conn.Dispose();
                }


                SqlConnection conn1 = new SqlConnection(c);
                conn1.Open();

                SqlCommand cmd1 = new SqlCommand("select * from usuario where usuario = @usu", conn1);
                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@usu";
                param1.Value = txtUsu.Text;
                cmd1.Parameters.Add(param1);
                SqlDataReader reader1 = cmd1.ExecuteReader();

                reader1.Read();

                x["CodUSUARIO"] = reader1["codusuario"];

                reader1.Dispose();
                reader1.Close();

                conn1.Close();
                conn1.Dispose();

            }

            #endregion

            x["CEP"] = txtcep.getText;
            x["ATIVO"] = "S";

            if (radioButton1.Checked)
            {

                x["SEXO"] = "M";
            }
            else
            {
                x["SEXO"] = "F";
            }

            return 0;

        }


        private void textButton1_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
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

        private void FrmCadVen_Load(object sender, EventArgs e)
        {

        }

        private void txtcep_ButtonClick(object sender, EventArgs e)
        {
            Validacoes v = new Validacoes();

            string cep = v.procuraCEP(txtcep.getText);

            if (cep != "")
            {
                string[] x = cep.Split(';');

                txtMunicipio.Text = x[0];
                cmbUfCli.Text = x[1];
                txtBairro.Text = x[2];
                txtEndereco.Text = x[3];

                txtnum.Focus();
            }
            else
            {
                MessageBox.Show("CEP não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
            }
        }

    }

}
