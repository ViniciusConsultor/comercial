using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Comercial
{
    public partial class FrmPrinc : Form
    {

        private BindingSource source;
        private COMERCIALEntities db;

        public void setdb(COMERCIALEntities c)
        {
            this.db = c;
        }

        public void setsource(BindingSource s)
        {
            source = s;
        }

        public void validaBotoes(bool val)
        {
            BtnSalvar.Enabled = val;
            BtnSalvar.Enabled = val;
        }

        public FrmPrinc()
        {
            InitializeComponent();
        }

        private void FrmPrinc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void devoluçãoDeNFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmDevNotaFiscal)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmDevNotaFiscal filho = new FrmDevNotaFiscal(this);
                filho.Show();

                tlStrpProcesso.Visible = true;
                tlStrpBtnDevNf.Visible = true;
                bindingNavigator1.Visible = false;

                // Util.Interface.ResetControls(filho);
                //Util.Interface.ChangeControlStatus(filho, false);


                filho.WindowState = FormWindowState.Maximized;
            }

            //CreateForm(this, typeof(FrmDevNotaFiscal));
        }

        private void CreateForm(Form parent, object children)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in parent.MdiChildren)
            {
                if (form.GetType() == children.GetType())
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                Type[] conTypes = new Type[1];
                conTypes[0] = typeof(Form);

                // Get the constructor that adheres to our parameters.
                ConstructorInfo constructor = children.GetType().GetConstructor(conTypes);

                object[] constructorParams = new object[1];
                constructorParams[0] = parent;

                // Invoke the constructor dynamically, getting an instance of the class.
                Form frm = (Form)constructor.Invoke(constructorParams);

                frm.Show();

                Util.Interface.ResetControls(frm);
                Util.Interface.ChangeControlStatus(frm, false);

                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmCadVen)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmCadVen filho = new FrmCadVen(this);
                filho.Show();

                //Util.Interface.ResetControls(filho);
                Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Maximized;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gerarModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmMinGer)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            if (x == 0 && y == 0)
            {
                FrmMinGer filho = new FrmMinGer(this);
                filho.Show();

                tlStrpProcesso.Visible = true;
                tlStrpBtnMinGer.Visible = true;
                bindingNavigator1.Visible = false;

                // Util.Interface.ResetControls(filho);
                //Util.Interface.ChangeControlStatus(filho, false);



                filho.WindowState = FormWindowState.Maximized;
            }

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmCadCli)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            if (x == 0 && y == 0)
            {
                FrmCadCli filho = new FrmCadCli(this);
                filho.Show();

                Util.Interface.ResetControls(filho);
                Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void vendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmConVen)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmConVen filho = new FrmConVen(this);
                filho.Show();

                tlStrpConsulta.Visible = true;
                bindingNavigator1.Visible = false;

                // Util.Interface.ResetControls(filho);
                //Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmCadProd)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmCadProd filho = new FrmCadProd(this);
                filho.Show();

                Util.Interface.ResetControls(filho);
                Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmCadPed)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmCadPed filho = new FrmCadPed(this);
                filho.Show();

                Util.Interface.ResetControls(filho);
                Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmConProd)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmConProd filho = new FrmConProd(this);
                filho.Show();

                tlStrpConsulta.Visible = true;
                bindingNavigator1.Visible = false;

                // Util.Interface.ResetControls(filho);
                //Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void notePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad");
        }

        private void excellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Excel");
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmAltSen)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmAltSen filho = new FrmAltSen(this);
                filho.Show();

                Util.Interface.ResetControls(filho);
                Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmCadGrpProd)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmCadGrpProd filho = new FrmCadGrpProd(this);
                filho.Show();

                Util.Interface.ResetControls(filho);
                Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmConCli)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                frmConCli filho = new frmConCli(this);
                filho.Show();

                tlStrpConsulta.Visible = true;
                bindingNavigator1.Visible = false;

                // Util.Interface.ResetControls(filho);
                //Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmCadUniMed)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmCadUniMed filho = new FrmCadUniMed(this);
                filho.Show();

               // Util.Interface.ResetControls(filho);
                Util.Interface.ChangeControlStatus(filho, false);

                
                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void condiçãoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmCadConPag)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmCadConPag filho = new FrmCadConPag(this);
                filho.Show();

               // Util.Interface.ResetControls(filho);
                Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void transportadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmCadTra)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmCadTra filho = new FrmCadTra(this);
                filho.Show();

              //  Util.Interface.ResetControls(filho);
                Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void tESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmCadTes)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmCadTes filho = new FrmCadTes(this);
                filho.Show();

            //    Util.Interface.ResetControls(filho);
                Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;

            MessageBox.Show("Registro salvo com sucesso!", frm.Text,
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            // instanciar o form ativo
            // executar o metodo salvar do form


            //var obj = frm.GetType().GetMethod("Salvar").Invoke(frm, null);

            //if ("Vendedor".Equals(obj.GetType()))
            //    dao.Save((Vendedor)obj);

            //  if(obj.GetType() ==)





            //teste.Controls.Find()

            //FrmCadVen cad = 
            //Control[] z = this.Controls.Find("FrmtoolStrip1", true);
            //ToolStrip strip = (ToolStrip)z[0];

            //foreach (ToolStripItem c in strip.Items)
            //    if (c.Name == "toolStripButton1")
            //        c.Visible = false;

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
          

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;
            Util.Interface.ChangeControlStatus(frm, true);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;
            if (MessageBox.Show("Tem certeza que deseja excluir o registro selecionado?", frm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Registro excluido com sucesso!", frm.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
          
        }

        private void Btnvoltar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {

        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmConPDV)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmConPDV filho = new FrmConPDV(this);
                filho.Show();

                tlStrpConsulta.Visible = true;
                bindingNavigator1.Visible = false;

                // Util.Interface.ResetControls(filho);
                //Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void faturamentoDoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmLibPDV)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmLibPDV filho = new FrmLibPDV(this);
                filho.Show();

                tlStrpProcesso.Visible = true;
                tlStrpBtnLibPed.Visible = true;
                bindingNavigator1.Visible = false;

                // Util.Interface.ResetControls(filho);
                //Util.Interface.ChangeControlStatus(filho, false);



                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmMinCon)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmMinCon filho = new FrmMinCon(this);
                filho.Show();

                tlStrpProcesso.Visible = true;
                tlStrpBtnConMin.Visible = true;
                tlStrpBtnPesquisar.Visible = false;
                bindingNavigator1.Visible = false;

                // Util.Interface.ResetControls(filho);
                //Util.Interface.ChangeControlStatus(filho, false);



                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void tlStrpPrinc_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmSobre)
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                frmSobre filho = new frmSobre(this);
                filho.Show();

                //Util.Interface.ResetControls(filho);
                //Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Normal;
            }
        }

        private void tlStrpBtnConsultar_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                FrmVisGeral x = new FrmVisGeral(this);
                x.ShowDialog();
            }
        }

        private void gerarNotaFiscalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmEmiNotFis)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmEmiNotFis filho = new FrmEmiNotFis(this);
                filho.Show();

                tlStrpProcesso.Visible = true;
                tlStrpBtnGeraNt.Visible = true;
                bindingNavigator1.Visible = false;

                // Util.Interface.ResetControls(filho);
                //Util.Interface.ChangeControlStatus(filho, false);



                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void tlStrpBtnMinGer_Click(object sender, EventArgs e)
        {
            FrmMinGer x = (FrmMinGer)this.MdiChildren[0];
            Control[] c1 = x.Controls.Find("prgrsBrCarrega", true);
            Control[] c2 = x.Controls.Find("tmrTempo", true);
            ProgressBar pr = (ProgressBar)c1[0];


            pr.Value = 0;
            pr.Visible = true;
          //  t.Enabled = true;
        }

        private void criarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmCadUsu)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    x++;
                }
                y++;

            }

            // Para criar o formulario 
            if (x == 0 && y == 0)
            {
                FrmCadUsu filho = new FrmCadUsu(this);
                filho.Show();


                // Util.Interface.ResetControls(filho);
                //Util.Interface.ChangeControlStatus(filho, false);



                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void tlStrpBtnConMin_Click(object sender, EventArgs e)
        {
            //FrmConMin x = new FrmConMin();
           // x.ShowDialog();
/* LE EXCEL
            Microsoft.Office.Interop.Excel.Application AppExcel = new Microsoft.Office.Interop.Excel.Application(); 
            Microsoft.Office.Interop.Excel.Workbook Excelwb; 
            Microsoft.Office.Interop.Excel.Sheets Excelss; 
            Microsoft.Office.Interop.Excel.Worksheet Excelws;Excelwb = 
            AppExcel.Workbooks.Open("c:\\exemplo.xls", 0, true, 5, "", "", true, 
            Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, 
            true, null, null); 
            Excelss = Excelwb.Worksheets; 
            Excelws = (Microsoft.Office.Interop.Excel.Worksheet)Excelss.get_Item(1); 
            string str; 
            str = (string)Excelws.get_Range("A1", "A1").Text;

            MessageBox.Show(str);
 * 
 * */

        }

        private void tmrTempo_Tick(object sender, EventArgs e)
        {

        }

        private void tlStrpBtnImprimir_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmConCli)
                {
                    FrmRelGeral filho = new FrmRelGeral("FrmConCli",null);
                    filho.Show();
                }
                if (form is FrmConPDV)
                {
                    FrmRelGeral filho = new FrmRelGeral("FrmConPDV",((FrmConPDV) form));
                    filho.Show();
                }
                if (form is FrmConProd)
                {
                    FrmRelGeral filho = new FrmRelGeral("FrmConProd",null);
                    filho.Show();
                }
                if (form is FrmConVen)
                {
                    FrmRelGeral filho = new FrmRelGeral("FrmConVen",null);
                    filho.Show();
                }

            }
        }

        private void tlStrpBtnGeraNt_Click(object sender, EventArgs e)
        {
            FrmRelGeral filho = new FrmRelGeral("FrmEmiNF", null);
            filho.Show();
        }

        private void tlStrpBtnPesquisar_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                FrmVisGeral x = new FrmVisGeral(this);
                x.ShowDialog();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnPrincipal_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;
            source.CancelEdit();
            db.Dispose();
            bindingNavigator1.BindingSource = null;            

            frm.Close();
        }

        private void BtnNovo_Click_1(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;
            //Util.Interface.ResetControls(frm);
            Util.Interface.ChangeControlStatus(frm, true);


        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;
            /*  Util.Interface.ResetControls(frm);
             Util.Interface.ChangeControlStatus(frm, false); */

            source.CancelEdit();
            Util.Interface.ChangeControlStatus(frm, false); 
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;
            Util.Interface.ChangeControlStatus(frm, true);

            if (frm is FrmCadVen)
            {
                FrmCadVen ven = (FrmCadVen)frm;

                ven.txtUsu.Enabled = false;
                ven.txtSenha.Enabled = false;
            }

        }

        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            int retorno = 0;
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;
            try
            {
                if (frm is FrmCadVen)
                {
                    FrmCadVen frmVen = (FrmCadVen)frm;
                    retorno = frmVen.salvar();
                }

                if (retorno == 0)
                {
                    source.EndEdit();
                    db.SaveChanges();
                    Util.Interface.ChangeControlStatus(frm, false);
                    bindingNavigator1.Refresh();
                    source.ResumeBinding();
                }
            }
            catch(Exception ex)
            {
               // if(e.)
                MessageBox.Show("Campo(s) Obrigatório(s) não preenchido(s).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return; 
            //COLOCAR MENSAGEM DE CONFIRMAÇAO...
            if (MessageBox.Show("Deseja excluir o registro selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bindingNavigator1.BindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Registro(s) filho(s) encontrado(s).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmPrinc_Load(object sender, EventArgs e)
        {
         
        }
    }
}
