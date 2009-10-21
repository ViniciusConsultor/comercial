﻿using System;
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
        DataTable dttRetorno = new DataTable();

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

            if (dtgrdvItenspven.RowCount == 0)
            {
                MessageBox.Show("Operação Cancelada, pois não existe itens para este pedido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Util.Interface.ChangeControlStatus(this, false);

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
                       Convert.ToString(objPedido["CODTRANSPORTADORA"].ToString()));
            }



            this.SalvarPedidoDeta();

            return 0;

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
            else if (objPedido["SITUACAO"].ToString() == "C")
            {
                chkCancelado.Checked = true;
            }
            else
            {
                chkEfetivado.Checked = false;
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
            dttRetorno.Columns.Add("VALOR", typeof(double));
            dttRetorno.Columns.Add("IPI", typeof(double));
            dttRetorno.Columns.Add("DESCONTO", typeof(double));

            dttRetorno.AcceptChanges();


            return dttRetorno;


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
            txtPrcVen.Text = String.Empty;
            txtQtdItem.Text = String.Empty;
            txtPrcUnit.Text = String.Empty;
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
            txtDescprod.Text = String.Empty;
            txtEstAtual.Text = String.Empty;
            txtUM.Text = String.Empty;
            txtPrcVen.Text = String.Empty;
            txtQtdItem.Text = String.Empty;
            txtPrcUnit.Text = String.Empty;
            txtDesconto.Text = String.Empty;
            txtipi.Text = String.Empty;

        }

        #endregion

        #region Adicionar LinhasDatatable

        private void btnAdditen_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(txtQtdItem.Text);
            int estoqueatual = Convert.ToInt32(txtEstAtual.Text);

            DataRow dtRow;

            try
            {

                if (quantidade > estoqueatual)
                {
                    MessageBox.Show("A Quantidade não pode ser maior que o estoque atual.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtRow = dttRetorno.NewRow();

                    //dtRow[1] = txtProduto.getText;
                    //dtRow[2] = txtDescprod.Text;
                    //dtRow[3] = txtQtdItem.Text;
                    //dtRow[4] = txtPrcUnit.Text;
                    //dtRow[5] = txtipi.Text;
                    //dtRow[6] = txtDesconto.Text;

                    dtRow["CODPRODUTO"] = txtProduto.getText;
                    dtRow["DESCRICAO"] = txtDescprod.Text;
                    dtRow["QUANTIDADE"] = txtQtdItem.Text;
                    dtRow["VALOR"] = txtPrcUnit.Text;
                    dtRow["IPI"] = txtipi.Text;
                    dtRow["DESCONTO"] = txtDesconto.Text;

                    dttRetorno.Rows.Add(dtRow);

                    for (int index = 0; index <= dttRetorno.Rows.Count - 1; index++)
                    {
                        dttRetorno.Rows[index][0] = index + 1;
                        continue;
                    }

                    dtgrdvItenspven.DataSource = dttRetorno;



                    this.Limparitens();
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

            //  DataRowView objPedidoItem;
            // objPedidoItem = (DataRowView)iTEMPEDIDOBindingSource.Current;

            int CodPed = GetNrPedido();

            try
            {

                for (int index = 0; index < dtgrdvItenspven.RowCount; index++)
                {
                    COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter();
                    table.Insert(Convert.ToInt32(CodPed),
                         Convert.ToInt32(dtgrdvItenspven.Rows[index].Cells[2].Value),
                            Convert.ToInt32(dtgrdvItenspven.Rows[index].Cells[4].Value),
                            Convert.ToDouble(dtgrdvItenspven.Rows[index].Cells[7].Value),
                            Convert.ToDouble(dtgrdvItenspven.Rows[index].Cells[5].Value),
                            Convert.ToDouble(dtgrdvItenspven.Rows[index].Cells[6].Value),
                            Convert.ToInt32(dtgrdvItenspven.Rows[index].Cells[1].Value));

                    //objPedidoItem["ITEM"] = Convert.ToInt32(dtgrdvItenspven.Rows[index].Cells[1].Value);
                    //objPedidoItem["NRPEDIDO"] = Convert.ToInt32(CodPed);
                    //objPedidoItem["CODPRODUTO"] = Convert.ToInt32(dtgrdvItenspven.Rows[index].Cells[2].Value);
                    //objPedidoItem["QUANTIDADE"] = Convert.ToInt32(dtgrdvItenspven.Rows[index].Cells[3].Value);
                    //objPedidoItem["VALOR"] = Convert.ToDouble(dtgrdvItenspven.Rows[index].Cells[4].Value);
                    //objPedidoItem["IPI"] = Convert.ToDouble(dtgrdvItenspven.Rows[index].Cells[5].Value);
                    //objPedidoItem["DESCONTO"] = Convert.ToDouble(dtgrdvItenspven.Rows[index].Cells[6].Value);

                    //COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter();
                    //table.Insert(Convert.ToInt32(objPedidoItem["NRPEDIDO"].ToString()),
                    //    Convert.ToInt32(objPedidoItem["CODPRODUTO"].ToString()),
                    //    Convert.ToInt32(objPedidoItem["QUANTIDADE"].ToString()),
                    //    Convert.ToInt32(objPedidoItem["DESCONTO"].ToString()),
                    //    Convert.ToInt32(objPedidoItem["VALOR"].ToString()),
                    //    Convert.ToInt32(objPedidoItem["IPI"].ToString()),
                    //    Convert.ToInt32(objPedidoItem["ITEM"].ToString()));

                    continue;

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

            sqlcommand.Append(" SELECT ITEM,ITEMPEDIDO.CODPRODUTO,DESCRICAO,QUANTIDADE,DESCONTO,VALOR,ITEMPEDIDO.IPI ");
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

            DataTable dttRetorno = new DataTable();

            int numeropedido;
            try
            {
                if (txtPedido.Text != String.Empty)
                {
                    numeropedido = Convert.ToInt32(txtPedido.Text);

                    dttRetorno = ListarItem(numeropedido);

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
                grpBxPedVenda.Enabled = false;
                //txtPedido.Enabled = false;
                //txtcodCli.Enabled = false;
                //txtNomeCliente.Enabled = false;
                //txtNomeVendedor.Enabled = false;
                //txtNomeTransportadora.Enabled = false;
                //txtCodTransportadora.Enabled = false;
                //txtCodVendedor.Enabled = false;
                //txtCondPagto.Enabled = false;
                //grpBxSitPed.Enabled = false;
                //grpTipoPedido.Enabled = false;
                //dtpEmissao.Enabled = false;
                //dtpEntrega.Enabled = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #endregion


        private void dtgrdvItenspven_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewImageColumn imagecolumn = new DataGridViewImageColumn();

                    if (e.ColumnIndex == 0)
                    {
                        if (dttRetorno.Rows.Count != 0)
                        {
                            dttRetorno.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {

                            //COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter();
                            //table.Delete(Convert.ToInt32(txtPedido.Text),
                            //    Convert.ToInt32(dtgrdvItenspven.Rows[e.RowIndex].Cells[2].Value),
                            //    Convert.ToInt32(dtgrdvItenspven.Rows[e.RowIndex].Cells[4].Value),
                            //    Convert.ToDouble(dtgrdvItenspven.Rows[e.RowIndex].Cells[7].Value),
                            //    Convert.ToDouble(dtgrdvItenspven.Rows[e.RowIndex].Cells[5].Value),
                            //    Convert.ToDouble(dtgrdvItenspven.Rows[e.RowIndex].Cells[6].Value),
                            //    Convert.ToInt32(dtgrdvItenspven.Rows[e.RowIndex].Cells[1].Value));

                            //this.populargrid();
                        }

                    }
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public int AtualizarPedido()
        {
            try
            {

                grpBxItPedVen.Enabled = false;


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
    }
}
