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
                #region Relatorio Cliente
                
                
                if (_princ == "FrmConCli")
                {
                    //Instancio o FormConsulta
                    FrmConCli x = (FrmConCli)_pdv;
                    RptConCli objRptConPDV = new RptConCli();

                    //Instancio o Relatorio
                    RptConCli objRptConCli = new RptConCli();

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

                    //Localiso o datatable criado no dataset
                    dtAdapter.Fill(oDataset, "RelCliente");

                    objRptConCli.SetDataSource(oDataset);

                    //atribiu o resultado ao CristalReportView            
                    crstlRprtVwrRel.DisplayGroupTree = false;
                    crstlRprtVwrRel.ReportSource = objRptConCli;
                }
                #endregion

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

                #region relatorio produto

                if (_princ == "FrmConProd")
                {
                    //Instancio o FormConsulta
                    FrmConProd x = (FrmConProd)_pdv;
                    
                    //Instancio o Relatorio
                    RptConProd objRptConProd = new RptConProd();

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
                    dtAdapter.Fill(oDataset, "RelProduto");

                    objRptConProd.SetDataSource(oDataset);

                    //atribiu o resultado ao CristalReportView            
                    crstlRprtVwrRel.DisplayGroupTree = false;
                    crstlRprtVwrRel.ReportSource = objRptConProd;
                }

                #endregion
                
                #region relatorio Estoque

                if (_princ == "FrmConEstProd")
                {
                    //Instancio o FormConsulta
                    FrmConEstProd x = (FrmConEstProd)_pdv;
                    
                    //Instancio o Relatorio
                    RptConEstoque objRptConEst = new RptConEstoque();

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
                    dtAdapter.Fill(oDataset, "RelEstoque");

                    objRptConEst.SetDataSource(oDataset);

                    //atribiu o resultado ao CristalReportView            
                    crstlRprtVwrRel.DisplayGroupTree = false;
                    crstlRprtVwrRel.ReportSource = objRptConEst;
                }

                #endregion

                if (_princ == "FrmEmiNF")
                {
                    //Instancio o FormConsulta
                    FrmLibPDV x = (FrmLibPDV)_pdv;

                    //Instancio o Relatorio
                    RptConNF objRptConNF = new RptConNF();

                    //Instancio o Dataset
                    COMERCIALDataSet oDataset = new COMERCIALDataSet();

                    Microsoft.Practices.EnterpriseLibrary.Data.Database db = DatabaseFactory.CreateDatabase();
                    //Crio a Conexão
                    SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString);

                    //Abro a conexão
                    sqlcon.Open();


                    string sql = string.Format("SELECT nf.*, ((nf.icms * itnf.valor)/100) as valoricms , itnf.*,((itnf.IPI * itnf.valor)/100) as valorIPI,tra.NOME as DescricaoTransp, "+
                        " tra.UF as UfTrans, tra.CNPJ as CnpjTrans, tra.ENDERECO as EnderecoTrans, tra.MUNICIPIO as MunicipioTrans, tra.IE as IeTrans, "+
                        " ( "+
                        " select SUM((n.icms * i.valor)/100) "+
                        " from NOTAFISCAL n inner join ItemNotaFiscal i on n.NrNotaFiscal = i.NrNotaFiscal "+
                        " where n.NrNotaFiscal = nf.nrNotaFiscal "+
                        " )total_ICMS, "+
                        " ( "+
                        " 	select SUM((i.IPI * i.valor)/100) "+
                        " from NOTAFISCAL n inner join ItemNotaFiscal i on n.NrNotaFiscal = i.NrNotaFiscal "+
                        " where n.NrNotaFiscal = nf.nrNotaFiscal "+
                        " )total_IPI "+
                        " FROM NOTAFISCAL nf INNER JOIN ItemNotaFiscal itnf ON nf.NrNotaFiscal = itnf.NrNotaFiscal " +
                        " 					INNER JOIN TRANSPORTADORA tra ON nf.CodTransportadora = tra.CNPJ WHERE nf.NrPedido = {0}", x.txtbtnPedido.Text);

                    SqlDataAdapter dtAdapter = new SqlDataAdapter(sql, sqlcon);

                    //Localiso o datateble criado no dataset
                    dtAdapter.Fill(oDataset, "RelNotaFiscal");

                    objRptConNF.SetDataSource(oDataset);

                    //atribiu o resultado ao CristalReportView            
                    crstlRprtVwrRel.DisplayGroupTree = false;
                    crstlRprtVwrRel.ReportSource = objRptConNF;
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
