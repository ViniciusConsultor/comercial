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
            /* VERIFICAR SE USUARIO E SENHA É VALIDO
             * 
             * VERIFICA SE USUARIO ESTA BLOQUEADO
             * 
             * VERIFICA SE USUARIO É PRIVILEGIADO, SENAO VERIFICA PERMISSOES.
             */

            string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;


            SqlConnection conn = new SqlConnection(c);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from usuario where usuario = @usu AND SENHA = @SENHA", conn);

            cmd.Parameters.Add(new SqlParameter("@usu",txtusu.Text));
            cmd.Parameters.Add(new SqlParameter("@SENHA", txtsenha.Text));

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            // verifica se é valido
            if (reader.HasRows)
            {
                //Verifica se nao esta bloqueado
                if(reader["BLOQUEADO"].ToString() == "S")
                {
                    MessageBox.Show("Usuário bloqueado, contate o administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //verifica se é privilegiado
                    if(reader["PRIVILEGIADO"].ToString() == "S")
                    {
                        FrmPrinc princ = new FrmPrinc();
                        princ.Show();
                        this.Hide();
                    }
                    else
                    {
                        // *** ARRUMAR verifica regras ***
                        //========================================
                        FrmPrinc princ = new FrmPrinc();
                        princ.Show();
                        this.Hide();
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
