using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comercial.COMERCIALDataSetTableAdapters;
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

        DataTable dttRetorno = new DataTable();
        Validacoes valida = new Validacoes();

        public FrmLibPDV(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
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
                    desconto += (Convert.ToDouble(item.Cells["ColDesconto"].Value)/100) *
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
                double icms = (getValorICMS("SP") / 100) *Convert.ToDouble(totalfaturado);

                txtICMS.Text = string.Format("{0:C2}",icms);
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

        #region Listar Valor Limite Pedido
        public DataTable ListarLimiteCliente(string CodCli)
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append(" SELECT ISNULL(SUM(C.LIMITECRED),0) AS LIMITE ");
            sqlcommand.Append(" FROM cliENTE C  ");
            sqlcommand.Append(" WHERE C.CNPJ = @CODcliENTE ");


            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@CODcliENTE", DbType.String, CodCli);

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

        #region RetornaQuantidadeLiberada
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
        #endregion

        #region Saldo a Liberar
        public int SaldoLiberar(int CodPed, int CodProd)
        {
            Database db = DatabaseFactory.CreateDatabase();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append(" SELECT QUANTIDADELIB AS QUANTIDADELIB  FROM ITEMPEDIDO WHERE CODPRODUTO = @CODPRODUTO AND NRPEDIDO = @NRPEDIDO ");

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
                    ValorFaturar = ValorPedido + Convert.ToDouble(txtBxVlrPedido.Text);

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
                #region ValidaLimiteCredito
                DataTable dttPedidocli = new DataTable();

                dttPedidocli = ListarValorCliente(txtCodCliente.Text);

                if (dttPedidocli.Rows.Count > 0)
                {
                    ValorPedido = Convert.ToDouble(dttPedidocli.Rows[0]["VALOR"]);
                    string valormercadoria = txtBxVlrFaturado.Text.Replace("R$", "").Replace(".", "");
                    ValorFaturar = ValorPedido + Convert.ToDouble(valormercadoria);

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
                #endregion

                //Verifico Saldo em estoque do produto selecionado
                #region ValidaEstoque
                foreach (DataGridViewRow item in dtgrdvItenspven.Rows)
                {
                    int SaldoEstoque = ListarSaldoEstoque(Convert.ToInt32(item.Cells["ColProd"].Value));

                    if (Convert.ToInt32(item.Cells["ClmQtdeLib"].Value) > SaldoEstoque)
                    {

                        throw new Exception("ValidaEstoque");

                    }

                    if (Convert.ToInt32(item.Cells["ClmQtdeLib"].Value) > Convert.ToInt32(item.Cells["ClmQtde"].Value))
                    {

                        throw new Exception("ValidaQtdeLiberada");

                    }

                    if (Convert.ToInt32(item.Cells["ClmQtdeLib"].Value) < 0)
                    {

                        throw new Exception("QuantidadeNegativa");

                    }


                }
                #endregion


                //Variavel para o contador dos itens
                var teste = 0;

                //variavel para contador, para atualizar situação
                var situacao = 0;

                //Crio o Datatable
                DataTable dttRetorno = new DataTable();

                //For para verificar os itens liberados e incrementar o contador
                for (int i = 0; i < dtgrdvItenspven.RowCount; i++)
                {

                    //Verifico o saldo disponivel para liberação
                    int saldolib = SaldoLiberar(Convert.ToInt32(txtbtnPedido.Text), Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ColProd"].Value));

                    //atribuo a lista de itens ao datatable
                    dttRetorno = ListarItem(Convert.ToInt32(txtbtnPedido.Text));

                    //verifico se o saldo = a quantidade do datatable se for = incremento o contador
                    if (saldolib == Convert.ToInt32(dttRetorno.Rows[i]["QUANTIDADE"]))
                    {
                        teste += 1;
                    }


                }

                //se o contador for = a qtde iten liberado dá a mensagem que o pedido já foi efetivado
                if (teste == dtgrdvItenspven.Rows.Count)
                {
                    if (isPedidoFaturado(Convert.ToInt32(txtbtnPedido.Text)))
                    {
                        MessageBox.Show("Pedido já efetivado e faturado!", "Aviso", MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Pedido já efetivado! \nDeseja faturar nota fiscal?", "Aviso",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            emitirNotaFiscal();
                            FrmRelGeral filho = new FrmRelGeral("FrmEmiNF", null, null);
                            filho.Show();
                        }
                    }
                }
                //se não continuo a liberação dos itens pendentes
                else
                {

                    //For para verificar os itens liberados, pego os itens checkado e que a quantidade liberada seja menor que a quantidade solicitada
                    for (int i = 0; i < dtgrdvItenspven.RowCount; i++)
                    {

                        //Verifico o saldo disponivel para liberação
                        int saldolib = SaldoLiberar(Convert.ToInt32(txtbtnPedido.Text), Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ColProd"].Value));

                        //verifico se o iten liberado é < que a quantidade já liberada
                        if (Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ClmQtdelib"].Value) < saldolib)
                        {
                            throw new Exception("ItenLibMenor");
                        }
                        else if (Convert.ToBoolean(dtgrdvItenspven.Rows[i].Cells["ColCheck"].Value = true) && (saldolib <= Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ClmQtde"].Value)))
                        {
                            //verifico a quantidade liberada - saldodisponivel para liberacao
                            int qdeliberada = Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ClmQtdelib"].Value) - saldolib;

                            //verifico saldo atual em estoque
                            int estoqueatual = ListarSaldoEstoque(Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ColProd"].Value));

                            //subtraio o saldo atual - qtdeliberada
                            int atualizaestoque = estoqueatual - qdeliberada;

                            //Atualiza a quantidade liberada do itenpedido
                            AtualizarQtde(Convert.ToInt32(txtbtnPedido.Text), Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ClmQtdeLib"].Value), Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ColProd"].Value));

                            //Atuliza a quantidade atual em estoque
                            atualizaSaldoEstoque(Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ColProd"].Value), atualizaestoque);

                        }
                        continue;
                    }

                    //for para atualizar a situação do pedido
                    for (int j = 0; j < dtgrdvItenspven.RowCount; j++)
                    {

                        //Pego a quantidade liberada do pedido por item
                        int qtdelib = Convert.ToInt32(dtgrdvItenspven.Rows[j].Cells["ClmQtdeLib"].Value);

                        //atribuo a lista de itens ao datatable
                        dttRetorno = ListarItem(Convert.ToInt32(txtbtnPedido.Text));

                        //verifico se é = a quantidade do datatable incrememnto meu contador
                        if (qtdelib == Convert.ToInt32(dttRetorno.Rows[j]["QUANTIDADE"]))
                        {
                            situacao += 1;
                        }

                    }

                    //se o contador for = a qtde iten liberado Atualiza a situação pedido para Efetivado
                    if (situacao == dtgrdvItenspven.Rows.Count)
                    {
                        atualizaSituacao("E", Convert.ToInt32(txtbtnPedido.Text));
                    }
                    //se for != da quantidade do datatable deixa como pendente o pedido
                    else
                    {
                        atualizaSituacao("P", Convert.ToInt32(txtbtnPedido.Text));

                    }

                    //mensagem de pedido liberao (Efetivado) Com sucesso
                    MessageBox.Show("Pedido Liberado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Processo Cancelamento
        public void CancelarPedido()
        {
            try
            {
                if (MessageBox.Show("Deseja Cancelar o Pedido selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                    for (int i = 0; i < dtgrdvItenspven.RowCount; i++)
                    {
                        int qdeliberada = Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ClmQtdelib"].Value);

                        //verifico saldo atual em estoque
                        int estoqueatual = ListarSaldoEstoque(Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ColProd"].Value));

                        //Pego o saldo atual + qtdeliberada
                        int atualizaestoque = estoqueatual + qdeliberada;

                        //Retorna a quantidade liberada do itenpedido
                        RetornaQtde(Convert.ToInt32(txtbtnPedido.Text), Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ColProd"].Value));

                        //Atuliza a quantidade atual em estoque
                        atualizaSaldoEstoque(Convert.ToInt32(dtgrdvItenspven.Rows[i].Cells["ColProd"].Value), atualizaestoque);

                        continue;
                    }

                    atualizaSituacao("C", Convert.ToInt32(txtbtnPedido.Text));

                    //mensagem de pedido Cancelado Com sucesso
                    MessageBox.Show("Pedido Cancelado Com Sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Limpo os controles da tela, preparando para uma novo Cancelamento 
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

        #region LimparCampos
        public void limparcampos()
        {
            try
            {
                txtbtnPedido.Text = String.Empty; ;
                txtBxDescontos.Text = String.Empty;
                txtBxVlrFaturado.Text = String.Empty;
                txtBxVlrPedido.Text = String.Empty;
                txtCodCliente.Text = String.Empty;
                txtCodTransportadora.Text = String.Empty;
                txtCodVendedor.Text = String.Empty;
                txtCondPagto.Text = String.Empty;
                txtNomeCliente.Text = String.Empty;
                txtNomeTransportadora.Text = String.Empty;
                txtNomeVendedor.Text = String.Empty;
                dtgrdvItenspven.Refresh();
                dttRetorno.Clear();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region CellValueChanged
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
        #endregion

        private void FrmLibPDV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.NOTAFISCAL' table. You can move, or remove it, as needed.
            this.nOTAFISCALTableAdapter.Fill(this.cOMERCIALDataSet.NOTAFISCAL);

        }

        #region Emissao de Nota Fiscal
        private void emitirNotaFiscal()
        {
            DataTable cli = getCliente(txtCodCliente.Text);
          
            string tipofrete = "D";
            if(!string.IsNullOrEmpty(txtFrete.Text))
                tipofrete = "E";

            double icms = getValorICMS("SP"); // Fixo
            int nrNotaFiscal = getNumeroNota(); 
            string serie = "0"; 
            string tipo = "S";
            string razaoSocial = cli.Rows[0]["RAZAOSOCIAL"].ToString();
            DateTime dtEmissao = DateTime.Now;
            string ie = cli.Rows[0]["IE"].ToString();
            string telefone = cli.Rows[0]["TELEFONE"].ToString();
            string endereco = cli.Rows[0]["ENDERECO"].ToString();
            string bairro = cli.Rows[0]["BAIRRO"].ToString();
            string cnpf = cli.Rows[0]["CNPJ"].ToString();
            string municipio = cli.Rows[0]["MUNICIPIO"].ToString();
            string codVendedor = txtCodVendedor.Text;
            string codTransportadora = txtCodTransportadora.Text;
            int nrPedido = Convert.ToInt32(txtbtnPedido.Text);
            double valorFrete = Convert.ToDouble(txtFrete.Text.Replace("R$", ""));
            double valorNota = Convert.ToDouble(txtBxVlrPedido.Text.Replace("R$", ""));

            NOTAFISCALTableAdapter nf = new NOTAFISCALTableAdapter();
            nf.Insert(nrNotaFiscal, razaoSocial, serie, dtEmissao, ie, 
                telefone, endereco, bairro, municipio, icms, tipo,
                cnpf, tipofrete, valorFrete, codVendedor, codTransportadora,
                nrPedido , valorNota);
        }

        #endregion

        #region Recuperar Cliente
        public DataTable getCliente(string cnpj)
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("SELECT * FROM cliENTE WHERE CNPJ = @cnpj ");
            
            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@cnpj", DbType.String, cnpj);

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];
        }
        #endregion

        #region Verificar se pedido já foi faturado
        public bool isPedidoFaturado(int nrpedido)
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select * from NOTAFISCAL where NrPedido = @nrpedido ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@nrpedido", DbType.String, nrpedido);

            dtsDados = db.ExecuteDataSet(dbComd);

            if (dtsDados.Tables[0].Rows.Count > 0)
                return true;
            return false;
        }
        #endregion

        #region Pegar Proximo número da nota
        public int getNumeroNota()
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select max(NrNotaFiscal) as MAX from NOTAFISCAL ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());
            
            dtsDados = db.ExecuteDataSet(dbComd);
            if (dtsDados.Tables[0].Rows[0]["MAX"].ToString() == "")
                return 1;
            return (Convert.ToInt32(dtsDados.Tables[0].Rows[0]["MAX"].ToString())) + 1;
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

        public string getNota()
        {
            string sql = "select g.CODGRUPOPRODUTO CODGRUPO, P.CODPRODUTO CODPROD, g.DESCRICAO GRUPO, p.DESCRICAO PRODUTO, p.DATACADASTRO, p.PRECOCUSTO, " +
                "p.PRECOVENDA, p.ESTOQUEATUAL, p.ESTOQUEMIN, p.IPI, g.DESCONTO from PRODUTO p inner join " +
                "GRUPOPRODUTO g on (p.CODGRUPOPRODUTO = g.CODGRUPOPRODUTO) ";
            
            string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(c);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            
            return sql;
        }
    }
}
