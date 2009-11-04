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
        Validacoes valida = new Validacoes();
                
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

        #region Saldo a Liberar
        public int SaldoLiberar(int CodPed, int CodProd)
        {
            Database db = DatabaseFactory.CreateDatabase();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append(" SELECT QUANTIDADELIB FROM ITEMPEDIDO WHERE CODPRODUTO = @CODPRODUTO AND NRPEDIDO = @NRPEDIDO ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@NRPEDIDO", DbType.Int32, CodPed);
            db.AddInParameter(dbComd, "@CODPRODUTO", DbType.Int32, CodProd);

            int saldo = Convert.ToInt32(db.ExecuteScalar(dbComd));

            return saldo;
        }
        #endregion

        #region AtualizaSaldoEstoque
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
        #endregion

        #region AtualizaSituaçãoPedido
        public void atualizaSituacao(string Situacao, int NrPedido)
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
            try
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
                    throw new Exception("ValidaLimite");
                }

            }
            catch (Exception ex)
            {
                Validacoes valida = new Validacoes();
                valida.tratarSystemExceções(ex);
            }
        }
        #endregion

        #region ValidaSaldoEstoque
        public void ValidaEstoque()
        {
            try
            {
                foreach (DataGridViewRow item in dtgrdvItenspven.Rows)
                {
                    int SaldoEstoque = ListarSaldoEstoque(Convert.ToInt32(item.Cells["ColProd"].Value));

                    if (Convert.ToInt32(item.Cells["ClmQtdeLib"].Value) > SaldoEstoque)
                    {
                        //MessageBox.Show("Saldo em Estoque Indisponivel para o produto!." + "Codigo: " + Convert.ToInt32(item.Cells["ColProd"].Value), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("ValidaEstoque");
                    }

                    if (Convert.ToInt32(item.Cells["ClmQtdeLib"].Value) > Convert.ToInt32(item.Cells["ClmQtde"].Value))
                    {
                        //MessageBox.Show("Quantidade liberada não pode ser superio a quantidade do pedido!." + "Codigo: " + Convert.ToInt32(item.Cells["ColProd"].Value), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("ValidaQtdeLiberada");
                    }
                }
            }
            catch (Exception ex)
            {

                Validacoes valida = new Validacoes();
                valida.tratarSystemExceções(ex);
            }


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

        #region Processo Liberacao
        public void LiberaPedido()
        {
            try
            {

                //Verifico o limite de crêdito do cliente
                validalimite();
                
                //Verifico Saldo em estoque do produto selecionado
                ValidaEstoque();

                //Variavel para o contador dos itens
                var teste = 0;

                //variavelpara contador, para atualizar situação
                var situacao = 0;

                //Crio o Datatable
                DataTable dttRetorno = new DataTable();

                //For para verificar os itens liberados e incrementar o contador
                for (int i = 0; i < dtgrdvItenspven.RowCount; i++)
                {

                    //Verifico o saldo disponivel para liberação
                    int saldolib = SaldoLiberar(Convert.ToInt32(txtbtnPedido.Text), Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ColProd"].Value));

                    dttRetorno = ListarItem(Convert.ToInt32(txtbtnPedido.Text));

                    if (saldolib == Convert.ToInt32(dttRetorno.Rows[i]["QUANTIDADE"]))
                    {
                        teste += 1;
                    }


                }

                //se o contador for = a qtde iten liberado dá a mensagem que o pedido já foi efetivado
                if (teste == dtgrdvItenspven.Rows.Count)
                {
                    MessageBox.Show("Pedido já efetvado!.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //se não continuo a liberação dos itens pendentes
                else
                {

                    //For para verificar os itens liberados, pego os itens checkado e que a quantidade liberada seja menor que a quantidade solicitada
                    for (int i = 0; i < dtgrdvItenspven.RowCount; i++)
                    {

                        //Verifico o saldo disponivel para liberação
                        int saldolib = SaldoLiberar(Convert.ToInt32(txtbtnPedido.Text), Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ColProd"].Value));

                        if (Convert.ToBoolean(dtgrdvItenspven.Rows[i].Cells["ColCheck"].Value = true) && (saldolib <= Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ClmQtde"].Value)))
                        {


                            //verifico a quantidade liberada - saldodisponivel para liberacao
                            int qdeliberada = Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ClmQtdelib"].Value) - saldolib;

                            //verifico saldo atual em estoque
                            int estoqueatual = ListarSaldoEstoque(Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ColProd"].Value));

                            //subtraio o saldo atual - qtdeliberada
                            int atualizaestoque = estoqueatual - qdeliberada;

                            //Atualiza a quantidade liberada do itenpedido
                            AtualizarQtde(Convert.ToInt32(txtbtnPedido.Text), Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ClmQtdeLib"].Value), Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ColProd"].Value));
                            atualizaSaldoEstoque(Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ColProd"].Value), atualizaestoque);
                        }


                    }

                    //for para atualizar a situação do pedido
                    for (int i = 0; i < dtgrdvItenspven.RowCount; i++)
                    {

                        int qtdelib = Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ClmQtdeLib"].Value);
                        //Verifico o saldo disponivel para liberação
                        int saldolib = SaldoLiberar(Convert.ToInt32(txtbtnPedido.Text), Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ColProd"].Value));

                        dttRetorno = ListarItem(Convert.ToInt32(txtbtnPedido.Text));

                        if (qtdelib == Convert.ToInt32(dttRetorno.Rows[i]["QUANTIDADE"]))
                        {
                            situacao += 1;
                        }

                    }

                    //se o contador for = a qtde iten liberado Atualiza a situação pedido para Efetivado
                    if (situacao == dtgrdvItenspven.Rows.Count)
                    {
                        atualizaSituacao("E", Convert.ToInt32(txtbtnPedido.Text));
                    }
                    else
                    {
                        atualizaSituacao("P", Convert.ToInt32(txtbtnPedido.Text));

                    }

                    //mensagem de pedido liberao (Efetivado) Com sucesso
                    MessageBox.Show("Pedido Liberado com Sucesso!.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Limpo os controles da tela, preparando para uma nova liberação 
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



        private void FrmLibPDV_Load(object sender, EventArgs e)
        {

        }

        #region LimparCampos
        public void limparcampos()
        {
            try
            {
                txtbtnPedido.Text = String.Empty; ;
                txtBxDescontos.Text = String.Empty;
                txtBxVlrFaturado.Text = String.Empty;
                txtBxVlrMercadoria.Text = String.Empty;
                txtCodCliente.Text = String.Empty;
                txtCodTransportadora.Text = String.Empty;
                txtCodVendedor.Text = String.Empty;
                txtCondPagto.Text = String.Empty;
                txtNomeCliente.Text = String.Empty;
                txtNomeTransportadora.Text = String.Empty;
                txtNomeVendedor.Text = String.Empty;
                dtgrdvItenspven.Refresh();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        private void dtgrdvItenspven_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dtgrdvItenspven.Rows)
                {
                    int Quantidade = Convert.ToInt32(item.Cells["ClmQtdeLib"].Value);
                    if (Quantidade == 0)
                    {
                        item.Cells["ColCheck"].Value = false;
                    }
                    else
                    {
                        item.Cells["ColCheck"].Value = true;
                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
