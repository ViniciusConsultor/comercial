using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comercial
{
    public partial class FrmRelGeral : Form
    {
        private string _princ = null;
        private FrmConPDV _pdv = null;

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

            if (_princ == "FrmConPDV")
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                report.Load(@"D:\Backup Facu\7 Semestre\TCC 2\TCC 2\Prototipo\Prototipo\RptConPDV.rpt");
               
                CrystalDecisions.Shared.ParameterField param =new CrystalDecisions.Shared.ParameterField();

                FrmConPDV x = (FrmConPDV)_pdv;

                Control[] c = x.Controls.Find("rdbped", true);


                RadioButton r = (RadioButton)c[0];

                if (r.Checked)
                {
                    report.SetParameterValue(0, "PDV");
                }
                else
                {
                    report.SetParameterValue(0, "prod");
                }

                crstlRprtVwrRel.ReportSource = report;
            }

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
    }
}
