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
    public partial class FrmCadRegiao : Form
        {
       private FrmPrinc _princ = null;

        public FrmCadRegiao(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
            _princ.bindingNavigator1.BindingSource = rEGIAOBindingSource;
            _princ.setdataSet(cOMERCIALDataSet);
            _princ.novo();
        }

        private void Form5_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'cOMERCIALDataSet.REGIAO' table. You can move, or remove it, as needed.
                this.rEGIAOTableAdapter.Fill(this.cOMERCIALDataSet.REGIAO);

            }

        private void rEGIAOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rEGIAOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void consultaRegiaoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                    this.rEGIAOTableAdapter.ConsultaRegiao(this.cOMERCIALDataSet.REGIAO, dESCRICAOToolStripTextBox.Text);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            dESCRICAOToolStripTextBox.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.rEGIAOTableAdapter.Fill(this.cOMERCIALDataSet.REGIAO);

                consultaRegiaoToolStrip.Visible = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }
        }
    }
