using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Comercial
{
    public partial class FrmCadProd : Form
    {
        private FrmPrinc _princ = null;

        public FrmCadProd(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;

            _princ.bindingNavigator1.BindingSource = pRODUTOBindingSource;
            _princ.setdataSet(cOMERCIALDataSet);

            // novo

            _princ.novo();
        }
        
        private void mskedTxtBxPrecoUnitario_Leave(object sender, EventArgs e)
        {

        }
        
        private void FrmCadProd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.UNIDADEMEDIDA' table. You can move, or remove it, as needed.
            this.uNIDADEMEDIDATableAdapter.Fill(this.cOMERCIALDataSet.UNIDADEMEDIDA);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.PRODUTO' table. You can move, or remove it, as needed.
        }

        private void FrmCadProd_Shown(object sender, EventArgs e)
        {
            pRODUTOTableAdapter.Fill(cOMERCIALDataSet.PRODUTO);
        }

        public int salvar()
        {
            String g = dtmPckrCadastro.Text;
            return 0;
        }

        public void novo()
        {
            dtmPckrCadastro.Value = DateTime.Now;
            dtmPckrCadastro.Enabled = false;
        }

        #region ListarProdutoDataGridView Pesquisa
        public DataTable ListaProduto()
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append(" SELECT CODPRODUTO,PRODUTO.DESCRICAO,CODUNIDADEMEDIDA,ESTOQUEATUAL,PRECOVENDA,IPI,GRUPOPRODUTO.DESCONTO");
            sqlcommand.Append(" FROM PRODUTO INNER JOIN GRUPOPRODUTO ON PRODUTO.CODGRUPOPRODUTO = GRUPOPRODUTO.CODGRUPOPRODUTO");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];

        }
        #endregion

        private void txtCodProd_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.dtGrdVwVis.DataSource = ListaProduto();
            x.Text = "Consulta Cadastro de Produto";

            x.ShowDialog();
        }
    }
}
