using System;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Comercial
{
    public partial class FrmEmiNotFis : Form
    {
        private FrmPrinc _princ = null;
        DataTable dttRetorno = new DataTable();

        public FrmEmiNotFis(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblNumNotFiscal_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void FrmEmiNotFis_Leave(object sender, EventArgs e)
        {
            Control[] z = _princ.Controls.Find("bindingNavigator1", true);
            ToolStrip strip = (ToolStrip)z[0];

            strip.Visible = true;

            Control[] y = _princ.Controls.Find("tlStrpProcesso", true);
            ToolStrip strip2 = (ToolStrip)y[0];

            strip2.Visible = false;
            foreach (ToolStripButton x in strip2.Items)
            {
                x.Visible = false;
            }
        }

        #region Listar NF
        public DataTable ListaNf()
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append(" SELECT NRNOTAFISCAL, SERIE, DATAEMISSAO, TIPO, NrPedido, VALORNOTA, VALORFRETE, ICMS ");
            sqlcommand.Append(" FROM NOTAFISCAL ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];

        }
        #endregion

        private void txtNumNF_ButtonClick(object sender, EventArgs e)
        {
            try
            {

                FrmVisGeral x = new FrmVisGeral(this, txtNumNF);
                x.dtGrdVwVis.DataSource = ListaNf();
                x.Text = "Pesquisa Nota Fiscal";

                x.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #region Listar item pedido NF
        public DataTable ListarItemNF(int NumNF)
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append(" SELECT CodProduto, Descricao, CodUnidadeMedida, Quantidade, Valor, (QUANTIDADE * VALOR) AS VALORTOTAL ");
            sqlcommand.Append(" FROM ITEMNOTAFISCAL ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@NrNotaFiscal ", DbType.Int32, NumNF);

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];
        }
        #endregion


        #region PopularGridNF
        public void populargrid()
        {

            int NrNotaFiscal;

            try
            {
                if (txtNumNF.getText != String.Empty)
                {
                    NrNotaFiscal = Convert.ToInt32(txtNumNF.getText);

                    dttRetorno = ListarItemNF(NrNotaFiscal);

                    dtGrdVwItensNF.DataSource = dttRetorno;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
