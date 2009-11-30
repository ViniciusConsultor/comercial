using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.AnalysisServices.AdomdClient;
using System.Diagnostics;

namespace install
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /* CRIANDO BASE SQL SERVER */
                string script = Application.StartupPath + "\\script\\create.sql";
                string bat = Application.StartupPath + "\\script\\exec.bat" + " ";
                string arg = txtServer.Text + " " + txtUsu.Text + " " + txtSenha.Text + " " + script;
                Process.Start(bat, arg);

                /* CRIANDO BASE ANALYSIS SERVICES */


                //Executar script de create dos cubos no BD

                string conexAnalysis = "Provider=MSOLAP.4;Integrated Security=SSPI;Persist Security Info=True;Initial Catalog=;Data Source=" + textBox1.Text;
                AdomdConnection connAnalysis = new AdomdConnection(conexAnalysis);

                FileInfo file2 = new FileInfo("script/Create_Comercial_mart.xmla");
                string script2 = file2.OpenText().ReadToEnd();

                AdomdCommand com = new AdomdCommand();
                com.Connection = connAnalysis;
                com.CommandText = script2;
                connAnalysis.Open();
                com.ExecuteNonQuery();

                MessageBox.Show("Executado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro ao executar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            /*  //Executar script de create das tabelas no BD

            string sqlConnectionString = "Data Source=" + txtServer.Text + ";Initial Catalog=Master;Persist Security Info=True;User ID=" + txtUsu.Text + ";Password=" + txtSenha.Text;

            FileInfo file = new FileInfo("script/create_insert_massa.sql");
            string script = file.OpenText().ReadToEnd();
            SqlConnection conn = new SqlConnection(sqlConnectionString);


            SqlCommand x = new SqlCommand();
            x.Connection = conn;
            x.CommandText = script;
            conn.Open();
            x.ExecuteNonQuery();

            //  -----------------------------------------------

            //Executar script de create das view's no BD

            FileInfo file1 = new FileInfo("script/script view's.sql");
            string script1 = file1.OpenText().ReadToEnd();
            x.Connection = conn;
            x.CommandText = script1;
            x.ExecuteNonQuery();

            //------------------------------------------------------

            //Executar script de create dos cubos no BD

            string conexAnalysis = "Provider=MSOLAP.4;Integrated Security=SSPI;Persist Security Info=True;Initial Catalog=COMERCIAL_MART;Data Source="+textBox1.Text;
            AdomdConnection connAnalysis = new AdomdConnection(conexAnalysis);

            FileInfo file2 = new FileInfo("script/Create_Comercial_mart.xmla");
            string script2 = file2.OpenText().ReadToEnd();

            AdomdCommand com = new AdomdCommand();
            com.Connection = connAnalysis;
            com.CommandText = script2;
            connAnalysis.Open();
            com.ExecuteNonQuery();
           * */
        }
    }
}
