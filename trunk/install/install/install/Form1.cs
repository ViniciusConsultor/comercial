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

            //Executar script de create no BD

            string sqlConnectionString = "Data Source=" + txtServer.Text + ";Initial Catalog=Master;Persist Security Info=True;User ID=" + txtUsu.Text + ";Password=" + txtSenha.Text;

            FileInfo file = new FileInfo("script/create.sql");
            string script = file.OpenText().ReadToEnd();
            SqlConnection conn = new SqlConnection(sqlConnectionString);


            SqlCommand x = new SqlCommand();
            x.Connection = conn;
            x.CommandText = script;
            conn.Open();
            x.ExecuteNonQuery();

        }
    }
}
