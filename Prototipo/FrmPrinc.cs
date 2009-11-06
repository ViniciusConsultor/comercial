using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Comercial
{
    public partial class FrmPrinc : Form
    {
        private COMERCIALDataSet _dataset;
        public bool edit;
        Validacoes valida = new Validacoes();

        public void setdataSet(COMERCIALDataSet data)
        {
            _dataset = data;
        }

        public COMERCIALDataSet getdataSet()
        {
            return _dataset;
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
                if (frm is FrmCadVen)
                {
                    FrmCadVen frmVen = (FrmCadVen)frm;
                    retorno = frmVen.salvar(edit);
                }

                #region Form's Claudio
                if (frm is FrmCadCli)
                {
                    FrmCadCli frmCli = (FrmCadCli)frm;
                    retorno = frmCli.salvar(edit);
                }
                #endregion

                if (frm is FrmCadProd && edit == false)
                {
                    FrmCadProd frmCadProd = (FrmCadProd)frm;
                    retorno = frmCadProd.salvar();
                }

                if (frm is FrmCadUsu && edit == false)
                {
                    FrmCadUsu frmCadven = (FrmCadUsu)frm;
                    retorno = frmCadven.salvar();
                }


                if (frm is FrmCadPed && edit == false)
                {
                    FrmCadPed frmPed = (FrmCadPed)frm;

                    if (frmPed.dtpEntrega.Value < frmPed.dtpEmissao.Value)
                    {
                        throw new Exception("DataInvalida");
                    }
                    retorno = frmPed.SalvarPedidoCab();

                }

                if (frm is FrmCadPed && edit == true)
                {
                    FrmCadPed frmPed = (FrmCadPed)frm;


                    retorno = frmPed.AtualizarPedido();

                }

                if (retorno == 0)
                {
                    bindingNavigator1.BindingSource.EndEdit();

                    // 
                    // CADA UM COLOCA O BLOCO DO SEU FORM...
                    if (frm is FrmCadConPag)
                    {
                        COMERCIALDataSetTableAdapters.CONDICAOPAGAMENTOTableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.CONDICAOPAGAMENTOTableAdapter();
                        table.Update(_dataset);
                        FrmCadConPag frmCond = (FrmCadConPag)frm;
                        retorno = frmCond.Salvar();
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

                        FrmCadVen ven = (FrmCadVen)frm;
                        ven.pictureBox1.Visible = false;
                        ven.pictureBox2.Visible = false;

                    }

                    if (frm is FrmCadProd)
                    {

                        COMERCIALDataSetTableAdapters.PRODUTOTableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.PRODUTOTableAdapter();
                        table.Update(_dataset);
                    }



                    Util.Interface.ChangeControlStatus(frm, false);
                    bindingNavigator1.Refresh();

                    edit = false;
                    cancelEdicao();


                    if (frm is FrmCadUsu)
                    {

                        COMERCIALDataSetTableAdapters.USUARIOTableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.USUARIOTableAdapter();
                        table.Update(_dataset);
                    }


                    if (frm is FrmCadTra)
                    {
                        FrmCadTra frmTrans = (FrmCadTra)frm;
                        retorno = frmTrans.ValidaCNPJ();
                        if (retorno == 1)
                        {
                            MessageBox.Show("CNPJ Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Util.Interface.ChangeControlStatus(frm, true);
                            bindingNavigator1.Refresh();

                            btnPesquisar.Enabled = false;
                            BtnDeletar.Enabled = false;
                            btnNovo.Enabled = false;
                            BtnPrincipal.Enabled = false;
                            btnEditar.Enabled = false;
                            btnSalvar.Enabled = true;
                            btnCancelEdicao.Enabled = true;
                        }
                        else
                        {
                            COMERCIALDataSetTableAdapters.TRANSPORTADORATableAdapter table = new Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORATableAdapter();
                            table.Update(_dataset);
                            retorno = frmTrans.salvar();

                        }

                    }

                }
            }
            catch (SqlException sqlex)
            {
                Validacoes valida = new Validacoes();
                valida.tratarSqlExceções(sqlex);
            }
            catch (Exception ex)
            {
                Validacoes valida = new Validacoes();
                valida.tratarSystemExceções(ex);
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
            bindingNavigator1.Enabled = true;
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
                FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
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

            Util.Interface.ChangeControlStatus(frm, true);

            if (frm is FrmCadProd && edit == false)
            {
                FrmCadProd frmCadProd = (FrmCadProd)frm;
                frmCadProd.novo();
            }

            btnPesquisar.Enabled = false;
            BtnDeletar.Enabled = false;
            btnNovo.Enabled = false;
            BtnPrincipal.Enabled = false;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelEdicao.Enabled = true;

            if (frm is FrmCadCli)
            {
                FrmCadCli cli = (FrmCadCli)frm;
                cli.txtLimCredCli.Enabled = false;
            }

            if (frm is FrmCadPed)
            {
                FrmCadPed Ped = (FrmCadPed)frm;
                Ped.dtgrdvItenspven.DataSource = Ped.ListarItem(0);
                Ped.LimparCampos();
                Ped.dtgrdvItenspven.Refresh();
                Ped.dttRetorno.Clear();
                Ped.desabilitacontroles();
                Ped.lblValortotal.Text = Convert.ToString(0);
            }
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
                tlStrpBtnPesquisar.Visible = true;
                tsbhomeProcesso.Visible = true;
                tsbCancelarPedido.Visible = true;
                tsbCancelarPedido.Text = "Cancelar Pedido";

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

            if (frm is FrmConEstProd)
            {
                FrmConEstProd est = (FrmConEstProd)frm;
                est.pesquisar();
            }
            #region Form's Claudio
            if (frm is frmConCli)
            {
                frmConCli cli = (frmConCli)frm;
                cli.pesquisar();
            }

            #endregion

            if (frm is FrmConProd)
            {
                FrmConProd prod = (FrmConProd)frm;
                prod.pesquisar();
            }

            if (frm is FrmConPDV)
            {
                FrmConPDV Ped = (FrmConPDV)frm;
                Ped.pesquisar();
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

            x.geraMining();
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

                tlStrpProcesso.Visible = true;
                // tlStrpBtnDevNf.Visible = true;
                bindingNavigator1.Visible = false;
                tlStrpBtnSalvarUsu.Visible = true;

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


            try
            {
                foreach (Form form in this.MdiChildren)
                {


                    if (form is frmConCli)
                    {
                        frmConCli frmcli = (frmConCli)form;
                        FrmRelGeral filho = new FrmRelGeral("FrmConCli", form, this);
                        filho.Show();
                    }
                    if (form is FrmConPDV)
                    {
                        FrmConPDV frmPed = (FrmConPDV)form;

                        if (frmPed.dtGrdConPDV.RowCount == 0)
                        {
                            throw new Exception("Grid Vazio");
                        }

                        FrmRelGeral filho = new FrmRelGeral("FrmConPDV", form, this);


                        filho.Show();
                    }

                    if (form is FrmConEstProd)
                    {
                        FrmConEstProd frmConEst = (FrmConEstProd)form;

                        if (frmConEst.dtGrdVwConProd.RowCount == 0)
                        {
                            throw new Exception("Grid Vazio");
                        }

                        FrmRelGeral filho = new FrmRelGeral("FrmConEstProd", form, this);


                        filho.Show();
                    }
                    if (form is FrmConProd)
                    {
                        FrmRelGeral filho = new FrmRelGeral("FrmConProd", form, this);
                        filho.Show();
                    }
                    if (form is FrmConVen)
                    {
                        FrmConVen frmPed = (FrmConVen)form;
                        FrmRelGeral filho = new FrmRelGeral("FrmConVen", form, this);
                        filho.Show();
                    }

                }
            }
            catch (Exception ex)
            {
                valida.tratarSystemExceções(ex);
            }
        }

        private void tlStrpBtnGeraNt_Click(object sender, EventArgs e)
        {
            FrmRelGeral filho = new FrmRelGeral("FrmEmiNF", null, this);
            filho.Show();
        }


        private void tlStrpBtnPesquisar_Click(object sender, EventArgs e)
        {

            Form form = this.ActiveMdiChild;
            if (form == null)
                return;

            if (form is FrmLibPDV)
            {
                FrmLibPDV frmlibPed = (FrmLibPDV)form;

                frmlibPed.PesquisaPedido();
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
                BtnDevNF.Visible = true;
                bindingNavigator1.Visible = false;
                filho.limparcampos();
                // Util.Interface.ResetControls(filho);
                //Util.Interface.ChangeControlStatus(filho, false);


                filho.WindowState = FormWindowState.Maximized;
            }

            //CreateForm(this, typeof(FrmDevNotaFiscal));
        }

        private void CreateForm(Form parent, Type children)
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
                // We are anticipating a constructor that take 1 parameter
                var conTypes = new Type[1];
                conTypes[0] = typeof(FrmPrinc);

                // Get the constructor that adheres to our parameters.
                ConstructorInfo constructor = children.GetConstructor(conTypes);

                // Define the parameters to pass into our constructor when we call it.
                var constructorParams = new object[1];
                constructorParams[0] = parent;

                // Invoke the constructor dynamically, getting an instance of the class.
                var frm = (Form)constructor.Invoke(constructorParams);

                frm.Show();

                // Interface.ResetControls(frm);
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
            CreateForm(this, typeof(FrmCadProd));
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm(this, typeof(FrmCadPed));
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
                    // =====
                    // CADA UM INFORME O CODIGO ABAIXO...
                    // =====
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

                    if (frm is FrmCadPed)
                    {
                        bindingNavigator1.BindingSource.RemoveCurrent();
                        COMERCIALDataSetTableAdapters.PEDIDOTableAdapter objPedido = new Comercial.COMERCIALDataSetTableAdapters.PEDIDOTableAdapter();
                        objPedido.Update(_dataset);
                    }



                }
                catch
                {
                    MessageBox.Show("Registro(s) filho(s) encontrado(s).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bindingNavigator1.Refresh();
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
            try
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
                    ven.txtCPF.Enabled = false;
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


                if (frm is FrmCadPed)
                {
                    FrmCadPed frmPed = (FrmCadPed)frm;


                    if (frmPed.chkEfetivado.Checked == true)
                    {
                        Util.Interface.ChangeControlStatus(frm, false);

                        novo();
                        throw new Exception("Efetivado");

                    }

                    //frmPed.limpardttable();
                    frmPed.ValidaControles();
                    frmPed.desabilitacontroles();

                }

            }
            catch (Exception ex)
            {

                valida.tratarSystemExceções(ex);
            }

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


            if (frm is FrmCadPed)
            {
                FrmCadPed Ped = (FrmCadPed)frm;
                Ped.Limparitens();
                Ped.limpardttable();
                Ped.txtNomeCliente.Text = Ped.ListarNomeCliente(Ped.txtcodCli.getText);
                Ped.txtNomeTransportadora.Text = Ped.ListarNomeTransportadora(Ped.txtCodTransportadora.getText);
                Ped.txtNomeVendedor.Text = Ped.ListarNomeVendedor(Ped.txtCodVendedor.getText);
                Ped.populargrid();
            }
            if (frm is FrmCadVen)
            {
                FrmCadVen ven = (FrmCadVen)frm;
                ven.pictureBox1.Visible = false;
                ven.pictureBox2.Visible = false;
            }
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
                FrmCadVen ven = (FrmCadVen)frm;
                ven.cnsltTlStrpConsulta.Visible = true;
                ven.cpfToolStripTextBox.Enabled = true;
                ven.nomeToolStripTextBox.Enabled = true;
                ven.toolStripButton1.Enabled = true;
                ven.toolStripButton2.Enabled = true;
                ven.cnsltTlStrpConsulta.Enabled = true;
            }
            #region Form's Claudio
            if (frm is FrmCadCli)
            {
                FrmCadCli cli = (FrmCadCli)frm;
                cli.cnsltTlStrpConsultaCli.Visible = true;
                cli.cnpjToolStripTextBox.Enabled = true;
                cli.nomeFantasiaToolStripTextBox.Enabled = true;
                cli.consultaToolStripButton.Enabled = true;
                cli.toolStripButton2.Enabled = true;
                cli.cnsltTlStrpConsultaCli.Enabled = true;
            }

            #endregion


        }

        private void FrmPrinc_Load(object sender, EventArgs e)
        {

        }

        private void BtnPrincipalCons_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;
            frm.Close();
            bindingNavigator1.Enabled = false;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm is FrmCadPed)
            {
                FrmCadPed Ped = (FrmCadPed)frm;
                Ped.populargrid();
                Ped.txtNomeCliente.Text = Ped.ListarNomeCliente(Ped.txtcodCli.getText);
                Ped.txtNomeTransportadora.Text = Ped.ListarNomeTransportadora(Ped.txtCodTransportadora.getText);
                Ped.txtNomeVendedor.Text = Ped.ListarNomeVendedor(Ped.txtCodVendedor.getText);

            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm is FrmCadPed)
            {
                FrmCadPed Ped = (FrmCadPed)frm;
                Ped.populargrid();
                Ped.txtNomeCliente.Text = Ped.ListarNomeCliente(Ped.txtcodCli.getText);
                Ped.txtNomeTransportadora.Text = Ped.ListarNomeTransportadora(Ped.txtCodTransportadora.getText);
                Ped.txtNomeVendedor.Text = Ped.ListarNomeVendedor(Ped.txtCodVendedor.getText);

            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm is FrmCadPed)
            {
                FrmCadPed Ped = (FrmCadPed)frm;
                Ped.populargrid();
                Ped.txtNomeCliente.Text = Ped.ListarNomeCliente(Ped.txtcodCli.getText);
                Ped.txtNomeTransportadora.Text = Ped.ListarNomeTransportadora(Ped.txtCodTransportadora.getText);
                Ped.txtNomeVendedor.Text = Ped.ListarNomeVendedor(Ped.txtCodVendedor.getText);
            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm is FrmCadPed)
            {
                FrmCadPed Ped = (FrmCadPed)frm;
                Ped.populargrid();
                Ped.txtNomeCliente.Text = Ped.ListarNomeCliente(Ped.txtcodCli.getText);
                Ped.txtNomeTransportadora.Text = Ped.ListarNomeTransportadora(Ped.txtCodTransportadora.getText);
                Ped.txtNomeVendedor.Text = Ped.ListarNomeVendedor(Ped.txtCodVendedor.getText);
            }
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            // Localiza o formulario
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmConEstProd)
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
                FrmConEstProd filho = new FrmConEstProd(this);
                filho.Show();

                tlStrpConsulta.Visible = true;
                bindingNavigator1.Visible = false;

                // Util.Interface.ResetControls(filho);
                //Util.Interface.ChangeControlStatus(filho, false);

                filho.WindowState = FormWindowState.Maximized;
            }
        }

        private void tlStrpBtnLibPed_Click_1(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;

            try
            {
                if (frm is FrmLibPDV)
                {
                    FrmLibPDV frmlib = (FrmLibPDV)frm;
                    frmlib.LiberaPedido();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       

        private void tlStrpBtnSalvarUsu_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm is FrmCadUsu)
            {
                FrmCadUsu frmusu = (FrmCadUsu)frm;
                if (frmusu.salvar() != 1)
                {
                    MessageBox.Show("Registro alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Util.Interface.ResetControls(frm);
                }
            }
        }

        private void tsbhomeProcesso_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;
            frm.Close();
            bindingNavigator1.Enabled = false;
            bindingNavigator1.Visible = true;
            tlStrpProcesso.Visible = false;
        }

        private void BtnDevNF_Click(object sender, EventArgs e)
        {

        }

        private void BtnDevNF_Click_1(object sender, EventArgs e)
        {

        }

        private void tsbCancelarPedido_Click(object sender, EventArgs e)
        {

            Form frm = this.ActiveMdiChild;
            if (frm == null)
                return;

            try
            {
                if (frm is FrmLibPDV)
                {
                    FrmLibPDV frmPedCanc = (FrmLibPDV)frm;
                    frmPedCanc.CancelarPedido();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
