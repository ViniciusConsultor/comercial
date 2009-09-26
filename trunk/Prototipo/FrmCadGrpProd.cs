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
