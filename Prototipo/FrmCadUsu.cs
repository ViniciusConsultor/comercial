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
    public partial class FrmCadUsu : Form
    {
        private FrmPrinc princ = null;

        public FrmCadUsu(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            princ = parent;
        }

        public int salvar()
        {
         
                //verificar se senha antiga esta certa...
                //se sim update no usuario e deleta todas permissoes e insere de novo...

                string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;


                SqlConnection conn = new SqlConnection(c);
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from usuario where usuario = @usu and senha = @senha", conn);
                cmd.Parameters.Add(new SqlParameter("@usu", txtUsu.getText));
                cmd.Parameters.Add(new SqlParameter("@usu", txtBxSenhaAntiga.Text));

                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                if (reader.HasRows)
                {
                    //confere senha
                    if (txtConSenha.Text != txtSenha.Text)
                    {
                        MessageBox.Show("Senha digitado errado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 1;
                    }
                    else
                    {

                        //update usuario
                        string priv, bloq;

                        if (chckBxPriv.Checked)
                        {
                            priv = "S";
                        }
                        else
                        {
                            priv = "N";
                        }

                        if (chckBxUsublq.Checked)
                        {
                            bloq = "S";
                        }
                        else
                        {
                            bloq = "N";
                        }

                        SqlConnection conn1 = new SqlConnection(c);
                        conn1.Open();

                        SqlCommand cmd1 = new SqlCommand("update usuario set " +
                                                            "SENHA = @senha, PRIVILEGIADO = @priv, " +
                                                            "BLOQUEADO = @bloq where usuario = @usu", conn);
                        cmd1.CommandType = CommandType.Text;
                        cmd1.Parameters.Add(new SqlParameter("@usu", txtUsu.getText));
                        cmd1.Parameters.Add(new SqlParameter("@senha", txtConSenha.Text));
                        cmd1.Parameters.Add(new SqlParameter("@priv", priv));
                        cmd1.Parameters.Add(new SqlParameter("@bloq", bloq));

                        cmd1.ExecuteNonQuery();

                        //deleta todas permissoes do usuario

                        cmd1.CommandText = "delete from acesso where codusuario = @usu";
                        cmd1.CommandType = CommandType.Text;
                        cmd1.Parameters.Add(new SqlParameter("@usu", txtUsu.getText));
                        cmd1.ExecuteNonQuery();

                        //cria novamente todas permissoes do usuario

                        // ***** ARRUMAR *****

                        conn1.Close();

                        return 0;
                    }
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Senha não confere com usuário selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void txtBtnUsu_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.Text = "Pesquisa Cadastro de Usuário";
            x.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMarAll_Click(object sender, EventArgs e)
        {
            foreach (TreeNode n in trVwMenu.Nodes)
            {
                foreach (TreeNode nn in n.Nodes)
                {
                    nn.Checked = true;

                    foreach (TreeNode nnn in nn.Nodes)
                    {
                        nnn.Checked = true;

                        foreach (TreeNode nnnn in nnn.Nodes)
                        {
                            nnnn.Checked = true;
                        }
                    }
                }
                n.Checked = true;
            }
        }

        private void btnDesAll_Click(object sender, EventArgs e)
        {
            foreach (TreeNode n in trVwMenu.Nodes)
            {
                foreach (TreeNode nn in n.Nodes)
                {
                    nn.Checked = false;

                    foreach (TreeNode nnn in nn.Nodes)
                    {
                        nnn.Checked = false;

                        foreach (TreeNode nnnn in nnn.Nodes)
                        {
                            nnnn.Checked = false;
                        }
                    }
                }
                n.Checked = false;
            }
        }

        private void FrmCadUsu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.cOMERCIALDataSet.USUARIO);

        }

        private void FrmCadUsu_Shown(object sender, EventArgs e)
        {
            //princ.btnSalvar.Enabled = true;
        }

        private void uSUARIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSUARIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }
    }
}
