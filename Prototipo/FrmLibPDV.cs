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

namespace Comercial
{
    public partial class FrmLibPDV : Form
    {
        private FrmPrinc _princ = null;
        DataTable dttRetorno = new DataTable();

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
    }
}
