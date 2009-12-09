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
    public partial class FrmCadUniMed : Form
    {
        private FrmPrinc _princ = null;

        public FrmCadUniMed(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
            _princ.novo();
            // =================================================
            // COLOCAR ESSA PARTE EM TODOS OS FORMS

            _princ.bindingNavigator1.BindingSource = uNIDADEMEDIDABindingSource;
            _princ.setdataSet(cOMERCIALDataSet);

            //==================================================

        }

        private void LblDescricao_Click(object sender, EventArgs e)
        {

        }

        private void uNIDADEMEDIDABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uNIDADEMEDIDABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);
        }


        public int Salvar()
        {

            if (uNIDADEMEDIDABindingSource.Current != null)
            {
                DataRowView Inteiro = (DataRowView)uNIDADEMEDIDABindingSource.Current;

                if (CkBoxInteiro.Checked)
                {

                    Inteiro["INTEIRO"] = "I";
                }
                else
                {
                    Inteiro["INTEIRO"] = "D";
                }
            }
            return 0;

        }

        private void cONDICAOPAGAMENTOBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (uNIDADEMEDIDABindingSource.Current != null)
            {
                DataRowView Inteiro = (DataRowView)uNIDADEMEDIDABindingSource.Current;

                if (Inteiro["INTEIRO"].ToString() == "I")
                {
                    CkBoxInteiro.Checked = true;
                }
                else
                {
                    CkBoxInteiro.Checked = false;
                }
            }

        }



        private void FrmCadUniMed_Load(object sender, EventArgs e)
        {
           

        }



        private void consultaunidadeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uNIDADEMEDIDATableAdapter.consultaunidade(this.cOMERCIALDataSet.UNIDADEMEDIDA, cODUNIDADEMEDIDAToolStripTextBox.Text, dESCRICAOToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            dESCRICAOToolStripTextBox.Clear();
            cODUNIDADEMEDIDAToolStripTextBox.Clear();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.uNIDADEMEDIDATableAdapter.Fill(this.cOMERCIALDataSet.UNIDADEMEDIDA);

                consultaunidadeToolStrip.Visible = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }

        private void uNIDADEMEDIDABindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.uNIDADEMEDIDABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void uNIDADEMEDIDABindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.uNIDADEMEDIDABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void uNIDADEMEDIDABindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.uNIDADEMEDIDABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void uNIDADEMEDIDABindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.uNIDADEMEDIDABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void FrmCadUniMed_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.UNIDADEMEDIDA' table. You can move, or remove it, as needed.
            this.uNIDADEMEDIDATableAdapter.Fill(this.cOMERCIALDataSet.UNIDADEMEDIDA);

        }

        private void uNIDADEMEDIDABindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (uNIDADEMEDIDABindingSource.Current != null)
            {
                DataRowView unidade = (DataRowView)uNIDADEMEDIDABindingSource.Current;

                if (unidade["INTEIRO"].ToString() == "I")
                {
                    CkBoxInteiro.Checked = true;
                }
                else
                {
                    CkBoxInteiro.Checked = false;
                }
            }
        }
    }
}
