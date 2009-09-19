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
    public partial class FrmCadConPag : Form
    {

       
        private COMERCIALEntities db;
        private FrmPrinc princ = null;

        public FrmCadConPag(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            princ = parent;

            parent.bindingNavigator1.BindingSource = cONDICAOPAGAMENTOBindingSource;
            parent.setsource(cONDICAOPAGAMENTOBindingSource);

            ComercialDAO DAO = new ComercialDAO();
            db = DAO.getComercialEntities();
            parent.setdb(db);
                 }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadConPag_Load(object sender, EventArgs e)
        {
            var v = from ven in db.CONDICAOPAGAMENTO
                    select ven;

            cONDICAOPAGAMENTOBindingSource.DataSource = v;


        }
    }
}
