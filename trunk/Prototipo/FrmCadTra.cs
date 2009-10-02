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

        private void label4_Click(object sender, EventArgs e)
            {

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void LblIer_Click(object sender, EventArgs e)
            {

            }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LblCnp_Click(object sender, EventArgs e)
            {

            }

        private void TbPgCadTra_Click(object sender, EventArgs e)
            {

            }

        private void textButton1_Load(object sender, EventArgs e)
        {

        }

        private void lblEmailCliente_Click(object sender, EventArgs e)
        {

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

              
        }
    }
