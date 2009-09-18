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
         private FrmPrinc princ = null;
         private COMERCIALEntities db;

         public FrmCadUniMed(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            princ = parent;
            parent.bindingNavigator1.BindingSource = uNIDADEMEDIDABindingSource;
            parent.setsource(uNIDADEMEDIDABindingSource);
            ComercialDAO DAO = new ComercialDAO();
            db = DAO.getComercialEntities();

            parent.setdb(db);


        }

        //----------
         private void LblDescricao_Click(object sender, EventArgs e)
         {

         }

         private void FrmCadUniMed_Load(object sender, EventArgs e)
         {
             var u = from un in db.UNIDADEMEDIDA
                     select un;

             uNIDADEMEDIDABindingSource.DataSource = u;

         }

         private void uNIDADEMEDIDABindingSource_DataSourceChanged(object sender, EventArgs e)
         {

         }
        }
    }
