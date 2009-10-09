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
        private COMERCIALDataSet _dataset;

        public FrmCadPed(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
            _princ.bindingNavigator1.BindingSource = pEDIDOBindingSource;
            _princ.setdataSet(cOMERCIALDataSet);
            _princ.novo();
        }

        private void textButton1_ButtonClick_1(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

        private void textButton4_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();

        }

        private void textButton2_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

        private void textButton5_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

        private void textButton3_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
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

        }
        #endregion

        #region AddItemDataTable
        public DataTable CriarDataTable()
        {

            DataTable dttRetorno = new DataTable();

            dttRetorno.Columns.Add("ITEM", typeof(int));
            dttRetorno.Columns.Add("CODPRODUTO", typeof(int));
            dttRetorno.Columns.Add("QUANTIDADE", typeof(int));
            dttRetorno.Columns.Add("DESCONTO", typeof(double));
            dttRetorno.Columns.Add("VALOR", typeof(double));
            dttRetorno.Columns.Add("IPI", typeof(double));

            dttRetorno.AcceptChanges();


            return dttRetorno;


        }

        #endregion

        #region LimparCampos
        public void Limparitens()
        {
            cmbProduto.SelectedValue = 0;
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

        private void rdbAddITem_Click(object sender, EventArgs e)
        {

            DataRow dtRow;

            try
            {

                dtRow = dttRetorno.NewRow();

                dtRow["CODPRODUTO"] = cmbProduto.SelectedValue;
                dtRow["QUANTIDADE"] = txtQtdItem.Text;
                dtRow["DESCONTO"] = txtDesconto.Text;
                dtRow["VALOR"] = txtPrcUnit.Text;
                dtRow["IPI"] = txtipi.Text;

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

            DataRowView objPedido;
            objPedido = (DataRowView)iTEMPEDIDOBindingSource.Current;
            int CodPed = GetNrPedido();

            try
            {

                for (int index = 0; index < dtgrdvItenspven.RowCount; index++)
                {
                    objPedido["ITEM"] = Convert.ToInt32(dtgrdvItenspven.Rows[index].Cells[1].Value);
                    objPedido["NRPEDIDO"] = Convert.ToInt32((CodPed));
                    objPedido["CODPRODUTO"] = Convert.ToInt32(dtgrdvItenspven.Rows[index].Cells[2].Value);
                    objPedido["QUANTIDADE"] = Convert.ToInt32(dtgrdvItenspven.Rows[index].Cells[3].Value);
                    objPedido["VALOR"] = Convert.ToDouble(dtgrdvItenspven.Rows[index].Cells[4].Value);
                    objPedido["IPI"] = Convert.ToDouble(dtgrdvItenspven.Rows[index].Cells[5].Value);
                    objPedido["DESCONTO"] = Convert.ToDouble(dtgrdvItenspven.Rows[index].Cells[6].Value);

                    COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter();
                    table.Insert(Convert.ToInt32(objPedido["NRPEDIDO"].ToString()),
                        Convert.ToInt32(objPedido["CODPRODUTO"].ToString()),
                        Convert.ToInt32(objPedido["QUANTIDADE"].ToString()),
                        Convert.ToInt32(objPedido["DESCONTO"].ToString()),
                        Convert.ToInt32(objPedido["VALOR"].ToString()),
                        Convert.ToInt32(objPedido["IPI"].ToString()),
                        Convert.ToInt32(objPedido["DESCONTO"].ToString()));

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

        public int GetNrPedido()
        {

            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select top 1 * from PEDIDO order by nrpedido desc");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            int codigopedido = (int)db.ExecuteScalar(dbComd);


            return codigopedido;


        }

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

        private void txtPedido_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
