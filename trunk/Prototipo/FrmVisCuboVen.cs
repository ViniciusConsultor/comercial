using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.AnalysisServices.AdomdClient;

namespace Comercial
{
    public partial class FrmVisCuboVen : Form
    {
        private FrmPrinc _princ = null;

        public FrmVisCuboVen(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        private void FrmVisCuboVen_Shown(object sender, EventArgs e)
        {
           // ADODB.Connection conn = new ADODB.Connection(
           //   ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString_Analysis"].ConnectionString);
           // string x = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString_Analysis"].ConnectionString;
                 
            axPivotTable1.ConnectionString = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString_Analysis"].ConnectionString;
            axPivotTable1.DataMember = "Vendas_Regiao_Produto";
            
            axChartSpace1.ConnectionString = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString_Analysis"].ConnectionString;
            axChartSpace1.DataMember = "Vendas_Regiao_Produto";
        }
    }
}
