using System;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.AnalysisServices.AdomdClient;
using Microsoft.Office.Interop.Owc11;
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
            SqlConnection conSql = new SqlConnection(ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString);
            SqlCommand comSql = new SqlCommand("select * from modelocampo where id = (select idModelo from modelo where estrutura = '" + comboBox1.Text + "')", conSql);

            conSql.Open();

            SqlDataReader read = comSql.ExecuteReader();


            int y = 0;
            string camp;
            foreach (var item in read)
            {

                camp += read["campo"].ToString()+";";
                y++;
            }

            string[] campos = camp.Split(';');


            comSql.CommandText = "select algoritmo from modelo where estrutura = '" + comboBox1.Text + "'";
            read = comSql.ExecuteReader();

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




            }

            /*
      //Create a new chart within ChartSpace1:

              ChartSpace ChartSpace1 = new ChartSpace();
              ChartSpace1.Charts.Add(0);
              ChartSpace1.Charts[0].SeriesCollection.Add(0);

              ChartSpace1.Charts[0].SeriesCollection[0].Type = ChartChartTypeEnum.chChartTypeLineMarkers;

              ChartSpace1.Charts[0].SeriesCollection[0].SetData(ChartDimensionsEnum.chDimSeriesNames,Convert.ToInt32(ChartSpecialDataSourcesEnum.chDataLiteral), "Chart1_Series1");
    
              //Populate the X and Y values from array:
              //ChartSpace1.Charts[0].SeriesCollection[0].SetData(ChartDimensionsEnum.chDimValues,Convert.ToInt32(ChartSpecialDataSourcesEnum.chDataLiteral), 1);
              ChartSpace1.Charts[0].SeriesCollection[0].SetData(ChartDimensionsEnum.chDimValues, Convert.ToInt32(ChartSpecialDataSourcesEnum.chDataLiteral), "10,5,3");

              //ChartSpace1.Charts[0].SeriesCollection[0].SetData(ChartDimensionsEnum.chDimValues, Convert.ToInt32(ChartSpecialDataSourcesEnum.chDataLiteral), 3);
              //ChartSpace1.Charts[0].SeriesCollection[0].SetData(ChartDimensionsEnum.chDimValues, Convert.ToInt32(ChartSpecialDataSourcesEnum.chDataLiteral), 5);

   //   ChartSpace1.Charts[0].SeriesCollection[0].SetData(ChartDimensionsEnum.chDimYValues,Convert.ToInt32(ChartSpecialDataSourcesEnum.chDataLiteral), 5);

              string strFullPathAndName = "c:\\x.gif";
              ChartSpace1.ExportPicture(strFullPathAndName, "gif", 800, 600);

   */

            /*
            AxChartSpace x = new AxChartSpace();

            x.add

             AxChartSpace1.HasChartSpaceTitle = true;
          //  AxChartSpace1 = "TESTE";
            AxChartSpace1.Charts.Add(0);
            AxChartSpace1.Charts.HasLegend = true;
            AxChartSpace1.Charts.Type = ChartChartTypeEnum.chChartTypeLine;
          ChSeries series0 = AxChartSpace1.Charts.SeriesCollection.Add(0);



           /* 'Set the data for the chart to literal comma-delimited string
            series0.SetData(Owc11.ChartDimensionsEnum.chDimCategories, Owc11.ChartSpecialDataSourcesEnum.chDataLiteral, "Week 1,Week 2,Week 3,Week 4,Week 5,Week 6")
            series0.SetData(Owc11.ChartDimensionsEnum.chDimValues, Owc11.ChartSpecialDataSourcesEnum.chDataLiteral, "11,25,16,14,8,20")

            AxChartSpace1.Charts.Add(1)
            AxChartSpace1.Charts(1).SetSpreadsheetData(fileName)
            AxChartSpace1.Visible = True
            */
        }
    }
}
