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
    public partial class FrmCadPed : Form
    {
        private FrmPrinc _princ = null;

        public FrmCadPed(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

         private void textButton1_ButtonClick_1(object sender, EventArgs e)
         {
             FrmVisGeral x = new FrmVisGeral(this);
             x.ShowDialog();
         }

         private void textButton4_ButtonClick(object sender, EventArgs e)
         {
             FrmVisGeral x = new FrmVisGeral(this);
             x.ShowDialog();

         }

         private void textButton2_ButtonClick(object sender, EventArgs e)
         {
             FrmVisGeral x = new FrmVisGeral(this);
             x.ShowDialog();
         }

         private void textButton5_ButtonClick(object sender, EventArgs e)
         {
             FrmVisGeral x = new FrmVisGeral(this);
             x.ShowDialog();
         }

         private void textButton3_ButtonClick(object sender, EventArgs e)
         {
             FrmVisGeral x = new FrmVisGeral(this);
             x.ShowDialog();
         }

             

    }
}
