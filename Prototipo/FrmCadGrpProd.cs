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
    public partial class FrmCadGrpProd : Form
    {
        private FrmPrinc _princ = null;

        public FrmCadGrpProd(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;

            _princ.bindingNavigator1.BindingSource = gRUPOPRODUTOBindingSource;
            _princ.setdataSet(cOMERCIALDataSet);
            _princ.novo();
        }

        private void gRUPOPRODUTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gRUPOPRODUTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void gRUPOPRODUTOBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.gRUPOPRODUTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void FrmCadGrpProd_Shown(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.GRUPOPRODUTO' table. You can move, or remove it, as needed.
            this.gRUPOPRODUTOTableAdapter.Fill(this.cOMERCIALDataSet.GRUPOPRODUTO);

        }

        //     private void toolStripButton4_Click(object sender, EventArgs e)
        //{
        //    cODGRUPOPRODUTOToolStripTextBox.Clear();
        //    dESCRICAOToolStripTextBox1.Clear();
        //}

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                this.gRUPOPRODUTOTableAdapter.Fill(this.cOMERCIALDataSet.GRUPOPRODUTO);

                //consultaGrpToolStrip.Visible = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }

       
        private void consultaGroProdutoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gRUPOPRODUTOTableAdapter.ConsultaGroProduto(this.cOMERCIALDataSet.GRUPOPRODUTO, dESCRICAOToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            dESCRICAOToolStripTextBox.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.gRUPOPRODUTOTableAdapter.Fill(this.cOMERCIALDataSet.GRUPOPRODUTO);

                consultaGroProdutoToolStrip.Visible = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }


    }
}
