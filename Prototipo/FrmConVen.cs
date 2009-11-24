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

namespace Comercial
{
    public partial class FrmConVen : Form
    {
        private FrmPrinc _princ = null;

        public FrmConVen(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;

        }

        public string pesquisar()
        {
            string sql = "select v.nome, v.cpf ,p.nrpedido, p.dataemissao dtemissao, " +
                 "( select isnull(SUM(i.VALOR),0) from ITEMPEDIDO i where i.NRPEDIDO = p.NRPEDIDO " +
                 ") valorpedido,comissao, (COMISSAO/100 * (select isnull(SUM(i.VALOR),0) from ITEMPEDIDO i " +
                 "where i.NRPEDIDO = p.NRPEDIDO)) valorcomissao " +
                            "from vendedor as v, pedido as p where p.codvendedor = v.cpf ";

            // pesquisa por nome
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                sql += "and v.nome like '" + txtNome.Text + "%' ";
            }

            // pesquisa por cpf
            if (!string.IsNullOrEmpty(txtCPF.Text))
            {
                sql += "and v.cpf = '" + txtCPF.Text + "' ";
            }

            // pesquisa por comissao
            if (!string.IsNullOrEmpty(txtComissao.Text))
            {
                sql += "and v.comissao = '" + txtComissao.Text + "' ";
            }

            // pesquisa por situacao pedido
            if (checkBox1.Checked)
            {
                if (rdBtnEfetivo.Checked)
                {
                    sql += "and p.situacao = 'E' ";
                }

                if (rdBtnPendente.Checked)
                {
                    sql += "and p.situacao = 'P' ";
                }

                if (rdBtnCancelado.Checked)
                {
                    sql += "and p.situacao = 'C' ";
                }
            }

            //Pesquisa por quant.
            if (!string.IsNullOrEmpty(txtQuant.Text))
            {
                sql += "and v.cpf in (select CODVENDEDOR from PEDIDO " +
                                        "group by CODVENDEDOR having COUNT(NRPEDIDO) " + cmBxOperador.Text + " " + txtQuant.Text + ") ";
            }

            if (cmBxTipoPed.Text == "N = Normal")
            {

                sql += "and p.tipo = 'N' ";
            }

            if (cmBxTipoPed.Text == "C = Complemento de preço")
            {

                sql += "and p.tipo = 'C' ";
            }

            if (chckBxDtEmissao.Checked)
            {
                string[] x;
                string dt1="";
                string dt2="";

                x = dateTimePicker1.Text.Split('/');
                dt1 = x[2] + "-" + x[1] + "-" + x[0];

                x = dateTimePicker2.Text.Split('/');
                dt2 = x[2] + "-" + x[1] + "-" + x[0];

                sql += "and p.dataemissao between '" + dt1 + "' and '" + dt2 + "' ";
            }

            string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(c);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            
            dtGrdVwConVen.DataSource = table;

            return sql;         

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmConVen_Leave(object sender, EventArgs e)
        {
            Control[] z = _princ.Controls.Find("bindingNavigator1", true);
            ToolStrip strip = (ToolStrip)z[0];

            strip.Visible = true;

            Control[] y = _princ.Controls.Find("tlStrpConsulta", true);
            ToolStrip strip2 = (ToolStrip)y[0];

            strip2.Visible = false;
        }

        private void FrmConVen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.VENDEDOR' table. You can move, or remove it, as needed.
            //   this.vENDEDORTableAdapter.Fill(this.cOMERCIALDataSet.VENDEDOR);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxDtEmissao.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }
    }
}
