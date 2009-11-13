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
using Microsoft.Practices.ObjectBuilder;
using System.Data.Common;
using System.Data.OleDb;

namespace Comercial
{
    public partial class FrmCadPed : Form
    {
        private FrmPrinc _princ = null;
        public DataTable dttRetorno = new DataTable();
        int statusped = 0;
        //Double valortotal;
        public FrmCadPed(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
            _princ.bindingNavigator1.BindingSource = pEDIDOBindingSource;
            _princ.setdataSet(cOMERCIALDataSet);
            _princ.novo();
        }

        private void pEDIDOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pEDIDOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        #region Show
        private void FrmCadPed_Shown(object sender, EventArgs e)
        {

            dttRetorno = CriarDataTable();

            // TODO: This line of code loads data into the 'cOMERCIALDataSet.CONDICAOPAGAMENTO' table. You can move, or remove it, as needed.
            this.cONDICAOPAGAMENTOTableAdapter.Fill(this.cOMERCIALDataSet.CONDICAOPAGAMENTO);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.cOMERCIALDataSet.CLIENTE);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.VENDEDOR' table. You can move, or remove it, as needed.
            this.vENDEDORTableAdapter.Fill(this.cOMERCIALDataSet.VENDEDOR);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.CONDICAOPAGAMENTO' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'cOMERCIALDataSet.TRANSPORTADORA' table. You can move, or remove it, as needed.
            this.tRANSPORTADORATableAdapter.Fill(this.cOMERCIALDataSet.TRANSPORTADORA);

            // TODO: This line of code loads data into the 'cOMERCIALDataSet.PEDIDO' table. You can move, or remove it, as needed.
            this.pEDIDOTableAdapter.Fill(this.cOMERCIALDataSet.PEDIDO);

            this.iTEMPEDIDOTableAdapter.Fill(this.cOMERCIALDataSet.ITEMPEDIDO);

            populargrid();

            txtNomeCliente.Text = Convert.ToString(ListarNomeCliente(txtcodCli.getText));
            txtNomeTransportadora.Text = Convert.ToString(ListarNomeTransportadora(txtCodTransportadora.getText));
            txtNomeVendedor.Text = Convert.ToString(ListarNomeVendedor(txtCodVendedor.getText));


        }

        #endregion

        #region Salvar
        public int SalvarPedidoCab()
        {
            DataRowView objPedido;
            objPedido = (DataRowView)pEDIDOBindingSource.Current;



            if (chkEfetivado.Checked)
            {
                objPedido["SITUACAO"] = "E";
            }
            else if (chkCancelado.Checked)
            {
                objPedido["SITUACAO"] = "C";
            }
            else
            {
                objPedido["SITUACAO"] = "P";
            }

            if (chkNormal.Checked)
            {

                objPedido["TIPO"] = "N";
            }
            else
            {
                objPedido["TIPO"] = "C";
            }

            objPedido["DATAEMISSAO"] = DateTime.Now;
            objPedido["DATAENTREGA"] = Convert.ToDateTime(dtpEntrega.Value).ToString("dd/MM/yyyy");
            objPedido["CODCLIENTE"] = txtcodCli.getText;
            objPedido["CODVENDEDOR"] = txtCodVendedor.getText;
            objPedido["CODCONDICAOPAGAMENTO"] = txtCondPagto.getText;
            objPedido["CODTRANSPORTADORA"] = txtCodTransportadora.getText;
            string ValorFrete = txtFrete.Text.Replace("R$", "").Replace(".", "");
            //txtFrete.Text = string.Format("{0:C2}", Convert.ToDouble(txtFrete.Text));
            objPedido["VALORFRETE"] = ValorFrete;

            if (dtgrdvItenspven.RowCount == 0)
            {
                MessageBox.Show("Operação Cancelada, pois não existe itens para este pedido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 1;
            }
            else
            {
                COMERCIALDataSetTableAdapters.PEDIDOTableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.PEDIDOTableAdapter();
                table.Insert(Convert.ToString(objPedido["TIPO"].ToString()),
                       Convert.ToDateTime(objPedido["DATAEMISSAO"].ToString()),
                       Convert.ToDateTime(objPedido["DATAENTREGA"].ToString()),
                       Convert.ToInt32(objPedido["CODCONDICAOPAGAMENTO"].ToString()),
                       Convert.ToString(objPedido["SITUACAO"].ToString()),
                       Convert.ToString(objPedido["CODVENDEDOR"].ToString()),
                       Convert.ToString(objPedido["CODCLIENTE"].ToString()),
                       Convert.ToString(objPedido["CODTRANSPORTADORA"].ToString()),
                       Convert.ToDouble(objPedido["VALORFRETE"].ToString()));


                this.SalvarPedidoDeta();

                return 0;
            }




        }
        #endregion

        #region PositionChanged

        private void pEDIDOBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DataRowView objPedido;
            objPedido = (DataRowView)pEDIDOBindingSource.Current;


            if (objPedido["SITUACAO"].ToString() == "E")
            {
                chkEfetivado.Checked = true;
            }
            else 
            {
                chkEfetivado.Checked = false;
            }

            if (objPedido["SITUACAO"].ToString() == "C")
            {
                chkCancelado.Checked = true;
            }
            else
            {
                chkCancelado.Checked = false;  
            }

            if (objPedido["SITUACAO"].ToString() == "P")
            {
                chkPendente.Checked = true;
            }
            else
            {
                chkPendente.Checked = false;
            }

            if (objPedido["TIPO"].ToString() == "N")
            {
                chkNormal.Checked = true;
            }
            else
            {
                chkNormal.Checked = false;
            }


            if (objPedido["TIPO"].ToString() == "C")
            {
                chkComplemento.Checked = true;
            }
            else
            {
                chkComplemento.Checked = false;
            }

            txtcodCli.getText = objPedido["CODCLIENTE"].ToString();
            txtCodVendedor.getText = objPedido["CODVENDEDOR"].ToString();
            txtCondPagto.getText = objPedido["CODCONDICAOPAGAMENTO"].ToString();
            txtCodTransportadora.getText = objPedido["CODTRANSPORTADORA"].ToString();
           // txtFrete.Text = Convert.ToString(objPedido["VALORFRETE"].ToString());
            //dtpEmissao.Value = Convert.ToDateTime(objPedido["DATAEMISSAO"].ToString());
            //dtpEntrega.Value = Convert.ToDateTime(objPedido["DATAENTREGA"].ToString());



        }
        #endregion

        #region AddItemDataTable
        public DataTable CriarDataTable()
        {

            DataTable dttRetorno = new DataTable();

            dttRetorno.Columns.Add("ITEM", typeof(int));
            dttRetorno.Columns.Add("CODPRODUTO", typeof(int));
            dttRetorno.Columns.Add("DESCRICAO", typeof(string));
            dttRetorno.Columns.Add("QUANTIDADE", typeof(int));
            dttRetorno.Columns.Add("QUANTIDADELIB", typeof(int));
            dttRetorno.Columns.Add("VALOR", typeof(float));
            dttRetorno.Columns.Add("IPI", typeof(double));
            dttRetorno.Columns.Add("DESCONTO", typeof(double));
            dttRetorno.Columns.Add("ValorTotal", typeof(float));
            dttRetorno.Columns.Add("Status", typeof(string));

            dttRetorno.AcceptChanges();


            return dttRetorno;


        }

        #endregion

        #region LimparDatatable
        public void limpardttable()
        {
            try
            {
                dttRetorno.Clear();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region LimparCampos
        public void LimparCampos()
        {
            grpBxSitPed.Enabled = false;
            chkNormal.Checked = true;
            chkPendente.Checked = true;
            txtDescprod.Text = String.Empty;
            txtEstAtual.Text = String.Empty;
            txtUM.Text = String.Empty;
            txtPrcUnit.Text = String.Empty;
            txtQtdItem.Text = String.Empty;
            txtValorTotal.Text = String.Empty;
            txtDesconto.Text = String.Empty;
            txtipi.Text = String.Empty;
            txtPedido.Text = String.Empty;
            txtcodCli.Text = String.Empty;
            txtNomeCliente.Text = String.Empty;
            txtNomeVendedor.Text = String.Empty;
            txtNomeTransportadora.Text = String.Empty;
        }

        #endregion

        #region LimparItens
        public void Limparitens()
        {

            txtProduto.getText = String.Empty;
            txtDescprod.Text = String.Empty;
            txtEstAtual.Text = String.Empty;
            txtUM.Text = String.Empty;
            txtPrcUnit.Text = String.Empty;
            txtQtdItem.Text = String.Empty;
            txtValorTotal.Text = String.Empty;
            txtDesconto.Text = String.Empty;
            txtipi.Text = String.Empty;

        }

        #endregion

        #region Adicionar LinhasDatatable

        private void btnAdditen_Click(object sender, EventArgs e)
        {
            try
            {
                if (_princ.edit == true)
                {
                    additemeditar();
                }
                else
                {
                    additemnovo();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Inserir Detalhe Pedido

        public int SalvarPedidoDeta()
        {
            int CodPed = GetNrPedido();

            try
            {
                if (_princ.edit == false)
                {
                    for (int index = 0; index < dttRetorno.Rows.Count; index++)
                    {

                        COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter();
                        table.Insert(Convert.ToInt32(CodPed),
                             Convert.ToInt32(dttRetorno.Rows[index]["CODPRODUTO"]),
                                Convert.ToInt32(dttRetorno.Rows[index]["QUANTIDADE"]),
                                Convert.ToInt32(dttRetorno.Rows[index]["QUANTIDADELIB"]),
                                Convert.ToDouble(dttRetorno.Rows[index]["DESCONTO"]),
                                Convert.ToDouble(dttRetorno.Rows[index]["VALOR"]),
                                Convert.ToDouble(dttRetorno.Rows[index]["IPI"]),
                                Convert.ToInt32(dttRetorno.Rows[index]["ITEM"]));

                        continue;


                    }
                }
                if (_princ.edit == true)
                {

                    for (int index = 0; index < dttRetorno.Rows.Count; index++)
                    {
                        if ((string)dttRetorno.Rows[index]["Status"] == "A")
                        {
                            COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter();
                            table.Insert(Convert.ToInt32(txtPedido.Text),
                                 Convert.ToInt32(dttRetorno.Rows[index]["CODPRODUTO"]),
                                    Convert.ToInt32(dttRetorno.Rows[index]["QUANTIDADE"]),
                                    Convert.ToInt32(dttRetorno.Rows[index]["QUANTIDADELIB"]),
                                    Convert.ToDouble(dttRetorno.Rows[index]["DESCONTO"]),
                                    Convert.ToDouble(dttRetorno.Rows[index]["VALOR"]),
                                    Convert.ToDouble(dttRetorno.Rows[index]["IPI"]),
                                    Convert.ToInt32(dttRetorno.Rows[index]["ITEM"]));

                            continue;

                        }
                        if (statusped == 1)
                        {
                            Excluiritem(Convert.ToInt32(txtPedido.Text), Convert.ToInt32(dttRetorno.Rows[index]["ITEM"]));

                            COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter tableinsert = new Comercial.COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter();
                            tableinsert.Insert(Convert.ToInt32(txtPedido.Text),
                                 Convert.ToInt32(dttRetorno.Rows[index]["CODPRODUTO"]),
                                    Convert.ToInt32(dttRetorno.Rows[index]["QUANTIDADE"]),
                                    Convert.ToInt32(dttRetorno.Rows[index]["QUANTIDADELIB"]),
                                    Convert.ToDouble(dttRetorno.Rows[index]["DESCONTO"]),
                                    Convert.ToDouble(dttRetorno.Rows[index]["VALOR"]),
                                    Convert.ToDouble(dttRetorno.Rows[index]["IPI"]),
                                    Convert.ToInt32(dttRetorno.Rows[index]["ITEM"]));

                            continue;
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return 0;
        }

        #endregion

        #region GetNumero Pedido
        public int GetNrPedido()
        {

            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append(" select top 1 * from PEDIDO order by nrpedido desc");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            int codigopedido = (int)db.ExecuteScalar(dbComd);


            return codigopedido;


        }
        #endregion

        #region Listar item pedido
        public DataTable ListarItem(int CodPed)
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append(" SELECT ITEM,ITEMPEDIDO.CODPRODUTO,DESCRICAO,QUANTIDADE,ISNULL(QUANTIDADELIB,0) as QUANTIDADELIB,");
            sqlcommand.Append(" DESCONTO,VALOR,ITEMPEDIDO.IPI, ((QUANTIDADE * VALOR) - QUANTIDADE * VALOR * DESCONTO /100) as VALORTOTAL ");
            sqlcommand.Append(" FROM ITEMPEDIDO INNER JOIN PRODUTO ON ITEMPEDIDO.CODPRODUTO = PRODUTO.CODPRODUTO ");
            sqlcommand.Append(" WHERE NRPEDIDO = @nrpedido ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@nrpedido", DbType.String, CodPed);

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];




        }
        #endregion

        #region ListarClienteDataGridView Pesquisa

        public DataTable ListarCliente()
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select cnpj, razaosocial from Cliente");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];

        }
        #endregion

        #region ListarVendedorDataGridView Pesquisa

        public DataTable ListarVendedor()
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select CPF, NOME from Vendedor");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];

        }
        #endregion

        #region ListarCondicaoPagtoDataGridView Pesquisa

        public DataTable ListarCondicaoPagto()
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select * from CONDICAOPAGAMENTO");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];

        }
        #endregion

        #region ListarTransportadoraDataGridView Pesquisa
        public DataTable ListaTransportadora()
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select CNPJ,NOME from TRANSPORTADORA");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];

        }
        #endregion

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

        #region PopularGrid
        public void populargrid()
        {

            // DataTable dttRetorno = new DataTable();

            int numeropedido;
            try
            {
                if (txtPedido.Text != String.Empty)
                {
                    numeropedido = Convert.ToInt32(txtPedido.Text);

                    dttRetorno = ListarItem(numeropedido);

                    dttRetorno.Columns.Add("Status", typeof(string));
                    
                    Double total = 0;

                    for (int index = 0; index < dttRetorno.Rows.Count; index++)
                    {

                       
                        total = Convert.ToDouble(total) + Convert.ToDouble(dttRetorno.Rows[index]["VALORTOTAL"]);
                        
                        lblValortotal.Text = Convert.ToString(total);
                        
                    }

                    string ValorFrete = txtFrete.Text.Replace("R$", "").Replace(".", "");
                    double Valortotalfrete = Convert.ToDouble(total) + Convert.ToDouble(ValorFrete);

                    lblValortotal.Text = string.Format("{0:C2}", Convert.ToDouble(Valortotalfrete));
                    
                    //lblValortotal.Text = Convert.ToString(Valortotalfrete);
                   
                    dtgrdvItenspven.DataSource = dttRetorno;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Chama Form Pesquisa

        #region Cliente
        private void txtcodCli_ButtonClick(object sender, EventArgs e)
        {


            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.dtGrdVwVis.DataSource = ListarCliente();
            x.Text = "Pesquisa Cadastro de Cliente";

            x.ShowDialog();

        }

        #endregion

        #region Vendedor
        private void txtCodVendedor_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.dtGrdVwVis.DataSource = ListarVendedor();
            x.Text = "Pesquisa Cadastro de Vendedor";

            x.ShowDialog();
        }
        #endregion

        #region Condição Pagto
        private void txtCondPagto_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.dtGrdVwVis.DataSource = ListarCondicaoPagto();
            x.Text = "Pesquisa Cadastro de Condição Pagamento";

            x.ShowDialog();
        }
        #endregion

        #region Transportadora
        private void txtCodTransportadora_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.dtGrdVwVis.DataSource = ListaTransportadora();
            x.Text = "Pesquisa Cadastro de Transportadora";

            x.ShowDialog();
        }

        #endregion

        #region Produto
        private void txtProduto_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.dtGrdVwVis.DataSource = ListaProduto();
            x.Text = "Pesquisa Cadastro de Produto";

            x.ShowDialog();
        }
        #endregion
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

        #region Listar Excluiritem
        public void Excluiritem(int CodPed, int Item)
        {
            Database db = DatabaseFactory.CreateDatabase();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("DELETE FROM ITEMPEDIDO WHERE NRPEDIDO =  @NRPEDIDO AND ITEM = @ITEM ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@NRPEDIDO", DbType.Int32, CodPed);
            db.AddInParameter(dbComd, "@ITEM", DbType.String, Item);

            db.ExecuteScalar(dbComd);

        }
        #endregion

        #region Listar UpdateItem
        public void UpdateItem(int CodPed, int Item, int quant)
        {
            Database db = DatabaseFactory.CreateDatabase();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("UPDATE ITEMPEDIDO SET QUANTIDADE = @QUANTIDADE WHERE NRPEDIDO=@NRPEDIDO AND ITEM = @ITEM ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@NRPEDIDO", DbType.Int32, CodPed);
            db.AddInParameter(dbComd, "@ITEM", DbType.Int32, Item);
            db.AddInParameter(dbComd, "@QUANTIDADE", DbType.Int32, quant);

            db.ExecuteScalar(dbComd);

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

        #region Validação

        #region ValidaSituacao
        public void validaSituacao()
        {
            try
            {
                if (chkEfetivado.Checked == true)
                {
                    MessageBox.Show("Pedido não pode ser alterado pois já está Efetivado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _princ.novo();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        #endregion

        #region ValidaControles
        public void ValidaControles()
        {
            try
            {
                txtPedido.Enabled = false;
                txtNomeCliente.Enabled = false;
                txtNomeTransportadora.Enabled = false;
                txtNomeVendedor.Enabled = false;
                grpBxSitPed.Enabled = false;
                grpTipoPedido.Enabled = false; 
                txtcodCli.Enabled = false;
                txtCodTransportadora.Enabled = false;
                txtCodVendedor.Enabled = false;
                txtCondPagto.Enabled = false;
                dtpEmissao.Enabled = false;
                txtFrete.Enabled = true;
                lblFrete.Enabled = true;
                dtpEntrega.Enabled = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #endregion

        #region Excluir Item do Grid
        private void dtgrdvItenspven_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Criação do Datarow para adicionar os itens
                DataRow dtRow;
                dtRow = dttRetorno.NewRow();

                if (e.RowIndex >= 0)
                {
                    DataGridViewImageColumn imagecolumn = new DataGridViewImageColumn();

                    if (e.ColumnIndex == 0)
                    {

                        if (MessageBox.Show("Deseja excluir o registro selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if ((string)dttRetorno.Rows[e.RowIndex]["status"] == "A")
                            {
                                dttRetorno.Rows.RemoveAt(e.RowIndex);
                            }
                            else
                            {
                                Excluiritem(Convert.ToInt32(txtPedido.Text), Convert.ToInt32(dtgrdvItenspven.Rows[e.RowIndex].Cells[1].Value));

                                this.populargrid();
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion

        #region Adicionar Item Novo
        public void additemnovo()
        {
            try
            {

                //Valida a quantidade for = 0
                if (Convert.ToInt32(txtQtdItem.Text) == 0)
                {
                    throw new Exception("Quantidade");
                }
                //Valida a quantidade for negativa
                if (Convert.ToInt32(txtQtdItem.Text) < 0)
                {
                    throw new Exception("QuantidadeNegativa");
                }

                //Replace no valor total de "." para ","
                string valortotal = (String)txtValorTotal.Text.Replace("R$", "");
     

                //Valida o Valor total = 0
                if (Convert.ToDouble(valortotal) == 0)
                {
                    throw new Exception("valortotal");
                }

                //Valida o Valor total negativo
                if (Convert.ToDouble(valortotal) < 0)
                {
                    throw new Exception("valortotalnegativo");
                }

                txtPrcUnit.Text = (String)txtPrcUnit.Text.Replace("R$", "");

                //Valida o preço unitário = 0
                if (Convert.ToDouble(txtPrcUnit.Text) == 0)
                {
                    throw new Exception("PrecoUnitario");
                }

                //valida o preço unitário negativo
                if (Convert.ToDouble(txtPrcUnit.Text) < 0)
                {
                    throw new Exception("PrecoUnitarioNegativo");
                }

                //Criação do Datarow para adicionar os itens
                DataRow dtRow;
                dtRow = dttRetorno.NewRow();

                var teste = 0;
                foreach (DataGridViewRow item in dtgrdvItenspven.Rows)
                {

                    if (txtProduto.getText == Convert.ToString(item.Cells[2].Value))
                    {
                        txtValorTotal.Text = "";
                        txtQtdItem.Text = Convert.ToString(Convert.ToInt32(txtQtdItem.Text) + Convert.ToInt32(item.Cells[4].Value));
                        txtValorTotal.Text = Convert.ToString(Convert.ToDouble(valortotal) + Convert.ToDouble(item.Cells[8].Value));

                        item.Cells[4].Value = txtQtdItem.Text;
                        item.Cells[8].Value = txtValorTotal.Text;
                        teste += 1;
                    }
                }
                if (teste == 0)
                {

                    
                    dtRow["CODPRODUTO"] = txtProduto.getText;
                    dtRow["DESCRICAO"] = txtDescprod.Text;
                    dtRow["QUANTIDADE"] = txtQtdItem.Text;
                    dtRow["QUANTIDADELIB"] = Convert.ToInt32(0);
                    dtRow["VALOR"] = Convert.ToDouble(txtPrcUnit.Text);
                    dtRow["IPI"] = txtipi.Text;
                    dtRow["DESCONTO"] = txtDesconto.Text;
                    dtRow["VALORTOTAL"] = Convert.ToDouble(valortotal);
                    dttRetorno.Rows.Add(dtRow);
                }
                for (int index = 0; index <= dttRetorno.Rows.Count - 1; index++)
                {
                    dttRetorno.Rows[index][0] = index + 1;
                    continue;
                }


                dtgrdvItenspven.DataSource = dttRetorno;

                this.Limparitens();
            }
            catch (Exception ex)
            {
                Validacoes valida = new Validacoes();
                valida.tratarSystemExceções(ex);
            }
        }
        #endregion

        #region Adicionar Item Editar


        public void additemeditar()
        {
            try
            {
                //Valida a quantidade for = 0
                if (Convert.ToInt32(txtQtdItem.Text) == 0)
                {
                    throw new Exception("Quantidade");
                }
                //Valida a quantidade for negativa
                if (Convert.ToInt32(txtQtdItem.Text) < 0)
                {
                    throw new Exception("QuantidadeNegativa");
                }

                //Replace no valor total de "." para ","
                String valortotal = (String)txtValorTotal.Text.Replace(".", ",");

                //Valida o Valor total = 0
                if (Convert.ToDouble(valortotal) == 0)
                {
                    throw new Exception("valortotal");
                }

                //Valida o Valor total negativo
                if (Convert.ToDouble(valortotal) < 0)
                {
                    throw new Exception("valortotalnegativo");
                }

                //Valida o preço unitário = 0
                if (Convert.ToDouble(txtPrcUnit.Text) == 0)
                {
                    throw new Exception("PrecoUnitario");
                }

                //valida o preço unitário negativo
                if (Convert.ToDouble(txtPrcUnit.Text) < 0)
                {
                    throw new Exception("PrecoUnitarioNegativo");
                }

                //Criação do Datarow para adicionar os itens
                DataRow dtRow;
                dtRow = dttRetorno.NewRow();

                var teste = 0;
                #region For Antigo
                //foreach (DataGridViewRow item in dtgrdvItenspven.Rows)
                //{
                //    //Verifico se o produto existe, se existir ele atualiza a quantidade com o preço total
                //    if (txtProduto.getText == Convert.ToString(item.Cells["ColProd"].Value))
                //    {
                //        txtValorTotal.Text = "";
                //        txtQtdItem.Text = Convert.ToString(Convert.ToInt32(txtQtdItem.Text) + Convert.ToInt32(item.Cells[4].Value));
                //        txtValorTotal.Text = Convert.ToString(Convert.ToDouble(valortotal) + Convert.ToDouble(item.Cells[8].Value));

                //        item.Cells[4].Value = txtQtdItem.Text;
                //        item.Cells[8].Value = txtValorTotal.Text;

                //        dtRow["CODPRODUTO"] = item.Cells[2].Value;
                //        dtRow["DESCRICAO"] = item.Cells[3].Value;
                //        dtRow["QUANTIDADE"] = item.Cells[4].Value;
                //        dtRow["VALOR"] = item.Cells[5].Value;
                //        dtRow["IPI"] = item.Cells[6].Value;
                //        dtRow["DESCONTO"] = item.Cells[7].Value;
                //        dtRow["VALORTOTAL"] = item.Cells[8].Value;
                //        dtRow["status"] = "A";
                //        dttRetorno.Rows.Add(dtRow);

                //        // Excluiritem(Convert.ToInt32(txtPedido.Text), Convert.ToInt32(item.Cells["ClmItem"].Value));
                //        teste += 1;

                //    }
                //}
                #endregion

                foreach (DataGridViewRow item in dtgrdvItenspven.Rows)
                {
                    //Verifico se o produto existe, se existir ele atualiza a quantidade com o preço total
                    if (txtProduto.getText == Convert.ToString(item.Cells["ColProd"].Value))
                    {
                        txtValorTotal.Text = "";
                        txtQtdItem.Text = Convert.ToString(Convert.ToInt32(txtQtdItem.Text) + Convert.ToInt32(item.Cells[4].Value));
                        txtValorTotal.Text = Convert.ToString(Convert.ToDouble(valortotal) + Convert.ToDouble(item.Cells[8].Value));

                        item.Cells[4].Value = txtQtdItem.Text;
                        item.Cells[8].Value = txtValorTotal.Text;
                        dtRow["status"] = "A";
                        teste += 1;
                        statusped += 1;

                    }
                }
                //se o produto não existir no datagrid ele adiciona o item novo
                if (teste == 0)
                {
                    dtRow["CODPRODUTO"] = txtProduto.getText;
                    dtRow["DESCRICAO"] = txtDescprod.Text;
                    dtRow["QUANTIDADE"] = txtQtdItem.Text;
                    dtRow["QUANTIDADELIB"] = 0;
                    dtRow["VALOR"] = txtPrcUnit.Text;
                    dtRow["IPI"] = txtipi.Text;
                    dtRow["DESCONTO"] = txtDesconto.Text;
                    dtRow["VALORTOTAL"] = valortotal;
                    dtRow["status"] = "A";
                    dttRetorno.Rows.Add(dtRow);


                }

                //for para verificação do item
                for (int index = 0; index <= dttRetorno.Rows.Count - 1; index++)
                {
                    dttRetorno.Rows[index][0] = index + 1;
                    continue;
                }

                //Popula o grid com o datatable
                dtgrdvItenspven.DataSource = dttRetorno;

                //Método para limpar os campos após insert dos itens
                this.Limparitens();
            }
            catch (Exception ex)
            {
                Validacoes valida = new Validacoes();
                valida.tratarSystemExceções(ex);
            }
        }
        #endregion

        public int AtualizarPedido()
        {
            try
            {
                DataTable dttItemPedido = ListarItem(Convert.ToInt32(txtPedido.Text));
                DataColumn dtrow = dttItemPedido.Columns["CODPRODUTO"];

                grpBxItPedVen.Enabled = false;

                SalvarPedidoDeta();



                return 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private void chkNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNormal.Checked)
            {
                chkComplemento.Checked = false;
            }
        }

        private void chkComplemento_CheckedChanged(object sender, EventArgs e)
        {
            if (chkComplemento.Checked)
            {
                chkNormal.Checked = false;
            }
        }

        private void txtQtdItem_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtQtdItem.Text) && !String.IsNullOrEmpty(txtPrcUnit.Text))
            {

                string PrecoUnit = txtPrcUnit.Text.Replace("R$", "").Replace(".", "");
                string valortotal = Convert.ToString(Convert.ToDouble(txtQtdItem.Text) * Convert.ToDouble(PrecoUnit));

                txtValorTotal.Text = string.Format("{0:C2}", Convert.ToDouble(valortotal));

            
            }
        }

        #region Desabilitacontroles
        public void desabilitacontroles()
        {
            try
            {
                txtNomeCliente.Enabled = false;
                txtNomeTransportadora.Enabled = false;
                txtNomeVendedor.Enabled = false;
                txtPedido.Enabled = false;
                txtPrcUnit.Enabled = false;
                txtDescprod.Enabled = false;
                txtDesconto.Enabled = false;
                txtEstAtual.Enabled = false;
                txtipi.Enabled = false;
                txtUM.Enabled = false;
                txtValorTotal.Enabled = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion


    }
}
