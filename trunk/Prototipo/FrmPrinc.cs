﻿using System;
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
        private COMERCIALDataSet _dataset;
        private bool edit;

        public void setdataSet(COMERCIALDataSet data)
        {
            _dataset = data;
        }
        public FrmPrinc()
        {
            InitializeComponent();
            bindingNavigator1.Enabled = false;
        }

        private void FrmPrinc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region Utilitarios
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
        #endregion

        #region Botão Salvar
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            int retorno = 0;
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;

            try
            {
                // METODOS QUE NECESSITAM DE LOGICA ANTES DE SALVAR
                if (frm is FrmCadVen && edit == false)
                {
                    FrmCadVen frmVen = (FrmCadVen)frm;
                    retorno = frmVen.salvar();
                }
                #region Form's Claudio
                if (frm is FrmCadCli && edit == false)
                {
                    FrmCadCli frmCli = (FrmCadCli)frm;
                    retorno = frmCli.salvar();
                }
                #endregion

                if (frm is FrmCadProd && edit == false)
                {
                    FrmCadProd frmCadProd = (FrmCadProd)frm;
                    retorno = frmCadProd.salvar();
                }

                if (retorno == 0)
                {
                    bindingNavigator1.BindingSource.EndEdit();

                    // ===================================
                    // CADA UM COLOCA O BLOCO DO SEU FORM...
                    if (frm is FrmCadConPag)
                    {
                        COMERCIALDataSetTableAdapters.CONDICAOPAGAMENTOTableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.CONDICAOPAGAMENTOTableAdapter();
                        table.Update(_dataset);
                    }

                
                    if (frm is FrmCadGrpProd)
                    {
                        COMERCIALDataSetTableAdapters.GRUPOPRODUTOTableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.GRUPOPRODUTOTableAdapter();
                        table.Update(_dataset);
                    }
                    #region Form's Claudio
                    if (frm is FrmCadCli)
                    {
                        COMERCIALDataSetTableAdapters.CLIENTETableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.CLIENTETableAdapter();
                        table.Update(_dataset);
                    }
                    #endregion

                    if (frm is FrmCadUniMed)
                    {
                        COMERCIALDataSetTableAdapters.UNIDADEMEDIDATableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.UNIDADEMEDIDATableAdapter();
                        table.Update(_dataset);
                    }

                    if (frm is FrmCadVen)
                    {

                        COMERCIALDataSetTableAdapters.VENDEDORTableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.VENDEDORTableAdapter();
                        table.Update(_dataset);
                    }

                    if (frm is FrmCadProd)
                    {

                        COMERCIALDataSetTableAdapters.PRODUTOTableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.PRODUTOTableAdapter();
                        table.Update(_dataset);
                    }

                    // ================================

                    Util.Interface.ChangeControlStatus(frm, false);
                    bindingNavigator1.Refresh();

                    if (frm is FrmCadTra)
                    {
                        FrmCadTra frmTrans = (FrmCadTra)frm;
                        retorno = frmTrans.salvar();
                    }

                    edit = false;
                    cancelEdicao();
                }
            }
            catch (Exception ex)
            {
                // if(e.)
                MessageBox.Show("Campo(s) Obrigatório(s) não preenchido(s).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        private void cancelEdicao()
        {
            btnPesquisar.Enabled = true;
            BtnDeletar.Enabled = true;
            btnNovo.Enabled = true;
            BtnPrincipal.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelEdicao.Enabled = false;
        }

        public void novo()
        {
            btnPesquisar.Enabled = true;
            BtnDeletar.Enabled = true;
            btnNovo.Enabled = true;
            BtnPrincipal.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelEdicao.Enabled = false;
        }
        
        #region Botão Pesquisar
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                FrmVisGeral x = new FrmVisGeral(this);
                x.ShowDialog();
            }
        }
        #endregion

        #region Botão Novo
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;

            if (frm is FrmCadProd && edit == false)
            {
                FrmCadProd frmCadProd = (FrmCadProd)frm;
                frmCadProd.novo();
            }

            Util.Interface.ChangeControlStatus(frm, true);

            btnPesquisar.Enabled = false;
            BtnDeletar.Enabled = false;
            btnNovo.Enabled = false;
            BtnPrincipal.Enabled = false;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelEdicao.Enabled = true;
        }
        #endregion

        #region Botão Cancelar
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;
            /*  Util.Interface.ResetControls(frm);
             Util.Interface.ChangeControlStatus(frm, false); */

            frm.ResetText();

        }
        #endregion

        #region Botão Editar
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;
            Util.Interface.ChangeControlStatus(frm, true);
        }
        #endregion

        #region Botão Excluir
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

        #endregion

        #region Botão Fechar
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;
            frm.Close();
        }
        #endregion

        #region Chamar as telas de acessos
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
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;

            if (frm is FrmConVen)
            {
                FrmConVen ven = (FrmConVen)frm;
                ven.pesquisar();
            }
            #region Form's Claudio
            if (frm is frmConCli)
            {
                frmConCli cli = (frmConCli)frm;
                cli.pesquisar();
            }

            #endregion
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

        private void tlStrpBtnImprimir_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmConCli)
                {
                    FrmRelGeral filho = new FrmRelGeral("FrmConCli", null);
                    filho.Show();
                }
                if (form is FrmConPDV)
                {
                    FrmRelGeral filho = new FrmRelGeral("FrmConPDV", ((FrmConPDV)form));
                    filho.Show();
                }
                if (form is FrmConProd)
                {
                    FrmRelGeral filho = new FrmRelGeral("FrmConProd", null);
                    filho.Show();
                }
                if (form is FrmConVen)
                {
                    FrmRelGeral filho = new FrmRelGeral("FrmConVen", null);
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

                Util.Interface.ResetControls(filho);
                Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Maximized;
            }

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

                Util.Interface.ResetControls(filho);
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

                Util.Interface.ResetControls(filho);
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

                Util.Interface.ResetControls(filho);
                Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Maximized;
            }
        }

        #endregion

        #region Botão Deletar
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
                    // ========================================
                    // CADA UM INFORME O CODIGO ABAIXO...
                    // ========================================
                    #region Form's Claudio
                    if (frm is FrmCadCli)
                    {
                        bindingNavigator1.BindingSource.RemoveCurrent();
                        COMERCIALDataSetTableAdapters.CLIENTETableAdapter teste = new Comercial.COMERCIALDataSetTableAdapters.CLIENTETableAdapter();
                        teste.Update(_dataset);
                    }
                    #endregion
                    if (frm is FrmCadVen)
                    {
                        bindingNavigator1.BindingSource.RemoveCurrent();
                        COMERCIALDataSetTableAdapters.VENDEDORTableAdapter teste = new Comercial.COMERCIALDataSetTableAdapters.VENDEDORTableAdapter();
                        teste.Update(_dataset);
                    }

                    if (frm is FrmCadConPag)
                    {
                        bindingNavigator1.BindingSource.RemoveCurrent();
                        COMERCIALDataSetTableAdapters.CONDICAOPAGAMENTOTableAdapter teste = new Comercial.COMERCIALDataSetTableAdapters.CONDICAOPAGAMENTOTableAdapter();
                        teste.Update(_dataset);
                    }

                    if (frm is FrmCadTra)
                    {
                        bindingNavigator1.BindingSource.RemoveCurrent();
                        COMERCIALDataSetTableAdapters.TRANSPORTADORATableAdapter teste = new Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORATableAdapter();
                        teste.Update(_dataset);
                    }


                    if (frm is FrmCadUniMed)
                    {
                        bindingNavigator1.BindingSource.RemoveCurrent();
                        COMERCIALDataSetTableAdapters.UNIDADEMEDIDATableAdapter teste = new Comercial.COMERCIALDataSetTableAdapters.UNIDADEMEDIDATableAdapter();
                        teste.Update(_dataset);
                    }

                    if (frm is FrmCadGrpProd)
                    {
                        bindingNavigator1.BindingSource.RemoveCurrent();
                        COMERCIALDataSetTableAdapters.GRUPOPRODUTOTableAdapter teste = new Comercial.COMERCIALDataSetTableAdapters.GRUPOPRODUTOTableAdapter();
                        teste.Update(_dataset);
                    }

                    if (frm is FrmCadProd)
                    {
                        bindingNavigator1.BindingSource.RemoveCurrent();
                        COMERCIALDataSetTableAdapters.PRODUTOTableAdapter teste = new Comercial.COMERCIALDataSetTableAdapters.PRODUTOTableAdapter();
                        teste.Update(_dataset);
                    }



                }
                catch
                {
                    MessageBox.Show("Registro(s) filho(s) encontrado(s).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }

        #endregion

        #region Botão Principal
        private void BtnPrincipal_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;
            bindingNavigator1.BindingSource.CancelEdit();
            bindingNavigator1.BindingSource = null;

            frm.Close();
            bindingNavigator1.Enabled = false;
        }
        #endregion

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;

            edit = true;
            Util.Interface.ChangeControlStatus(frm, true);


            if (frm is FrmCadVen)
            {
                FrmCadVen ven = (FrmCadVen)frm;

                ven.txtUsu.Enabled = false;
                ven.txtSenha.Enabled = false;
            }
            #region Form's Claudio
            if (frm is FrmCadCli)
            {
                FrmCadCli cli = (FrmCadCli)frm;

                cli.txtUsuarioCli.Enabled = false;
                cli.txtSenhaCli.Enabled = false;
                cli.txtCnpjCli.Enabled = false;
            }

            btnPesquisar.Enabled = false;
            BtnDeletar.Enabled = false;
            btnNovo.Enabled = false;
            BtnPrincipal.Enabled = false;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;            
            btnCancelEdicao.Enabled = true;

            #endregion
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;

            bindingNavigator1.BindingSource.CancelEdit();
            Util.Interface.ChangeControlStatus(frm, false);
            edit = false;

            cancelEdicao();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;

            if (frm is FrmCadVen)
            {
                FrmCadVen ven = (FrmCadVen) frm;
                ven.cnsltTlStrpConsulta.Visible = true;
                ven.cpfToolStripTextBox.Enabled = true;
                ven.nomeToolStripTextBox.Enabled = true;
                ven.toolStripButton1.Enabled = true;
                ven.toolStripButton2.Enabled = true;
                ven.cnsltTlStrpConsulta.Enabled = true;
            }
        }
    }
}