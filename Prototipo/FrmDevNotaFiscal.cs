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
    public partial class FrmDevNotaFiscal : Form
    {
       private FrmPrinc _princ = null;

       public FrmDevNotaFiscal(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

       private void FrmDevNotaFiscal_Leave(object sender, EventArgs e)
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
           foreach (ToolStripButton x in strip2.Items)
           {
               x.Visible = false;
           }
       }

       private void nOTAFISCALBindingNavigatorSaveItem_Click(object sender, EventArgs e)
       {
           this.Validate();
           this.nOTAFISCALBindingSource.EndEdit();
           this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

       }

       private void FrmDevNotaFiscal_Load(object sender, EventArgs e)
       {
           // TODO: This line of code loads data into the 'cOMERCIALDataSet.NOTAFISCAL' table. You can move, or remove it, as needed.
           this.nOTAFISCALTableAdapter.Fill(this.cOMERCIALDataSet.NOTAFISCAL);
           

       }


       #region Listar NF
       public DataTable ListaNf()
       {
           Database db = DatabaseFactory.CreateDatabase();

           DataSet dtsDados = new DataSet();

           StringBuilder sqlcommand = new StringBuilder();

           sqlcommand.Append(" SELECT NRNOTAFISCAL, SERIE, DATAEMISSAO, TIPO ");
           sqlcommand.Append(" FROM NOTAFISCAL ");
           
           DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

           dtsDados = db.ExecuteDataSet(dbComd);

           return dtsDados.Tables[0];

       }
       #endregion
       

       #region Pesquisar NF
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
    # endregion


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

           DataTable dttRetorno = new DataTable();
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


       #region LimparCampos
       public void limparcampos()
       {
           try
           {
               txtNumNF.Text = String.Empty; ;
               txtSerie.Text = String.Empty;
               txtTipoNF.Text = String.Empty;
               dtTmPckrDtEmissao.Text = String.Empty;
               txtBxVlrMercadoria.Text = String.Empty;
            
               dtGrdVwItensNF.Refresh();

           }
           catch (Exception ex)
           {

               throw ex;
           }
       }
       #endregion


       #region Devolver NF
       public void DevolveNF()
       {

       }

       #endregion





    }
}
