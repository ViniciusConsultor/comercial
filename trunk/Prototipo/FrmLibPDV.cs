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

        public FrmLibPDV(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        private void rptConProd1_InitReport(object sender, EventArgs e)
        {

        }

        private void txtNumPed_ButtonClick(object sender, EventArgs e)
        {
            //FrmVisGeral x = new FrmVisGeral(this);
            //x.ShowDialog();

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

            sqlcommand.Append(" SELECT NRPEDIDO, TIPO, ped.CODCLIENTE, CODVENDEDOR,CODCONDICAOPAGAMENTO, CODTRANSPORTADORA,  DATAEMISSAO, DATAENTREGA ");
            sqlcommand.Append(" FROM PEDIDO ped INNER JOIN CLIENTE cli ON ped.CODCLIENTE = cli.CNPJ ");
            sqlcommand.Append(" WHERE SITUACAO <> 'C'");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];

        }
        #endregion

        private void txtbtnPedido_ButtonClick(object sender, EventArgs e)
        {

            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.dtGrdVwVis.DataSource = ListarPedido();
            x.Text = "Pesquisa Cadastro de Cliente";
            
            x.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pEDIDOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pEDIDOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void pEDIDOBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pEDIDOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void FrmLibPDV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.PEDIDO' table. You can move, or remove it, as needed.
            this.pEDIDOTableAdapter.Fill(this.cOMERCIALDataSet.PEDIDO);

        }

        //private void pEDIDOBindingSource_PositionChanged(object sender, EventArgs e)
        //{
        //    DataRowView objPedido;
        //    objPedido = (DataRowView)pEDIDOBindingSource.Current;


        //    //if (objPedido["SITUACAO"].ToString() == "E")
        //    //{
        //    //    chkEfetivado.Checked = true;
        //    //}
        //    //else if (objPedido["SITUACAO"].ToString() == "C")
        //    //{
        //    //    chkCancelado.Checked = true;
        //    //}
        //    //else
        //    //{
        //    //    chkEfetivado.Checked = false;
        //    //}

        //    //if (objPedido["SITUACAO"].ToString() == "P")
        //    //{
        //    //    chkPendente.Checked = true;
        //    //}
        //    //else
        //    //{
        //    //    chkPendente.Checked = false;
        //    //}

        //    if (objPedido["TIPO"].ToString() == "N")
        //    {
        //        chkNormal.Checked = true;
        //    }
        //    else
        //    {
        //        chkNormal.Checked = false;
        //    }


        //    if (objPedido["TIPO"].ToString() == "C")
        //    {
        //        chkComplemento.Checked = true;
        //    }
        //    else
        //    {
        //        chkComplemento.Checked = false;
        //    }

        //    txtCodCliente.Text = objPedido["CODCLIENTE"].ToString();
        //    txtCodVendedor.Text = objPedido["CODVENDEDOR"].ToString();
        //    txtCondPagto.Text = objPedido["CODCONDICAOPAGAMENTO"].ToString();
        //    txtCodTransportadora.Text = objPedido["CODTRANSPORTADORA"].ToString();
        //}

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
                if (txtbtnPedido.getText != String.Empty)
                {
                    numeropedido = Convert.ToInt32(txtbtnPedido.getText);

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

            sqlcommand.Append(" SELECT ITEM,ITEMPEDIDO.CODPRODUTO,DESCRICAO,QUANTIDADE,DESCONTO,VALOR,ITEMPEDIDO.IPI, (QUANTIDADE *VALOR) as VALORTOTAL ");
            sqlcommand.Append(" FROM ITEMPEDIDO INNER JOIN PRODUTO ON ITEMPEDIDO.CODPRODUTO = PRODUTO.CODPRODUTO ");
            sqlcommand.Append(" WHERE NRPEDIDO = @nrpedido ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@nrpedido", DbType.String, CodPed);

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];




        }
        #endregion

        //private void FrmLibPDV_Shown(object sender, EventArgs e)
        //{
        //    txtNomeCliente.Text = Convert.ToString(ListarNomeCliente(txtCodCliente.Text));
        //    txtNomeTransportadora.Text = Convert.ToString(ListarNomeTransportadora(txtCodTransportadora.Text));              txtNomeVendedor.Text = Convert.ToString(ListarNomeVendedor(txtCodVendedor.Text));
        //}
    }
}
