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
using Microsoft.AnalysisServices.AdomdClient;


namespace Comercial
{
    public partial class FrmMinGer : Form
    {
        private FrmPrinc _princ = null;

        private string _algoritmo;
        private string opc = "'U','V'";

        private string tabela = "";
        private string key = "";
        private string input = "";
        private string predictable = "";
        private string algoritmo = "";


        #region geraMIning

        public void geraMining()
        {

            // valida os dados...

            if (string.IsNullOrEmpty(txtnomeEstrutura.Text))
            {
                MessageBox.Show("Nome da estrutura inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCntrlMining.SelectedTab = tabPage1;
                txtnomeEstrutura.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cmbBxTipoDataMining.Text))
            {
                MessageBox.Show("Tipo da estrutura não selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCntrlMining.SelectedTab = tabPage1;
                cmbBxTipoDataMining.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tabela))
            {
                MessageBox.Show("Tabela não indicada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCntrlMining.SelectedTab = tbPgTabela;
                // dataGridView2.Focus();
                return;
            }

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Campo chave obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCntrlMining.SelectedTab = tabPage3;
                // dataGridView2.Focus();
                return;
            }

            lblTexto.Visible = true;
            prgrsBrCarrega.Value = 0;
            prgrsBrCarrega.Visible = true;
            tmrTempo.Enabled = true;

            // GERAR MODELO...

            /*    CREATE MINING MODEL SalesForecast (
                    ReportingDate DATE KEY TIME,
                    ModelRegion TEXT KEY,
                    Amount LONG CONTINUOUS PREDICT,
                    Quantity LONG CONTINUOUS PREDICT
                )
                USING Microsoft_Time_Series (PERIODICITY_HINT = '{12}', FORECAST_METHOD = 'ARTXP')
         Microsoft_Clustering 
             * */



            // Create mining model
            /* Árvore de decisão
                Agrupamento
                MTS (Microsoft Time Serial) */

            if (cmbBxTipoDataMining.Text == "MTS (Microsoft Time Serial)")
            {

                if (!key.Contains("date"))
                {
                    MessageBox.Show("Campo chave deve ser do tipo datetime", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCntrlMining.SelectedTab = tabPage3;
                    // dataGridView2.Focus();
                    return;
                }

                string[] inp = input.Split(';');

                string input_limpo = "";

                foreach (var x in inp)
                {
                    if (x.Contains("date"))
                    {
                      input_limpo += x.Remove(x.IndexOf("("), x.Length - x.IndexOf("(")) + " DATE, ";
                    }

                    if (x.Contains("varchar") || x.Contains("char"))
                    {
                        input_limpo += x.Remove(x.IndexOf("("), x.Length - x.IndexOf("(")) + " text, ";
                    }

                    if (x.Contains("float"))
                    {
                        input_limpo += x.Remove(x.IndexOf("("), x.Length - x.IndexOf("(")) + " double, ";
                    }

                    if (x.Contains("int"))
                    {
                        input_limpo += x.Remove(x.IndexOf("("), x.Length - x.IndexOf("(")) + " long, ";
                    }
                }

                string[] pred = predictable.Split(';');

                string pred_limpo = "";

                foreach (var x in pred)
                {
                    if (x.Contains("date"))
                    {
                        pred_limpo += x.Remove(x.IndexOf("("), x.Length - x.IndexOf("(")) + " DATE PREDICT_ONLY, ";
                    }

                    if (x.Contains("varchar") || x.Contains("char"))
                    {
                        pred_limpo += x.Remove(x.IndexOf("("), x.Length - x.IndexOf("(")) + " text PREDICT_ONLY, ";
                    }

                    if (x.Contains("float"))
                    {
                        pred_limpo += x.Remove(x.IndexOf("("), x.Length - x.IndexOf("(")) + " double PREDICT_ONLY, ";
                    }

                    if (x.Contains("int"))
                    {
                        pred_limpo += x.Remove(x.IndexOf("("), x.Length - x.IndexOf("(")) + " long PREDICT_ONLY, ";
                    }
                }

               pred_limpo = pred_limpo.Remove(pred_limpo.Length - 2, 2);


                AdomdConnection conn = new AdomdConnection(ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString_Analysis"].ConnectionString);
                AdomdCommand cmd = new AdomdCommand();
                conn.Open();
                cmd.Connection = conn;
                String createMiningModel =
                                "CREATE MINING MODEL " + txtnomeEstrutura.Text +
                                " ( " +
                                    key.Remove(key.IndexOf("("), key.Length - key.IndexOf("(")) + "DATE KEY TIME, " +
                                    input_limpo + " " + pred_limpo +
                                " ) USING Microsoft_Time_Series " +
                                "WITH DRILLTHROUGH";
                cmd.CommandText = createMiningModel;
                cmd.ExecuteNonQuery();

            }


        }

        #endregion


        public FrmMinGer(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        public FrmPrinc getPrinc()
        {
            return _princ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prgrsBrCarrega.Value == 100)
            {
                tmrTempo.Enabled = false;
            }
            else
            {
                prgrsBrCarrega.Value += 1;
            }

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

        }

        private void dtGrdVwCampos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstBxTabelas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExecutar_Click_1(object sender, EventArgs e)
        {

        }

        private void rdBtnCliente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdBtnDia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chckBxDia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmMinGer_Load(object sender, EventArgs e)
        {


        }

        private void lstBxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmMinGer_Leave(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbBxTipoDataMining_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxTipoDataMining.SelectedIndex == 0)
            {
                rchTxtBxTexto.Text = "O algoritmo Árvores de Decisão é um algoritmo de decisão adequado para modelos de previsão. O algoritmo oferece suporte à previsão de atributos discretos e contínuos.";
            }

            if (cmbBxTipoDataMining.SelectedIndex == 1)
            {
                rchTxtBxTexto.Text = "O algoritmo de agrupamento usa técnicas iterativas para agrupar registros de um conjunto de dados em clusters que contenham características semelhantes. Isso é útil quando você deseja encontrar agrupamentos gerais nos seus dados.";
            }

            if (cmbBxTipoDataMining.SelectedIndex == 2)
            {
                rchTxtBxTexto.Text = "O algoritmo MTS usa uma combinação de análise ARIMA e de regressão linear com base em árvores de decisão para analisar os dados relacionados a tempo, por exemplo, dados de vendas mensais ou lucros anuais. Os padrões descobertos podem ser usados para prever valores para futuros períodos. O algoritmo pode ser personalizado para usar ou método de árvore de decisão ou ARIMA, ou mesmo ambos.";
            }

            algoritmo = (string)cmbBxTipoDataMining.SelectedValue;
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(c);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from sys.all_objects where type in (" + opc + ") " +
                                                "and schema_id = '1'and name not like 'sysdiagrams' " +
                                                "order by name", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            // reader.Read();
            //while (reader.Read())
            if (reader.HasRows)
            {
                foreach (var r in reader)
                {
                    dataGridView2.Rows.Add(false, reader["name"].ToString());
                }
            }

            reader.Close();
            reader.Dispose();

            conn.Close();
            conn.Dispose();

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {


        }

        private void treeView1_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dv = dataGridView2.Rows[e.RowIndex];

            if (e.ColumnIndex == 0)
            {

                foreach (DataGridViewRow d in dataGridView2.Rows)
                {
                    d.Cells[0].Value = false;
                }

                dv.Cells[0].Value = true;
                tabela = (string)dv.Cells[1].Value;
            }
        }

        private void chckBxTable_CheckedChanged(object sender, EventArgs e)
        {

            if (chckBxTable.Checked)
            {
                if (chckBxVw.Checked)
                {
                    opc = "'U','V'";
                }
                else
                {
                    opc = "'U'";
                }
            }
            else
            {
                if (chckBxVw.Checked)
                {
                    opc = "'V'";
                }
                else
                {
                    opc = "''";
                }
            }
            dataGridView2.Rows.Clear();
            tabPage2_Enter(null, null);
            dataGridView2.Refresh();
        }

        private void chckBxVw_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxVw.Checked)
            {
                if (chckBxTable.Checked)
                {
                    opc = "'U','V'";
                }
                else
                {
                    opc = "'V'";
                }
            }
            else
            {
                if (chckBxTable.Checked)
                {
                    opc = "'U'";
                }
                else
                {
                    opc = "''";
                }
            }
            dataGridView2.Rows.Clear();
            tabPage2_Enter(null, null);
            dataGridView2.Refresh();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(c);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select t.name tipo, c.name coluna from sys.all_columns c inner join sys.all_objects o on c.object_id = o.object_id " +
                                            "inner join sys.types t on c.system_type_id = t.system_type_id " +
                                            "where o.name = @col " +
                                            "and t.name <> 'sysname' " +
                                            "order by c.name", conn);
            cmd.Parameters.Add(new SqlParameter("@col", tabela));
            SqlDataReader reader = cmd.ExecuteReader();
            // reader.Read();
            //while (reader.Read())
            if (reader.HasRows)
            {
                foreach (var r in reader)
                {
                    dataGridView1.Rows.Add(reader["coluna"].ToString() + " (" + reader["tipo"].ToString() + ")", false, false, false);
                }
            }

            reader.Close();
            reader.Dispose();

            conn.Close();
            conn.Dispose();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dv = dataGridView1.Rows[e.RowIndex];

            if (e.ColumnIndex == 1)
            {

                foreach (DataGridViewRow d in dataGridView1.Rows)
                {
                    if (d != dv)
                    {
                        d.Cells[1].Value = false;
                    }
                }

                //dv.Cells[1].Value = true;
                key = (string)dv.Cells[0].Value;
            }

        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            foreach (DataGridViewRow d in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(d.Cells[2].Value) == true)
                {
                    input += d.Cells[0].Value + "; ";
                }

                if (Convert.ToBoolean(d.Cells[3].Value) == true)
                {
                    predictable += d.Cells[0].Value + "; ";
                }
            }

            richTextBox2.Text = "--------------------\nResumo:\n--------------------\nNome da estrutura: " + txtnomeEstrutura.Text + "\n" +
                    "Tipo do algoritmo: " + cmbBxTipoDataMining.Text + "\n\n" +
                    "--------------------\nTabela:\n--------------------\n" +
                    "Nome: " + tabela + "\n\n" +
                    "-------------------\nColunas:\n--------------------\n" +
                    "Key: " + key + "\n" +
                    "Input: " + input + "\n" +
                    "Predictable: " + predictable + "\n";
        }

    }
}
