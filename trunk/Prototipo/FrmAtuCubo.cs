using System;
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
using System.IO;

namespace Comercial
{
    public partial class FrmAtuCubo : Form
    {
        private FrmPrinc _princ = null;
        public FrmAtuCubo(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
            this.Enabled = true;
        }

        private void tbPgHistorico_Click(object sender, EventArgs e)
        {

        }

        private void FrmatuCubo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.ATUCUBO' table. You can move, or remove it, as needed.
            this.aTUCUBOTableAdapter.Fill(this.cOMERCIALDataSet.ATUCUBO);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.ATUCUBO' table. You can move, or remove it, as needed.
            this.aTUCUBOTableAdapter.Fill(this.cOMERCIALDataSet.ATUCUBO);

            preencheGrid();

        }

        private void preencheGrid()
        {
            string sql = "select atu.NRATUALIZACAO,usu.USUARIO,atu.DATAATUALIZACAO from ATUCUBO atu, USUARIO usu where atu.CODUSUARIO=usu.CODUSUARIO order by atu.DATAATUALIZACAO desc,NRATUALIZACAO desc ";
            string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(c);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);


            dtgrdAtuCubo.DataSource = table;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void FrmAtuCubo_Leave(object sender, EventArgs e)
        {

        }

        private void btnAtuCubo_Click(object sender, EventArgs e)
        {
            try
            {
                string linha = "";
                lblTexto.Visible = true;
                prgrsBrCarrega.Value = 0;
                prgrsBrCarrega.Visible = true;
                tmrTempo.Enabled = true;

                //Abrir o arquivo

                //linha += "<Batch xmlns=\"http://schemas.microsoft.com/analysisservices/2003/engine\"> " +
                //         "<Parallel> " +
                //         "<Process xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:ddl2=\"http://schemas.microsoft.com/analysisservices/2003/engine/2\" xmlns:ddl2_2=\"http://schemas.microsoft.com/analysisservices/2003/engine/2/2\" xmlns:ddl100_100=\"http://schemas.microsoft.com/analysisservices/2008/engine/100/100\">  " +
                //         "<Object> " +
                //         "<DatabaseID>Comercial_Mart</DatabaseID> " +
                //         "<DimensionID>Regiao</DimensionID> " +
                //         "</Object> " +
                //         "<Type>ProcessUpdate</Type> " +
                //         "<WriteBackTableCreation>UseExisting</WriteBackTableCreation> " +
                //         "</Process> " +
                //         "<Process xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:ddl2=\"http://schemas.microsoft.com/analysisservices/2003/engine/2\" xmlns:ddl2_2=\"http://schemas.microsoft.com/analysisservices/2003/engine/2/2\" xmlns:ddl100_100=\"http://schemas.microsoft.com/analysisservices/2008/engine/100/100\"> " +
                //         "<Object> " +
                //         "<DatabaseID>Comercial_Mart</DatabaseID> " +
                //         "<CubeID>Vendas_Regiao_Produto</CubeID> " +
                //         "</Object> " +
                //         "<Type>ProcessFull</Type> " +
                //         "<WriteBackTableCreation>UseExisting</WriteBackTableCreation> " +
                //         "</Process> " +
                //         "<Process xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:ddl2=\"http://schemas.microsoft.com/analysisservices/2003/engine/2\" xmlns:ddl2_2=\"http://schemas.microsoft.com/analysisservices/2003/engine/2/2\" xmlns:ddl100_100=\"http://schemas.microsoft.com/analysisservices/2008/engine/100/100\"> " +
                //         "<Object> " +
                //         "<DatabaseID>Comercial_Mart</DatabaseID> " +
                //         "<DimensionID>Produto</DimensionID> " +
                //         "</Object> " +
                //         "<Type>ProcessUpdate</Type> " +
                //         "<WriteBackTableCreation>UseExisting</WriteBackTableCreation> " +
                //         "</Process> " +
                //         "<Process xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:ddl2=\"http://schemas.microsoft.com/analysisservices/2003/engine/2\" xmlns:ddl2_2=\"http://schemas.microsoft.com/analysisservices/2003/engine/2/2\" xmlns:ddl100_100=\"http://schemas.microsoft.com/analysisservices/2008/engine/100/100\"> " +
                //         "<Object> " +
                //         "<DatabaseID>Comercial_Mart</DatabaseID> " +
                //         "<DimensionID>Data</DimensionID> " +
                //         "</Object> " +
                //         "<Type>ProcessUpdate</Type> " +
                //         "<WriteBackTableCreation>UseExisting</WriteBackTableCreation> " +
                //         "</Process> " +
                //         "</Parallel> " +
                //         "</Batch>";
                ////FileInfo x = new FileInfo(@"E:\Faculdade\Tcc_google\Prototipo\atucubo.txt");

                //// StreamReader valor = x.OpenText();

                ////while (valor.ReadLine() != null)
                //// {
                //// linha += valor.ReadLine();

                ////}

                //string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString_analysis"].ConnectionString;

                //AdomdConnection conn = new AdomdConnection(c);
                //conn.Open();
                //AdomdCommand cmd = new AdomdCommand(linha, conn);
                //cmd.Execute();
                //conn.Close();



                COMERCIALDataSetTableAdapters.ATUCUBOTableAdapter atu = new Comercial.COMERCIALDataSetTableAdapters.ATUCUBOTableAdapter();
                DateTime data = Convert.ToDateTime(DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day);
                atu.Insert(_princ.usuarioLogado, data);

                preencheGrid();

                prgrsBrCarrega.Value = 100;
                tmrTempo.Enabled = false;
                lblTexto.Visible = false;
                MessageBox.Show("Processo executado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;


            }
            catch(Exception ex)
            {
                tmrTempo.Enabled = false;
                lblTexto.Visible = false;
                prgrsBrCarrega.Visible = false;
                MessageBox.Show("Houve um problema na execução da atualização!\nConsulte o DBA.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBox1.Visible = false;
                pictureBox1.Visible = false;
            }
        }

        private void aTUCUBOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aTUCUBOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void aTUCUBOBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.aTUCUBOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void lblTexto_Click(object sender, EventArgs e)
        {

        }

        private void prgrsBrCarrega_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prgrsBrCarrega.Value == 100)
            {
                

                prgrsBrCarrega.Visible = false;

            }
            else
            {
                prgrsBrCarrega.Value += 1;
            }
        }
    }
}
