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

            if (_princ == "FrmConPDV")
            {

                ParameterDiscreteValue parameter = new ParameterDiscreteValue();

                //CrystalDecisions.CrystalReports.Engine.ReportDocument report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                

                //CrystalDecisions.Shared.ParameterField param = new CrystalDecisions.Shared.ParameterField();

                FrmConPDV x = (FrmConPDV)_pdv;

                //Control[] c = x.Controls.Find("rdbped", true);


                //RadioButton r = (RadioButton)c[0];

                if (x.rdbped.Checked)
                {
                    parameter.Value = "PDV";               
                    this.ImprimirRelPed(Codped);
                }
                else
                {
                    //report.SetParameterValue(0, "prod");
                }

                
              
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

        public void ImprimirRelPed(int CodPed)
        {

            RptConPDV objRptConPDV = new RptConPDV();
            COMERCIALDataSet oDataset = new COMERCIALDataSet();

           Microsoft.Practices.EnterpriseLibrary.Data.Database db = DatabaseFactory.CreateDatabase();

           SqlConnection sqlcon = new SqlConnection("Data Source=zabs\\sql2008;Initial Catalog=COMERCIAL;Persist Security Info=True;User ID=SIGA;Password=SIGA");

           sqlcon.Open();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("SELECT p.NRPEDIDO as CodPedido,c.RAZAOSOCIAL as Cliente, DATAEMISSAO, DATAENTREGA ,prd.CODPRODUTO as CodProduto, prd.DESCRICAO as DescricaoProd, QUANTIDADE, VALOR as PrecoUnitario");
            sqlcommand.Append(" FROM PEDIDO p INNER JOIN CLIENTE c ON p.CODCLIENTE = c.CNPJ ");
            sqlcommand.Append(" INNER JOIN ITEMPEDIDO ip ON p.NRPEDIDO = ip.NRPEDIDO ");
            sqlcommand.Append(" INNER JOIN PRODUTO prd ON ip.CODPRODUTO = prd.CODPRODUTO ");
            sqlcommand.Append(" WHERE p.NRPEDIDO = " + Codped);
            
            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            //db.AddInParameter(dbComd, "@CodPedido", DbType.String, CodPed);

            SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlcommand.ToString(), sqlcon);

            dtAdapter.Fill(oDataset, "RelPedido");
            
           // db.ExecuteDataSet(dbComd);

            objRptConPDV.SetDataSource(oDataset);

            crstlRprtVwrRel.DisplayGroupTree = false;
            crstlRprtVwrRel.ReportSource = objRptConPDV;

        }


    }

}
