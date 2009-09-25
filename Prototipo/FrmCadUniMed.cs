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

         private void FrmCadUniMed_Load(object sender, EventArgs e)
         {
             // TODO: This line of code loads data into the 'cOMERCIALDataSet.UNIDADEMEDIDA' table. You can move, or remove it, as needed.
             this.uNIDADEMEDIDATableAdapter.Fill(this.cOMERCIALDataSet.UNIDADEMEDIDA);

         }
        }
    }
