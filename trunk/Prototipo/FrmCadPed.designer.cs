namespace Comercial
{
    partial class FrmCadPed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadPed));
            this.BtmTlStrpnlPedVenda = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbCntrlPedVend = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpBxPedVenda = new System.Windows.Forms.GroupBox();
            this.grpTipoPedido = new System.Windows.Forms.GroupBox();
            this.chkComplemento = new System.Windows.Forms.CheckBox();
            this.chkNormal = new System.Windows.Forms.CheckBox();
            this.grpBxSitPed = new System.Windows.Forms.GroupBox();
            this.chkCancelado = new System.Windows.Forms.CheckBox();
            this.chkPendente = new System.Windows.Forms.CheckBox();
            this.chkEfetivado = new System.Windows.Forms.CheckBox();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.pEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodTransportadora = new Comercial.TextButton();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtNomeTransportadora = new System.Windows.Forms.TextBox();
            this.vENDEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbldtemi = new System.Windows.Forms.Label();
            this.lblNomeTransportadora = new System.Windows.Forms.Label();
            this.txtCondPagto = new Comercial.TextButton();
            this.txtCodVendedor = new Comercial.TextButton();
            this.txtcodCli = new Comercial.TextButton();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.lbltpfre = new System.Windows.Forms.Label();
            this.lblcondp = new System.Windows.Forms.Label();
            this.lblnomven = new System.Windows.Forms.Label();
            this.lclcodven = new System.Windows.Forms.Label();
            this.lblnomecli = new System.Windows.Forms.Label();
            this.lblcodcli = new System.Windows.Forms.Label();
            this.lblnumPed = new System.Windows.Forms.Label();
            this.grpBxItPedVen = new System.Windows.Forms.GroupBox();
            this.txtProduto = new Comercial.TextButton();
            this.btnAdditen = new System.Windows.Forms.Button();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.pnlItenped = new System.Windows.Forms.Panel();
            this.dtgrdvItenspven = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.ClmItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDescProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrcUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmIPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtipi = new System.Windows.Forms.TextBox();
            this.LblIPI = new System.Windows.Forms.Label();
            this.txtPrcUnit = new System.Windows.Forms.TextBox();
            this.LblPrcUnit = new System.Windows.Forms.Label();
            this.txtQtdItem = new System.Windows.Forms.TextBox();
            this.LblqtdItem = new System.Windows.Forms.Label();
            this.txtPrcVen = new System.Windows.Forms.TextBox();
            this.LblPrcVen = new System.Windows.Forms.Label();
            this.txtEstAtual = new System.Windows.Forms.TextBox();
            this.LblEstAtu = new System.Windows.Forms.Label();
            this.txtUM = new System.Windows.Forms.TextBox();
            this.LblUm = new System.Windows.Forms.Label();
            this.txtDescprod = new System.Windows.Forms.TextBox();
            this.LbDescProd = new System.Windows.Forms.Label();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.pRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTEMPEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRANSPORTADORABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONDICAOPAGAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pEDIDOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.PEDIDOTableAdapter();
            this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
            this.tRANSPORTADORATableAdapter = new Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORATableAdapter();
            this.vENDEDORTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.VENDEDORTableAdapter();
            this.cLIENTETableAdapter = new Comercial.COMERCIALDataSetTableAdapters.CLIENTETableAdapter();
            this.cONDICAOPAGAMENTOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.CONDICAOPAGAMENTOTableAdapter();
            this.iTEMPEDIDOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter();
            this.pRODUTOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.PRODUTOTableAdapter();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbCntrlPedVend.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpBxPedVenda.SuspendLayout();
            this.grpTipoPedido.SuspendLayout();
            this.grpBxSitPed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            this.grpBxItPedVen.SuspendLayout();
            this.pnlItenped.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvItenspven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMPEDIDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTADORABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONDICAOPAGAMENTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtmTlStrpnlPedVenda
            // 
            this.BtmTlStrpnlPedVenda.Location = new System.Drawing.Point(0, 0);
            this.BtmTlStrpnlPedVenda.Name = "BtmTlStrpnlPedVenda";
            this.BtmTlStrpnlPedVenda.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BtmTlStrpnlPedVenda.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BtmTlStrpnlPedVenda.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Column3";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // tbCntrlPedVend
            // 
            this.tbCntrlPedVend.Controls.Add(this.tabPage1);
            this.tbCntrlPedVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlPedVend.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlPedVend.Name = "tbCntrlPedVend";
            this.tbCntrlPedVend.SelectedIndex = 0;
            this.tbCntrlPedVend.Size = new System.Drawing.Size(999, 524);
            this.tbCntrlPedVend.TabIndex = 2001;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.grpBxPedVenda);
            this.tabPage1.Controls.Add(this.grpBxItPedVen);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(991, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pedidos de Vendas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpBxPedVenda
            // 
            this.grpBxPedVenda.Controls.Add(this.grpTipoPedido);
            this.grpBxPedVenda.Controls.Add(this.grpBxSitPed);
            this.grpBxPedVenda.Controls.Add(this.dtpEntrega);
            this.grpBxPedVenda.Controls.Add(this.label1);
            this.grpBxPedVenda.Controls.Add(this.txtCodTransportadora);
            this.grpBxPedVenda.Controls.Add(this.dtpEmissao);
            this.grpBxPedVenda.Controls.Add(this.txtNomeTransportadora);
            this.grpBxPedVenda.Controls.Add(this.lbldtemi);
            this.grpBxPedVenda.Controls.Add(this.lblNomeTransportadora);
            this.grpBxPedVenda.Controls.Add(this.txtCondPagto);
            this.grpBxPedVenda.Controls.Add(this.txtCodVendedor);
            this.grpBxPedVenda.Controls.Add(this.txtcodCli);
            this.grpBxPedVenda.Controls.Add(this.txtNomeVendedor);
            this.grpBxPedVenda.Controls.Add(this.txtNomeCliente);
            this.grpBxPedVenda.Controls.Add(this.txtPedido);
            this.grpBxPedVenda.Controls.Add(this.lbltpfre);
            this.grpBxPedVenda.Controls.Add(this.lblcondp);
            this.grpBxPedVenda.Controls.Add(this.lblnomven);
            this.grpBxPedVenda.Controls.Add(this.lclcodven);
            this.grpBxPedVenda.Controls.Add(this.lblnomecli);
            this.grpBxPedVenda.Controls.Add(this.lblcodcli);
            this.grpBxPedVenda.Controls.Add(this.lblnumPed);
            this.grpBxPedVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxPedVenda.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxPedVenda.Location = new System.Drawing.Point(11, 13);
            this.grpBxPedVenda.Name = "grpBxPedVenda";
            this.grpBxPedVenda.Size = new System.Drawing.Size(942, 116);
            this.grpBxPedVenda.TabIndex = 17;
            this.grpBxPedVenda.TabStop = false;
            this.grpBxPedVenda.Text = "Pedido Venda";
            // 
            // grpTipoPedido
            // 
            this.grpTipoPedido.Controls.Add(this.chkComplemento);
            this.grpTipoPedido.Controls.Add(this.chkNormal);
            this.grpTipoPedido.ForeColor = System.Drawing.Color.CadetBlue;
            this.grpTipoPedido.Location = new System.Drawing.Point(447, 58);
            this.grpTipoPedido.Name = "grpTipoPedido";
            this.grpTipoPedido.Size = new System.Drawing.Size(184, 41);
            this.grpTipoPedido.TabIndex = 90;
            this.grpTipoPedido.TabStop = false;
            this.grpTipoPedido.Text = "Tipo Pedido";
            // 
            // chkComplemento
            // 
            this.chkComplemento.AutoSize = true;
            this.chkComplemento.Location = new System.Drawing.Point(73, 16);
            this.chkComplemento.Name = "chkComplemento";
            this.chkComplemento.Size = new System.Drawing.Size(98, 17);
            this.chkComplemento.TabIndex = 1;
            this.chkComplemento.Text = "Complemeto ";
            this.chkComplemento.UseVisualStyleBackColor = true;
            this.chkComplemento.CheckedChanged += new System.EventHandler(this.chkComplemento_CheckedChanged);
            // 
            // chkNormal
            // 
            this.chkNormal.AutoSize = true;
            this.chkNormal.Location = new System.Drawing.Point(7, 16);
            this.chkNormal.Name = "chkNormal";
            this.chkNormal.Size = new System.Drawing.Size(65, 17);
            this.chkNormal.TabIndex = 0;
            this.chkNormal.Text = "Normal";
            this.chkNormal.UseVisualStyleBackColor = true;
            this.chkNormal.CheckedChanged += new System.EventHandler(this.chkNormal_CheckedChanged);
            // 
            // grpBxSitPed
            // 
            this.grpBxSitPed.Controls.Add(this.chkCancelado);
            this.grpBxSitPed.Controls.Add(this.chkPendente);
            this.grpBxSitPed.Controls.Add(this.chkEfetivado);
            this.grpBxSitPed.ForeColor = System.Drawing.Color.CadetBlue;
            this.grpBxSitPed.Location = new System.Drawing.Point(838, 18);
            this.grpBxSitPed.Name = "grpBxSitPed";
            this.grpBxSitPed.Size = new System.Drawing.Size(91, 85);
            this.grpBxSitPed.TabIndex = 89;
            this.grpBxSitPed.TabStop = false;
            this.grpBxSitPed.Text = "Situação ";
            // 
            // chkCancelado
            // 
            this.chkCancelado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCancelado.Location = new System.Drawing.Point(6, 54);
            this.chkCancelado.Name = "chkCancelado";
            this.chkCancelado.Size = new System.Drawing.Size(92, 26);
            this.chkCancelado.TabIndex = 50;
            this.chkCancelado.Text = "Cancelado";
            this.chkCancelado.UseVisualStyleBackColor = true;
            // 
            // chkPendente
            // 
            this.chkPendente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPendente.Checked = true;
            this.chkPendente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPendente.Location = new System.Drawing.Point(6, 32);
            this.chkPendente.Name = "chkPendente";
            this.chkPendente.Size = new System.Drawing.Size(85, 26);
            this.chkPendente.TabIndex = 49;
            this.chkPendente.Text = "Pendente";
            this.chkPendente.UseVisualStyleBackColor = true;
            // 
            // chkEfetivado
            // 
            this.chkEfetivado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEfetivado.Location = new System.Drawing.Point(6, 10);
            this.chkEfetivado.Name = "chkEfetivado";
            this.chkEfetivado.Size = new System.Drawing.Size(92, 30);
            this.chkEfetivado.TabIndex = 48;
            this.chkEfetivado.Text = "Efetivado";
            this.chkEfetivado.UseVisualStyleBackColor = true;
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEDIDOBindingSource, "DATAENTREGA", true));
            this.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrega.Location = new System.Drawing.Point(742, 76);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(90, 20);
            this.dtpEntrega.TabIndex = 97;
            // 
            // pEDIDOBindingSource
            // 
            this.pEDIDOBindingSource.DataMember = "PEDIDO";
            this.pEDIDOBindingSource.DataSource = this.cOMERCIALDataSet;
            this.pEDIDOBindingSource.PositionChanged += new System.EventHandler(this.pEDIDOBindingSource_PositionChanged);
            // 
            // cOMERCIALDataSet
            // 
            this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
            this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(739, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Data Entrega:";
            // 
            // txtCodTransportadora
            // 
            this.txtCodTransportadora.getText = "";
            this.txtCodTransportadora.Image = ((System.Drawing.Image)(resources.GetObject("txtCodTransportadora.Image")));
            this.txtCodTransportadora.Location = new System.Drawing.Point(14, 79);
            this.txtCodTransportadora.Name = "txtCodTransportadora";
            this.txtCodTransportadora.ShowButton = false;
            this.txtCodTransportadora.Size = new System.Drawing.Size(144, 25);
            this.txtCodTransportadora.TabIndex = 95;
            this.txtCodTransportadora.ButtonClick += new System.EventHandler(this.txtCodTransportadora_ButtonClick);
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEDIDOBindingSource, "DATAEMISSAO", true));
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissao.Location = new System.Drawing.Point(640, 75);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(96, 20);
            this.dtpEmissao.TabIndex = 92;
            // 
            // txtNomeTransportadora
            // 
            this.txtNomeTransportadora.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "NOME", true));
            this.txtNomeTransportadora.Location = new System.Drawing.Point(164, 79);
            this.txtNomeTransportadora.Name = "txtNomeTransportadora";
            this.txtNomeTransportadora.Size = new System.Drawing.Size(184, 20);
            this.txtNomeTransportadora.TabIndex = 94;
            // 
            // vENDEDORBindingSource
            // 
            this.vENDEDORBindingSource.DataMember = "VENDEDOR";
            this.vENDEDORBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // lbldtemi
            // 
            this.lbldtemi.AutoSize = true;
            this.lbldtemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtemi.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbldtemi.Location = new System.Drawing.Point(637, 57);
            this.lbldtemi.Name = "lbldtemi";
            this.lbldtemi.Size = new System.Drawing.Size(75, 13);
            this.lbldtemi.TabIndex = 91;
            this.lbldtemi.Text = "Data Emissão:";
            // 
            // lblNomeTransportadora
            // 
            this.lblNomeTransportadora.AutoSize = true;
            this.lblNomeTransportadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTransportadora.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNomeTransportadora.Location = new System.Drawing.Point(161, 62);
            this.lblNomeTransportadora.Name = "lblNomeTransportadora";
            this.lblNomeTransportadora.Size = new System.Drawing.Size(184, 13);
            this.lblNomeTransportadora.TabIndex = 93;
            this.lblNomeTransportadora.Text = "Nome / Razão Social Transportadora";
            // 
            // txtCondPagto
            // 
            this.txtCondPagto.getText = "";
            this.txtCondPagto.Image = ((System.Drawing.Image)(resources.GetObject("txtCondPagto.Image")));
            this.txtCondPagto.Location = new System.Drawing.Point(358, 78);
            this.txtCondPagto.Name = "txtCondPagto";
            this.txtCondPagto.ShowButton = false;
            this.txtCondPagto.Size = new System.Drawing.Size(71, 25);
            this.txtCondPagto.TabIndex = 92;
            this.txtCondPagto.ButtonClick += new System.EventHandler(this.txtCondPagto_ButtonClick);
            // 
            // txtCodVendedor
            // 
            this.txtCodVendedor.getText = "";
            this.txtCodVendedor.Image = ((System.Drawing.Image)(resources.GetObject("txtCodVendedor.Image")));
            this.txtCodVendedor.Location = new System.Drawing.Point(457, 34);
            this.txtCodVendedor.Name = "txtCodVendedor";
            this.txtCodVendedor.ShowButton = false;
            this.txtCodVendedor.Size = new System.Drawing.Size(132, 25);
            this.txtCodVendedor.TabIndex = 91;
            this.txtCodVendedor.ButtonClick += new System.EventHandler(this.txtCodVendedor_ButtonClick);
            // 
            // txtcodCli
            // 
            this.txtcodCli.getText = "";
            this.txtcodCli.Image = ((System.Drawing.Image)(resources.GetObject("txtcodCli.Image")));
            this.txtcodCli.Location = new System.Drawing.Point(100, 37);
            this.txtcodCli.Name = "txtcodCli";
            this.txtcodCli.ShowButton = false;
            this.txtcodCli.Size = new System.Drawing.Size(127, 25);
            this.txtcodCli.TabIndex = 90;
            this.txtcodCli.ButtonClick += new System.EventHandler(this.txtcodCli_ButtonClick);
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "NOME", true));
            this.txtNomeVendedor.Location = new System.Drawing.Point(595, 34);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(237, 20);
            this.txtNomeVendedor.TabIndex = 84;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "RAZAOSOCIAL", true));
            this.txtNomeCliente.Location = new System.Drawing.Point(233, 36);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(219, 20);
            this.txtNomeCliente.TabIndex = 82;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // txtPedido
            // 
            this.txtPedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEDIDOBindingSource, "NRPEDIDO", true));
            this.txtPedido.Enabled = false;
            this.txtPedido.Location = new System.Drawing.Point(14, 37);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(80, 20);
            this.txtPedido.TabIndex = 18;
            // 
            // lbltpfre
            // 
            this.lbltpfre.AutoSize = true;
            this.lbltpfre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltpfre.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbltpfre.Location = new System.Drawing.Point(11, 65);
            this.lbltpfre.Name = "lbltpfre";
            this.lbltpfre.Size = new System.Drawing.Size(97, 13);
            this.lbltpfre.TabIndex = 73;
            this.lbltpfre.Text = "Transportadora:";
            // 
            // lblcondp
            // 
            this.lblcondp.AutoSize = true;
            this.lblcondp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcondp.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblcondp.Location = new System.Drawing.Point(355, 62);
            this.lblcondp.Name = "lblcondp";
            this.lblcondp.Size = new System.Drawing.Size(74, 13);
            this.lblcondp.TabIndex = 70;
            this.lblcondp.Text = "Cond. Pgto:";
            // 
            // lblnomven
            // 
            this.lblnomven.AutoSize = true;
            this.lblnomven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomven.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblnomven.Location = new System.Drawing.Point(592, 16);
            this.lblnomven.Name = "lblnomven";
            this.lblnomven.Size = new System.Drawing.Size(161, 13);
            this.lblnomven.TabIndex = 68;
            this.lblnomven.Text = "Nome / Razão Social Vendedor:";
            // 
            // lclcodven
            // 
            this.lclcodven.AutoSize = true;
            this.lclcodven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclcodven.ForeColor = System.Drawing.Color.CadetBlue;
            this.lclcodven.Location = new System.Drawing.Point(454, 18);
            this.lclcodven.Name = "lclcodven";
            this.lclcodven.Size = new System.Drawing.Size(108, 13);
            this.lclcodven.TabIndex = 65;
            this.lclcodven.Text = "Código Vendedor:";
            // 
            // lblnomecli
            // 
            this.lblnomecli.AutoSize = true;
            this.lblnomecli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomecli.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblnomecli.Location = new System.Drawing.Point(230, 20);
            this.lblnomecli.Name = "lblnomecli";
            this.lblnomecli.Size = new System.Drawing.Size(147, 13);
            this.lblnomecli.TabIndex = 57;
            this.lblnomecli.Text = "Nome / Razão Social Cliente:";
            // 
            // lblcodcli
            // 
            this.lblcodcli.AutoSize = true;
            this.lblcodcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodcli.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblcodcli.Location = new System.Drawing.Point(101, 20);
            this.lblcodcli.Name = "lblcodcli";
            this.lblcodcli.Size = new System.Drawing.Size(93, 13);
            this.lblcodcli.TabIndex = 54;
            this.lblcodcli.Text = "Código Cliente:";
            // 
            // lblnumPed
            // 
            this.lblnumPed.AutoSize = true;
            this.lblnumPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumPed.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblnumPed.Location = new System.Drawing.Point(11, 20);
            this.lblnumPed.Name = "lblnumPed";
            this.lblnumPed.Size = new System.Drawing.Size(83, 13);
            this.lblnumPed.TabIndex = 52;
            this.lblnumPed.Text = "Numero Pedido:";
            // 
            // grpBxItPedVen
            // 
            this.grpBxItPedVen.Controls.Add(this.txtProduto);
            this.grpBxItPedVen.Controls.Add(this.btnAdditen);
            this.grpBxItPedVen.Controls.Add(this.lblDesconto);
            this.grpBxItPedVen.Controls.Add(this.txtDesconto);
            this.grpBxItPedVen.Controls.Add(this.pnlItenped);
            this.grpBxItPedVen.Controls.Add(this.txtipi);
            this.grpBxItPedVen.Controls.Add(this.LblIPI);
            this.grpBxItPedVen.Controls.Add(this.txtPrcUnit);
            this.grpBxItPedVen.Controls.Add(this.LblPrcUnit);
            this.grpBxItPedVen.Controls.Add(this.txtQtdItem);
            this.grpBxItPedVen.Controls.Add(this.LblqtdItem);
            this.grpBxItPedVen.Controls.Add(this.txtPrcVen);
            this.grpBxItPedVen.Controls.Add(this.LblPrcVen);
            this.grpBxItPedVen.Controls.Add(this.txtEstAtual);
            this.grpBxItPedVen.Controls.Add(this.LblEstAtu);
            this.grpBxItPedVen.Controls.Add(this.txtUM);
            this.grpBxItPedVen.Controls.Add(this.LblUm);
            this.grpBxItPedVen.Controls.Add(this.txtDescprod);
            this.grpBxItPedVen.Controls.Add(this.LbDescProd);
            this.grpBxItPedVen.Controls.Add(this.lblCodProd);
            this.grpBxItPedVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxItPedVen.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxItPedVen.Location = new System.Drawing.Point(11, 145);
            this.grpBxItPedVen.Name = "grpBxItPedVen";
            this.grpBxItPedVen.Size = new System.Drawing.Size(942, 320);
            this.grpBxItPedVen.TabIndex = 16;
            this.grpBxItPedVen.TabStop = false;
            this.grpBxItPedVen.Text = "Itens Pedido Venda";
            // 
            // txtProduto
            // 
            this.txtProduto.getText = "";
            this.txtProduto.Image = ((System.Drawing.Image)(resources.GetObject("txtProduto.Image")));
            this.txtProduto.Location = new System.Drawing.Point(46, 284);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ShowButton = false;
            this.txtProduto.Size = new System.Drawing.Size(84, 25);
            this.txtProduto.TabIndex = 108;
            this.txtProduto.ButtonClick += new System.EventHandler(this.txtProduto_ButtonClick);
            // 
            // btnAdditen
            // 
            this.btnAdditen.Image = ((System.Drawing.Image)(resources.GetObject("btnAdditen.Image")));
            this.btnAdditen.Location = new System.Drawing.Point(835, 283);
            this.btnAdditen.Name = "btnAdditen";
            this.btnAdditen.Size = new System.Drawing.Size(37, 23);
            this.btnAdditen.TabIndex = 107;
            this.btnAdditen.UseVisualStyleBackColor = true;
            this.btnAdditen.Click += new System.EventHandler(this.btnAdditen_Click);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDesconto.Location = new System.Drawing.Point(692, 267);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(61, 13);
            this.lblDesconto.TabIndex = 105;
            this.lblDesconto.Text = "Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(692, 283);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(61, 20);
            this.txtDesconto.TabIndex = 104;
            // 
            // pnlItenped
            // 
            this.pnlItenped.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlItenped.Controls.Add(this.dtgrdvItenspven);
            this.pnlItenped.Location = new System.Drawing.Point(39, 19);
            this.pnlItenped.Name = "pnlItenped";
            this.pnlItenped.Size = new System.Drawing.Size(867, 235);
            this.pnlItenped.TabIndex = 100;
            // 
            // dtgrdvItenspven
            // 
            this.dtgrdvItenspven.AllowUserToAddRows = false;
            this.dtgrdvItenspven.AllowUserToDeleteRows = false;
            this.dtgrdvItenspven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvItenspven.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.ClmItem,
            this.ColProd,
            this.ClmDescProd,
            this.ClmQtde,
            this.ClmPrcUnit,
            this.ClmIPI,
            this.ColDesconto});
            this.dtgrdvItenspven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrdvItenspven.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtgrdvItenspven.Location = new System.Drawing.Point(0, 0);
            this.dtgrdvItenspven.Name = "dtgrdvItenspven";
            this.dtgrdvItenspven.ReadOnly = true;
            this.dtgrdvItenspven.Size = new System.Drawing.Size(867, 235);
            this.dtgrdvItenspven.TabIndex = 25;
            this.dtgrdvItenspven.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdvItenspven_CellClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 25;
            // 
            // ClmItem
            // 
            this.ClmItem.DataPropertyName = "ITEM";
            this.ClmItem.HeaderText = "Item";
            this.ClmItem.Name = "ClmItem";
            this.ClmItem.ReadOnly = true;
            this.ClmItem.Width = 35;
            // 
            // ColProd
            // 
            this.ColProd.DataPropertyName = "CODPRODUTO";
            this.ColProd.HeaderText = "Codigo Produto";
            this.ColProd.Name = "ColProd";
            this.ColProd.ReadOnly = true;
            this.ColProd.Visible = false;
            // 
            // ClmDescProd
            // 
            this.ClmDescProd.DataPropertyName = "DESCRICAO";
            this.ClmDescProd.HeaderText = "Descrição Produto";
            this.ClmDescProd.Name = "ClmDescProd";
            this.ClmDescProd.ReadOnly = true;
            this.ClmDescProd.Width = 125;
            // 
            // ClmQtde
            // 
            this.ClmQtde.DataPropertyName = "QUANTIDADE";
            this.ClmQtde.HeaderText = "Quantidade";
            this.ClmQtde.Name = "ClmQtde";
            this.ClmQtde.ReadOnly = true;
            // 
            // ClmPrcUnit
            // 
            this.ClmPrcUnit.DataPropertyName = "VALOR";
            this.ClmPrcUnit.HeaderText = "Preço Unitário";
            this.ClmPrcUnit.Name = "ClmPrcUnit";
            this.ClmPrcUnit.ReadOnly = true;
            // 
            // ClmIPI
            // 
            this.ClmIPI.DataPropertyName = "IPI";
            this.ClmIPI.HeaderText = "% IPI";
            this.ClmIPI.Name = "ClmIPI";
            this.ClmIPI.ReadOnly = true;
            // 
            // ColDesconto
            // 
            this.ColDesconto.DataPropertyName = "DESCONTO";
            this.ColDesconto.HeaderText = "Desconto";
            this.ColDesconto.Name = "ColDesconto";
            this.ColDesconto.ReadOnly = true;
            // 
            // txtipi
            // 
            this.txtipi.Location = new System.Drawing.Point(759, 283);
            this.txtipi.Name = "txtipi";
            this.txtipi.Size = new System.Drawing.Size(70, 20);
            this.txtipi.TabIndex = 20;
            // 
            // LblIPI
            // 
            this.LblIPI.AutoSize = true;
            this.LblIPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIPI.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblIPI.Location = new System.Drawing.Point(756, 267);
            this.LblIPI.Name = "LblIPI";
            this.LblIPI.Size = new System.Drawing.Size(44, 13);
            this.LblIPI.TabIndex = 94;
            this.LblIPI.Text = "IPI % :";
            // 
            // txtPrcUnit
            // 
            this.txtPrcUnit.Location = new System.Drawing.Point(612, 284);
            this.txtPrcUnit.Name = "txtPrcUnit";
            this.txtPrcUnit.Size = new System.Drawing.Size(70, 20);
            this.txtPrcUnit.TabIndex = 18;
            // 
            // LblPrcUnit
            // 
            this.LblPrcUnit.AutoSize = true;
            this.LblPrcUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrcUnit.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblPrcUnit.Location = new System.Drawing.Point(609, 268);
            this.LblPrcUnit.Name = "LblPrcUnit";
            this.LblPrcUnit.Size = new System.Drawing.Size(75, 13);
            this.LblPrcUnit.TabIndex = 88;
            this.LblPrcUnit.Text = "Preço Unit :";
            // 
            // txtQtdItem
            // 
            this.txtQtdItem.Location = new System.Drawing.Point(533, 284);
            this.txtQtdItem.Name = "txtQtdItem";
            this.txtQtdItem.Size = new System.Drawing.Size(70, 20);
            this.txtQtdItem.TabIndex = 17;
            // 
            // LblqtdItem
            // 
            this.LblqtdItem.AutoSize = true;
            this.LblqtdItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblqtdItem.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblqtdItem.Location = new System.Drawing.Point(530, 268);
            this.LblqtdItem.Name = "LblqtdItem";
            this.LblqtdItem.Size = new System.Drawing.Size(70, 13);
            this.LblqtdItem.TabIndex = 86;
            this.LblqtdItem.Text = "Qtde Item :";
            // 
            // txtPrcVen
            // 
            this.txtPrcVen.Location = new System.Drawing.Point(454, 284);
            this.txtPrcVen.Name = "txtPrcVen";
            this.txtPrcVen.Size = new System.Drawing.Size(70, 20);
            this.txtPrcVen.TabIndex = 16;
            // 
            // LblPrcVen
            // 
            this.LblPrcVen.AutoSize = true;
            this.LblPrcVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrcVen.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblPrcVen.Location = new System.Drawing.Point(451, 268);
            this.LblPrcVen.Name = "LblPrcVen";
            this.LblPrcVen.Size = new System.Drawing.Size(69, 13);
            this.LblPrcVen.TabIndex = 84;
            this.LblPrcVen.Text = "Preço Venda";
            // 
            // txtEstAtual
            // 
            this.txtEstAtual.Location = new System.Drawing.Point(375, 284);
            this.txtEstAtual.Name = "txtEstAtual";
            this.txtEstAtual.Size = new System.Drawing.Size(70, 20);
            this.txtEstAtual.TabIndex = 15;
            // 
            // LblEstAtu
            // 
            this.LblEstAtu.AutoSize = true;
            this.LblEstAtu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstAtu.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblEstAtu.Location = new System.Drawing.Point(372, 268);
            this.LblEstAtu.Name = "LblEstAtu";
            this.LblEstAtu.Size = new System.Drawing.Size(73, 13);
            this.LblEstAtu.TabIndex = 82;
            this.LblEstAtu.Text = "Estoque Atual";
            // 
            // txtUM
            // 
            this.txtUM.Location = new System.Drawing.Point(331, 284);
            this.txtUM.Name = "txtUM";
            this.txtUM.Size = new System.Drawing.Size(38, 20);
            this.txtUM.TabIndex = 14;
            // 
            // LblUm
            // 
            this.LblUm.AutoSize = true;
            this.LblUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUm.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblUm.Location = new System.Drawing.Point(328, 268);
            this.LblUm.Name = "LblUm";
            this.LblUm.Size = new System.Drawing.Size(24, 13);
            this.LblUm.TabIndex = 80;
            this.LblUm.Text = "UM";
            // 
            // txtDescprod
            // 
            this.txtDescprod.Location = new System.Drawing.Point(140, 284);
            this.txtDescprod.Name = "txtDescprod";
            this.txtDescprod.Size = new System.Drawing.Size(185, 20);
            this.txtDescprod.TabIndex = 13;
            // 
            // LbDescProd
            // 
            this.LbDescProd.AutoSize = true;
            this.LbDescProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDescProd.ForeColor = System.Drawing.Color.CadetBlue;
            this.LbDescProd.Location = new System.Drawing.Point(137, 267);
            this.LbDescProd.Name = "LbDescProd";
            this.LbDescProd.Size = new System.Drawing.Size(95, 13);
            this.LbDescProd.TabIndex = 78;
            this.LbDescProd.Text = "Descrição Produto";
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProd.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblCodProd.Location = new System.Drawing.Point(44, 268);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(94, 13);
            this.lblCodProd.TabIndex = 75;
            this.lblCodProd.Text = "Código Produto";
            // 
            // pRODUTOBindingSource
            // 
            this.pRODUTOBindingSource.DataMember = "PRODUTO";
            this.pRODUTOBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // iTEMPEDIDOBindingSource
            // 
            this.iTEMPEDIDOBindingSource.DataMember = "ITEMPEDIDO";
            this.iTEMPEDIDOBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // tRANSPORTADORABindingSource
            // 
            this.tRANSPORTADORABindingSource.DataMember = "TRANSPORTADORA";
            this.tRANSPORTADORABindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // cONDICAOPAGAMENTOBindingSource
            // 
            this.cONDICAOPAGAMENTOBindingSource.DataMember = "CONDICAOPAGAMENTO";
            this.cONDICAOPAGAMENTOBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // pEDIDOTableAdapter
            // 
            this.pEDIDOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PEDIDOTableAdapter = this.pEDIDOTableAdapter;
            this.tableAdapterManager.PRODUTOTableAdapter = null;
            this.tableAdapterManager.REGIAOTableAdapter = null;
            this.tableAdapterManager.TRANSPORTADORATableAdapter = this.tRANSPORTADORATableAdapter;
            this.tableAdapterManager.TRANSPORTADORAVIATableAdapter = null;
            this.tableAdapterManager.UNIDADEMEDIDATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            this.tableAdapterManager.VENDEDORTableAdapter = this.vENDEDORTableAdapter;
            this.tableAdapterManager.VIATRANSPORTETableAdapter = null;
            // 
            // tRANSPORTADORATableAdapter
            // 
            this.tRANSPORTADORATableAdapter.ClearBeforeFill = true;
            // 
            // vENDEDORTableAdapter
            // 
            this.vENDEDORTableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // cONDICAOPAGAMENTOTableAdapter
            // 
            this.cONDICAOPAGAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // iTEMPEDIDOTableAdapter
            // 
            this.iTEMPEDIDOTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUTOTableAdapter
            // 
            this.pRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 25;
            // 
            // FrmCadPed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1023, 548);
            this.Controls.Add(this.tbCntrlPedVend);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadPed";
            this.Text = "FrmCadPed";
            this.Shown += new System.EventHandler(this.FrmCadPed_Shown);
            this.tbCntrlPedVend.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpBxPedVenda.ResumeLayout(false);
            this.grpBxPedVenda.PerformLayout();
            this.grpTipoPedido.ResumeLayout(false);
            this.grpTipoPedido.PerformLayout();
            this.grpBxSitPed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            this.grpBxItPedVen.ResumeLayout(false);
            this.grpBxItPedVen.PerformLayout();
            this.pnlItenped.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvItenspven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMPEDIDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTADORABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONDICAOPAGAMENTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BtmTlStrpnlPedVenda;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TabControl tbCntrlPedVend;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label lblcondp;
        private System.Windows.Forms.Label lblnomven;
        private System.Windows.Forms.Label lclcodven;
        private System.Windows.Forms.Label lblnomecli;
        private System.Windows.Forms.Label lblcodcli;
        private System.Windows.Forms.Label lblnumPed;
        private System.Windows.Forms.GroupBox grpBxItPedVen;
        private System.Windows.Forms.Panel pnlItenped;
        private System.Windows.Forms.Label LblIPI;
        private System.Windows.Forms.TextBox txtPrcUnit;
        private System.Windows.Forms.Label LblPrcUnit;
        private System.Windows.Forms.TextBox txtQtdItem;
        private System.Windows.Forms.Label LblqtdItem;
        private System.Windows.Forms.Label LblPrcVen;
        private System.Windows.Forms.Label LblEstAtu;
        private System.Windows.Forms.Label LblUm;
        private System.Windows.Forms.Label LbDescProd;
        private System.Windows.Forms.Label lblCodProd;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource pEDIDOBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.PEDIDOTableAdapter pEDIDOTableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORATableAdapter tRANSPORTADORATableAdapter;
        private System.Windows.Forms.BindingSource tRANSPORTADORABindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.VENDEDORTableAdapter vENDEDORTableAdapter;
        private System.Windows.Forms.BindingSource vENDEDORBindingSource;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.BindingSource cONDICAOPAGAMENTOBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.CONDICAOPAGAMENTOTableAdapter cONDICAOPAGAMENTOTableAdapter;
        public System.Windows.Forms.GroupBox grpBxPedVenda;
        private System.Windows.Forms.BindingSource iTEMPEDIDOBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter iTEMPEDIDOTableAdapter;
        private System.Windows.Forms.BindingSource pRODUTOBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.PRODUTOTableAdapter pRODUTOTableAdapter;
        private System.Windows.Forms.Label lblDesconto;
        public System.Windows.Forms.DataGridView dtgrdvItenspven;
        private System.Windows.Forms.Button btnAdditen;
        public TextButton txtcodCli;
        public TextButton txtCodVendedor;
        public System.Windows.Forms.TextBox txtNomeCliente;
        public System.Windows.Forms.TextBox txtNomeVendedor;
        public TextButton txtCondPagto;
        public TextButton txtProduto;
        public System.Windows.Forms.TextBox txtPrcVen;
        public System.Windows.Forms.TextBox txtEstAtual;
        public System.Windows.Forms.TextBox txtUM;
        public System.Windows.Forms.TextBox txtDescprod;
        public System.Windows.Forms.TextBox txtipi;
        public System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.GroupBox grpTipoPedido;
        private System.Windows.Forms.CheckBox chkComplemento;
        private System.Windows.Forms.CheckBox chkNormal;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.Label label1;
        public TextButton txtCodTransportadora;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        public System.Windows.Forms.TextBox txtNomeTransportadora;
        private System.Windows.Forms.Label lbldtemi;
        private System.Windows.Forms.GroupBox grpBxSitPed;
        private System.Windows.Forms.Label lblNomeTransportadora;
        private System.Windows.Forms.Label lbltpfre;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.CheckBox chkCancelado;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDescProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrcUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDesconto;
        public System.Windows.Forms.CheckBox chkPendente;
        public System.Windows.Forms.CheckBox chkEfetivado;

    }
}