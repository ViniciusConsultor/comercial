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
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.ObjectBuilder;
using System.Data.Common;
using System.Data.OleDb;

namespace Comercial
{
    public partial class FrmCadTra : Form
    {
        private FrmPrinc _princ = null;
        Validacoes valida = new Validacoes();

        public FrmCadTra(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;

            // =================================================
            // COLOCAR ESSA PARTE EM TODOS OS FORMS

            _princ.bindingNavigator1.BindingSource = tRANSPORTADORABindingSource;
            _princ.setdataSet(cOMERCIALDataSet);

            _princ.novo();
            //==================================================
        }

        private void tRANSPORTADORABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tRANSPORTADORABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void FrmCadTra_Shown(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.TRANSPORTADORA' table. You can move, or remove it, as needed.
            this.tRANSPORTADORATableAdapter.Fill(this.cOMERCIALDataSet.TRANSPORTADORA);
        }

        public void limparcampos()
        {
            chkAereo.Checked = false;
            chkFerroviario.Checked = false;
            chkMaritimo.Checked = false;
            chkTerrestre.Checked = false;
        }

        public DataTable Listar(String CodTrans)
        {

            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select * from TRANSPORTADORAVIA where CODTRANSPORTADORA = @CODTRANSPORTADORA");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            db.AddInParameter(dbComd, "@CODTRANSPORTADORA", DbType.String, CodTrans);

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];


        }

        public int salvar()
        {

            if (!string.IsNullOrEmpty(txtEmailtrans.Text))
            {
                Boolean emailOk = valida.ValidaEmail(txtEmailtrans.Text);
                if (emailOk == false)
                {
                    //MessageBox.Show("Email Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return 1;
                    throw new Exception("email invalido");
                }


                String CnpjTrans = (String)txtCnpjTrans.Text.Replace(".", "").Replace("/", "").Replace("-", "");

                if (chkAereo.Checked)
                {
                    COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter VTrans = new Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter();
                    VTrans.Insert("aer", CnpjTrans);
                }
                if (chkFerroviario.Checked)
                {
                    COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter VTrans = new Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter();
                    VTrans.Insert("fer", CnpjTrans);
                }
                if (chkMaritimo.Checked)
                {
                    COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter VTrans = new Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter();
                    VTrans.Insert("mar", CnpjTrans);
                }
                if (chkTerrestre.Checked)
                {
                    COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter VTrans = new Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter();
                    VTrans.Insert("ter", CnpjTrans);
                }


                this.limparcampos();




            }
            return 0;
        }

        public int salvarcep()
        {


            try
            {

                DataRowView Trans = (DataRowView)tRANSPORTADORABindingSource.Current;

                DataTable table = new DataTable();

                Trans["CEP"] = txtCepTrans.getText;

                return 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }





        }



        private void FrmCadTra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.TRANSPORTADORAVIA' table. You can move, or remove it, as needed.
            this.tRANSPORTADORAVIATableAdapter.Fill(this.cOMERCIALDataSet.TRANSPORTADORAVIA);

        }

        public int ValidaCNPJ()
        {
            String CnpjTrans = (String)txtCnpjTrans.Text.Replace(".", "").Replace("/", "").Replace("-", "");

            //Valida CNPJ

            DataRowView x;
            x = (DataRowView)tRANSPORTADORABindingSource.Current;
            int cnpj = valida.ValidaCNPJ(CnpjTrans);

            return cnpj;
        }

        private void txtCepTrans_ButtonClick_1(object sender, EventArgs e)
        {

            string cep = valida.procuraCEP(txtCepTrans.getText);

            if (cep != "")
            {
                string[] x = cep.Split(';');

                txtMunicipiotrans.Text = x[0];
                uFComboBox.Text = x[1];
                txtBairrotrans.Text = x[2];
                txtEndtrans.Text = x[3];

                NumTrans.Focus();
            }
            else
            {
                MessageBox.Show("CEP não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndtrans.Focus();
            }
        }

        private void txtEmailtrans_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumTrans_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

        private void TxtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCnpjTrans_Leave(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtCnpjTrans.Text) && txtCnpjTrans.Text.Length == 14)
            {
                if (valida.ValidaCNPJ(txtCnpjTrans.Text) == 1)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    txtCnpjTrans.Focus();
                }
                else
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                }
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                txtCnpjTrans.Focus();
            }
        }

        private void consultaTransportadoraToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tRANSPORTADORATableAdapter.ConsultaTransportadora(this.cOMERCIALDataSet.TRANSPORTADORA, cNPJToolStripTextBox.Text, nomeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tRANSPORTADORATableAdapter.Fill(this.cOMERCIALDataSet.TRANSPORTADORA);

                consultaTransportadoraToolStrip.Visible = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            cNPJToolStripTextBox.Clear();
            nomeToolStripTextBox.Clear();
        }

        private void tRANSPORTADORABindingSource_PositionChanged_1(object sender, EventArgs e)
        {
            if (tRANSPORTADORAVIABindingSource.Current != null)
            {
                DataRowView Trans = (DataRowView)tRANSPORTADORABindingSource.Current;

                if ((Trans != null))
                {

                    DataTable table = new DataTable();

                    txtCepTrans.getText = Trans["CEP"].ToString();

                    string Codtrans = Trans["CNPJ"].ToString();

                    table = Listar(Codtrans);

                    this.limparcampos();


                    foreach (DataRow item in table.Rows)
                    {

                        string i = Convert.ToString(item.ItemArray[0]);


                        switch (i)
                        {
                            case "aer": chkAereo.Checked = true;
                                continue;

                            case "fer": chkFerroviario.Checked = true;
                                continue;

                            case "mar": chkMaritimo.Checked = true;
                                continue;

                            case "ter": chkTerrestre.Checked = true;
                                continue;

                        }

                    }

                }

            }
        }


    }

}

