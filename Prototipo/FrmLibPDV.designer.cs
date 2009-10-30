namespace Comercial
{
    partial class FrmLibPDV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbCntrlPedVend = new System.Windows.Forms.TabControl();
            this.tbPgPDV = new System.Windows.Forms.TabPage();
            this.grpBxPedVenda = new System.Windows.Forms.GroupBox();
            this.txtbtnPedido = new System.Windows.Forms.TextBox();
            this.txtCondPagto = new System.Windows.Forms.TextBox();
            this.txtCodTransportadora = new System.Windows.Forms.TextBox();
            this.txtCodVendedor = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.grpTipoPedido = new System.Windows.Forms.GroupBox();
            this.chkComplemento = new System.Windows.Forms.CheckBox();
            this.chkNormal = new System.Windows.Forms.CheckBox();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtNomeTransportadora = new System.Windows.Forms.TextBox();
            this.lbldtemi = new System.Windows.Forms.Label();
            this.lblNomeTransportadora = new System.Windows.Forms.Label();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lbltpfre = new System.Windows.Forms.Label();
            this.lblcondp = new System.Windows.Forms.Label();
            this.lblnomven = new System.Windows.Forms.Label();
            this.lclcodven = new System.Windows.Forms.Label();
            this.lblnomecli = new System.Windows.Forms.Label();
            this.lblcodcli = new System.Windows.Forms.Label();
            this.lblnumPed = new System.Windows.Forms.Label();
            this.grpBxItPedVen = new System.Windows.Forms.GroupBox();
            this.grpBxTotais = new System.Windows.Forms.GroupBox();
            this.lblDescontos = new System.Windows.Forms.Label();
            this.lblVlrFrete = new System.Windows.Forms.Label();
            this.lblVlrMercadoria = new System.Windows.Forms.Label();
            this.txtBxDescontos = new System.Windows.Forms.TextBox();
            this.txtBxVlrFaturado = new System.Windows.Forms.TextBox();
            this.txtBxVlrMercadoria = new System.Windows.Forms.TextBox();
            this.pnlItenped = new System.Windows.Forms.Panel();
            this.dtgrdvItenspven = new System.Windows.Forms.DataGridView();
            this.pEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.pEDIDOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.PEDIDOTableAdapter();
            this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
            this.ColCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClmItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDescProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmQtdeLib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrcUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmIPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVALORFATU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatusItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCntrlPedVend.SuspendLayout();
            this.tbPgPDV.SuspendLayout();
            this.grpBxPedVenda.SuspendLayout();
            this.grpTipoPedido.SuspendLayout();
            this.grpBxItPedVen.SuspendLayout();
            this.grpBxTotais.SuspendLayout();
            this.pnlItenped.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvItenspven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrlPedVend
            // 
            this.tbCntrlPedVend.Controls.Add(this.tbPgPDV);
            this.tbCntrlPedVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlPedVend.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlPedVend.Name = "tbCntrlPedVend";
            this.tbCntrlPedVend.SelectedIndex = 0;
            this.tbCntrlPedVend.Size = new System.Drawing.Size(885, 545);
            this.tbCntrlPedVend.TabIndex = 2001;
            // 
            // tbPgPDV
            // 
            this.tbPgPDV.AutoScroll = true;
            this.tbPgPDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tbPgPDV.Controls.Add(this.grpBxPedVenda);
            this.tbPgPDV.Controls.Add(this.grpBxItPedVen);
            this.tbPgPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPgPDV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbPgPDV.Location = new System.Drawing.Point(4, 22);
            this.tbPgPDV.Name = "tbPgPDV";
            this.tbPgPDV.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgPDV.Size = new System.Drawing.Size(877, 519);
            this.tbPgPDV.TabIndex = 0;
            this.tbPgPDV.Text = "Pedidos de Vendas";
            this.tbPgPDV.UseVisualStyleBackColor = true;
            // 
            // grpBxPedVenda
            // 
            this.grpBxPedVenda.Controls.Add(this.txtbtnPedido);
            this.grpBxPedVenda.Controls.Add(this.txtCondPagto);
            this.grpBxPedVenda.Controls.Add(this.txtCodTransportadora);
            this.grpBxPedVenda.Controls.Add(this.txtCodVendedor);
            this.grpBxPedVenda.Controls.Add(this.txtCodCliente);
            this.grpBxPedVenda.Controls.Add(this.grpTipoPedido);
            this.grpBxPedVenda.Controls.Add(this.dtpEntrega);
            this.grpBxPedVenda.Controls.Add(this.label1);
            this.grpBxPedVenda.Controls.Add(this.dtpEmissao);
            this.grpBxPedVenda.Controls.Add(this.txtNomeTransportadora);
            this.grpBxPedVenda.Controls.Add(this.lbldtemi);
            this.grpBxPedVenda.Controls.Add(this.lblNomeTransportadora);
            this.grpBxPedVenda.Controls.Add(this.txtNomeVendedor);
            this.grpBxPedVenda.Controls.Add(this.txtNomeCliente);
            this.grpBxPedVenda.Controls.Add(this.lbltpfre);
            this.grpBxPedVenda.Controls.Add(this.lblcondp);
            this.grpBxPedVenda.Controls.Add(this.lblnomven);
            this.grpBxPedVenda.Controls.Add(this.lclcodven);
            this.grpBxPedVenda.Controls.Add(this.lblnomecli);
            this.grpBxPedVenda.Controls.Add(this.lblcodcli);
            this.grpBxPedVenda.Controls.Add(this.lblnumPed);
            this.grpBxPedVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxPedVenda.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxPedVenda.Location = new System.Drawing.Point(11, 7);
            this.grpBxPedVenda.Name = "grpBxPedVenda";
            this.grpBxPedVenda.Size = new System.Drawing.Size(858, 116);
            this.grpBxPedVenda.TabIndex = 102;
            this.grpBxPedVenda.TabStop = false;
            this.grpBxPedVenda.Text = "Pedido Venda";
            // 
            // txtbtnPedido
            // 
            this.txtbtnPedido.Enabled = false;
            this.txtbtnPedido.Location = new System.Drawing.Point(14, 36);
            this.txtbtnPedido.Name = "txtbtnPedido";
            this.txtbtnPedido.Size = new System.Drawing.Size(84, 20);
            this.txtbtnPedido.TabIndex = 103;
            // 
            // txtCondPagto
            // 
            this.txtCondPagto.Enabled = false;
            this.txtCondPagto.Location = new System.Drawing.Point(358, 77);
            this.txtCondPagto.Name = "txtCondPagto";
            this.txtCondPagto.Size = new System.Drawing.Size(83, 20);
            this.txtCondPagto.TabIndex = 102;
            // 
            // txtCodTransportadora
            // 
            this.txtCodTransportadora.Enabled = false;
            this.txtCodTransportadora.Location = new System.Drawing.Point(14, 78);
            this.txtCodTransportadora.Name = "txtCodTransportadora";
            this.txtCodTransportadora.Size = new System.Drawing.Size(144, 20);
            this.txtCodTransportadora.TabIndex = 101;
            // 
            // txtCodVendedor
            // 
            this.txtCodVendedor.Enabled = false;
            this.txtCodVendedor.Location = new System.Drawing.Point(458, 34);
            this.txtCodVendedor.Name = "txtCodVendedor";
            this.txtCodVendedor.Size = new System.Drawing.Size(123, 20);
            this.txtCodVendedor.TabIndex = 100;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Location = new System.Drawing.Point(104, 36);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(123, 20);
            this.txtCodCliente.TabIndex = 99;
            // 
            // grpTipoPedido
            // 
            this.grpTipoPedido.Controls.Add(this.chkComplemento);
            this.grpTipoPedido.Controls.Add(this.chkNormal);
            this.grpTipoPedido.Enabled = false;
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
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Enabled = false;
            this.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrega.Location = new System.Drawing.Point(742, 76);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(90, 20);
            this.dtpEntrega.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(739, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Data Entrega:";
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.Enabled = false;
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissao.Location = new System.Drawing.Point(640, 75);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(96, 20);
            this.dtpEmissao.TabIndex = 92;
            // 
            // txtNomeTransportadora
            // 
            this.txtNomeTransportadora.Enabled = false;
            this.txtNomeTransportadora.Location = new System.Drawing.Point(164, 79);
            this.txtNomeTransportadora.Name = "txtNomeTransportadora";
            this.txtNomeTransportadora.Size = new System.Drawing.Size(184, 20);
            this.txtNomeTransportadora.TabIndex = 94;
            // 
            // lbldtemi
            // 
            this.lbldtemi.AutoSize = true;
            this.lbldtemi.Enabled = false;
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
            this.lblNomeTransportadora.Enabled = false;
            this.lblNomeTransportadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTransportadora.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNomeTransportadora.Location = new System.Drawing.Point(161, 62);
            this.lblNomeTransportadora.Name = "lblNomeTransportadora";
            this.lblNomeTransportadora.Size = new System.Drawing.Size(184, 13);
            this.lblNomeTransportadora.TabIndex = 93;
            this.lblNomeTransportadora.Text = "Nome / Razão Social Transportadora";
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Enabled = false;
            this.txtNomeVendedor.Location = new System.Drawing.Point(595, 34);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(237, 20);
            this.txtNomeVendedor.TabIndex = 84;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(233, 36);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(219, 20);
            this.txtNomeCliente.TabIndex = 82;
            // 
            // lbltpfre
            // 
            this.lbltpfre.AutoSize = true;
            this.lbltpfre.Enabled = false;
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
            this.lblcondp.Enabled = false;
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
            this.lblnomven.Enabled = false;
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
            this.lclcodven.Enabled = false;
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
            this.lblnomecli.Enabled = false;
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
            this.lblcodcli.Enabled = false;
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
            this.grpBxItPedVen.Controls.Add(this.grpBxTotais);
            this.grpBxItPedVen.Controls.Add(this.pnlItenped);
            this.grpBxItPedVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxItPedVen.ForeColor = System.Drawing.Color.CadetBlue;
            this.grpBxItPedVen.Location = new System.Drawing.Point(11, 129);
            this.grpBxItPedVen.Name = "grpBxItPedVen";
            this.grpBxItPedVen.Size = new System.Drawing.Size(858, 379);
            this.grpBxItPedVen.TabIndex = 16;
            this.grpBxItPedVen.TabStop = false;
            this.grpBxItPedVen.Text = "Itens Pedido Venda";
            // 
            // grpBxTotais
            // 
            this.grpBxTotais.Controls.Add(this.lblDescontos);
            this.grpBxTotais.Controls.Add(this.lblVlrFrete);
            this.grpBxTotais.Controls.Add(this.lblVlrMercadoria);
            this.grpBxTotais.Controls.Add(this.txtBxDescontos);
            this.grpBxTotais.Controls.Add(this.txtBxVlrFaturado);
            this.grpBxTotais.Controls.Add(this.txtBxVlrMercadoria);
            this.grpBxTotais.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxTotais.Location = new System.Drawing.Point(10, 260);
            this.grpBxTotais.Name = "grpBxTotais";
            this.grpBxTotais.Size = new System.Drawing.Size(841, 102);
            this.grpBxTotais.TabIndex = 101;
            this.grpBxTotais.TabStop = false;
            this.grpBxTotais.Text = "Totais";
            // 
            // lblDescontos
            // 
            this.lblDescontos.AutoSize = true;
            this.lblDescontos.Enabled = false;
            this.lblDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontos.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDescontos.Location = new System.Drawing.Point(674, 48);
            this.lblDescontos.Name = "lblDescontos";
            this.lblDescontos.Size = new System.Drawing.Size(61, 13);
            this.lblDescontos.TabIndex = 24;
            this.lblDescontos.Text = "Descontos:";
            // 
            // lblVlrFrete
            // 
            this.lblVlrFrete.AutoSize = true;
            this.lblVlrFrete.Enabled = false;
            this.lblVlrFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrFrete.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblVlrFrete.Location = new System.Drawing.Point(656, 19);
            this.lblVlrFrete.Name = "lblVlrFrete";
            this.lblVlrFrete.Size = new System.Drawing.Size(79, 13);
            this.lblVlrFrete.TabIndex = 23;
            this.lblVlrFrete.Text = "Valor Faturado:";
            // 
            // lblVlrMercadoria
            // 
            this.lblVlrMercadoria.AutoSize = true;
            this.lblVlrMercadoria.Enabled = false;
            this.lblVlrMercadoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrMercadoria.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblVlrMercadoria.Location = new System.Drawing.Point(665, 74);
            this.lblVlrMercadoria.Name = "lblVlrMercadoria";
            this.lblVlrMercadoria.Size = new System.Drawing.Size(70, 13);
            this.lblVlrMercadoria.TabIndex = 22;
            this.lblVlrMercadoria.Text = "Valor Pedido:";
            // 
            // txtBxDescontos
            // 
            this.txtBxDescontos.Enabled = false;
            this.txtBxDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDescontos.Location = new System.Drawing.Point(752, 45);
            this.txtBxDescontos.Name = "txtBxDescontos";
            this.txtBxDescontos.Size = new System.Drawing.Size(83, 20);
            this.txtBxDescontos.TabIndex = 21;
            // 
            // txtBxVlrFaturado
            // 
            this.txtBxVlrFaturado.Enabled = false;
            this.txtBxVlrFaturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxVlrFaturado.Location = new System.Drawing.Point(752, 19);
            this.txtBxVlrFaturado.Name = "txtBxVlrFaturado";
            this.txtBxVlrFaturado.Size = new System.Drawing.Size(83, 20);
            this.txtBxVlrFaturado.TabIndex = 19;
            // 
            // txtBxVlrMercadoria
            // 
            this.txtBxVlrMercadoria.Enabled = false;
            this.txtBxVlrMercadoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxVlrMercadoria.Location = new System.Drawing.Point(752, 71);
            this.txtBxVlrMercadoria.Name = "txtBxVlrMercadoria";
            this.txtBxVlrMercadoria.Size = new System.Drawing.Size(83, 20);
            this.txtBxVlrMercadoria.TabIndex = 18;
            // 
            // pnlItenped
            // 
            this.pnlItenped.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlItenped.Controls.Add(this.dtgrdvItenspven);
            this.pnlItenped.Location = new System.Drawing.Point(10, 19);
            this.pnlItenped.Name = "pnlItenped";
            this.pnlItenped.Size = new System.Drawing.Size(841, 235);
            this.pnlItenped.TabIndex = 100;
            // 
            // dtgrdvItenspven
            // 
            this.dtgrdvItenspven.AllowUserToAddRows = false;
            this.dtgrdvItenspven.AllowUserToDeleteRows = false;
            this.dtgrdvItenspven.AllowUserToResizeColumns = false;
            this.dtgrdvItenspven.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvItenspven.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrdvItenspven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvItenspven.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCheck,
            this.ClmItem,
            this.ColProd,
            this.ClmDescProd,
            this.ClmQtde,
            this.ClmQtdeLib,
            this.ClmPrcUnit,
            this.ClmIPI,
            this.ColDesconto,
            this.ColTotal,
            this.ColVALORFATU,
            this.ColStatusItem});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrdvItenspven.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrdvItenspven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrdvItenspven.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtgrdvItenspven.Location = new System.Drawing.Point(0, 0);
            this.dtgrdvItenspven.Name = "dtgrdvItenspven";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvItenspven.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrdvItenspven.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgrdvItenspven.Size = new System.Drawing.Size(841, 235);
            this.dtgrdvItenspven.TabIndex = 26;
            this.dtgrdvItenspven.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdvItenspven_CellValueChanged);
            // 
            // pEDIDOBindingSource
            // 
            this.pEDIDOBindingSource.DataMember = "PEDIDO";
            this.pEDIDOBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // cOMERCIALDataSet
            // 
            this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
            this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.TRANSPORTADORATableAdapter = null;
            this.tableAdapterManager.TRANSPORTADORAVIATableAdapter = null;
            this.tableAdapterManager.UNIDADEMEDIDATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            this.tableAdapterManager.VENDEDORTableAdapter = null;
            this.tableAdapterManager.VIATRANSPORTETableAdapter = null;
            // 
            // ColCheck
            // 
            this.ColCheck.FalseValue = "";
            this.ColCheck.HeaderText = "";
            this.ColCheck.Name = "ColCheck";
            this.ColCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCheck.TrueValue = "";
            this.ColCheck.Width = 25;
            // 
            // ClmItem
            // 
            this.ClmItem.DataPropertyName = "ITEM";
            this.ClmItem.HeaderText = "Item";
            this.ClmItem.Name = "ClmItem";
            this.ClmItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClmItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClmItem.Width = 35;
            // 
            // ColProd
            // 
            this.ColProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColProd.DataPropertyName = "CODPRODUTO";
            this.ColProd.HeaderText = "Codigo Produto";
            this.ColProd.Name = "ColProd";
            this.ColProd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColProd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClmDescProd
            // 
            this.ClmDescProd.DataPropertyName = "DESCRICAO";
            this.ClmDescProd.HeaderText = "Descrição Produto";
            this.ClmDescProd.Name = "ClmDescProd";
            this.ClmDescProd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClmDescProd.Width = 125;
            // 
            // ClmQtde
            // 
            this.ClmQtde.DataPropertyName = "QUANTIDADE";
            this.ClmQtde.HeaderText = "Quantidade";
            this.ClmQtde.Name = "ClmQtde";
            this.ClmQtde.ReadOnly = true;
            this.ClmQtde.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClmQtdeLib
            // 
            this.ClmQtdeLib.DataPropertyName = "QUANTLIB";
            this.ClmQtdeLib.HeaderText = "Quantidade Liberada";
            this.ClmQtdeLib.Name = "ClmQtdeLib";
            this.ClmQtdeLib.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClmPrcUnit
            // 
            this.ClmPrcUnit.DataPropertyName = "VALOR";
            this.ClmPrcUnit.HeaderText = "Preço Unitário";
            this.ClmPrcUnit.Name = "ClmPrcUnit";
            this.ClmPrcUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClmIPI
            // 
            this.ClmIPI.DataPropertyName = "IPI";
            this.ClmIPI.HeaderText = "% IPI";
            this.ClmIPI.Name = "ClmIPI";
            this.ClmIPI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClmIPI.Visible = false;
            // 
            // ColDesconto
            // 
            this.ColDesconto.DataPropertyName = "DESCONTO";
            this.ColDesconto.HeaderText = "Desconto";
            this.ColDesconto.Name = "ColDesconto";
            this.ColDesconto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColTotal
            // 
            this.ColTotal.DataPropertyName = "VALORTOTAL";
            this.ColTotal.HeaderText = "Valor Total";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColVALORFATU
            // 
            this.ColVALORFATU.DataPropertyName = "VALORFATU";
            this.ColVALORFATU.HeaderText = "Valor Faturado";
            this.ColVALORFATU.Name = "ColVALORFATU";
            this.ColVALORFATU.ReadOnly = true;
            this.ColVALORFATU.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColVALORFATU.Visible = false;
            // 
            // ColStatusItem
            // 
            this.ColStatusItem.DataPropertyName = "Status";
            this.ColStatusItem.HeaderText = "Status";
            this.ColStatusItem.Name = "ColStatusItem";
            this.ColStatusItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColStatusItem.Visible = false;
            // 
            // FrmLibPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 567);
            this.Controls.Add(this.tbCntrlPedVend);
            this.Name = "FrmLibPDV";
            this.Text = "Liberação de Pedido";
            this.Load += new System.EventHandler(this.FrmLibPDV_Load);
            this.Leave += new System.EventHandler(this.FrmLibPDV_Leave);
            this.tbCntrlPedVend.ResumeLayout(false);
            this.tbPgPDV.ResumeLayout(false);
            this.grpBxPedVenda.ResumeLayout(false);
            this.grpBxPedVenda.PerformLayout();
            this.grpTipoPedido.ResumeLayout(false);
            this.grpTipoPedido.PerformLayout();
            this.grpBxItPedVen.ResumeLayout(false);
            this.grpBxTotais.ResumeLayout(false);
            this.grpBxTotais.PerformLayout();
            this.pnlItenped.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvItenspven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrlPedVend;
        private System.Windows.Forms.TabPage tbPgPDV;
        private System.Windows.Forms.GroupBox grpBxItPedVen;
        private System.Windows.Forms.GroupBox grpBxTotais;
        private System.Windows.Forms.Label lblDescontos;
        private System.Windows.Forms.Label lblVlrFrete;
        private System.Windows.Forms.Label lblVlrMercadoria;
        private System.Windows.Forms.TextBox txtBxDescontos;
        private System.Windows.Forms.TextBox txtBxVlrFaturado;
        private System.Windows.Forms.Panel pnlItenped;
        public System.Windows.Forms.GroupBox grpBxPedVenda;
        private System.Windows.Forms.GroupBox grpTipoPedido;
        public System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtpEmissao;
        public System.Windows.Forms.TextBox txtNomeTransportadora;
        private System.Windows.Forms.Label lbldtemi;
        private System.Windows.Forms.Label lblNomeTransportadora;
        public System.Windows.Forms.TextBox txtNomeVendedor;
        public System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lbltpfre;
        private System.Windows.Forms.Label lblcondp;
        private System.Windows.Forms.Label lblnomven;
        private System.Windows.Forms.Label lclcodven;
        private System.Windows.Forms.Label lblnomecli;
        private System.Windows.Forms.Label lblcodcli;
        private System.Windows.Forms.Label lblnumPed;
        public System.Windows.Forms.DataGridView dtgrdvItenspven;
        public System.Windows.Forms.TextBox txtCodCliente;
        public System.Windows.Forms.TextBox txtCodTransportadora;
        public System.Windows.Forms.TextBox txtCodVendedor;
        public System.Windows.Forms.TextBox txtCondPagto;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource pEDIDOBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.PEDIDOTableAdapter pEDIDOTableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.CheckBox chkComplemento;
        public System.Windows.Forms.CheckBox chkNormal;
        public System.Windows.Forms.TextBox txtBxVlrMercadoria;
        public System.Windows.Forms.TextBox txtbtnPedido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDescProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmQtdeLib;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrcUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVALORFATU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatusItem;

    }
}