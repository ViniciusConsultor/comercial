using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Comercial
{
    public partial class FrmPermissoesUsu : Form
    {
        private FrmPrinc princ = null;

        public FrmPermissoesUsu(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            princ = parent;
        }

        public int salvar()
        {

            if (!string.IsNullOrEmpty(txtUsu.getText))
            {
                string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

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
                                                    " PRIVILEGIADO = @priv, " +
                                                    "BLOQUEADO = @bloq where usuario = @usu", conn1);
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.Add(new SqlParameter("@usu", txtUsu.getText));
                cmd1.Parameters.Add(new SqlParameter("@priv", priv));
                cmd1.Parameters.Add(new SqlParameter("@bloq", bloq));

                cmd1.ExecuteNonQuery();

                


                conn1.Close();

                return 0;
  
            }
            else
            {
                MessageBox.Show("Usuário não selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }


        }
        
        private void txtBtnUsu_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.Text = "Pesquisa Cadastro de Usuário";
            x.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMarAll_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDesAll_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmPermissoesUsu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.cOMERCIALDataSet.USUARIO);

        }

        private void FrmPermissoesUsu_Shown(object sender, EventArgs e)
        {
            princ.tsbhomeProcesso.Visible = true;
        }

        private void FrmPermissoesUsu_Leave(object sender, EventArgs e)
        {
            princ.tlStrpProcesso.Visible = false;
            princ.bindingNavigator1.Visible = true;
        }

        private void trVwMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
