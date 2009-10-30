using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace Comercial
{
    public partial class FrmLibPDV : Form
    {
        private FrmPrinc _princ = null;
        double ValorPedido;
        double ValorLimite;
        double ValorFaturar;
        public FrmLibPDV(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        private void FrmLibPDV_Leave(object sender, EventArgs e)
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

        #region Listar Pedido
        public DataTable ListarPedido()
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append(" SELECT NRPEDIDO, TIPO, ped.CODCLIENTE, CODVENDEDOR,CODCONDICAOPAGAMENTO, CODTRANSPORTADORA, Convert(char(10),DATAEMISSAO,103)as DATAEMISSAO , Convert(char(10),DATAENTREGA,103) as DATAENTREGA ");
            sqlcommand.Append(" FROM PEDIDO ped INNER JOIN CLIENTE cli ON ped.CODCLIENTE = cli.CNPJ ");
            sqlcommand.Append(" WHERE SITUACAO <> 'C' AND SITUACAO <> 'E' ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];

        }
        #endregion

        #region SomarClunas
        public void SomarColunas()
        {
            try
            {
                Double total = 0;
                Double totalfaturado = 0;
                Double desconto = 0;

                foreach (DataGridViewRow item in dtgrdvItenspven.Rows)
                {
                    total = Convert.ToDouble(total) + Convert.ToDouble(item.Cells["ColTotal"].Value);
                    desconto = Convert.ToDouble(desconto) + Convert.ToDouble(item.Cells["ColDesconto"].Value);
                    totalfaturado = Convert.ToDouble(totalfaturado) + Convert.ToDouble(item.Cells["ColVALORFATU"].Value);



                }

                txtBxVlrMercadoria.Text = Convert.ToString(total);
                txtBxDescontos.Text = Convert.ToString(desconto);
                txtBxVlrFaturado.Text = Convert.ToString(totalfaturado);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region Botão Pesquisar TxtbtnPedido
        private void txtbtnPedido_ButtonClick(object sender, EventArgs e)
        {

        }
        #endregion

        #region Listar Nome Cliente
        public string ListarNomeCliente(string codCli)
        {
            Database db = DatabaseFactory.CreateDatabase();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select top 1 Razaosocial from CLIENTE inner join PEDIDO on CNPJ= CODCLIENTE WHERE CNPJ=@CNPJ ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@CNPJ", DbType.String, codCli);

            string nomecli = (string)db.ExecuteScalar(dbComd);

            return nomecli;




        }
        #endregion

        #region Listar Nome Vendedor
        public string ListarNomeVendedor(string CodVendedor)
        {
            Database db = DatabaseFactory.CreateDatabase();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select top 1 NOME from VENDEDOR inner join PEDIDO on CPF= CODVENDEDOR WHERE CPF=@CPF ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@CPF", DbType.String, CodVendedor);

            string nomeVend = (string)db.ExecuteScalar(dbComd);

            return nomeVend;




        }
        #endregion

        #region Listar Nome Transportadora
        public string ListarNomeTransportadora(string codTrans)
        {
            Database db = DatabaseFactory.CreateDatabase();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select top 1 NOME from TRANSPORTADORA inner join PEDIDO on CNPJ = CODTRANSPORTADORA  WHERE CNPJ=@CNPJ ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@CNPJ", DbType.String, codTrans);

            string nomeTrans = (string)db.ExecuteScalar(dbComd);

            return nomeTrans;




        }
        #endregion

        #region PopularGrid
        public void populargrid()
        {

            // DataTable dttRetorno = new DataTable();

            int numeropedido;

            DataTable dttRetorno = new DataTable();
            try
            {
                if (txtbtnPedido.Text != String.Empty)
                {
                    numeropedido = Convert.ToInt32(txtbtnPedido.Text);

                    dttRetorno = ListarItem(numeropedido);

                    dttRetorno.Columns.Add("Status", typeof(string));

                    dtgrdvItenspven.DataSource = dttRetorno;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Listar item pedido
        public DataTable ListarItem(int CodPed)
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append(" SELECT ITEM,ITEMPEDIDO.CODPRODUTO,DESCRICAO,QUANTIDADE, ISNULL(QUANTIDADELIB,0) AS QUANTLIB,DESCONTO,VALOR,ITEMPEDIDO.IPI, (QUANTIDADE *VALOR) as VALORTOTAL,(QUANTIDADELIB * VALOR) as VALORFATU  ");
            sqlcommand.Append(" FROM ITEMPEDIDO INNER JOIN PRODUTO ON ITEMPEDIDO.CODPRODUTO = PRODUTO.CODPRODUTO ");
            sqlcommand.Append(" WHERE NRPEDIDO = @nrpedido ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@nrpedido", DbType.String, CodPed);

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];




        }
        #endregion

        #region Listar Valor Total Pedido Cliente
        public DataTable ListarValorCliente(string CodCli)
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append(" SELECT ISNULL(SUM(QUANTIDADE * VALOR),0) AS VALOR  ");
            sqlcommand.Append(" FROM PEDIDO p inner join ITEMPEDIDO i on p.NRPEDIDO = i.NRPEDIDO ");
            sqlcommand.Append(" WHERE p.CODCLIENTE = @CODCLIENTE AND P.SITUACAO = 'E' ");


            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@CODCLIENTE", DbType.String, CodCli);

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];




        }
        #endregion

        #region Listar Valor Limite Pedido
        public DataTable ListarLimiteCliente(string CodCli)
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append(" SELECT ISNULL(SUM(C.LIMITECRED),0) AS LIMITE ");
            sqlcommand.Append(" FROM CLIENTE C  ");
            sqlcommand.Append(" WHERE C.CNPJ = @CODCLIENTE ");


            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@CODCLIENTE", DbType.String, CodCli);

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];




        }
        #endregion

        #region Listar Saldo Estoque
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
        #endregion

        #region Pesquisar Pedido
        public void PesquisaPedido()
        {

            try
            {

                FrmVisGeral x = new FrmVisGeral(this, txtbtnPedido);
                x.dtGrdVwVis.DataSource = ListarPedido();
                x.Text = "Pesquisa Pedido Venda";

                x.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region ValidaLimiteCliente
        public void validalimite()
        {
            DataTable dttPedidocli = new DataTable();

            dttPedidocli = ListarValorCliente(txtCodCliente.Text);

            if (dttPedidocli.Rows.Count > 0)
            {
                ValorPedido = Convert.ToDouble(dttPedidocli.Rows[0]["VALOR"]);
                ValorFaturar = ValorPedido + Convert.ToDouble(txtBxVlrMercadoria.Text);

            }

            DataTable dttCliente = new DataTable();

            dttCliente = ListarLimiteCliente(txtCodCliente.Text);

            if (dttCliente.Rows.Count > 0)
            {
                ValorLimite = Convert.ToDouble(dttCliente.Rows[0]["LIMITE"]);

            }

            if ((ValorFaturar > ValorLimite))
            {
                MessageBox.Show("Limite de Credito insuficiente!.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region ValidaSaldoEstoque
        public void ValidaEstoque()
        {
            foreach (DataGridViewRow item in dtgrdvItenspven.Rows)
            {
                int SaldoEstoque = ListarSaldoEstoque(Convert.ToInt32(item.Cells["ColProd"].Value));

                if (Convert.ToInt32(item.Cells["ClmQtdeLib"].Value) > SaldoEstoque)
                {
                    MessageBox.Show("Saldo em Estoque Indisponivel para o produto!." + "Codigo: " + Convert.ToInt32(item.Cells["ColProd"].Value), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        #endregion

        #region ValidaItemLiberados
        public void ValidaItemLiberado()
        {
            try
            {
                foreach (DataGridViewRow item in dtgrdvItenspven.Rows)
                {

                    if (Convert.ToInt32(item.Cells["ClmQtdeLib"].Value) == Convert.ToInt32(item.Cells["ClmQtde"].Value))
                    {
                        item.Cells["ColCheck"].Value = true;
                        item.ReadOnly = true;



                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Processo Liberacao
        public int LiberaPedido()
        {
            try
            {
                validalimite();
                ValidaEstoque();


                return 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        private void FrmLibPDV_Load(object sender, EventArgs e)
        {
        }

        private void dtgrdvItenspven_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ValidaItemLiberado();
        }
    }
}
