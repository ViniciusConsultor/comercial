namespace Comercial
{
    partial class FrmCadUsu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Criar Usúario");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Alterar Senha");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Controle Usúario", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Backup");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Calculadora");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Notepad");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Excel");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Utilitários", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Arquivo", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Cliente");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Produto");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Pedido");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Vendedor");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Unidade Medida");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Condição Pagamento");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Transportadora");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Grupo de produto");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Ajustes", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Cadastros", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Cliente");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Produto");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Pedido");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Vendedor");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Consultas", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Gerar NF");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Devolução NF");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Liberação Pedido");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Gerar Modelo");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Consultar");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Mineração Dados", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Processos", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Sistema Comercial", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode19,
            treeNode24,
            treeNode31});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadUsu));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpBxMenu = new System.Windows.Forms.GroupBox();
            this.trVwMenu = new System.Windows.Forms.TreeView();
            this.btnDesAll = new System.Windows.Forms.Button();
            this.btnMarAll = new System.Windows.Forms.Button();
            this.grpBxInfor = new System.Windows.Forms.GroupBox();
            this.txtBxSenhaAntiga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chckBxPriv = new System.Windows.Forms.CheckBox();
            this.txtUsu = new Comercial.TextButton();
            this.chckBxUsublq = new System.Windows.Forms.CheckBox();
            this.txtConSenha = new System.Windows.Forms.TextBox();
            this.lblConSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblUsua = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbCntrlCtrUsu = new System.Windows.Forms.TabControl();
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.USUARIOTableAdapter();
            this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
            this.tabPage1.SuspendLayout();
            this.grpBxMenu.SuspendLayout();
            this.grpBxInfor.SuspendLayout();
            this.tbCntrlCtrUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.grpBxMenu);
            this.tabPage1.Controls.Add(this.grpBxInfor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Identificação";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpBxMenu
            // 
            this.grpBxMenu.Controls.Add(this.trVwMenu);
            this.grpBxMenu.Controls.Add(this.btnDesAll);
            this.grpBxMenu.Controls.Add(this.btnMarAll);
            this.grpBxMenu.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxMenu.Location = new System.Drawing.Point(273, 6);
            this.grpBxMenu.Name = "grpBxMenu";
            this.grpBxMenu.Size = new System.Drawing.Size(250, 265);
            this.grpBxMenu.TabIndex = 3;
            this.grpBxMenu.TabStop = false;
            this.grpBxMenu.Text = "Menu";
            // 
            // trVwMenu
            // 
            this.trVwMenu.CheckBoxes = true;
            this.trVwMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.trVwMenu.Location = new System.Drawing.Point(6, 13);
            this.trVwMenu.Name = "trVwMenu";
            treeNode1.Name = "criarSenha";
            treeNode1.Text = "Criar Usúario";
            treeNode2.Name = "altSenha";
            treeNode2.Text = "Alterar Senha";
            treeNode3.Name = "controle usuario";
            treeNode3.Text = "Controle Usúario";
            treeNode4.Name = "backup";
            treeNode4.Text = "Backup";
            treeNode5.Name = "Nó14";
            treeNode5.Text = "Calculadora";
            treeNode6.Name = "Nó15";
            treeNode6.Text = "Notepad";
            treeNode7.Name = "Nó16";
            treeNode7.Text = "Excel";
            treeNode8.Name = "utilitario";
            treeNode8.Text = "Utilitários";
            treeNode9.Name = "arquivo";
            treeNode9.Text = "Arquivo";
            treeNode10.Name = "cadcli";
            treeNode10.Text = "Cliente";
            treeNode11.Name = "cadprod";
            treeNode11.Text = "Produto";
            treeNode12.Name = "cadped";
            treeNode12.Text = "Pedido";
            treeNode13.Name = "cadven";
            treeNode13.Text = "Vendedor";
            treeNode14.Name = "cadmed";
            treeNode14.Text = "Unidade Medida";
            treeNode15.Name = "cadcondpag";
            treeNode15.Text = "Condição Pagamento";
            treeNode16.Name = "cadtransp";
            treeNode16.Text = "Transportadora";
            treeNode17.Name = "cadgrupoprod";
            treeNode17.Text = "Grupo de produto";
            treeNode18.Name = "ajustes";
            treeNode18.Text = "Ajustes";
            treeNode19.Name = "cadastros";
            treeNode19.Text = "Cadastros";
            treeNode20.Name = "concli";
            treeNode20.Text = "Cliente";
            treeNode21.Name = "conprod";
            treeNode21.Text = "Produto";
            treeNode22.Name = "conped";
            treeNode22.Text = "Pedido";
            treeNode23.Name = "conven";
            treeNode23.Text = "Vendedor";
            treeNode24.Name = "consultas";
            treeNode24.Text = "Consultas";
            treeNode25.Name = "Gerar NF";
            treeNode25.Text = "Gerar NF";
            treeNode26.Name = "Dev NF";
            treeNode26.Text = "Devolução NF";
            treeNode27.Name = "LibPedido";
            treeNode27.Text = "Liberação Pedido";
            treeNode28.Name = "gerar min";
            treeNode28.Text = "Gerar Modelo";
            treeNode29.Name = "consultar min";
            treeNode29.Text = "Consultar";
            treeNode30.Name = "Min";
            treeNode30.Text = "Mineração Dados";
            treeNode31.Name = "processos";
            treeNode31.Text = "Processos";
            treeNode32.Name = "todos";
            treeNode32.Text = "Sistema Comercial";
            this.trVwMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode32});
            this.trVwMenu.Size = new System.Drawing.Size(238, 217);
            this.trVwMenu.TabIndex = 3;
            // 
            // btnDesAll
            // 
            this.btnDesAll.ForeColor = System.Drawing.Color.Black;
            this.btnDesAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesAll.Location = new System.Drawing.Point(134, 236);
            this.btnDesAll.Name = "btnDesAll";
            this.btnDesAll.Size = new System.Drawing.Size(110, 23);
            this.btnDesAll.TabIndex = 2;
            this.btnDesAll.Text = "Desmarcar Todos";
            this.btnDesAll.UseVisualStyleBackColor = true;
            this.btnDesAll.Click += new System.EventHandler(this.btnDesAll_Click);
            // 
            // btnMarAll
            // 
            this.btnMarAll.ForeColor = System.Drawing.Color.Black;
            this.btnMarAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarAll.Location = new System.Drawing.Point(6, 236);
            this.btnMarAll.Name = "btnMarAll";
            this.btnMarAll.Size = new System.Drawing.Size(122, 23);
            this.btnMarAll.TabIndex = 1;
            this.btnMarAll.Text = "Marcar Todos";
            this.btnMarAll.UseVisualStyleBackColor = true;
            this.btnMarAll.Click += new System.EventHandler(this.btnMarAll_Click);
            // 
            // grpBxInfor
            // 
            this.grpBxInfor.Controls.Add(this.txtBxSenhaAntiga);
            this.grpBxInfor.Controls.Add(this.label1);
            this.grpBxInfor.Controls.Add(this.chckBxPriv);
            this.grpBxInfor.Controls.Add(this.txtUsu);
            this.grpBxInfor.Controls.Add(this.chckBxUsublq);
            this.grpBxInfor.Controls.Add(this.txtConSenha);
            this.grpBxInfor.Controls.Add(this.lblConSenha);
            this.grpBxInfor.Controls.Add(this.txtSenha);
            this.grpBxInfor.Controls.Add(this.lblUsua);
            this.grpBxInfor.Controls.Add(this.lblSenha);
            this.grpBxInfor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxInfor.Location = new System.Drawing.Point(6, 6);
            this.grpBxInfor.Name = "grpBxInfor";
            this.grpBxInfor.Size = new System.Drawing.Size(261, 265);
            this.grpBxInfor.TabIndex = 0;
            this.grpBxInfor.TabStop = false;
            this.grpBxInfor.Text = "Informação";
            // 
            // txtBxSenhaAntiga
            // 
            this.txtBxSenhaAntiga.Location = new System.Drawing.Point(11, 74);
            this.txtBxSenhaAntiga.Name = "txtBxSenhaAntiga";
            this.txtBxSenhaAntiga.PasswordChar = '*';
            this.txtBxSenhaAntiga.Size = new System.Drawing.Size(100, 20);
            this.txtBxSenhaAntiga.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Senha antiga: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chckBxPriv
            // 
            this.chckBxPriv.AutoSize = true;
            this.chckBxPriv.ForeColor = System.Drawing.Color.CadetBlue;
            this.chckBxPriv.Location = new System.Drawing.Point(11, 213);
            this.chckBxPriv.Name = "chckBxPriv";
            this.chckBxPriv.Size = new System.Drawing.Size(80, 17);
            this.chckBxPriv.TabIndex = 45;
            this.chckBxPriv.Text = "Privilegiado";
            this.chckBxPriv.UseVisualStyleBackColor = true;
            // 
            // txtUsu
            // 
            this.txtUsu.getText = "";
            this.txtUsu.Image = ((System.Drawing.Image)(resources.GetObject("txtUsu.Image")));
            this.txtUsu.Location = new System.Drawing.Point(11, 35);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.ShowButton = false;
            this.txtUsu.Size = new System.Drawing.Size(181, 25);
            this.txtUsu.TabIndex = 44;
            this.txtUsu.ButtonClick += new System.EventHandler(this.txtBtnUsu_ButtonClick);
            // 
            // chckBxUsublq
            // 
            this.chckBxUsublq.AutoSize = true;
            this.chckBxUsublq.ForeColor = System.Drawing.Color.CadetBlue;
            this.chckBxUsublq.Location = new System.Drawing.Point(11, 184);
            this.chckBxUsublq.Name = "chckBxUsublq";
            this.chckBxUsublq.Size = new System.Drawing.Size(116, 17);
            this.chckBxUsublq.TabIndex = 43;
            this.chckBxUsublq.Text = "Usuário Bloqueado";
            this.chckBxUsublq.UseVisualStyleBackColor = true;
            // 
            // txtConSenha
            // 
            this.txtConSenha.Location = new System.Drawing.Point(11, 152);
            this.txtConSenha.Name = "txtConSenha";
            this.txtConSenha.PasswordChar = '*';
            this.txtConSenha.Size = new System.Drawing.Size(100, 20);
            this.txtConSenha.TabIndex = 42;
            // 
            // lblConSenha
            // 
            this.lblConSenha.AutoSize = true;
            this.lblConSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConSenha.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblConSenha.Location = new System.Drawing.Point(11, 136);
            this.lblConSenha.Name = "lblConSenha";
            this.lblConSenha.Size = new System.Drawing.Size(108, 13);
            this.lblConSenha.TabIndex = 41;
            this.lblConSenha.Text = "Confirmar Senha :";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(11, 113);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 40;
            // 
            // lblUsua
            // 
            this.lblUsua.AutoSize = true;
            this.lblUsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsua.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblUsua.Location = new System.Drawing.Point(11, 19);
            this.lblUsua.Name = "lblUsua";
            this.lblUsua.Size = new System.Drawing.Size(58, 13);
            this.lblUsua.TabIndex = 36;
            this.lblUsua.Text = "Usuário :";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblSenha.Location = new System.Drawing.Point(11, 97);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(55, 13);
            this.lblSenha.TabIndex = 31;
            this.lblSenha.Text = "Senha : ";
            // 
            // tbCntrlCtrUsu
            // 
            this.tbCntrlCtrUsu.Controls.Add(this.tabPage1);
            this.tbCntrlCtrUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlCtrUsu.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlCtrUsu.Name = "tbCntrlCtrUsu";
            this.tbCntrlCtrUsu.SelectedIndex = 0;
            this.tbCntrlCtrUsu.Size = new System.Drawing.Size(537, 303);
            this.tbCntrlCtrUsu.TabIndex = 0;
            // 
            // cOMERCIALDataSet
            // 
            this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
            this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.CONDICAOPAGAMENTOTableAdapter = null;
            this.tableAdapterManager.GRUPOPRODUTOTableAdapter = null;
            this.tableAdapterManager.ICMSTableAdapter = null;
            this.tableAdapterManager.ItemNotaFiscalTableAdapter = null;
            this.tableAdapterManager.ITEMPEDIDOTableAdapter = null;
            this.tableAdapterManager.MODULOTableAdapter = null;
            this.tableAdapterManager.NOTAFISCALTableAdapter = null;
            this.tableAdapterManager.PEDIDOTableAdapter = null;
            this.tableAdapterManager.PRODUTOTableAdapter = null;
            this.tableAdapterManager.REGIAOTableAdapter = null;
            this.tableAdapterManager.TRANSPORTADORATableAdapter = null;
            this.tableAdapterManager.TRANSPORTADORAVIATableAdapter = null;
            this.tableAdapterManager.UNIDADEMEDIDATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = this.uSUARIOTableAdapter;
            this.tableAdapterManager.VENDEDORTableAdapter = null;
            this.tableAdapterManager.VIATRANSPORTETableAdapter = null;
            // 
            // FrmCadUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 348);
            this.Controls.Add(this.tbCntrlCtrUsu);
            this.Name = "FrmCadUsu";
            this.Text = "Controle de usuários";
            this.Load += new System.EventHandler(this.FrmCadUsu_Load);
            this.Shown += new System.EventHandler(this.FrmCadUsu_Shown);
            this.tabPage1.ResumeLayout(false);
            this.grpBxMenu.ResumeLayout(false);
            this.grpBxInfor.ResumeLayout(false);
            this.grpBxInfor.PerformLayout();
            this.tbCntrlCtrUsu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpBxMenu;
        private System.Windows.Forms.TreeView trVwMenu;
        private System.Windows.Forms.Button btnDesAll;
        private System.Windows.Forms.Button btnMarAll;
        private System.Windows.Forms.GroupBox grpBxInfor;
        private System.Windows.Forms.CheckBox chckBxPriv;
        private System.Windows.Forms.CheckBox chckBxUsublq;
        private System.Windows.Forms.TextBox txtConSenha;
        private System.Windows.Forms.Label lblConSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblUsua;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TabControl tbCntrlCtrUsu;
        private System.Windows.Forms.TextBox txtBxSenhaAntiga;
        private System.Windows.Forms.Label label1;
        public TextButton txtUsu;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;

    }
}