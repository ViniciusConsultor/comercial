using System;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.AnalysisServices.AdomdClient;
using AxOWC11;
using System.Data;
using System.Data.SqlClient;
//using Microsoft.Office.Interop;

namespace Comercial
{
    public partial class FrmMinCon : Form
    {
        private FrmPrinc _princ = null;
        private DataTable table = new DataTable("table");
        private string[] campos;
        private AdomdDataReader prev;
        public FrmMinCon(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        public void carregaGrid()
        {
            dataGridView1.Rows.Clear();
            DataTableReader x = table.CreateDataReader();
            int index = 1;
            foreach (var item in x)
            {
                dataGridView1.Rows.Add(index, x[0].ToString(), x[1].ToString());
                index++;
            }

        }

        private void FrmMinCon_Leave(object sender, EventArgs e)
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
            _princ.tlStrpBtnConMin.Visible = false;
        }

        private void FrmMinCon_Shown(object sender, EventArgs e)
        {

            int x = 1;
            foreach (var item in cOMERCIALDataSet.modelo)
            {
                comboBox1.Items.Insert(x, item.estrutura + " - " + item.dataCriacao.ToString("dd/MM/yyyy"));
                x++;
            }
            _princ.tlStrpBtnConMin.Visible = false;
            _princ.tsbhomeProcesso.Visible = true;

        }

        private void FrmMinCon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.modelo' table. You can move, or remove it, as needed.
            this.modeloTableAdapter.Fill(this.cOMERCIALDataSet.modelo);

          //  _princ.tlStrpBtnConMin.Visible = false;

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.modeloTableAdapter.FillBy(this.cOMERCIALDataSet.modelo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Obtendo campos do modelo*/
            if (comboBox1.SelectedIndex != 0)
            {
                SqlConnection conSql = new SqlConnection(ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString);
                SqlCommand comSql = new SqlCommand("select * from modelocampo where idModelo = (select id from modelo where estrutura = '" + comboBox1.Text.Substring(0, comboBox1.Text.Length - 13) + "')", conSql);

                conSql.Open();

                SqlDataReader read = comSql.ExecuteReader();

                if (read.HasRows)
                {
                    int y = 0;
                    string camp = "";
                    foreach (var item in read)
                    {

                        camp += read["campo"].ToString() + ";";
                        y++;
                    }

                    campos = camp.Split(';');

                    read.Close();
                    read.Dispose();
                    comSql.CommandText = "select algoritmo from modelo where estrutura = '" + comboBox1.Text.Substring(0, comboBox1.Text.Length - 13) + "'";
                    read = comSql.ExecuteReader();
                    read.Read();
                    if (read["algoritmo"].ToString() == "MTS (Microsoft Time Serial)")
                    {



                        int x = 0;
                        AdomdConnection conn = new AdomdConnection(ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString_Analysis"].ConnectionString);
                        AdomdCommand comand = new AdomdCommand();
                        conn.Open();
                        comand.Connection = conn;
                        comand.CommandText = "SELECT StructureColumn('" + campos[0].Trim() + "'),StructureColumn('" + campos[1].Trim() + "') " +
                                                "FROM " + comboBox1.Text.Substring(0, comboBox1.Text.Length - 13) + ".CASES";

                        AdomdDataAdapter ad = new AdomdDataAdapter(comand);
                        table.Clear();
                        ad.Fill(table);

                        DataTableReader reader = table.CreateDataReader();
                        // read.Read();
                        string valores = "";
                        foreach (var item in reader)
                        {
                            valores += reader[1].ToString() + ",";
                        }

                        valores = valores.Substring(0, valores.Length - 1);

                        try
                        {
                            //chartHist.Clear();
                            chartHist.Charts[0].SeriesCollection.Delete(0);
                            chartHist.Charts.Delete(0);
                            chartHist.Refresh();
                        }
                        catch
                        {
                        }
                        chartHist.ResetText();
                        chartHist.Charts.Add(0);
                        chartHist.Charts[0].SeriesCollection.Add(0);
                        chartHist.Charts[0].Type = OWC11.ChartChartTypeEnum.chChartTypeLine;
                        chartHist.Charts[0].SeriesCollection[0].SetData(OWC11.ChartDimensionsEnum.chDimSeriesNames, Convert.ToInt32(OWC11.ChartSpecialDataSourcesEnum.chDataLiteral), "Quantidade");
                        chartHist.Charts[0].SeriesCollection[0].SetData(OWC11.ChartDimensionsEnum.chDimValues, Convert.ToInt32(OWC11.ChartSpecialDataSourcesEnum.chDataLiteral), valores);
                        chartHist.Refresh();
                    }
                }

                carregaGrid();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0 && !string.IsNullOrEmpty(comboBox1.Text))
            {
                Microsoft.AnalysisServices.AdomdClient.AdomdConnection conn = new AdomdConnection(ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString_Analysis"].ConnectionString);
                Microsoft.AnalysisServices.AdomdClient.AdomdCommand comand = new AdomdCommand();
                conn.Open();
                comand.Connection = conn;
                comand.CommandText = "SELECT FLATTENED PredictTimeSeries(" + comboBox1.Text.Substring(0, comboBox1.Text.Length - 13) + "." + campos[1].Trim() + "," + numericUpDown1.Value + ") " +
                                        "From " + comboBox1.Text.Substring(0, comboBox1.Text.Length - 13);

                prev = comand.ExecuteReader();
                //  Expression expression = new Expression();
                // expression = (Expression) x[0];

                string val = "";
                int j = 1;

                //CARREGA GRID e valores grafico

                dataGridView2.Rows.Clear();

                foreach (var item in prev)
                {
                    val += item[1].ToString() + ",";

                    dataGridView2.Rows.Add(j, prev[0].ToString(), prev[1].ToString());

                    j++;


                }
                val = val.Substring(0, val.Length - 1);

                try
                {
                    //chartHist.Clear();
                    chartPrev.Charts[0].SeriesCollection.Delete(0);
                    chartPrev.Charts.Delete(0);
                    chartPrev.Refresh();
                }
                catch
                {
                }
                chartPrev.ResetText();
                chartPrev.Charts.Add(0);
                chartPrev.Charts[0].SeriesCollection.Add(0);
                chartPrev.Charts[0].Type = OWC11.ChartChartTypeEnum.chChartTypeLine;
                chartPrev.Charts[0].SeriesCollection[0].SetData(OWC11.ChartDimensionsEnum.chDimSeriesNames, Convert.ToInt32(OWC11.ChartSpecialDataSourcesEnum.chDataLiteral), "Quantidade");
                chartPrev.Charts[0].SeriesCollection[0].SetData(OWC11.ChartDimensionsEnum.chDimValues, Convert.ToInt32(OWC11.ChartSpecialDataSourcesEnum.chDataLiteral), val);
                chartPrev.Refresh();
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0 && !string.IsNullOrEmpty(comboBox1.Text))
            {
                Microsoft.AnalysisServices.AdomdClient.AdomdConnection conn = new AdomdConnection(ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString_Analysis"].ConnectionString);
                Microsoft.AnalysisServices.AdomdClient.AdomdCommand comand = new AdomdCommand();
                conn.Open();
                comand.Connection = conn;
                comand.CommandText = "SELECT FLATTENED PredictTimeSeries(" + comboBox1.Text.Substring(0, comboBox1.Text.Length - 13) + "." + campos[1].Trim() + "," + numericUpDown1.Value + ") " +
                                        "From " + comboBox1.Text.Substring(0, comboBox1.Text.Length - 13);

                prev = comand.ExecuteReader();
                //  Expression expression = new Expression();
                // expression = (Expression) x[0];

                string val = "";
                int j = 1;

                //CARREGA GRID e valores grafico

                dataGridView2.Rows.Clear();

                foreach (var item in prev)
                {
                    val += item[1].ToString() + ",";

                    dataGridView2.Rows.Add(j, prev[0].ToString(), prev[1].ToString());

                    j++;


                }
                val = val.Substring(0, val.Length - 1);

                try
                {
                    //chartHist.Clear();
                    chartPrev.Charts[0].SeriesCollection.Delete(0);
                    chartPrev.Charts.Delete(0);
                    chartPrev.Refresh();
                }
                catch
                {
                }
                chartPrev.ResetText();
                chartPrev.Charts.Add(0);
                chartPrev.Charts[0].SeriesCollection.Add(0);
                chartPrev.Charts[0].Type = OWC11.ChartChartTypeEnum.chChartTypeLine;
                chartPrev.Charts[0].SeriesCollection[0].SetData(OWC11.ChartDimensionsEnum.chDimSeriesNames, Convert.ToInt32(OWC11.ChartSpecialDataSourcesEnum.chDataLiteral), "Quantidade");
                chartPrev.Charts[0].SeriesCollection[0].SetData(OWC11.ChartDimensionsEnum.chDimValues, Convert.ToInt32(OWC11.ChartSpecialDataSourcesEnum.chDataLiteral), val);
                chartPrev.Refresh();
            }

        }
    }
}