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
            private COMERCIALEntities db;
            private FrmPrinc princ = null;


        public FrmCadTra(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            princ = parent;

            parent.bindingNavigator1.BindingSource = tRANSPORTADORABindingSource;
            parent.setsource(tRANSPORTADORABindingSource);

            ComercialDAO DAO = new ComercialDAO();
            db = DAO.getComercialEntities();
            parent.setdb(db);
        }


        private void FrmCadTra_Load(object sender, EventArgs e)
        {
            var query = from trans in db.TRANSPORTADORA
                        select trans;

            tRANSPORTADORABindingSource.DataSource = query;
        }

        }
    }
