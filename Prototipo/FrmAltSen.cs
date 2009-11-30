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
    public partial class FrmAltSen : Form
    {
          private FrmPrinc _princ = null;

        public FrmAltSen(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsu_Click(object sender, EventArgs e)
        {

        }

        private void txtUsu_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.Text = "Pesquisa Cadastro de Usuário";
            x.ShowDialog();
        }

        internal int salvar()
        {
            if (!string.IsNullOrEmpty(txtUsu.getText))
            {
                //verificar se senha antiga esta certa...
                //se sim update no usuario e deleta todas permissoes e insere de novo...

                string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;


                SqlConnection conn = new SqlConnection(c);
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from usuario where usuario = @usu and senha = @senha", conn);
                cmd.Parameters.Add(new SqlParameter("@usu", txtUsu.getText));
                cmd.Parameters.Add(new SqlParameter("@senha", txtSenhaAtual.Text));

                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                if (reader.HasRows)
                {
                    //confere senha
                    if (txtConfSenha.Text != txtNovaSenha.Text)
                    {
                        conn.Close();
                        MessageBox.Show("Senha digitada não confere.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 1;
                    }
                    else
                    {

                        
                        SqlConnection conn1 = new SqlConnection(c);
                        conn1.Open();

                        SqlCommand cmd1 = new SqlCommand("update usuario set " +
                                                            "SENHA = @senha where usuario = @usu", conn1);
                        cmd1.CommandType = CommandType.Text;
                        cmd1.Parameters.Add(new SqlParameter("@usu", txtUsu.getText));
                        cmd1.Parameters.Add(new SqlParameter("@senha", txtConfSenha.Text));
                        

                        cmd1.ExecuteNonQuery();

                        
                        conn1.Close();

                        return 0;
                    }
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Senha não confere com usuário selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }

            }
            else
            {
                MessageBox.Show("Usuário não selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }


        
        }

        private void lblSenhaNova_Click(object sender, EventArgs e)
        {

        }
    }
}
