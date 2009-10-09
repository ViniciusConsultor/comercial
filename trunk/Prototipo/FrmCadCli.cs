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

        public int salvar()
        {
            //Valida CNPJ

            DataRowView x;
            x= (DataRowView) cLIENTEBindingSource.Current;
            Validacoes valida = new Validacoes();
            int cnpj = valida.ValidaCNPJ(txtCnpjCli.Text);

            if (cnpj == 1)
            {
                MessageBox.Show("CNPJ Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            // Valida email

            if(!string.IsNullOrEmpty(txtEmailCli.Text))
            {
                Boolean emailOk = valida.ValidaEmail(txtEmailCli.Text);
                if (emailOk == false)
                {
                   MessageBox.Show("Email Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return 1;
                }
            }
            #region Validação de campos vazios ou nulos
            
            
            if (string.IsNullOrEmpty(txtRazaoSocialCli.Text))
            {
                MessageBox.Show("Campo(s) obrigatório(s) não preenchido(s).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            if (string.IsNullOrEmpty(txtNomeFantCli.Text))
            {
                MessageBox.Show("Campo(s) obrigatório(s) não preenchido(s).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            if (string.IsNullOrEmpty(txtIeCli.Text))
            {
                MessageBox.Show("Campo(s) obrigatório(s) não preenchido(s).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }

            #endregion

            if (!string.IsNullOrEmpty(txtUsuarioCli.Text) && !string.IsNullOrEmpty(txtSenhaCli.Text))
            {
                COMERCIALDataSetTableAdapters.USUARIOTableAdapter usu = new Comercial.COMERCIALDataSetTableAdapters.USUARIOTableAdapter();
                usu.Insert(txtUsuarioCli.Text, txtSenhaCli.Text, "N", "S");
            }

            string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;


            SqlConnection conn = new SqlConnection(c);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from usuario where usuario = @usu", conn);
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@usu";
            param.Value = txtUsuarioCli.Text;
            cmd.Parameters.Add(param);
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

             if (chckBxCred.Checked)
            {
                 
               x["APROVADOCRED"] = "S";
            }
            else
            {
                x["APROVADOCRED"] = "N";
            }
            x["CEP"] = txtCepCli.getText;

            x["CodUSUARIO"] = reader["codusuario"];

            reader.Dispose();
            reader.Close();
             
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
            /*if (chckBxCred.Checked)
            {
                
                txtLimCredCli.Enabled = true;
            }
            else txtLimCredCli.Enabled = false;*/
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
    }
}
