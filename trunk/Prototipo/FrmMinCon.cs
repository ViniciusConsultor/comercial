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
    public partial class FrmMinCon : Form
    {
        private FrmPrinc _princ = null;

        private string _consulta = null;

        private string _filtro = null;

        public FrmMinCon(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        private void lstBxFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
           // _consulta = lstBxProdutos.SelectedItem.ToString();

        }

        private void txtConsulta_Enter(object sender, EventArgs e)
        {
          
        }

        private void txtConsulta_Enter_1(object sender, EventArgs e)
        {
           /* if (_consulta != null)
            {
                txtConsulta.Text = txtConsulta.Text + " " + _consulta;
                _consulta = null;
            } */
        }

        private void lstBxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  _filtro = lstBxFiltro.SelectedItem.ToString();
         
        }

        private void txtFiltro_Enter(object sender, EventArgs e)
        {
          /*  if (_filtro != null)
            {
                txtFiltro.Text = txtFiltro.Text + " " + _filtro;
                _filtro = null;
            } */
        }

        private void lstBxOperadores_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  _filtro = lstBxOperadores.SelectedItem.ToString();
         //   _consulta = lstBxOperadores.SelectedItem.ToString();
        }

        private void FrmMinCon_Leave(object sender, EventArgs e)
        {
            Control[] z = _princ.Controls.Find("tlStrpPrinc", true);
            ToolStrip strip = (ToolStrip)z[0];

            strip.Visible = true;

            Control[] y = _princ.Controls.Find("tlStrpProcesso", true);
            ToolStrip strip2 = (ToolStrip)y[0];

            strip2.Visible = false;

            foreach (ToolStripButton x in strip2.Items)
            {
                x.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
