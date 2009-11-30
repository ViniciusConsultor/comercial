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
            
         /*   Configuration conf = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            conf.ConnectionStrings.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString = "Outro Valor";
            conf.Save();

            */

            Configuration conf = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            string con = conf.ConnectionStrings.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;
            string[] x = con.Split(';');

            if (x[0] == "Data Source=#local#")
            {

                FrmConf frmConf = new FrmConf();
                frmConf.ShowDialog();
                
                Configuration conf1 = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                conf1.ConnectionStrings.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString =
                    "Data Source="+frmConf.textBox1.Text+";Initial Catalog=COMERCIAL;Persist Security Info=True;User ID=comercial;Password=123*abc";
                conf1.Save();

                Configuration conf2 = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                conf2.ConnectionStrings.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString_Analysis"].ConnectionString =
                    "Provider=MSOLAP.4;Integrated Security=SSPI;Persist Security Info=True;Initial Catalog=COMERCIAL_MART;Data Source="+frmConf.textBox2.Text;
                conf2.Save();

                Application.Exit();
            }
            else
            {

                /* VERIFICAR SE USUARIO E SENHA É VALIDO
                 * 
                 * VERIFICA SE USUARIO ESTA BLOQUEADO
                 * 
                 * VERIFICA SE USUARIO É PRIVILEGIADO, SENAO VERIFICA PERMISSOES.
                 */

                try
                {
                    string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;


                    SqlConnection conn = new SqlConnection(c);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("select * from usuario where usuario = @usu AND SENHA = @SENHA", conn);

                    cmd.Parameters.Add(new SqlParameter("@usu", txtusu.Text));
                    cmd.Parameters.Add(new SqlParameter("@SENHA", txtsenha.Text));

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    int codUsuario = (int)reader.GetValue(0);

                    // verifica se é valido
                    if (reader.HasRows)
                    {
                        //Verifica se nao esta bloqueado
                        if (reader["BLOQUEADO"].ToString() == "S")
                        {
                            MessageBox.Show("Usuário bloqueado, contate o administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //verifica se é privilegiado
                            FrmPrinc princ = new FrmPrinc();
                            if (reader["PRIVILEGIADO"].ToString() == "S")
                            {

                                princ.Show();
                                this.Hide();
                            }
                            else
                            {
                                princ.PermissoesUsuárioToolStripMenuItem.Enabled = false;
                                princ.mineraçãoDeDadosToolStripMenuItem.Enabled = false;
                                princ.atualizaCubosToolStripMenuItem.Enabled = false;

                                princ.Show();
                                this.Hide();
                            }
                            princ.usuarioLogado = codUsuario;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    Validacoes valida = new Validacoes();
                    valida.tratarSystemExceções(ex);

                }
            }



        }
    }
}
