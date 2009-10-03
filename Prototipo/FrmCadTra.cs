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


            String CnpjTrans = (String)txtCnpjTrans.Text.Replace(".", "").Replace("/", "").Replace("-", "");

            if (chkAereo.Checked)
            {
                COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter VTrans = new Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter();
                VTrans.Insert("1", CnpjTrans);
            }
            if (chkFerroviario.Checked)
            {
                COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter VTrans = new Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter();
                VTrans.Insert("2", CnpjTrans);
            }
            if (chkMaritimo.Checked)
            {
                COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter VTrans = new Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter();
                VTrans.Insert("3", CnpjTrans);
            }
            if (chkTerrestre.Checked)
            {
                COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter VTrans = new Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter();
                VTrans.Insert("4", CnpjTrans);
            }

            this.limparcampos();
            return 0;



        }

        private void tRANSPORTADORABindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (tRANSPORTADORAVIABindingSource.Current != null)
            {
                DataRowView Trans = (DataRowView)tRANSPORTADORABindingSource.Current;

                DataTable table = new DataTable();

                //txtCepCli.getText = c["CEP"].ToString();

                String Codtrans = Trans["CNPJ"].ToString();

                table = Listar(Codtrans);

                this.limparcampos();


                foreach (DataRow item in table.Rows)
                {

                    int i = Convert.ToInt32(item.ItemArray[0]);


                    switch (i)
                    {
                        case 1: chkAereo.Checked = true;
                            continue;

                        case 2: chkFerroviario.Checked = true;
                            continue;

                        case 3: chkMaritimo.Checked = true;
                            continue;

                        case 4: chkTerrestre.Checked = true;
                            continue;

                    }

                }



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

            //Valida CPF

            DataRowView x;
            x = (DataRowView)tRANSPORTADORABindingSource.Current;
            Validacoes valida = new Validacoes();
            int cnpj = valida.ValidaCNPJ(CnpjTrans);

            return cnpj;
        }
    }

}

