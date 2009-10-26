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
    public partial class FrmCadConPag : Form
    {
        private FrmPrinc _princ = null;

        public FrmCadConPag(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;

            // =================================================
            // COLOCAR ESSA PARTE EM TODOS OS FORMS

            _princ.bindingNavigator1.BindingSource = cONDICAOPAGAMENTOBindingSource;
            _princ.setdataSet(cOMERCIALDataSet);

            //==================================================

            _princ.novo();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cONDICAOPAGAMENTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cONDICAOPAGAMENTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void cONDICAOPAGAMENTOBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cONDICAOPAGAMENTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void cONDICAOPAGAMENTOBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.cONDICAOPAGAMENTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void FrmCadConPag_Shown(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.CONDICAOPAGAMENTO' table. You can move, or remove it, as needed.
            this.cONDICAOPAGAMENTOTableAdapter.Fill(this.cOMERCIALDataSet.CONDICAOPAGAMENTO);
        }



        public int Salvar()
        {

            if (cONDICAOPAGAMENTOBindingSource.Current != null)
            {
                DataRowView CondPagto = (DataRowView)cONDICAOPAGAMENTOBindingSource.Current;

                if (chkEntrada.Checked)
                {

                    CondPagto["ENTRADA"] = "S";
                }
                else
                {
                    CondPagto["ENTRADA"] = "N";
                }
            }
            return 0;

        }

        private void cONDICAOPAGAMENTOBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (cONDICAOPAGAMENTOBindingSource.Current != null)
            {
                DataRowView condpagto = (DataRowView)cONDICAOPAGAMENTOBindingSource.Current;

                if (condpagto["ENTRADA"].ToString() == "S")
                {
                    chkEntrada.Checked = true;
                }
                else
                {
                    chkEntrada.Checked = false;
                }
            }

        }

        private void FrmCadConPag_Load(object sender, EventArgs e)
        {

        }

        private void TxtDiaDes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }
    }
}
