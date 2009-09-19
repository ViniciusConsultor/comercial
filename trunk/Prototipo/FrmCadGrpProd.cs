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
         private FrmPrinc princ = null;
         private COMERCIALEntities db;
        public FrmCadGrpProd(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            princ = parent;

            parent.bindingNavigator1.BindingSource = gRUPOPRODUTOBindingSource;
            parent.setsource(gRUPOPRODUTOBindingSource);


            ComercialDAO DAO = new ComercialDAO();
            db = new COMERCIALEntities();//DAO.getComercialEntities();

            parent.setdb(db);
        }

        private void FrmCadGrpProd_Load(object sender, EventArgs e)
        {
            var v = from ven in db.GRUPOPRODUTO
                    select ven;

            gRUPOPRODUTOBindingSource.DataSource = v;
        }

     

       
        }
    }
