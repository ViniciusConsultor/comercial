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
        }

        private void FrmCadBan_Load(object sender, EventArgs e)
            {
              

            }

        private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

        private void textBox4_TextChanged(object sender, EventArgs e)
            {

            }

        private void LblEst_Click(object sender, EventArgs e)
            {

            }

        private void LblBai_Click(object sender, EventArgs e)
            {

            }

        private void LblNomBan_Click(object sender, EventArgs e)
            {

            }

        private void LblNumAge_Click(object sender, EventArgs e)
            {

            }

        private void LblTel_Click(object sender, EventArgs e)
            {

            }

        private void LblCep_Click(object sender, EventArgs e)
            {

            }

        private void LblCid_Click(object sender, EventArgs e)
            {

            }

        private void LblEnd_Click(object sender, EventArgs e)
            {

            }

        private void LblNumCon_Click(object sender, EventArgs e)
            {

            }

        private void TbPgCadBancos_Click(object sender, EventArgs e)
            {

            }

        private void LblEst_Click_1(object sender, EventArgs e)
            {

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
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.GRUPOPRODUTO' table. You can move, or remove it, as needed.
            this.gRUPOPRODUTOTableAdapter.Fill(this.cOMERCIALDataSet.GRUPOPRODUTO);
        }
        }
    }
