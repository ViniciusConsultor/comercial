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
    public partial class FrmCadVen : Form 
    {
        private FrmPrinc _princ = null;
        private COMERCIALEntities db;
        
        public FrmCadVen(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
            parent.bindingNavigator1.BindingSource = vENDEDORBindingSource;
            parent.setsource(vENDEDORBindingSource);

            ComercialDAO DAO = new ComercialDAO();
            db = DAO.getComercialEntities();

            parent.setdb(db);

            
        }

        public int salvar()
        {
           //Valida CPF

            Validacoes valida = new Validacoes();
            int cpf = valida.ValidaCPF(txtCPF.Text);

            if (cpf == 1)
            {
                MessageBox.Show("CPF Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            
            VENDEDOR x = (VENDEDOR)vENDEDORBindingSource.Current;
            if (!string.IsNullOrEmpty(txtUsu.Text) && !string.IsNullOrEmpty(txtSenha.Text))
            {
                USUARIO usu = new USUARIO();
                usu.BLOQUEADO = "S";
                usu.PRIVILEGIADO = "N";
                usu.USUARIO1 = txtUsu.Text;
                usu.SENHA = txtSenha.Text;
                db.AddToUSUARIO(usu);
                x.USUARIO = usu;
            }
            
            
            REGIAO reg = (REGIAO) rEGIAOBindingSource.Current;
            x.ATIVO = "S";
            x.REGIAO = reg;
            x.CEP = txtcep.getText;

            if (radioButton1.Checked)
            {
                x.SEXO = "M";
            }
            else
            {
                x.SEXO = "F";
            }
            return 0;
        }


        private void FrmCadVen_Load(object sender, EventArgs e)
        {
             var v = from ven in db.VENDEDOR
                    select ven;

            vENDEDORBindingSource.DataSource = v;


            var r = from reg in db.REGIAO
                    select reg;

            rEGIAOBindingSource.DataSource = r;

//            this.txtcep.DataBindings.Add("Text", vENDEDORBindingSource, "CEP");


        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblUF_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void textButton1_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void cEPTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void vENDEDORBindingSource_PositionChanged(object sender, EventArgs e)
        {
            VENDEDOR v =(VENDEDOR) vENDEDORBindingSource.Current;

            txtcep.getText = v.CEP;
            if (v.SEXO == "M")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            if(v.REGIAO is REGIAO)
                cmBxRegiao.SelectedValue = v.REGIAO.CODREGIAO;
            else
                cmBxRegiao.SelectedValue = -1;

        }

    } 

}
