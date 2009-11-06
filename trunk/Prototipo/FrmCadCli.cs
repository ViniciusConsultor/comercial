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
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;


namespace Comercial
{
    
    public partial class FrmCadCli : Form
    {
       private FrmPrinc _princ = null;
        


        public FrmCadCli(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
            _princ.bindingNavigator1.BindingSource = cLIENTEBindingSource;
            _princ.setdataSet(cOMERCIALDataSet);
            _princ.novo();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cLIENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void FrmCadCli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.REGIAO' table. You can move, or remove it, as needed.
            this.rEGIAOTableAdapter.Fill(this.cOMERCIALDataSet.REGIAO);
            /*// TODO: This line of code loads data into the 'cOMERCIALDataSet.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.cOMERCIALDataSet.USUARIO);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.cOMERCIALDataSet.CLIENTE);*/

        }

        private void FrmCadCli_Shown(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.cOMERCIALDataSet.USUARIO);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.cOMERCIALDataSet.CLIENTE);
        }
        
        //[DllImport("C:\\dllInscE32.dll")]
        [DllImport("//dllInscE32.dll")]
        
        


        

        public static extern int ConsisteInscricaoEstadual(string ie, string uf);

        public int salvar(bool edit)
        {


            DataRowView x;
            x = (DataRowView)cLIENTEBindingSource.Current;
            Validacoes valida = new Validacoes();
            string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

            //Valida CNPJ
            if (!String.IsNullOrEmpty(txtCnpjCli.Text) && txtCnpjCli.Text.Trim().Length == 14)
            {

                int cnpj = valida.ValidaCNPJ(txtCnpjCli.Text);

                if (cnpj == 1)
                {
                    //MessageBox.Show("CNPJ Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return 1;
                    throw new Exception("cnpj invalido");

                }
            }
            else
            {
                throw new Exception("cnpj invalido");
            }
            // Valida IE
            if (!String.IsNullOrEmpty(txtIeCli.Text))
            {


                string ie = txtIeCli.Text;
                string uf = cmbUfCli.SelectedItem.ToString();
                int returnIe = ConsisteInscricaoEstadual(ie, uf);
                if (returnIe == 1)
                {
                    //MessageBox.Show("I.E. Inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      //return 1;
                    throw new Exception("ie invalida");
                }
                //if (string.IsNullOrEmpty(txtRazaoSocialCli.Text))
                //{
                //    MessageBox.Show("Campo(s) obrigatório(s) não preenchido(s).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return 1;
                //}
            }

            // Valida limite de crédito
           // string va = txtLimCredCli.Te
            if(!String.IsNullOrEmpty(txtLimCredCli.Text))
            {
                double valor = double.Parse(txtLimCredCli.Text,System.Globalization.NumberStyles.Currency);
                if (valor<=0)
                {
                    throw new Exception("valor invalido");
                }
            }

            // Valida email

            if (!string.IsNullOrEmpty(txtEmailCli.Text))
            {
                Boolean emailOk = valida.ValidaEmail(txtEmailCli.Text);
                if (emailOk == false)
                {
                    //MessageBox.Show("Email Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return 1;
                    throw new Exception("email invalido");
                }



                #region Salva Usuario
                if (edit == false)
                {

                    if (!string.IsNullOrEmpty(txtUsuarioCli.Text) && !string.IsNullOrEmpty(txtSenhaCli.Text))
                    {

                        SqlConnection conn = new SqlConnection(c);
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("select * from usuario where usuario = @usu", conn);
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@usu";
                        param.Value = txtUsuarioCli.Text;
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
                            usu.Insert(txtUsuarioCli.Text, txtSenhaCli.Text, "N", "S");
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
                    param1.Value = txtUsuarioCli.Text;
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
                if (chckBxCred.Checked)
                {

                    x["APROVADOCRED"] = "S";
                }
                else
                {
                    x["APROVADOCRED"] = "N";
                }
                x["CEP"] = txtCepCli.getText;

                txtSenhaCli.Text = "";
                txtUsuarioCli.Text = "";

                
            }
            return 0;
        }
        private void cLIENTEBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (cLIENTEBindingSource.Current != null)
            {
                DataRowView c = (DataRowView)cLIENTEBindingSource.Current;

                txtCepCli.getText = c["CEP"].ToString();

                if (c["APROVADOCRED"].ToString() == "S")
                {
                    chckBxCred.Checked = true;
                }
                else
                {
                    chckBxCred.Checked = false;
                }
                cmbAreaAtuCli.SelectedValue = c["AREAATUACAO"].ToString();
            }
            else
            {
                txtCepCli.getText = "";
                chckBxCred.Checked = false;
                cmbAreaAtuCli.SelectedValue = -1;
                cmbUfCli.SelectedValue = -1;
            }

            /*if (!string.IsNullOrEmpty(cLIENTETableAdapter.Container.Components["codregiao"].ToString()))
                cmBxRegiaoCli.SelectedValue = cLIENTETableAdapter.Container.Components["codregiao"].ToString();
            else
                cmBxRegiaoCli.SelectedValue = -1;*/
                       


        }

        private void chckBxCred_CheckedChanged(object sender, EventArgs e)
        {
            if(txtBairroCli.Enabled==true)
            {
                if (chckBxCred.Checked)
                {

                    txtLimCredCli.Enabled = true;
                }
                else
                {
                    txtLimCredCli.Enabled = false;
                    txtLimCredCli.Text = null;
                }
            }
        }

        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.cLIENTETableAdapter.Consulta(this.cOMERCIALDataSet.CLIENTE, cnpjToolStripTextBox.Text, nomeFantasiaToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            cnpjToolStripTextBox.Clear();
            nomeFantasiaToolStripTextBox.Clear();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           try
            {
                this.cLIENTETableAdapter.Fill(this.cOMERCIALDataSet.CLIENTE);

                cnsltTlStrpConsultaCli.Visible = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }

        private void consultaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cLIENTETableAdapter.Consulta(this.cOMERCIALDataSet.CLIENTE, cnpjToolStripTextBox.Text, nomeFantasiaToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txtRazaoSocialCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCepCli_ButtonClick(object sender, EventArgs e)
        {
        }
            
        private void txtCepCli_ButtonClick_1(object sender, EventArgs e)
        {
             Validacoes v = new Validacoes();

            string cep = v.procuraCEP(txtCepCli.getText);

            if (cep != "")
            {
                string[] x = cep.Split(';');

                txtMunicipioCli.Text = x[0];
                cmbUfCli.Text = x[1];
                txtBairroCli.Text = x[2];
                txtEndCli.Text = x[3];

                if (!String.IsNullOrEmpty(txtEndCli.Text))
                    txtEndCli.Focus();
                else
                    txtNumCli.Focus();
            }
            else
            {
                MessageBox.Show("CEP não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndCli.Focus();
            }
        }

        private void txtLimCredCli_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCnpjCli_Leave(object sender, EventArgs e)
        {
             Validacoes v = new Validacoes();
            
            if (!string.IsNullOrEmpty(txtCnpjCli.Text) && txtCnpjCli.Text.Length==14)
            {
                if (v.ValidaCNPJ(txtCnpjCli.Text) == 1)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    txtCnpjCli.Focus();
                }
                else
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                }
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                txtCnpjCli.Focus();
            }
        }

        

        }
      }
  

