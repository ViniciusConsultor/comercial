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

        #region Listar Pedido
        public DataTable ListarPedido()
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append(" SELECT NRPEDIDO, TIPO, ped.CODcliENTE, CODVENDEDOR,CODCONDICAOPAGAMENTO, CODTRANSPORTADORA, Convert(char(10),DATAEMISSAO,103)as DATAEMISSAO , Convert(char(10),DATAENTREGA,103) as DATAENTREGA, VALORFRETE ");
            sqlcommand.Append(" FROM PEDIDO ped INNER JOIN cliENTE cli ON ped.CODcliENTE = cli.CNPJ ");
            sqlcommand.Append(" WHERE SITUACAO <> 'C' ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];

        }
        #endregion

        #region PopularGrid
        public void populargrid()
        {

            // DataTable dttRetorno = new DataTable();

            int numeropedido;

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

            sqlcommand.Append(" SELECT ITEM,ITEMPEDIDO.CODPRODUTO,DESCRICAO,QUANTIDADE, ISNULL(QUANTIDADELIB,0) AS QUANTLIB, ");
            sqlcommand.Append(" DESCONTO,VALOR,ITEMPEDIDO.IPI, ((QUANTIDADE * VALOR) - QUANTIDADE * VALOR * DESCONTO /100) as VALORTOTAL, ");
            sqlcommand.Append(" ((QUANTIDADELIB * VALOR) - QUANTIDADELIB * VALOR * DESCONTO /100) as VALORFATU ");
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

            sqlcommand.Append(" SELECT ISNULL(SUM(QUANTIDADELIB * VALOR),0) AS VALOR  ");
            sqlcommand.Append(" FROM PEDIDO p inner join ITEMPEDIDO i on p.NRPEDIDO = i.NRPEDIDO ");
            sqlcommand.Append(" WHERE p.CODcliENTE = @CODcliENTE AND P.SITUACAO = 'E' ");


            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@CODcliENTE", DbType.String, CodCli);

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];
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

        #region SomarClunas
        public void SomarColunas()
        {
            try
            {
                Double total = 0;
                Double totalfaturado = 0;
                Double desconto = 0;
                Double ipi = 0;

                foreach (DataGridViewRow item in dtgrdvItenspven.Rows)
                {
                    total = Convert.ToDouble(total) + Convert.ToDouble(item.Cells["ColTotal"].Value);
                    //desconto = Convert.ToDouble(desconto) + Convert.ToDouble(item.Cells["ColDesconto"].Value);
                    desconto += (Convert.ToDouble(item.Cells["ColDesconto"].Value) / 100) *
                                (Convert.ToDouble(item.Cells["ClmPrcUnit"].Value) *
                                Convert.ToDouble(item.Cells["ClmQtdeLib"].Value));
                    totalfaturado = Convert.ToDouble(totalfaturado) + Convert.ToDouble(item.Cells["ColVALORFATU"].Value);
                    ipi += (Convert.ToDouble(item.Cells["ClmIPI"].Value) / 100) *
                                (Convert.ToDouble(item.Cells["ClmPrcUnit"].Value) *
                                Convert.ToDouble(item.Cells["ClmQtdeLib"].Value));

                    txtIPI.Text = string.Format("{0:C2}", Convert.ToDouble(ipi));
                    txtBxVlrPedido.Text = string.Format("{0:C2}", Convert.ToDouble(total));
                    txtBxVlrFaturado.Text = string.Format("{0:C2}", Convert.ToDouble(totalfaturado));
                    txtBxDescontos.Text = string.Format("{0:C2}", Convert.ToDouble(desconto));
                }
                double icms = (getValorICMS("SP") / 100) * Convert.ToDouble(totalfaturado);

                txtICMS.Text = string.Format("{0:C2}", icms);
                txtIPI.Text = Convert.ToString(txtIPI.Text);
                txtBxVlrPedido.Text = string.Format("{0:C2}", totalfaturado + ipi + icms + Convert.ToDouble(txtFrete.Text.Replace("R$", "")));
                txtBxDescontos.Text = Convert.ToString(txtBxDescontos.Text);
                txtBxVlrFaturado.Text = Convert.ToString(txtBxVlrFaturado.Text);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region Listar Nome Cliente
        public string ListarNomeCliente(string codCli)
        {
            Database db = DatabaseFactory.CreateDatabase();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select top 1 Razaosocial from cliENTE inner join PEDIDO on CNPJ= CODcliENTE WHERE CNPJ=@CNPJ ");

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

        #region Pegar valor ICMS
        public double getValorICMS(string uf)
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select aliquota from ICMS where uf = @uf ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@uf", DbType.String, uf);

            dtsDados = db.ExecuteDataSet(dbComd);

            return ((double)dtsDados.Tables[0].Rows[0]["aliquota"]);
        }
        #endregion

        #region ValidaItemLiberados
        public void ValidaItemLiberado()
        {
            try
            {
                for (int i = 0; i < dtgrdvItenspven.RowCount; i++)
                {
                    int QuantidadeLib = (int)dtgrdvItenspven.Rows[i].Cells["ClmQtdeLib"].Value;
                    int Quantidade = (int)dtgrdvItenspven.Rows[i].Cells["ClmQtde"].Value;


                    if ((int)dtgrdvItenspven.Rows[i].Cells["ClmQtdeLib"].Value == (int)dtgrdvItenspven.Rows[i].Cells["ClmQtde"].Value)
                    {
                        dtgrdvItenspven.Rows[i].Cells["ColCheck"].Value = true;
                        dtgrdvItenspven.Rows[i].ReadOnly = true;
                        //dtgrdvItenspven.Rows[i].Cells["ColCheck"].Style.BackColor = Color.Green;
                        dtgrdvItenspven.Rows[i].Cells["ColStatus"].Value = Comercial.Properties.Resources.BolaVerde;
                    }
                    else if ((QuantidadeLib != 0) && (QuantidadeLib != Quantidade))
                    {
                        dtgrdvItenspven.Rows[i].Cells["ColCheck"].Value = true;
                        //dtgrdvItenspven.Rows[i].Cells["ColCheck"].Style.BackColor = Color.Yellow;
                        dtgrdvItenspven.Rows[i].Cells["ColStatus"].Value = Comercial.Properties.Resources.BolaAmarela;
                    }
                    else if ((QuantidadeLib == 0))
                    {
                        dtgrdvItenspven.Rows[i].Cells["ColCheck"].Value = true;
                        //dtgrdvItenspven.Rows[i].Cells["ColCheck"].Style.BackColor = Color.Red;
                        dtgrdvItenspven.Rows[i].Cells["ColStatus"].Value = Comercial.Properties.Resources.BolaVermelho;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        private void FrmEmiNotFis_Shown(object sender, EventArgs e)
        {
            _princ.tlStrpBtnPesquisar.Visible = true;
        }
        
    }
}
