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

        public FrmMinCon(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
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
        }

        private void FrmMinCon_Shown(object sender, EventArgs e)
        {


        }

        private void FrmMinCon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.modelo' table. You can move, or remove it, as needed.
            this.modeloTableAdapter.Fill(this.cOMERCIALDataSet.modelo);

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
            /* Obtendo campos do modelo*/
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                SqlConnection conSql = new SqlConnection(ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString);
                SqlCommand comSql = new SqlCommand("select * from modelocampo where idModelo = (select idModelo from modelo where estrutura = '" + comboBox1.Text + "')", conSql);

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

                    string[] campos = camp.Split(';');

                    read.Close();
                    read.Dispose();
                    comSql.CommandText = "select algoritmo from modelo where estrutura = '" + comboBox1.Text + "'";
                    read = comSql.ExecuteReader();
                    read.Read();
                    if (read["algoritmo"].ToString() == "MTS (Microsoft Time Serial)")
                    {


                        DataTable table = new DataTable("table");
                        int x = 0;
                        AdomdConnection conn = new AdomdConnection(ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString_Analysis"].ConnectionString);
                        AdomdCommand comand = new AdomdCommand();
                        conn.Open();
                        comand.Connection = conn;
                        comand.CommandText = "SELECT StructureColumn('" + campos[0] + "'),StructureColumn('" + campos[1] + "') " +
                                                "FROM " + comboBox1.Text + ".CASES";

                        AdomdDataAdapter ad = new AdomdDataAdapter(comand);
                        ad.Fill(table);

                        DataTableReader reader = table.CreateDataReader();
                       // read.Read();
                        string valores = "";
                        foreach (var item in reader)
                        {
                            valores += reader[1].ToString() + ",";
                        }

                        valores = valores.Substring(0, valores.Length - 1);
                        chartHist.Charts.Add(0);
                        chartHist.Charts[0].SeriesCollection.Add(0);
                        chartHist.Charts[0].Type = OWC11.ChartChartTypeEnum.chChartTypeLine;
                        chartHist.Charts[0].SeriesCollection[0].SetData(OWC11.ChartDimensionsEnum.chDimSeriesNames, Convert.ToInt32(OWC11.ChartSpecialDataSourcesEnum.chDataLiteral), "Quantidade");
                        chartHist.Charts[0].SeriesCollection[0].SetData(OWC11.ChartDimensionsEnum.chDimValues, Convert.ToInt32(OWC11.ChartSpecialDataSourcesEnum.chDataLiteral), valores);
                        chartHist.Refresh();
                    }
                }
            }
        }
    }
}