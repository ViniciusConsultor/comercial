using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.ObjectBuilder;
using System.Data.Common;
using System.Data.OleDb;
using System.Configuration;
using System.Data.SqlClient;

namespace Comercial
{
    public partial class FrmLibPDV2 : Form
    {
        private FrmPrinc _princ = null;
        DataTable dttRetorno = new DataTable();

        public FrmLibPDV2(FrmPrinc parent)
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
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.ShowDialog();

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

        private void pEDIDOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pEDIDOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void FrmLibPDV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.PEDIDO' table. You can move, or remove it, as needed.
            this.pEDIDOTableAdapter.Fill(this.cOMERCIALDataSet.PEDIDO);
           
            populargrid();
            status();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pEDIDOTableAdapter.FillBy(this.cOMERCIALDataSet.PEDIDO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void listPedidoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pEDIDOTableAdapter.ListPedido(this.cOMERCIALDataSet.PEDIDO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        #region Listar Pedido
        public DataTable ListarPedido()
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append(" SELECT NRPEDIDO, TIPO, cli.RAZAOSOCIAL, DATAEMISSAO, DATAENTREGA, SITUACAO ");
            sqlcommand.Append(" FROM PEDIDO ped INNER JOIN CLIENTE cli ON ped.CODCLIENTE = cli.CNPJ ");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];

        }
        #endregion

        #region PopularGrid
        public void populargrid()
        {

            

            try
            {

                dttRetorno = ListarPedido();

                dttRetorno.Columns.Add("ImageStatus", typeof(Object));

                dtgvListarPedido.DataSource = dttRetorno;

            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region VerificaStatus
        public void status()
        {
            try
            {
               
                foreach (DataRow item in dttRetorno.Rows)
                {

                    if (item["SITUACAO"].ToString() == "P")
                    {
                        item["ImageStatus"] = Comercial.Properties.Resources.BolaAmarela;

                    }
                    else if (item["SITUACAO"].ToString() == "E")
                    {
                        item["ImageStatus"] = Comercial.Properties.Resources.BolaVerde;

                    }
                    else
                    {
                        item["ImageStatus"] = Comercial.Properties.Resources.BolaVermelho;
                    }
                    continue;
                }

                dtgvListarPedido.DataSource = dttRetorno;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }
        #endregion

        #region Pesquisar
        public string pesquisar()
        {

            try
            {
                dttRetorno.Clear();

                string sql = "SELECT ped.NRPEDIDO, TIPO, cli.RAZAOSOCIAL, DATAEMISSAO, DATAENTREGA, SITUACAO " +
                             " FROM PEDIDO ped INNER JOIN CLIENTE cli ON ped.CODCLIENTE = cli.CNPJ ";
                string groupBy = " GROUP BY ped.NRPEDIDO,TIPO,SITUACAO,cli.RAZAOSOCIAL, DATAEMISSAO, DATAENTREGA";

                if (!string.IsNullOrEmpty(txtPesquisar.Text))
                {
                    if (cmbtpPesquisa.Text == "Numero Pedido")
                    {
                        sql += "and ped.NRPEDIDO =" + txtPesquisar.Text;
                    }
                    
                }

                if (!string.IsNullOrEmpty(txtPesquisar.Text))
                {
                    if (cmbtpPesquisa.Text == "Cliente")
                    {
                        sql += "and cli.RAZAOSOCIAL LIKE '" + txtPesquisar.Text + "%' ";
                    }

                }

                //// pesquisa por nrPedido
                //if (!string.IsNullOrEmpty(txtCodPed.Text))
                //{
                //    sql += " and p.nrPedido = " + txtCodPed.Text;
                //}

                //// pesquisa por Produto
                //if (!string.IsNullOrEmpty(txtCodProd.getText))
                //{
                //    sql += " and prd.CODPRODUTO = " + txtCodProd.getText;
                //}

                //// pesquisa por tipo pedido
                //if (!string.IsNullOrEmpty(cmBxTipoPed.Text))
                //{
                //    if (cmBxTipoPed.Text == "N = Normal")
                //    {
                //        sql += " and p.tipo = 'N'";
                //    }
                //    else sql += " and p.tipo = 'C'";

                //}

                //// pesquisa por situacao pedido
                //if (rdbtnEfetivado.Checked)
                //{
                //    sql += " and p.situacao ='E'";
                //}

                //if (rdbtnPendente.Checked)
                //{
                //    sql += " and p.situacao ='P'";
                //}

                ////Pesquisa por data
                //if ((dttmDataPedido.Checked) && (dttmDataPedidoate.Checked))
                //{
                //    string formatData = dttmDataPedido.Value.Year + "-" + dttmDataPedido.Value.Month + "-" + dttmDataPedido.Value.Day;
                //    string formatDataate = dttmDataPedidoate.Value.Year + "-" + dttmDataPedidoate.Value.Month + "-" + dttmDataPedidoate.Value.Day;

                //    sql += " and p.dataEmissao BETWEEN '" + formatData + "'AND'" + formatDataate + "'";
                //}

                sql += groupBy;

                string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                SqlConnection conn = new SqlConnection(c);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //DataTable table = new DataTable();
                //table.Load(reader);

                dttRetorno.Load(reader);


                status();

                dtgvListarPedido.DataSource = dttRetorno;

                return sql;
            }
            catch (Exception)
            {

                throw;
            }


        }
        #endregion
        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pEDIDOTableAdapter.FillBy1(this.cOMERCIALDataSet.PEDIDO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tbPgPDV_Click(object sender, EventArgs e)
        {

        }

        private void dtgvListarPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLibPDV ped = new FrmLibPDV(_princ);
            ped.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void chkLegenda_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkLegenda.Checked)
                {
                    grpSituacao.Visible = true;
                    grpSituacao.Enabled = true;
                }
                else
                {
                    grpSituacao.Visible = false;    
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        private void btnPesqusiar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }
    }
}
