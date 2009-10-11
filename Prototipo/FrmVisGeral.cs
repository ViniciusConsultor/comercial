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
    public partial class FrmVisGeral : Form
    {
        private Form _parent;

        public FrmVisGeral(Form parent)
        {
            InitializeComponent();
            _parent = parent;


            if (_parent is FrmCadUsu)
            {



                rdBtnCod.Visible = false;
                rdBtnNome.Text = "Usuário";
                rdBtnNome.Checked = true;

                col1.HeaderText = "Usuário";
                col1.DataPropertyName = "usuario";
                dtGrdVwVis.Columns[1].Visible = false;
            }

            #region ColunasPesquisaCliente
            if (_parent is FrmCadPed)
            {
                rdBtnCod.Visible = true;
                rdBtnCod.Text = "CNPJ";
                rdBtnCod.Checked = true;
                rdBtnNome.Text = "Nome";
                rdBtnNome.Checked = true;

                col1.HeaderText = "CNPJ";
                col1.DataPropertyName = "CNPJ";
                dtGrdVwVis.Columns[1].Visible = true;

                col2.HeaderText = "Razão Social";
                col2.DataPropertyName = "RAZAOSOCIAL";
                dtGrdVwVis.Columns[1].Visible = true;
            }
            #endregion
            /*
                            if (form is FrmCadCli)
                            {
                                rdBtnCod.Text = "Código";
                                rdBtnNome.Text = "Nome";

                                ClmUm.HeaderText = "Código";
                                ClmDois.HeaderText = "Nome";
                            }

                            if (form is FrmCadProd)
                            {
                                rdBtnCod.Text = "Código";
                                rdBtnNome.Text = "Descrição";

                                ClmUm.HeaderText = "Código";
                                ClmDois.HeaderText = "Descrição";
                            }

                            if (form is FrmCadVen)
                            {
                                rdBtnCod.Text = "Código";
                                rdBtnNome.Text = "Nome";

                                ClmUm.HeaderText = "Código";
                                ClmDois.HeaderText = "Nome";
                            }

                            if (form is FrmCadGrpProd)
                            {
                                rdBtnCod.Text = "Código";
                                rdBtnNome.Text = "Descrição";

                                ClmUm.HeaderText = "Código";
                                ClmDois.HeaderText = "Descrição";
                            }

                            if (form is FrmCadConPag)
                            {
                                rdBtnCod.Text = "Código";
                                rdBtnNome.Text = "Descrição";

                                ClmUm.HeaderText = "Código";
                                ClmDois.HeaderText = "Descrição";
                            }

                            if (form is FrmCadTes)
                            {
                                rdBtnCod.Text = "Código";
                                rdBtnNome.Text = "Descrição";

                                ClmUm.HeaderText = "Código";
                                ClmDois.HeaderText = "Descrição";
                            }

                            if (form is FrmCadTra)
                            {
                                rdBtnCod.Text = "Código";
                                rdBtnNome.Text = "Descrição";

                                ClmUm.HeaderText = "Código";
                                ClmDois.HeaderText = "Descrição";
                            }
             * */

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (_parent is FrmCadUsu)
            {

                string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                SqlConnection conn = new SqlConnection(c);
                conn.Open();

                SqlCommand cmd = new SqlCommand("select usuario from usuario where usuario like @usu ", conn);

                cmd.Parameters.Add(new SqlParameter("@usu", txtPesquisar.Text + "%"));

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);

                dtGrdVwVis.DataSource = table;


            }


            if (_parent is FrmCadPed)
            {


                if (rdBtnCod.Checked == true)
                {
                    string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                    SqlConnection conn = new SqlConnection(c);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("select cnpj, razaosocial from CLIENTE where cnpj like @cnpj ", conn);

                    cmd.Parameters.Add(new SqlParameter("@cnpj", txtPesquisar.Text + "%"));

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);

                    dtGrdVwVis.DataSource = table;
                }


                if (rdBtnNome.Checked == true)
                {
                    string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                    SqlConnection conn = new SqlConnection(c);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("select cnpj, razaosocial from CLIENTE where razaosocial like @razaosocial ", conn);

                    cmd.Parameters.Add(new SqlParameter("@razaosocial", txtPesquisar.Text + "%"));

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);

                    dtGrdVwVis.DataSource = table;
                }



            }
        }

        private void dtGrdVwVis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_parent is FrmCadUsu)
            {
                FrmCadUsu usu = (FrmCadUsu)_parent;

                // vamos obter as células selecionadas no DataGridView
                DataGridViewSelectedCellCollection selecionadas = dtGrdVwVis.SelectedCells;

                DataGridViewCell celula = selecionadas[1];
                int linha = celula.RowIndex;
                int coluna = celula.ColumnIndex;


                usu.txtUsu.getText = celula.Value.ToString();

                this.Close();
                this.Dispose();
            }

            if (_parent is FrmCadPed)
            {
                FrmCadPed Ped = (FrmCadPed)_parent;

                // vamos obter as células selecionadas no DataGridView
                DataGridViewSelectedCellCollection selecionadas = dtGrdVwVis.SelectedCells;

                DataGridViewCell celula = selecionadas[0];
                int linha = celula.RowIndex;
                int coluna = celula.ColumnIndex;


                Ped.txtcodCli.getText = celula.Value.ToString();

                this.Close();
                this.Dispose();
            }
        }
    }
}
