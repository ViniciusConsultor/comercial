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
using System.Data.Common;

namespace Comercial
{
    public partial class FrmConPDV : Form
    {
        private FrmPrinc _princ = null;
        DataTable dttRetorno = new DataTable();

        public FrmConPDV(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }



        private void tbPgConCli_Click(object sender, EventArgs e)
        {

        }

        private void FrmConPDV_Leave(object sender, EventArgs e)
        {
            Control[] z = _princ.Controls.Find("bindingNavigator1", true);
            ToolStrip strip = (ToolStrip)z[0];

            strip.Visible = true;

            Control[] y = _princ.Controls.Find("tlStrpConsulta", true);
            ToolStrip strip2 = (ToolStrip)y[0];

            strip2.Visible = false;
        }

        private void FrmConPDV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.PEDIDO' table. You can move, or remove it, as needed.
            this.pEDIDOTableAdapter.Fill(this.cOMERCIALDataSet.PEDIDO);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.ITEMPEDIDO' table. You can move, or remove it, as needed.
            this.iTEMPEDIDOTableAdapter.Fill(this.cOMERCIALDataSet.ITEMPEDIDO);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.ITEMPEDIDO' table. You can move, or remove it, as needed.
            this.iTEMPEDIDOTableAdapter.Fill(this.cOMERCIALDataSet.ITEMPEDIDO);

            // TODO: This line of code loads data into the 'cOMERCIALDataSet.ITEMPEDIDO' table. You can move, or remove it, as needed.
            this.iTEMPEDIDOTableAdapter.Fill(this.cOMERCIALDataSet.ITEMPEDIDO);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.PEDIDO' table. You can move, or remove it, as needed.
            this.pEDIDOTableAdapter.Fill(this.cOMERCIALDataSet.PEDIDO);
            dttRetorno.Columns.Add("ImageStatus", typeof(Object));

        }

        private void pEDIDOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pEDIDOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        #region Pesquisar
        public string pesquisar()
        {
            
            try
            {
                dttRetorno.Clear();

                string sql = "SELECT p.NRPEDIDO ,TIPO,SITUACAO,c.RAZAOSOCIAL, DATAEMISSAO, DATAENTREGA,prd.CODPRODUTO, prd.DESCRICAO, QUANTIDADE, SUM(VALOR) as Valor, (VALOR * QUANTIDADE) as ValorTotal  " +
                             " FROM PEDIDO p INNER JOIN CLIENTE c ON p.CODCLIENTE = c.CNPJ  " +
                             " INNER JOIN ITEMPEDIDO ip ON p.NRPEDIDO = ip.NRPEDIDO   " +
                             " INNER JOIN PRODUTO prd ON ip.CODPRODUTO = prd.CODPRODUTO ";
                string groupBy = " GROUP BY p.NRPEDIDO,TIPO,SITUACAO,c.RAZAOSOCIAL, DATAEMISSAO, DATAENTREGA,prd.CODPRODUTO,prd.DESCRICAO, QUANTIDADE, VALOR";

                // pesquisa por nrPedido
                if (!string.IsNullOrEmpty(txtCodPed.Text))
                {
                    sql += " and p.nrPedido = " + txtCodPed.Text;
                }

                // pesquisa por Produto
                if (!string.IsNullOrEmpty(txtCodProd.getText))
                {
                    sql += " and prd.CODPRODUTO = " + txtCodProd.getText;
                }

                // pesquisa por tipo pedido
                if (!string.IsNullOrEmpty(cmBxTipoPed.Text))
                {
                    if (cmBxTipoPed.Text == "N = Normal")
                    {
                        sql += " and p.tipo = 'N'";
                    }
                    else sql += " and p.tipo = 'C'";

                }

                // pesquisa por situacao pedido
                if (rdbtnEfetivado.Checked)
                {
                    sql += " and p.situacao ='E'";
                }

                if (rdbtnPendente.Checked)
                {
                    sql += " and p.situacao ='P'";
                }

                //Pesquisa por data
                if ((dttmDataPedido.Checked) && (dttmDataPedidoate.Checked))
                {
                    string formatData = dttmDataPedido.Value.Year + "-" + dttmDataPedido.Value.Month + "-" + dttmDataPedido.Value.Day;
                    string formatDataate = dttmDataPedidoate.Value.Year + "-" + dttmDataPedidoate.Value.Month + "-" + dttmDataPedidoate.Value.Day;

                    sql += " and p.dataEmissao BETWEEN '" + formatData + "'AND'" + formatDataate + "'";
                }

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

                dtGrdConPDV.DataSource = dttRetorno;

                return sql;
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


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {

                rdbtnEfetivado.Checked = false;
                rdbtnPendente.Checked = false;
                //groupBox2.Enabled = false;
            }
            else rdbtnEfetivado.Checked = true;
        }

        private void rdbtnEfetivado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnEfetivado.Checked == true)
                checkBox1.Checked = true;

        }

        private void rdbtnPendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnPendente.Checked == true)
                checkBox1.Checked = true;
        }

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

        private void txtCodProd_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.dtGrdVwVis.DataSource = ListaProduto();
            x.Text = "Consulta Cadastro de Produto";

            x.ShowDialog();
        }

        private void txtCodPed_ButtonClick(object sender, EventArgs e)
        {

        }

        private void iTEMPEDIDOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iTEMPEDIDOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void iTEMPEDIDOBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.iTEMPEDIDOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }


    }
}
