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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibPDV));
            this.tbCntrlPedVend = new System.Windows.Forms.TabControl();
            this.tbPgPDV = new System.Windows.Forms.TabPage();
            this.pnlItenped = new System.Windows.Forms.Panel();
            this.grpBxTotais = new System.Windows.Forms.GroupBox();
            this.txtBxVlrMercadoria = new System.Windows.Forms.TextBox();
            this.txtBxVlrFrete = new System.Windows.Forms.TextBox();
            this.txtBxVlrBruto = new System.Windows.Forms.TextBox();
            this.txtBxDescontos = new System.Windows.Forms.TextBox();
            this.lblVlrMercadoria = new System.Windows.Forms.Label();
            this.lblVlrFrete = new System.Windows.Forms.Label();
            this.lblDescontos = new System.Windows.Forms.Label();
            this.lblVlrBruto = new System.Windows.Forms.Label();
            this.grpBxItPedVen = new System.Windows.Forms.GroupBox();
            this.grpBxPedVenda = new System.Windows.Forms.GroupBox();
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
            this.dtgrdvItenspven = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClmItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDescProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrcUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmIPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatusItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbtnPedido = new Comercial.TextButton();
            this.txtCodTransportadora = new Comercial.TextButton();
            this.txtCondPagto = new Comercial.TextButton();
            this.txtCodVendedor = new Comercial.TextButton();
            this.txtcodCli = new Comercial.TextButton();
            this.tbCntrlPedVend.SuspendLayout();
            this.tbPgPDV.SuspendLayout();
            this.pnlItenped.SuspendLayout();
            this.grpBxTotais.SuspendLayout();
            this.grpBxItPedVen.SuspendLayout();
            this.grpBxPedVenda.SuspendLayout();
            this.grpTipoPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvItenspven)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrlPedVend
            // 
            this.tbCntrlPedVend.Controls.Add(this.tbPgPDV);
            this.tbCntrlPedVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlPedVend.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlPedVend.Name = "tbCntrlPedVend";
            this.tbCntrlPedVend.SelectedIndex = 0;
            this.tbCntrlPedVend.Size = new System.Drawing.Size(888, 557);
            this.tbCntrlPedVend.TabIndex = 2001;
            // 
            // tbPgPDV
            // 
            this.tbPgPDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tbPgPDV.Controls.Add(this.grpBxPedVenda);
            this.tbPgPDV.Controls.Add(this.grpBxItPedVen);
            this.tbPgPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPgPDV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbPgPDV.Location = new System.Drawing.Point(4, 22);
            this.tbPgPDV.Name = "tbPgPDV";
            this.tbPgPDV.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgPDV.Size = new System.Drawing.Size(880, 531);
            this.tbPgPDV.TabIndex = 0;
            this.tbPgPDV.Text = "Pedidos de Vendas";
            this.tbPgPDV.UseVisualStyleBackColor = true;
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
            // grpBxTotais
            // 
            this.grpBxTotais.Controls.Add(this.lblVlrBruto);
            this.grpBxTotais.Controls.Add(this.lblDescontos);
            this.grpBxTotais.Controls.Add(this.lblVlrFrete);
            this.grpBxTotais.Controls.Add(this.lblVlrMercadoria);
            this.grpBxTotais.Controls.Add(this.txtBxDescontos);
            this.grpBxTotais.Controls.Add(this.txtBxVlrBruto);
            this.grpBxTotais.Controls.Add(this.txtBxVlrFrete);
            this.grpBxTotais.Controls.Add(this.txtBxVlrMercadoria);
            this.grpBxTotais.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxTotais.Location = new System.Drawing.Point(10, 264);
            this.grpBxTotais.Name = "grpBxTotais";
            this.grpBxTotais.Size = new System.Drawing.Size(841, 135);
            this.grpBxTotais.TabIndex = 101;
            this.grpBxTotais.TabStop = false;
            this.grpBxTotais.Text = "Totais";
            // 
            // txtBxVlrMercadoria
            // 
            this.txtBxVlrMercadoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxVlrMercadoria.Location = new System.Drawing.Point(752, 19);
            this.txtBxVlrMercadoria.Name = "txtBxVlrMercadoria";
            this.txtBxVlrMercadoria.Size = new System.Drawing.Size(83, 20);
            this.txtBxVlrMercadoria.TabIndex = 18;
            // 
            // txtBxVlrFrete
            // 
            this.txtBxVlrFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxVlrFrete.Location = new System.Drawing.Point(752, 48);
            this.txtBxVlrFrete.Name = "txtBxVlrFrete";
            this.txtBxVlrFrete.Size = new System.Drawing.Size(83, 20);
            this.txtBxVlrFrete.TabIndex = 19;
            // 
            // txtBxVlrBruto
            // 
            this.txtBxVlrBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxVlrBruto.Location = new System.Drawing.Point(752, 100);
            this.txtBxVlrBruto.Name = "txtBxVlrBruto";
            this.txtBxVlrBruto.Size = new System.Drawing.Size(83, 20);
            this.txtBxVlrBruto.TabIndex = 20;
            // 
            // txtBxDescontos
            // 
            this.txtBxDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDescontos.Location = new System.Drawing.Point(752, 74);
            this.txtBxDescontos.Name = "txtBxDescontos";
            this.txtBxDescontos.Size = new System.Drawing.Size(83, 20);
            this.txtBxDescontos.TabIndex = 21;
            // 
            // lblVlrMercadoria
            // 
            this.lblVlrMercadoria.AutoSize = true;
            this.lblVlrMercadoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrMercadoria.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblVlrMercadoria.Location = new System.Drawing.Point(665, 22);
            this.lblVlrMercadoria.Name = "lblVlrMercadoria";
            this.lblVlrMercadoria.Size = new System.Drawing.Size(70, 13);
            this.lblVlrMercadoria.TabIndex = 22;
            this.lblVlrMercadoria.Text = "Valor Pedido:";
            // 
            // lblVlrFrete
            // 
            this.lblVlrFrete.AutoSize = true;
            this.lblVlrFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrFrete.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblVlrFrete.Location = new System.Drawing.Point(656, 48);
            this.lblVlrFrete.Name = "lblVlrFrete";
            this.lblVlrFrete.Size = new System.Drawing.Size(79, 13);
            this.lblVlrFrete.TabIndex = 23;
            this.lblVlrFrete.Text = "Valor Faturado:";
            // 
            // lblDescontos
            // 
            this.lblDescontos.AutoSize = true;
            this.lblDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontos.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDescontos.Location = new System.Drawing.Point(674, 77);
            this.lblDescontos.Name = "lblDescontos";
            this.lblDescontos.Size = new System.Drawing.Size(61, 13);
            this.lblDescontos.TabIndex = 24;
            this.lblDescontos.Text = "Descontos:";
            // 
            // lblVlrBruto
            // 
            this.lblVlrBruto.AutoSize = true;
            this.lblVlrBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrBruto.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblVlrBruto.Location = new System.Drawing.Point(674, 103);
            this.lblVlrBruto.Name = "lblVlrBruto";
            this.lblVlrBruto.Size = new System.Drawing.Size(61, 13);
            this.lblVlrBruto.TabIndex = 25;
            this.lblVlrBruto.Text = "Valor Total:";
            // 
            // grpBxItPedVen
            // 
            this.grpBxItPedVen.Controls.Add(this.grpBxTotais);
            this.grpBxItPedVen.Controls.Add(this.pnlItenped);
            this.grpBxItPedVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxItPedVen.ForeColor = System.Drawing.Color.CadetBlue;
            this.grpBxItPedVen.Location = new System.Drawing.Point(11, 129);
            this.grpBxItPedVen.Name = "grpBxItPedVen";
            this.grpBxItPedVen.Size = new System.Drawing.Size(858, 394);
            this.grpBxItPedVen.TabIndex = 16;
            this.grpBxItPedVen.TabStop = false;
            this.grpBxItPedVen.Text = "Itens Pedido Venda";
            // 
            // grpBxPedVenda
            // 
            this.grpBxPedVenda.Controls.Add(this.txtbtnPedido);
            this.grpBxPedVenda.Controls.Add(this.grpTipoPedido);
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
            this.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrega.Location = new System.Drawing.Point(742, 76);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(90, 20);
            this.dtpEntrega.TabIndex = 97;
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
            this.txtNomeTransportadora.Location = new System.Drawing.Point(164, 79);
            this.txtNomeTransportadora.Name = "txtNomeTransportadora";
            this.txtNomeTransportadora.Size = new System.Drawing.Size(184, 20);
            this.txtNomeTransportadora.TabIndex = 94;
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
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Location = new System.Drawing.Point(595, 34);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(237, 20);
            this.txtNomeVendedor.TabIndex = 84;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(233, 36);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(219, 20);
            this.txtNomeCliente.TabIndex = 82;
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
            // dtgrdvItenspven
            // 
            this.dtgrdvItenspven.AllowUserToDeleteRows = false;
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
            this.Delete,
            this.ClmItem,
            this.ColProd,
            this.ClmDescProd,
            this.ClmQtde,
            this.ClmPrcUnit,
            this.ClmIPI,
            this.ColDesconto,
            this.ColTotal,
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
            this.dtgrdvItenspven.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvItenspven.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrdvItenspven.Size = new System.Drawing.Size(841, 235);
            this.dtgrdvItenspven.TabIndex = 26;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
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
            // ColTotal
            // 
            this.ColTotal.DataPropertyName = "VALORTOTAL";
            this.ColTotal.HeaderText = "Valor Total";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.ReadOnly = true;
            // 
            // ColStatusItem
            // 
            this.ColStatusItem.DataPropertyName = "Status";
            this.ColStatusItem.HeaderText = "Status";
            this.ColStatusItem.Name = "ColStatusItem";
            this.ColStatusItem.ReadOnly = true;
            this.ColStatusItem.Visible = false;
            // 
            // txtbtnPedido
            // 
            this.txtbtnPedido.getText = "";
            this.txtbtnPedido.Image = global::Comercial.Properties.Resources.search1;
            this.txtbtnPedido.Location = new System.Drawing.Point(14, 36);
            this.txtbtnPedido.Name = "txtbtnPedido";
            this.txtbtnPedido.ShowButton = false;
            this.txtbtnPedido.Size = new System.Drawing.Size(80, 25);
            this.txtbtnPedido.TabIndex = 98;
            this.txtbtnPedido.ButtonClick += new System.EventHandler(this.txtbtnPedido_ButtonClick);
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
            // 
            // FrmLibPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 577);
            this.Controls.Add(this.tbCntrlPedVend);
            this.Name = "FrmLibPDV";
            this.Text = "FrmLibPDV";
            this.Leave += new System.EventHandler(this.FrmLibPDV_Leave);
            this.tbCntrlPedVend.ResumeLayout(false);
            this.tbPgPDV.ResumeLayout(false);
            this.pnlItenped.ResumeLayout(false);
            this.grpBxTotais.ResumeLayout(false);
            this.grpBxTotais.PerformLayout();
            this.grpBxItPedVen.ResumeLayout(false);
            this.grpBxPedVenda.ResumeLayout(false);
            this.grpBxPedVenda.PerformLayout();
            this.grpTipoPedido.ResumeLayout(false);
            this.grpTipoPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvItenspven)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrlPedVend;
        private System.Windows.Forms.TabPage tbPgPDV;
        private System.Windows.Forms.GroupBox grpBxItPedVen;
        private System.Windows.Forms.GroupBox grpBxTotais;
        private System.Windows.Forms.Label lblVlrBruto;
        private System.Windows.Forms.Label lblDescontos;
        private System.Windows.Forms.Label lblVlrFrete;
        private System.Windows.Forms.Label lblVlrMercadoria;
        private System.Windows.Forms.TextBox txtBxDescontos;
        private System.Windows.Forms.TextBox txtBxVlrBruto;
        private System.Windows.Forms.TextBox txtBxVlrFrete;
        private System.Windows.Forms.TextBox txtBxVlrMercadoria;
        private System.Windows.Forms.Panel pnlItenped;
        public System.Windows.Forms.GroupBox grpBxPedVenda;
        private System.Windows.Forms.GroupBox grpTipoPedido;
        private System.Windows.Forms.CheckBox chkComplemento;
        private System.Windows.Forms.CheckBox chkNormal;
        public System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.Label label1;
        public TextButton txtCodTransportadora;
        public System.Windows.Forms.DateTimePicker dtpEmissao;
        public System.Windows.Forms.TextBox txtNomeTransportadora;
        private System.Windows.Forms.Label lbldtemi;
        private System.Windows.Forms.Label lblNomeTransportadora;
        public TextButton txtCondPagto;
        public TextButton txtCodVendedor;
        public TextButton txtcodCli;
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
        private TextButton txtbtnPedido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDescProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrcUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatusItem;

    }
}