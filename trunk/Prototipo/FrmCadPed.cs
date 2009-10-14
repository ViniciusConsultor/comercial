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
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.TRANSPORTADORA' table. You can move, or remove it, as needed.
            this.tRANSPORTADORATableAdapter.Fill(this.cOMERCIALDataSet.TRANSPORTADORA);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.PEDIDO' table. You can move, or remove it, as needed.
            this.pEDIDOTableAdapter.Fill(this.cOMERCIALDataSet.PEDIDO);

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

        
            if (chkCancelado.Checked)
            {

                objPedido["SITUACAO"] = "C";
            }
            else if (chkEfetivado.Checked)
            {
                objPedido["SITUACAO"] = "E";
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

            objPedido["CODCLIENTE"] = txtcodCli.getText;
            objPedido["CODVENDEDOR"] = txtCodVendedor.getText;
            objPedido["CODCONDICAOPAGAMENTO"] = txtCondPagto.getText;
            //objPedido["NRPEDIDO"] = txtPedido.Text;
            objPedido["CODTRANSPORTADORA"] = txtCodTransportadora.getText;


            return 0;

        }
        #endregion

        #region PositionChanged

        private void pEDIDOBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DataRowView objPedido;
            objPedido = (DataRowView)pEDIDOBindingSource.Current;

            if (objPedido["SITUACAO"].ToString() == "C")
            {
                chkCancelado.Checked = true;
            }
            else
            {
                chkCancelado.Checked = false;
            }
            if (objPedido["SITUACAO"].ToString() == "E")
            {
                chkEfetivado.Checked = true;
            }
            else
            {
                chkPendente.Checked = false;
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



        }
        #endregion

        #region AddItemDataTable
        public DataTable CriarDataTable()
        {

            DataTable dttRetorno = new DataTable();

            dttRetorno.Columns.Add("ITEM", typeof(int));
            dttRetorno.Columns.Add("CODPRODUTO", typeof(int));
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

            txtDescprod.Text = String.Empty;
            txtEstAtual.Text = String.Empty;
            txtUM.Text = String.Empty;
            txtPrcVen.Text = String.Empty;
            txtQtdItem.Text = String.Empty;
            txtPrcUnit.Text = String.Empty;
            txtVlrtotal.Text = String.Empty;
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
            txtVlrtotal.Text = String.Empty;
            txtDesconto.Text = String.Empty;
            txtipi.Text = String.Empty;

        }

        #endregion

        #region Adicionar LinhasDatatable

        private void btnAdditen_Click(object sender, EventArgs e)
        {

            DataRow dtRow;

            try
            {

                dtRow = dttRetorno.NewRow();

                dtRow["CODPRODUTO"] = txtProduto.getText;
                dtRow["QUANTIDADE"] = txtQtdItem.Text;
                dtRow["VALOR"] = txtPrcUnit.Text;
                dtRow["IPI"] = txtipi.Text;
                dtRow["DESCONTO"] = txtDesconto.Text;

                dttRetorno.Rows.Add(dtRow);

                for (int index = 0; index <= dttRetorno.Rows.Count - 1; index++)
                {
                    dttRetorno.Rows[index]["ITEM"] = index + 1;
                    continue;
                }

                dtgrdvItenspven.DataSource = dttRetorno;

                this.Limparitens();
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
           
            DataRowView objPedidoItem;
            objPedidoItem = (DataRowView)iTEMPEDIDOBindingSource.Current;
           
            int CodPed = GetNrPedido();

            try
            {

                for (int index = 0; index < dtgrdvItenspven.RowCount; index++)
                {
                    objPedidoItem["ITEM"] = Convert.ToInt32(dtgrdvItenspven.Rows[index].Cells[1].Value);
                    objPedidoItem["NRPEDIDO"] = Convert.ToInt32(CodPed);
                    objPedidoItem["CODPRODUTO"] = Convert.ToInt32(dtgrdvItenspven.Rows[index].Cells[2].Value);
                    objPedidoItem["QUANTIDADE"] = Convert.ToInt32(dtgrdvItenspven.Rows[index].Cells[3].Value);
                    objPedidoItem["VALOR"] = Convert.ToDouble(dtgrdvItenspven.Rows[index].Cells[4].Value);
                    objPedidoItem["IPI"] = Convert.ToDouble(dtgrdvItenspven.Rows[index].Cells[5].Value);
                    objPedidoItem["DESCONTO"] = Convert.ToDouble(dtgrdvItenspven.Rows[index].Cells[6].Value);

                    COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter();
                    table.Insert(Convert.ToInt32(objPedidoItem["NRPEDIDO"].ToString()),
                        Convert.ToInt32(objPedidoItem["CODPRODUTO"].ToString()),
                        Convert.ToInt32(objPedidoItem["QUANTIDADE"].ToString()),
                        Convert.ToInt32(objPedidoItem["DESCONTO"].ToString()),
                        Convert.ToInt32(objPedidoItem["VALOR"].ToString()),
                        Convert.ToInt32(objPedidoItem["IPI"].ToString()),
                        Convert.ToInt32(objPedidoItem["ITEM"].ToString()));

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

            sqlcommand.Append("select * from itempedido where nrpedido = @nrpedido");

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

        #region ListarTransportadoraDataGridView Pesquisa
        public DataTable ListaProduto()
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select CODPRODUTO,DESCRICAO,CODUNIDADEMEDIDA,ESTOQUEATUAL,PRECOVENDA from Produto");

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

        private void FrmCadPed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.ITEMPEDIDO' table. You can move, or remove it, as needed.
            this.iTEMPEDIDOTableAdapter.Fill(this.cOMERCIALDataSet.ITEMPEDIDO);

        }

        private void FrmCadPed_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.PRODUTO' table. You can move, or remove it, as needed.
            this.pRODUTOTableAdapter.Fill(this.cOMERCIALDataSet.PRODUTO);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.ITEMPEDIDO' table. You can move, or remove it, as needed.
            this.iTEMPEDIDOTableAdapter.Fill(this.cOMERCIALDataSet.ITEMPEDIDO);

        }

    }
}
