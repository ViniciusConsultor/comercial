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
        private FrmConPDV _pdv = null;
        public int Codped;

        public FrmRelGeral(string parent, FrmConPDV pdv)
        {
            _princ = parent;
            _pdv = pdv;
            InitializeComponent();
        }

        private void FrmRelGeral_Load(object sender, EventArgs e)
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
                    SqlConnection sqlcon = new SqlConnection("Data Source=zabs\\sql2008;Initial Catalog=COMERCIAL;Persist Security Info=True;User ID=SIGA;Password=SIGA");

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
                    SqlConnection sqlcon = new SqlConnection("Data Source=zabs\\sql2008;Initial Catalog=COMERCIAL;Persist Security Info=True;User ID=SIGA;Password=SIGA");

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
            #endregion

            if (_princ == "FrmConVen")
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                report.Load(@"D:\Backup Facu\7 Semestre\TCC 2\TCC 2\Prototipo\Prototipo\RptConVen.rpt");
                CrystalDecisions.Shared.ParameterField param;

                crstlRprtVwrRel.ReportSource = report;
            }

            if (_princ == "FrmEmiNF")
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                report.Load(@"D:\Backup Facu\7 Semestre\TCC 2\TCC 2\Prototipo\Prototipo\RptConNF.rpt");
                CrystalDecisions.Shared.ParameterField param;

                crstlRprtVwrRel.ReportSource = report;
            }
        }

       
        #region ImprimerRelatorio Pedido
        public void ImprimirRelPed(int CodPed)
        {
            
        

        }
        #endregion


    }

}
