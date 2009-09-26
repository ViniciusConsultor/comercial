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
    public partial class FrmCadProd : Form
    {
        private FrmPrinc _princ = null;

        public FrmCadProd(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;

            _princ.bindingNavigator1.BindingSource = pRODUTOBindingSource;
            _princ.setdataSet(cOMERCIALDataSet);
        }

        private void mskedTxtBxImpostos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void mskedTxtBxPrecoUnitario_Leave(object sender, EventArgs e)
        {

        }

        private void txtFabricante_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

        private void txtGrupo_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

        private void pRODUTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRODUTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);
        }

        private void FrmCadProd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.UNIDADEMEDIDA' table. You can move, or remove it, as needed.
            this.uNIDADEMEDIDATableAdapter.Fill(this.cOMERCIALDataSet.UNIDADEMEDIDA);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.PRODUTO' table. You can move, or remove it, as needed.
        }

        private void FrmCadProd_Shown(object sender, EventArgs e)
        {
            this.pRODUTOTableAdapter.Fill(this.cOMERCIALDataSet.PRODUTO);
        }

        public int salvar()
        {
            String g = dtmPckrCadastro.Text;
            return 0;
        }

        public void novo()
        {
            dtmPckrCadastro.Value = DateTime.Now;

        }
    }
}
