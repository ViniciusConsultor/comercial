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
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace Comercial
{
    public partial class FrmConEstProd : Form
    {
        private FrmPrinc _princ = null;

        public FrmConEstProd(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }


        private void txtCodProd_ButtonClick(object sender, EventArgs e)
        {
           // FrmVisGeral x = new FrmVisGeral(this, txtCodProd);
           // x.ShowDialog();
        }

        private void FrmConProd_Leave(object sender, EventArgs e)
        {
            Control[] z = _princ.Controls.Find("bindingNavigator1", true);
            ToolStrip strip = (ToolStrip)z[0];

            strip.Visible = true;

            Control[] y = _princ.Controls.Find("tlStrpConsulta", true);
            ToolStrip strip2 = (ToolStrip)y[0];

            strip2.Visible = false;
        }

        public string pesquisar()
        {
            string sql = "SELECT CODPRODUTO,PRD.DESCRICAO,PRD.DATACADASTRO,PRD.ESTOQUEMIN,PRECOCUSTO,PRD.CODGRUPOPRODUTO,GRP.DESCRICAO AS GRPDESC,PRD.ESTOQUEATUAL " +
                "FROM PRODUTO PRD INNER JOIN GRUPOPRODUTO GRP ON PRD.CODGRUPOPRODUTO = GRP.CODGRUPOPRODUTO ";

            //Pesquisa por Código do produto
            if (!string.IsNullOrEmpty(txtCodProd.getText))
            {
                sql += "and CODPRODUTO ='" + txtCodProd.getText + "'";
            }

            //Pesquisa por descrição do produto
            if (!string.IsNullOrEmpty(txtProdDesc.Text))
            {
                sql += "and PRD.descricao like '%" + txtProdDesc.Text + "%' ";
            }

            //Pesquisa por data
            if (dtTPckrDtCadastro.Checked)
            {
                string formatData = dtTPckrDtCadastro.Value.Year + "-" + dtTPckrDtCadastro.Value.Month + "-" + dtTPckrDtCadastro.Value.Day;
                sql += "and PRD.datacadastro = '" + formatData + "'";
            }

            //Pesquisa por saldo atual de estoque utilizando operadores 
            if (!string.IsNullOrEmpty(txtEstoque.Text))
            {
                sql += "and PRD.estoqueatual " + cmBxOpEstoque.Text + " " + txtEstoque.Text;
            }

            //Pesquisa por saldo estoque minimo utilizando operadores 
            if (!string.IsNullOrEmpty(TxtEstMin.Text))
            {
                sql += "and PRD.ESTOQUEMIN " + cmBxOpEstoqueMin.Text + " " + TxtEstMin.Text;
            }

            //Pesquisa por grupo de produto
            string regiao = cmbGrupoProd.Text;
            if (regiao == "Todos")
            {
                sql=  "SELECT CODPRODUTO,DESCRICAO,DATACADASTRO,ESTOQUEMIN,PRECOCUSTO,CODGRUPOPRODUTO,ESTOQUEATUAL " +
                "FROM PRODUTO ";
            }
            else
            {
                if (!string.IsNullOrEmpty(cmbGrupoProd.Text))
                {
                    sql += "and GRP.DESCRICAO = '" + cmbGrupoProd.Text + "'";
                }
            }
            string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(c);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dtGrdVwConProd.DataSource = table;
            return sql;
        }
    
    

        private void txtCodGrp_ButtonClick(object sender, EventArgs e)
        {
           // FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
           // x.dtGrdVwVis.DataSource = ListarGrupoProduto();
           // x.Text = "Pesquisa Produtos";

           // x.ShowDialog();
        }

        public DataTable ListarGrupoProduto()
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select codgrupoproduto, descricao from grupoproduto");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];

        }

        public DataTable ListarProduto()
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select codproduto, descricao from produto");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];

        }

        private void txtNumPed_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.dtGrdVwVis.DataSource = ListarProduto();
            x.Text = "Pesquisa Estoque de Produtos";

            x.ShowDialog();
        }

        private void gRUPOPRODUTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gRUPOPRODUTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void FrmConEstProd_Load(object sender, EventArgs e)
        {

        }

        private void gRUPOPRODUTOBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.gRUPOPRODUTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void FrmConEstProd_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.GRUPOPRODUTO' table. You can move, or remove it, as needed.
            this.gRUPOPRODUTOTableAdapter.Fill(this.cOMERCIALDataSet.GRUPOPRODUTO);


            cmbGrupoProd.SelectedIndex = -1;
            
            
        }

        private void txtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

        private void dtGrdVwConProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpBxProd_Enter(object sender, EventArgs e)
        {

        }

        private void TxtEstMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }
    }
}
