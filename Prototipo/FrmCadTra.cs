using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.UI.WebControls;

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

        private void FrmCadTra_Load(object sender, EventArgs e)
        {

        }

        public int salvar()
        {

            String CnpjTrans = (String)txtCnpjTrans.Text.Replace(".", "").Replace("/", "").Replace("-", "");

            if (chkAereo.Checked)
            {
                COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter VTrans = new Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter();
                VTrans.Insert("1",CnpjTrans);
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
            return 0;

        }
<<<<<<< .mine
=======

              
        }
>>>>>>> .r26
    }
}
