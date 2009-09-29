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
    
    public partial class FrmCadCli : Form
    {
       private FrmPrinc _princ = null;

        public FrmCadCli(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
            _princ.bindingNavigator1.BindingSource = cLIENTEBindingSource;
            _princ.setdataSet(cOMERCIALDataSet); 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbpCadCli_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cLIENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void FrmCadCli_Load(object sender, EventArgs e)
        {
            /*// TODO: This line of code loads data into the 'cOMERCIALDataSet.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.cOMERCIALDataSet.USUARIO);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.cOMERCIALDataSet.CLIENTE);*/

        }

        private void FrmCadCli_Shown(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.cOMERCIALDataSet.USUARIO);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.cOMERCIALDataSet.CLIENTE);
        }

        public int salvar()
        {
            //Valida CPF

            DataRowView x;
            x= (DataRowView) cLIENTEBindingSource.Current;
            Validacoes valida = new Validacoes();
            int cnpj = valida.ValidaCNPJ(txtCnpjCli.Text);

            if (cnpj == 1)
            {
                MessageBox.Show("CNPJ Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }

             if (chckBxCred.Checked)
            {
                 
               x["APROVADOCRED"] = "S";
            }
            else
            {
                x["APROVADOCRED"] = "N";
            }
            x["CEP"] = txtCepCli.getText;
             
            return 0;
        }
    }
}
