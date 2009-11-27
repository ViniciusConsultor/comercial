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
       DataTable dttRetorno = new DataTable();
      
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

           sqlcommand.Append(" SELECT NRNOTAFISCAL, SERIE, DATAEMISSAO, TIPO, NrPedido ");
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
               txtNumNF.getText = String.Empty; ;
               txtSerie.Text = String.Empty;
               txtTipoNF.Text = String.Empty;
               dtTmPckrDtEmissao.Text = String.Empty;
               txtBxVlrMercadoria.Text = String.Empty;
               txtNrPedido.Text = String.Empty;
               dtGrdVwItensNF.Refresh();
               dttRetorno.Clear();                                         
               
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }
       #endregion

       #region AtualizaSituaçãoPedido
       public void atualizaStatusPedido(string Situacao, int NrPedido)
       {
           Database db = DatabaseFactory.CreateDatabase();

           StringBuilder sqlcommand = new StringBuilder();

           sqlcommand.Append(" UPDATE PEDIDO SET SITUACAO = @SITUACAO WHERE NRPEDIDO = @NRPEDIDO ");

           DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

           db.AddInParameter(dbComd, "@SITUACAO", DbType.String, Situacao);
           db.AddInParameter(dbComd, "@NRPEDIDO", DbType.Int32, NrPedido);


           db.ExecuteScalar(dbComd);


       }
       #endregion

        
       #region Devolver NF
       public void DevolverNF()
       {
           try
           {
               if (MessageBox.Show("Deseja Devolver a Nota Fiscal selecionada?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
               {

                   for (int i = 0; i < dtGrdVwItensNF.RowCount; i++)
                   {
                       int quantidade = Convert.ToInt32(dtGrdVwItensNF.Rows[i].Cells["clmQuantidade"].Value);


                       //verifica saldo atual em estoque
                       int estoqueatual = ListarSaldoEstoque(Convert.ToInt32(dtGrdVwItensNF.Rows[i].Cells["clmProduto"].Value));

                       //Soma o saldo atual + qtdeliberada
                       int atualizaestoque = estoqueatual + quantidade;

                      //Atualiza quantidade liberada do pedido para 0 pasando como parametro o pedido e o cod do produto
                       AtualizarQtde(Convert.ToInt32(txtNrPedido.Text), 0, Convert.ToInt32(dtGrdVwItensNF.Rows[i].Cells["clmProduto"].Value));
                       
                       //Atuliza a quantidade atual em estoque passando com oparametro produto e a quantida a atualizar
                       atualizaSaldoEstoque(Convert.ToInt32(dtGrdVwItensNF.Rows[i].Cells["clmProduto"].Value), atualizaestoque);

                       continue;
                   }

                   //Atualiza Status do Pedido para "P"
                   atualizaStatusPedido("P", Convert.ToInt32(txtNrPedido.Text));

                   //Atualiza Tipo da NF para "E" ...
                   atualizaStatusNF("E", Convert.ToInt32(txtNumNF.getText));

                   //mensagem de NF devolvida
                   MessageBox.Show("Nota Fiscal Devolvida Com Sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   //Limpar campos
                   limparcampos();
               }
           }

               
            catch (Exception ex)
            {
                Validacoes valida = new Validacoes();
                valida.tratarSystemExceções(ex);
            }
           
       }
       

    
   #endregion


       #region AtualizarQuantidadeLiberada
       public void AtualizarQtde(int CodPed, int QtdeLib, int CodProd)
       {
           Database db = DatabaseFactory.CreateDatabase();

           StringBuilder sqlcommand = new StringBuilder();

           sqlcommand.Append(" UPDATE ITEMPEDIDO SET QUANTIDADELIB = @QUANTIDADELIB WHERE NRPEDIDO = @NRPEDIDO AND CODPRODUTO = @CODPRODUTO");

           DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

           db.AddInParameter(dbComd, "@QUANTIDADELIB", DbType.Int32, QtdeLib);
           db.AddInParameter(dbComd, "@NRPEDIDO", DbType.Int32, CodPed);
           db.AddInParameter(dbComd, "@CODPRODUTO", DbType.Int32, CodProd);

           db.ExecuteScalar(dbComd);


       }
       #endregion
      
    public int ListarSaldoEstoque(int CodProd)
       {
           Database db = DatabaseFactory.CreateDatabase();

           StringBuilder sqlcommand = new StringBuilder();

           sqlcommand.Append(" SELECT ESTOQUEATUAL ");
           sqlcommand.Append(" FROM PRODUTO  ");
           sqlcommand.Append(" WHERE CODPRODUTO = @CODPRODUTO ");

           DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

           db.AddInParameter(dbComd, "@CODPRODUTO", DbType.Int32, CodProd);

           int estoque = Convert.ToInt32(db.ExecuteScalar(dbComd));

           return estoque;

       }


       public void RetornaQtde(int CodPed, int CodProd)
       {
           Database db = DatabaseFactory.CreateDatabase();

           StringBuilder sqlcommand = new StringBuilder();

           sqlcommand.Append(" UPDATE ITEMPEDIDO SET QUANTIDADELIB = 0 WHERE NRPEDIDO = @NRPEDIDO AND CODPRODUTO = @CODPRODUTO");

           DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());


           db.AddInParameter(dbComd, "@NRPEDIDO", DbType.Int32, CodPed);
           db.AddInParameter(dbComd, "@CODPRODUTO", DbType.Int32, CodProd);

           db.ExecuteScalar(dbComd);


       }


       public void atualizaSaldoEstoque(int CodProd, int qtde)
       {
           Database db = DatabaseFactory.CreateDatabase();

           StringBuilder sqlcommand = new StringBuilder();

           sqlcommand.Append(" UPDATE PRODUTO SET ESTOQUEATUAL = @ESTOQUEATUAL WHERE CODPRODUTO = @CODPRODUTO ");

           DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

           db.AddInParameter(dbComd, "@ESTOQUEATUAL", DbType.Int32, qtde);
           db.AddInParameter(dbComd, "@CODPRODUTO", DbType.Int32, CodProd);


           db.ExecuteScalar(dbComd);


       }


       public void atualizaStatusNF(string Status, int NrNotaFiscal)
       {
           Database db = DatabaseFactory.CreateDatabase();

           StringBuilder sqlcommand = new StringBuilder();

           sqlcommand.Append(" UPDATE NOTAFISCAL SET TIPO = @TIPO WHERE NRNOTAFISCAL = @NRNOTAFISCAL ");

           DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

           db.AddInParameter(dbComd, "@TIPO", DbType.String, Status);
           db.AddInParameter(dbComd, "@NRNOTAFISCAL", DbType.Int32,NrNotaFiscal);


           db.ExecuteScalar(dbComd);


       }


   





    }
}
