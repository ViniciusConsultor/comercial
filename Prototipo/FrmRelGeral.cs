using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.ObjectBuilder;
using System.Configuration;




namespace Comercial
{
    public partial class FrmRelGeral : Form
    {
        private string _princ = null;
        private object _pdv = null;
                private FrmPrinc _frmprinc;

        public FrmRelGeral(string parent, object pdv, FrmPrinc frmprinc)
        {
            _princ = parent;
            _pdv = pdv;
            _frmprinc = frmprinc;
            InitializeComponent();
        }

        private void FrmRelGeral_Load(object sender, EventArgs e)
        {

            try
            {
                if (_princ == "FrmConCli")
                {
                    CrystalDecisions.CrystalReports.Engine.ReportDocument report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                    report.Load(@"D:\Backup Facu\7 Semestre\TCC 2\TCC 2\Prototipo\Prototipo\RptConCli.rpt");
                    CrystalDecisions.Shared.ParameterField param;

                    crstlRprtVwrRel.ReportSource = report;
                }

                if (_princ == "FrmConProd")
                {
                    CrystalDecisions.CrystalReports.Engine.ReportDocument report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                    report.Load(@"D:\Backup Facu\7 Semestre\TCC 2\TCC 2\Prototipo\Prototipo\RptConProd.rpt");
                    CrystalDecisions.Shared.ParameterField param;

                    crstlRprtVwrRel.ReportSource = report;
                }

                #region Relatorio Pedido
                if (_princ == "FrmConPDV")
                {

                    ImprimirRelPed();

                }
                #endregion

                #region relatorio vendedor

                if (_princ == "FrmConVen")
                {
                    //Instancio o FormConsulta
                    FrmConVen x = (FrmConVen)_pdv;

                    RptConVen objRptConPDV = new RptConVen();

                    //Instancio o Relatorio
                    RptConVen objRptConVen = new RptConVen();

                    //Instancio o Dataset
                    COMERCIALDataSet oDataset = new COMERCIALDataSet();

                    Microsoft.Practices.EnterpriseLibrary.Data.Database db = DatabaseFactory.CreateDatabase();
                    //Crio a Conexão
                    SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString);

                    //Abro a conexão
                    sqlcon.Open();

                    //Recebo a String SQL feita na tela de consulta
                    string StringConnection = x.pesquisar();

                    SqlDataAdapter dtAdapter = new SqlDataAdapter(StringConnection, sqlcon);

                    //Localiso o datateble criado no dataset
                    dtAdapter.Fill(oDataset, "RelVendedor");

                    objRptConVen.SetDataSource(oDataset);

                    //atribiu o resultado ao CristalReportView            
                    crstlRprtVwrRel.DisplayGroupTree = false;
                    crstlRprtVwrRel.ReportSource = objRptConVen;
                }

                #endregion

                if (_princ == "FrmEmiNF")
                {
                    CrystalDecisions.CrystalReports.Engine.ReportDocument report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                    report.Load(@"D:\Backup Facu\7 Semestre\TCC 2\TCC 2\Prototipo\Prototipo\RptConNF.rpt");
                    CrystalDecisions.Shared.ParameterField param;

                    crstlRprtVwrRel.ReportSource = report;
                }

            }
            catch (Exception ex)
            {


                throw ex;

            }
        }


        #region ImprimerRelatorio Pedido
        public void ImprimirRelPed()
        {
            try
            {
                //Instancio o FormConsulta
                FrmConPDV x = (FrmConPDV)_pdv;

                if (x.rdbped.Checked)
                {
                    //Instancio o Relatorio
                    RptConPDV objRptConPDV = new RptConPDV();

                    //Instancio o Dataset
                    COMERCIALDataSet oDataset = new COMERCIALDataSet();

                    Microsoft.Practices.EnterpriseLibrary.Data.Database db = DatabaseFactory.CreateDatabase();
                    //Crio a Conexão
                    SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString);

                    //Abro a conexão
                    sqlcon.Open();

                    //Recebo a String SQL feita na tela de consulta
                    string StringConnection = x.pesquisar();


                    SqlDataAdapter dtAdapter = new SqlDataAdapter(StringConnection, sqlcon);

                    //Localizo o datatable criado no dataset
                    dtAdapter.Fill(oDataset, "RelPedido");

                    objRptConPDV.SetDataSource(oDataset);

                    //Passo parametro para relatorio no caso somente o de pedido tem parametro
                    ParameterFieldDefinitions crParameterFieldDefinitions;
                    ParameterFieldDefinition crParameterFieldDefinition;
                    ParameterValues crParameterValues = new ParameterValues();
                    ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                    crParameterDiscreteValue.Value = "PDV";
                    crParameterFieldDefinitions = objRptConPDV.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["Tipo"];
                    crParameterValues = crParameterFieldDefinition.CurrentValues;

                    crParameterValues.Clear();
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    //atribiu o resultado ao CristalReportView            
                    crstlRprtVwrRel.DisplayGroupTree = false;
                    crstlRprtVwrRel.ReportSource = objRptConPDV;
                }
                else
                {
                    //Instancio o Relatorio
                    RptConPDV objRptConPDV = new RptConPDV();

                    //Instancio o Dataset
                    COMERCIALDataSet oDataset = new COMERCIALDataSet();

                    Microsoft.Practices.EnterpriseLibrary.Data.Database db = DatabaseFactory.CreateDatabase();
                    //Crio a Conexão
                    SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString);

                    //Abro a conexão
                    sqlcon.Open();

                    //Recebo a String SQL feita na tela de consulta
                    string StringConnection = x.pesquisar();

                    SqlDataAdapter dtAdapter = new SqlDataAdapter(StringConnection, sqlcon);

                    //Localiso o datateble criado no dataset
                    dtAdapter.Fill(oDataset, "RelPedido");

                    objRptConPDV.SetDataSource(oDataset);

                    //Passo parametro para relatorio no caso somente o de pedido tem parametro
                    ParameterFieldDefinitions crParameterFieldDefinitions;
                    ParameterFieldDefinition crParameterFieldDefinition;
                    ParameterValues crParameterValues = new ParameterValues();
                    ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                    crParameterDiscreteValue.Value = "prd";
                    crParameterFieldDefinitions = objRptConPDV.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["Tipo"];
                    crParameterValues = crParameterFieldDefinition.CurrentValues;

                    crParameterValues.Clear();
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    //atribiu o resultado ao CristalReportView            
                    crstlRprtVwrRel.DisplayGroupTree = false;
                    crstlRprtVwrRel.ReportSource = objRptConPDV;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        #endregion


    }

}
