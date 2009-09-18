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
            this.tbCntrlPedVend = new System.Windows.Forms.TabControl();
            this.tbPgPDV = new System.Windows.Forms.TabPage();
            this.grpBxPedVenda = new System.Windows.Forms.GroupBox();
            this.txtTrans = new System.Windows.Forms.TextBox();
            this.txtCondPgto = new System.Windows.Forms.TextBox();
            this.txtCodVen = new System.Windows.Forms.TextBox();
            this.txtTpFrete = new System.Windows.Forms.TextBox();
            this.txtTpClien = new System.Windows.Forms.TextBox();
            this.txtDtEmi = new System.Windows.Forms.TextBox();
            this.txtTpPed = new System.Windows.Forms.TextBox();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.lblTpFrete = new System.Windows.Forms.Label();
            this.grpBxSitPed = new System.Windows.Forms.GroupBox();
            this.rdbcanc = new System.Windows.Forms.RadioButton();
            this.rdbpend = new System.Windows.Forms.RadioButton();
            this.rdbefet = new System.Windows.Forms.RadioButton();
            this.lbltpfre = new System.Windows.Forms.Label();
            this.lblcondp = new System.Windows.Forms.Label();
            this.txtNomeVend = new System.Windows.Forms.TextBox();
            this.lblnomven = new System.Windows.Forms.Label();
            this.lclcodven = new System.Windows.Forms.Label();
            this.lbltpcli = new System.Windows.Forms.Label();
            this.lbldtemi = new System.Windows.Forms.Label();
            this.lbltipped = new System.Windows.Forms.Label();
            this.txtNomecli = new System.Windows.Forms.TextBox();
            this.lblnomecli = new System.Windows.Forms.Label();
            this.lblcodcli = new System.Windows.Forms.Label();
            this.lblnumPed = new System.Windows.Forms.Label();
            this.grpBxItPedVen = new System.Windows.Forms.GroupBox();
            this.grpBxTotais = new System.Windows.Forms.GroupBox();
            this.lblVlrBruto = new System.Windows.Forms.Label();
            this.lblDescontos = new System.Windows.Forms.Label();
            this.lblVlrFrete = new System.Windows.Forms.Label();
            this.lblVlrMercadoria = new System.Windows.Forms.Label();
            this.txtBxDescontos = new System.Windows.Forms.TextBox();
            this.txtBxVlrBruto = new System.Windows.Forms.TextBox();
            this.txtBxVlrFrete = new System.Windows.Forms.TextBox();
            this.txtBxVlrMercadoria = new System.Windows.Forms.TextBox();
            this.pnlItenped = new System.Windows.Forms.Panel();
            this.dtGrdVwItensNotFiscal = new System.Windows.Forms.DataGridView();
            this.clmFoiAlterado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlrDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVlrUnitário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlrUniIPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlrTotIPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVlrTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumPed = new Comercial.TextButton();
            this.tbCntrlPedVend.SuspendLayout();
            this.tbPgPDV.SuspendLayout();
            this.grpBxPedVenda.SuspendLayout();
            this.grpBxSitPed.SuspendLayout();
            this.grpBxItPedVen.SuspendLayout();
            this.grpBxTotais.SuspendLayout();
            this.pnlItenped.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwItensNotFiscal)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrlPedVend
            // 
            this.tbCntrlPedVend.Controls.Add(this.tbPgPDV);
            this.tbCntrlPedVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlPedVend.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlPedVend.Name = "tbCntrlPedVend";
            this.tbCntrlPedVend.SelectedIndex = 0;
            this.tbCntrlPedVend.Size = new System.Drawing.Size(889, 557);
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
            this.tbPgPDV.Size = new System.Drawing.Size(881, 531);
            this.tbPgPDV.TabIndex = 0;
            this.tbPgPDV.Text = "Pedidos de Vendas";
            this.tbPgPDV.UseVisualStyleBackColor = true;
            // 
            // grpBxPedVenda
            // 
            this.grpBxPedVenda.Controls.Add(this.txtNumPed);
            this.grpBxPedVenda.Controls.Add(this.txtTrans);
            this.grpBxPedVenda.Controls.Add(this.txtCondPgto);
            this.grpBxPedVenda.Controls.Add(this.txtCodVen);
            this.grpBxPedVenda.Controls.Add(this.txtTpFrete);
            this.grpBxPedVenda.Controls.Add(this.txtTpClien);
            this.grpBxPedVenda.Controls.Add(this.txtDtEmi);
            this.grpBxPedVenda.Controls.Add(this.txtTpPed);
            this.grpBxPedVenda.Controls.Add(this.txtCodCli);
            this.grpBxPedVenda.Controls.Add(this.lblTpFrete);
            this.grpBxPedVenda.Controls.Add(this.grpBxSitPed);
            this.grpBxPedVenda.Controls.Add(this.lbltpfre);
            this.grpBxPedVenda.Controls.Add(this.lblcondp);
            this.grpBxPedVenda.Controls.Add(this.txtNomeVend);
            this.grpBxPedVenda.Controls.Add(this.lblnomven);
            this.grpBxPedVenda.Controls.Add(this.lclcodven);
            this.grpBxPedVenda.Controls.Add(this.lbltpcli);
            this.grpBxPedVenda.Controls.Add(this.lbldtemi);
            this.grpBxPedVenda.Controls.Add(this.lbltipped);
            this.grpBxPedVenda.Controls.Add(this.txtNomecli);
            this.grpBxPedVenda.Controls.Add(this.lblnomecli);
            this.grpBxPedVenda.Controls.Add(this.lblcodcli);
            this.grpBxPedVenda.Controls.Add(this.lblnumPed);
            this.grpBxPedVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxPedVenda.ForeColor = System.Drawing.Color.CadetBlue;
            this.grpBxPedVenda.Location = new System.Drawing.Point(11, 13);
            this.grpBxPedVenda.Name = "grpBxPedVenda";
            this.grpBxPedVenda.Size = new System.Drawing.Size(858, 110);
            this.grpBxPedVenda.TabIndex = 17;
            this.grpBxPedVenda.TabStop = false;
            this.grpBxPedVenda.Text = "Pedido Venda";
            // 
            // txtTrans
            // 
            this.txtTrans.Location = new System.Drawing.Point(398, 78);
            this.txtTrans.Name = "txtTrans";
            this.txtTrans.Size = new System.Drawing.Size(100, 20);
            this.txtTrans.TabIndex = 85;
            // 
            // txtCondPgto
            // 
            this.txtCondPgto.Location = new System.Drawing.Point(306, 79);
            this.txtCondPgto.Name = "txtCondPgto";
            this.txtCondPgto.Size = new System.Drawing.Size(84, 20);
            this.txtCondPgto.TabIndex = 84;
            // 
            // txtCodVen
            // 
            this.txtCodVen.Location = new System.Drawing.Point(14, 81);
            this.txtCodVen.Name = "txtCodVen";
            this.txtCodVen.Size = new System.Drawing.Size(100, 20);
            this.txtCodVen.TabIndex = 83;
            // 
            // txtTpFrete
            // 
            this.txtTpFrete.Location = new System.Drawing.Point(776, 36);
            this.txtTpFrete.Name = "txtTpFrete";
            this.txtTpFrete.Size = new System.Drawing.Size(76, 20);
            this.txtTpFrete.TabIndex = 82;
            // 
            // txtTpClien
            // 
            this.txtTpClien.Location = new System.Drawing.Point(670, 36);
            this.txtTpClien.Name = "txtTpClien";
            this.txtTpClien.Size = new System.Drawing.Size(100, 20);
            this.txtTpClien.TabIndex = 81;
            // 
            // txtDtEmi
            // 
            this.txtDtEmi.Location = new System.Drawing.Point(564, 36);
            this.txtDtEmi.Name = "txtDtEmi";
            this.txtDtEmi.Size = new System.Drawing.Size(100, 20);
            this.txtDtEmi.TabIndex = 80;
            // 
            // txtTpPed
            // 
            this.txtTpPed.Location = new System.Drawing.Point(458, 36);
            this.txtTpPed.Name = "txtTpPed";
            this.txtTpPed.Size = new System.Drawing.Size(100, 20);
            this.txtTpPed.TabIndex = 79;
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(120, 36);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(100, 20);
            this.txtCodCli.TabIndex = 78;
            // 
            // lblTpFrete
            // 
            this.lblTpFrete.AutoSize = true;
            this.lblTpFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpFrete.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTpFrete.Location = new System.Drawing.Point(772, 16);
            this.lblTpFrete.Name = "lblTpFrete";
            this.lblTpFrete.Size = new System.Drawing.Size(58, 13);
            this.lblTpFrete.TabIndex = 77;
            this.lblTpFrete.Text = "Tipo Frete:";
            // 
            // grpBxSitPed
            // 
            this.grpBxSitPed.Controls.Add(this.rdbcanc);
            this.grpBxSitPed.Controls.Add(this.rdbpend);
            this.grpBxSitPed.Controls.Add(this.rdbefet);
            this.grpBxSitPed.ForeColor = System.Drawing.Color.CadetBlue;
            this.grpBxSitPed.Location = new System.Drawing.Point(512, 62);
            this.grpBxSitPed.Name = "grpBxSitPed";
            this.grpBxSitPed.Size = new System.Drawing.Size(236, 37);
            this.grpBxSitPed.TabIndex = 9;
            this.grpBxSitPed.TabStop = false;
            this.grpBxSitPed.Text = "Situação Pedido";
            // 
            // rdbcanc
            // 
            this.rdbcanc.AutoSize = true;
            this.rdbcanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbcanc.ForeColor = System.Drawing.Color.CadetBlue;
            this.rdbcanc.Location = new System.Drawing.Point(159, 14);
            this.rdbcanc.Name = "rdbcanc";
            this.rdbcanc.Size = new System.Drawing.Size(76, 17);
            this.rdbcanc.TabIndex = 47;
            this.rdbcanc.Text = "Cancelado";
            this.rdbcanc.UseVisualStyleBackColor = true;
            // 
            // rdbpend
            // 
            this.rdbpend.AutoSize = true;
            this.rdbpend.Checked = true;
            this.rdbpend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbpend.ForeColor = System.Drawing.Color.CadetBlue;
            this.rdbpend.Location = new System.Drawing.Point(82, 13);
            this.rdbpend.Name = "rdbpend";
            this.rdbpend.Size = new System.Drawing.Size(71, 17);
            this.rdbpend.TabIndex = 46;
            this.rdbpend.TabStop = true;
            this.rdbpend.Text = "Pendente";
            this.rdbpend.UseVisualStyleBackColor = true;
            // 
            // rdbefet
            // 
            this.rdbefet.AutoSize = true;
            this.rdbefet.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdbefet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbefet.ForeColor = System.Drawing.Color.CadetBlue;
            this.rdbefet.Location = new System.Drawing.Point(6, 13);
            this.rdbefet.Name = "rdbefet";
            this.rdbefet.Size = new System.Drawing.Size(70, 17);
            this.rdbefet.TabIndex = 45;
            this.rdbefet.Text = "Efetivado";
            this.rdbefet.UseVisualStyleBackColor = true;
            // 
            // lbltpfre
            // 
            this.lbltpfre.AutoSize = true;
            this.lbltpfre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltpfre.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbltpfre.Location = new System.Drawing.Point(395, 65);
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
            this.lblcondp.Location = new System.Drawing.Point(303, 65);
            this.lblcondp.Name = "lblcondp";
            this.lblcondp.Size = new System.Drawing.Size(74, 13);
            this.lblcondp.TabIndex = 70;
            this.lblcondp.Text = "Cond. Pgto:";
            // 
            // txtNomeVend
            // 
            this.txtNomeVend.Location = new System.Drawing.Point(120, 81);
            this.txtNomeVend.Name = "txtNomeVend";
            this.txtNomeVend.Size = new System.Drawing.Size(180, 20);
            this.txtNomeVend.TabIndex = 8;
            // 
            // lblnomven
            // 
            this.lblnomven.AutoSize = true;
            this.lblnomven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomven.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblnomven.Location = new System.Drawing.Point(117, 65);
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
            this.lclcodven.Location = new System.Drawing.Point(11, 65);
            this.lclcodven.Name = "lclcodven";
            this.lclcodven.Size = new System.Drawing.Size(108, 13);
            this.lclcodven.TabIndex = 65;
            this.lclcodven.Text = "Código Vendedor:";
            // 
            // lbltpcli
            // 
            this.lbltpcli.AutoSize = true;
            this.lbltpcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltpcli.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbltpcli.Location = new System.Drawing.Point(669, 20);
            this.lbltpcli.Name = "lbltpcli";
            this.lbltpcli.Size = new System.Drawing.Size(79, 13);
            this.lbltpcli.TabIndex = 64;
            this.lbltpcli.Text = "Tipo Cliente:";
            // 
            // lbldtemi
            // 
            this.lbldtemi.AutoSize = true;
            this.lbldtemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtemi.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbldtemi.Location = new System.Drawing.Point(561, 20);
            this.lbldtemi.Name = "lbldtemi";
            this.lbldtemi.Size = new System.Drawing.Size(75, 13);
            this.lbldtemi.TabIndex = 62;
            this.lbldtemi.Text = "Data Emissão:";
            // 
            // lbltipped
            // 
            this.lbltipped.AutoSize = true;
            this.lbltipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipped.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbltipped.Location = new System.Drawing.Point(455, 20);
            this.lbltipped.Name = "lbltipped";
            this.lbltipped.Size = new System.Drawing.Size(82, 13);
            this.lbltipped.TabIndex = 60;
            this.lbltipped.Text = "Tipo do Pedido:";
            // 
            // txtNomecli
            // 
            this.txtNomecli.Location = new System.Drawing.Point(233, 37);
            this.txtNomecli.Name = "txtNomecli";
            this.txtNomecli.Size = new System.Drawing.Size(219, 20);
            this.txtNomecli.TabIndex = 3;
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
            this.lblcodcli.Location = new System.Drawing.Point(117, 20);
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
            this.grpBxItPedVen.Size = new System.Drawing.Size(858, 394);
            this.grpBxItPedVen.TabIndex = 16;
            this.grpBxItPedVen.TabStop = false;
            this.grpBxItPedVen.Text = "Itens Pedido Venda";
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
            // txtBxDescontos
            // 
            this.txtBxDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDescontos.Location = new System.Drawing.Point(752, 74);
            this.txtBxDescontos.Name = "txtBxDescontos";
            this.txtBxDescontos.Size = new System.Drawing.Size(83, 20);
            this.txtBxDescontos.TabIndex = 21;
            // 
            // txtBxVlrBruto
            // 
            this.txtBxVlrBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxVlrBruto.Location = new System.Drawing.Point(752, 100);
            this.txtBxVlrBruto.Name = "txtBxVlrBruto";
            this.txtBxVlrBruto.Size = new System.Drawing.Size(83, 20);
            this.txtBxVlrBruto.TabIndex = 20;
            // 
            // txtBxVlrFrete
            // 
            this.txtBxVlrFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxVlrFrete.Location = new System.Drawing.Point(752, 48);
            this.txtBxVlrFrete.Name = "txtBxVlrFrete";
            this.txtBxVlrFrete.Size = new System.Drawing.Size(83, 20);
            this.txtBxVlrFrete.TabIndex = 19;
            // 
            // txtBxVlrMercadoria
            // 
            this.txtBxVlrMercadoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxVlrMercadoria.Location = new System.Drawing.Point(752, 19);
            this.txtBxVlrMercadoria.Name = "txtBxVlrMercadoria";
            this.txtBxVlrMercadoria.Size = new System.Drawing.Size(83, 20);
            this.txtBxVlrMercadoria.TabIndex = 18;
            // 
            // pnlItenped
            // 
            this.pnlItenped.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlItenped.Controls.Add(this.dtGrdVwItensNotFiscal);
            this.pnlItenped.Location = new System.Drawing.Point(10, 19);
            this.pnlItenped.Name = "pnlItenped";
            this.pnlItenped.Size = new System.Drawing.Size(841, 235);
            this.pnlItenped.TabIndex = 100;
            // 
            // dtGrdVwItensNotFiscal
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdVwItensNotFiscal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrdVwItensNotFiscal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwItensNotFiscal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFoiAlterado,
            this.clmProduto,
            this.Codprod,
            this.clmDescProd,
            this.clmUnidade,
            this.clmQuantidade,
            this.VlrDesconto,
            this.clmVlrUnitário,
            this.IPI,
            this.VlrUniIPI,
            this.VlrTotIPI,
            this.clmVlrTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrdVwItensNotFiscal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrdVwItensNotFiscal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrdVwItensNotFiscal.Location = new System.Drawing.Point(0, 0);
            this.dtGrdVwItensNotFiscal.Name = "dtGrdVwItensNotFiscal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdVwItensNotFiscal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGrdVwItensNotFiscal.Size = new System.Drawing.Size(841, 235);
            this.dtGrdVwItensNotFiscal.TabIndex = 1;
            // 
            // clmFoiAlterado
            // 
            this.clmFoiAlterado.HeaderText = "";
            this.clmFoiAlterado.Name = "clmFoiAlterado";
            this.clmFoiAlterado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmFoiAlterado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmFoiAlterado.Width = 50;
            // 
            // clmProduto
            // 
            this.clmProduto.HeaderText = "Item";
            this.clmProduto.Name = "clmProduto";
            // 
            // Codprod
            // 
            this.Codprod.HeaderText = "Código Produto";
            this.Codprod.Name = "Codprod";
            // 
            // clmDescProd
            // 
            this.clmDescProd.HeaderText = "Descrição  Produto";
            this.clmDescProd.Name = "clmDescProd";
            this.clmDescProd.Width = 120;
            // 
            // clmUnidade
            // 
            this.clmUnidade.HeaderText = "U.M";
            this.clmUnidade.Name = "clmUnidade";
            // 
            // clmQuantidade
            // 
            this.clmQuantidade.HeaderText = "Quantidade";
            this.clmQuantidade.Name = "clmQuantidade";
            // 
            // VlrDesconto
            // 
            this.VlrDesconto.HeaderText = "Vlr Desconto";
            this.VlrDesconto.Name = "VlrDesconto";
            // 
            // clmVlrUnitário
            // 
            this.clmVlrUnitário.HeaderText = "Preço Unitário";
            this.clmVlrUnitário.Name = "clmVlrUnitário";
            // 
            // IPI
            // 
            this.IPI.HeaderText = "%IPI";
            this.IPI.Name = "IPI";
            // 
            // VlrUniIPI
            // 
            this.VlrUniIPI.HeaderText = "Vlr Unit IPI";
            this.VlrUniIPI.Name = "VlrUniIPI";
            // 
            // VlrTotIPI
            // 
            this.VlrTotIPI.HeaderText = "Vlr Total IPI";
            this.VlrTotIPI.Name = "VlrTotIPI";
            // 
            // clmVlrTotal
            // 
            this.clmVlrTotal.HeaderText = "Preço Total";
            this.clmVlrTotal.Name = "clmVlrTotal";
            // 
            // txtNumPed
            // 
            this.txtNumPed.Image = global::Comercial.Properties.Resources.search1;
            this.txtNumPed.Location = new System.Drawing.Point(14, 36);
            this.txtNumPed.Name = "txtNumPed";
            this.txtNumPed.ShowButton = false;
            this.txtNumPed.Size = new System.Drawing.Size(100, 25);
            this.txtNumPed.TabIndex = 86;
            this.txtNumPed.ButtonClick += new System.EventHandler(this.txtNumPed_ButtonClick);
            // 
            // FrmLibPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 577);
            this.Controls.Add(this.tbCntrlPedVend);
            this.Name = "FrmLibPDV";
            this.Text = "FrmLibPDV";
            this.Leave += new System.EventHandler(this.FrmLibPDV_Leave);
            this.tbCntrlPedVend.ResumeLayout(false);
            this.tbPgPDV.ResumeLayout(false);
            this.grpBxPedVenda.ResumeLayout(false);
            this.grpBxPedVenda.PerformLayout();
            this.grpBxSitPed.ResumeLayout(false);
            this.grpBxSitPed.PerformLayout();
            this.grpBxItPedVen.ResumeLayout(false);
            this.grpBxTotais.ResumeLayout(false);
            this.grpBxTotais.PerformLayout();
            this.pnlItenped.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwItensNotFiscal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrlPedVend;
        private System.Windows.Forms.TabPage tbPgPDV;
        private System.Windows.Forms.GroupBox grpBxPedVenda;
        private System.Windows.Forms.Label lblTpFrete;
        private System.Windows.Forms.GroupBox grpBxSitPed;
        private System.Windows.Forms.RadioButton rdbcanc;
        private System.Windows.Forms.RadioButton rdbpend;
        private System.Windows.Forms.RadioButton rdbefet;
        private System.Windows.Forms.Label lbltpfre;
        private System.Windows.Forms.Label lblcondp;
        private System.Windows.Forms.TextBox txtNomeVend;
        private System.Windows.Forms.Label lblnomven;
        private System.Windows.Forms.Label lclcodven;
        private System.Windows.Forms.Label lbltpcli;
        private System.Windows.Forms.Label lbldtemi;
        private System.Windows.Forms.Label lbltipped;
        private System.Windows.Forms.TextBox txtNomecli;
        private System.Windows.Forms.Label lblnomecli;
        private System.Windows.Forms.Label lblcodcli;
        private System.Windows.Forms.Label lblnumPed;
        private System.Windows.Forms.GroupBox grpBxItPedVen;
        private System.Windows.Forms.Panel pnlItenped;
        private System.Windows.Forms.DataGridView dtGrdVwItensNotFiscal;
        private System.Windows.Forms.GroupBox grpBxTotais;
        private System.Windows.Forms.Label lblVlrBruto;
        private System.Windows.Forms.Label lblDescontos;
        private System.Windows.Forms.Label lblVlrFrete;
        private System.Windows.Forms.Label lblVlrMercadoria;
        private System.Windows.Forms.TextBox txtBxDescontos;
        private System.Windows.Forms.TextBox txtBxVlrBruto;
        private System.Windows.Forms.TextBox txtBxVlrFrete;
        private System.Windows.Forms.TextBox txtBxVlrMercadoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmFoiAlterado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlrDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVlrUnitário;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlrUniIPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlrTotIPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVlrTotal;
        private System.Windows.Forms.TextBox txtTrans;
        private System.Windows.Forms.TextBox txtCondPgto;
        private System.Windows.Forms.TextBox txtCodVen;
        private System.Windows.Forms.TextBox txtTpFrete;
        private System.Windows.Forms.TextBox txtTpClien;
        private System.Windows.Forms.TextBox txtDtEmi;
        private System.Windows.Forms.TextBox txtTpPed;
        private System.Windows.Forms.TextBox txtCodCli;
        private TextButton txtNumPed;

    }
}