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
    public partial class FrmAtuCubo : Form
    {
        private FrmPrinc _princ = null;
        public FrmAtuCubo(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
            this.Enabled = true;
        }

        private void tbPgHistorico_Click(object sender, EventArgs e)
        {

        }

        private void FrmatuCubo_Load(object sender, EventArgs e)
        {
            string sql = "select atu.NRATUALIZACAO,usu.USUARIO,atu.DATAATUALIZACAO from ATUCUBO atu, USUARIO usu where atu.CODUSUARIO=usu.CODUSUARIO order by atu.DATAATUALIZACAO desc ";
            string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(c);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);


            dtgrdAtuCubo.DataSource = table;
            conn.Close();


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void FrmAtuCubo_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnAtuCubo_Click(object sender, EventArgs e)
        {
            string sql = "select atu.NRATUALIZACAO,usu.USUARIO,atu.DATAATUALIZACAO from ATUCUBO atu, USUARIO usu where atu.CODUSUARIO=usu.CODUSUARIO order by atu.DATAATUALIZACAO desc ";
            string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(c);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            
        }
        }
 }
