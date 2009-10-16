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
    public partial class FrmConProd : Form
    {
         private FrmPrinc _princ = null;

        public FrmConProd(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        private void txtFabricante_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, txtGrupo);
            x.ShowDialog();
        }

        private void txtCodProd_ButtonClick(object sender, EventArgs e)
        {
            //FrmVisGeral x = new FrmVisGeral(this, txtCodProd);
            //x.ShowDialog();
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

        public void pesquisar()
        {
            string sql = "select g.DESCRICAO GRUPO, p.DESCRICAO PRODUTO, p.DATACADASTRO, p.PRECOCUSTO, "+
                "p.PRECOVENDA, p.ESTOQUEATUAL, p.ESTOQUEMIN, p.IPI, g.DESCONTO from PRODUTO p inner join "+
                "GRUPOPRODUTO g on (p.CODGRUPOPRODUTO = g.CODGRUPOPRODUTO) ";

            if (!string.IsNullOrEmpty(txtDesconto.Text))
            {
                sql += "and g.desconto " + cmBxOpDesconto.Text + " " + txtDesconto.Text; 
            }

            if (!string.IsNullOrEmpty(txtGrupo.Text))
            {
                sql += "and g.descricao like '%" + txtGrupo.Text + "%' ";
            }

            if (!string.IsNullOrEmpty(txtProdDesc.Text))
            {
                sql += "and p.descricao like '%" + txtProdDesc.Text + "%' ";
            }

            //Pesquisa por data
            if (dtTPckrDtCadastro.Checked)
            {
                string formatData = dtTPckrDtCadastro.Value.Year + "-" + dtTPckrDtCadastro.Value.Month + "-" + dtTPckrDtCadastro.Value.Day;
                sql += "and p.datacadastro = '" + formatData + "'";
            }

            if (!string.IsNullOrEmpty(txtEstoque.Text))
            {
                sql += "and p.estoqueatual " + cmBxOpEstoque.Text + " " + txtEstoque.Text;                 
            }

            string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(c);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);


            dtGrdVwConProd.DataSource = table;
        }
              
        private void txtBtnCodGrp_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.dtGrdVwVis.DataSource = ListarGrupoProduto();
            x.Text = "Pesquisa Cadastro de Grupo de Produtos";

            x.ShowDialog();            
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
            x.Text = "Pesquisa Cadastro de Produtos";

            x.ShowDialog();
        }        
    }
}
