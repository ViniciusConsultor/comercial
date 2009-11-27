namespace Comercial
    {
    partial class FrmEmiNotFis
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
                this.TbPgNotFis = new System.Windows.Forms.TabPage();
                this.GrpBxDest = new System.Windows.Forms.GroupBox();
                this.TxtTelCli = new System.Windows.Forms.MaskedTextBox();
                this.LblTelCli = new System.Windows.Forms.Label();
                this.TxtMunCli = new System.Windows.Forms.TextBox();
                this.LblMunCli = new System.Windows.Forms.Label();
                this.TxtBaiCli = new System.Windows.Forms.TextBox();
                this.LblBaiCli = new System.Windows.Forms.Label();
                this.TxtEndCli = new System.Windows.Forms.TextBox();
                this.LblEndCli = new System.Windows.Forms.Label();
                this.TxtIeCli = new System.Windows.Forms.MaskedTextBox();
                this.TxtCnpCli = new System.Windows.Forms.MaskedTextBox();
                this.LblIECli = new System.Windows.Forms.Label();
                this.LblCnpCli = new System.Windows.Forms.Label();
                this.TxtNomCli = new System.Windows.Forms.TextBox();
                this.LblNomCli = new System.Windows.Forms.Label();
                this.GrpBxTot = new System.Windows.Forms.GroupBox();
                this.LblVlrBru = new System.Windows.Forms.Label();
                this.LblDes = new System.Windows.Forms.Label();
                this.TxtBxDes = new System.Windows.Forms.TextBox();
                this.TxtBxVlrBru = new System.Windows.Forms.TextBox();
                this.LblVlrFre = new System.Windows.Forms.Label();
                this.LblVlrMer = new System.Windows.Forms.Label();
                this.TxtVlrFre = new System.Windows.Forms.TextBox();
                this.TxtVlrMer = new System.Windows.Forms.TextBox();
                this.GrpBxItens = new System.Windows.Forms.GroupBox();
                this.dtGrdVwItensNF = new System.Windows.Forms.DataGridView();
                this.GrpBxInfNotFis = new System.Windows.Forms.GroupBox();
                this.LlblNumNotFis = new System.Windows.Forms.Label();
                this.LblUfOrigem = new System.Windows.Forms.Label();
                this.LblDtEmissao = new System.Windows.Forms.Label();
                this.TxtSerie = new System.Windows.Forms.TextBox();
                this.CmbBxUf = new System.Windows.Forms.ComboBox();
                this.LblSerie = new System.Windows.Forms.Label();
                this.CmbBxFornecedor = new System.Windows.Forms.ComboBox();
                this.DtTmPckrDtEmissao = new System.Windows.Forms.DateTimePicker();
                this.LblForncedor = new System.Windows.Forms.Label();
                this.TbCntEmiNF = new System.Windows.Forms.TabControl();
                this.clmProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.clmDescProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.clmUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.clmQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.clmVlrUnitário = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.clmVlrTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.txtNumNF = new Comercial.TextButton();
                this.TbPgNotFis.SuspendLayout();
                this.GrpBxDest.SuspendLayout();
                this.GrpBxTot.SuspendLayout();
                this.GrpBxItens.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwItensNF)).BeginInit();
                this.GrpBxInfNotFis.SuspendLayout();
                this.TbCntEmiNF.SuspendLayout();
                this.SuspendLayout();
                // 
                // TbPgNotFis
                // 
                this.TbPgNotFis.Controls.Add(this.GrpBxDest);
                this.TbPgNotFis.Controls.Add(this.GrpBxTot);
                this.TbPgNotFis.Controls.Add(this.GrpBxItens);
                this.TbPgNotFis.Controls.Add(this.GrpBxInfNotFis);
                this.TbPgNotFis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TbPgNotFis.Location = new System.Drawing.Point(4, 22);
                this.TbPgNotFis.Name = "TbPgNotFis";
                this.TbPgNotFis.Padding = new System.Windows.Forms.Padding(3);
                this.TbPgNotFis.Size = new System.Drawing.Size(797, 473);
                this.TbPgNotFis.TabIndex = 0;
                this.TbPgNotFis.Text = "Emissão Nota Fiscal";
                this.TbPgNotFis.UseVisualStyleBackColor = true;
                // 
                // GrpBxDest
                // 
                this.GrpBxDest.Controls.Add(this.TxtTelCli);
                this.GrpBxDest.Controls.Add(this.LblTelCli);
                this.GrpBxDest.Controls.Add(this.TxtMunCli);
                this.GrpBxDest.Controls.Add(this.LblMunCli);
                this.GrpBxDest.Controls.Add(this.TxtBaiCli);
                this.GrpBxDest.Controls.Add(this.LblBaiCli);
                this.GrpBxDest.Controls.Add(this.TxtEndCli);
                this.GrpBxDest.Controls.Add(this.LblEndCli);
                this.GrpBxDest.Controls.Add(this.TxtIeCli);
                this.GrpBxDest.Controls.Add(this.TxtCnpCli);
                this.GrpBxDest.Controls.Add(this.LblIECli);
                this.GrpBxDest.Controls.Add(this.LblCnpCli);
                this.GrpBxDest.Controls.Add(this.TxtNomCli);
                this.GrpBxDest.Controls.Add(this.LblNomCli);
                this.GrpBxDest.ForeColor = System.Drawing.Color.CornflowerBlue;
                this.GrpBxDest.Location = new System.Drawing.Point(4, 77);
                this.GrpBxDest.Name = "GrpBxDest";
                this.GrpBxDest.Size = new System.Drawing.Size(756, 123);
                this.GrpBxDest.TabIndex = 4;
                this.GrpBxDest.TabStop = false;
                this.GrpBxDest.Text = "Destinatário ";
                this.GrpBxDest.Enter += new System.EventHandler(this.groupBox1_Enter_1);
                // 
                // TxtTelCli
                // 
                this.TxtTelCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TxtTelCli.Location = new System.Drawing.Point(572, 32);
                this.TxtTelCli.Mask = "(99) 9999-9999";
                this.TxtTelCli.Name = "TxtTelCli";
                this.TxtTelCli.PromptChar = ' ';
                this.TxtTelCli.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.TxtTelCli.Size = new System.Drawing.Size(89, 20);
                this.TxtTelCli.TabIndex = 70;
                this.TxtTelCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // LblTelCli
                // 
                this.LblTelCli.AutoSize = true;
                this.LblTelCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblTelCli.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblTelCli.Location = new System.Drawing.Point(569, 16);
                this.LblTelCli.Name = "LblTelCli";
                this.LblTelCli.Size = new System.Drawing.Size(49, 13);
                this.LblTelCli.TabIndex = 71;
                this.LblTelCli.Text = "Telefone";
                // 
                // TxtMunCli
                // 
                this.TxtMunCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
                this.TxtMunCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TxtMunCli.Location = new System.Drawing.Point(572, 71);
                this.TxtMunCli.Name = "TxtMunCli";
                this.TxtMunCli.Size = new System.Drawing.Size(160, 20);
                this.TxtMunCli.TabIndex = 68;
                // 
                // LblMunCli
                // 
                this.LblMunCli.AutoSize = true;
                this.LblMunCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblMunCli.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblMunCli.Location = new System.Drawing.Point(569, 56);
                this.LblMunCli.Name = "LblMunCli";
                this.LblMunCli.Size = new System.Drawing.Size(52, 13);
                this.LblMunCli.TabIndex = 69;
                this.LblMunCli.Text = "Municípo";
                // 
                // TxtBaiCli
                // 
                this.TxtBaiCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
                this.TxtBaiCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TxtBaiCli.Location = new System.Drawing.Point(386, 72);
                this.TxtBaiCli.Name = "TxtBaiCli";
                this.TxtBaiCli.Size = new System.Drawing.Size(158, 20);
                this.TxtBaiCli.TabIndex = 66;
                // 
                // LblBaiCli
                // 
                this.LblBaiCli.AutoSize = true;
                this.LblBaiCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblBaiCli.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblBaiCli.Location = new System.Drawing.Point(383, 56);
                this.LblBaiCli.Name = "LblBaiCli";
                this.LblBaiCli.Size = new System.Drawing.Size(34, 13);
                this.LblBaiCli.TabIndex = 67;
                this.LblBaiCli.Text = "Bairro";
                // 
                // TxtEndCli
                // 
                this.TxtEndCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
                this.TxtEndCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TxtEndCli.Location = new System.Drawing.Point(20, 72);
                this.TxtEndCli.Name = "TxtEndCli";
                this.TxtEndCli.Size = new System.Drawing.Size(355, 20);
                this.TxtEndCli.TabIndex = 64;
                // 
                // LblEndCli
                // 
                this.LblEndCli.AutoSize = true;
                this.LblEndCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblEndCli.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblEndCli.Location = new System.Drawing.Point(20, 56);
                this.LblEndCli.Name = "LblEndCli";
                this.LblEndCli.Size = new System.Drawing.Size(61, 13);
                this.LblEndCli.TabIndex = 65;
                this.LblEndCli.Text = "Endereço";
                // 
                // TxtIeCli
                // 
                this.TxtIeCli.Location = new System.Drawing.Point(385, 32);
                this.TxtIeCli.Mask = "999,999,999,999";
                this.TxtIeCli.Name = "TxtIeCli";
                this.TxtIeCli.PromptChar = ' ';
                this.TxtIeCli.Size = new System.Drawing.Size(179, 20);
                this.TxtIeCli.TabIndex = 63;
                // 
                // TxtCnpCli
                // 
                this.TxtCnpCli.Location = new System.Drawing.Point(252, 32);
                this.TxtCnpCli.Mask = "99,999,999/9999-99";
                this.TxtCnpCli.Name = "TxtCnpCli";
                this.TxtCnpCli.PromptChar = ' ';
                this.TxtCnpCli.Size = new System.Drawing.Size(123, 20);
                this.TxtCnpCli.TabIndex = 62;
                // 
                // LblIECli
                // 
                this.LblIECli.AutoSize = true;
                this.LblIECli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblIECli.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblIECli.Location = new System.Drawing.Point(383, 16);
                this.LblIECli.Name = "LblIECli";
                this.LblIECli.Size = new System.Drawing.Size(20, 13);
                this.LblIECli.TabIndex = 61;
                this.LblIECli.Text = "I.E";
                // 
                // LblCnpCli
                // 
                this.LblCnpCli.AutoSize = true;
                this.LblCnpCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblCnpCli.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblCnpCli.Location = new System.Drawing.Point(255, 16);
                this.LblCnpCli.Name = "LblCnpCli";
                this.LblCnpCli.Size = new System.Drawing.Size(34, 13);
                this.LblCnpCli.TabIndex = 60;
                this.LblCnpCli.Text = "CNPJ";
                // 
                // TxtNomCli
                // 
                this.TxtNomCli.Location = new System.Drawing.Point(23, 33);
                this.TxtNomCli.Name = "TxtNomCli";
                this.TxtNomCli.Size = new System.Drawing.Size(219, 20);
                this.TxtNomCli.TabIndex = 58;
                // 
                // LblNomCli
                // 
                this.LblNomCli.AutoSize = true;
                this.LblNomCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblNomCli.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblNomCli.Location = new System.Drawing.Point(20, 16);
                this.LblNomCli.Name = "LblNomCli";
                this.LblNomCli.Size = new System.Drawing.Size(147, 13);
                this.LblNomCli.TabIndex = 59;
                this.LblNomCli.Text = "Nome / Razão Social Cliente:";
                // 
                // GrpBxTot
                // 
                this.GrpBxTot.Controls.Add(this.LblVlrBru);
                this.GrpBxTot.Controls.Add(this.LblDes);
                this.GrpBxTot.Controls.Add(this.TxtBxDes);
                this.GrpBxTot.Controls.Add(this.TxtBxVlrBru);
                this.GrpBxTot.Controls.Add(this.LblVlrFre);
                this.GrpBxTot.Controls.Add(this.LblVlrMer);
                this.GrpBxTot.Controls.Add(this.TxtVlrFre);
                this.GrpBxTot.Controls.Add(this.TxtVlrMer);
                this.GrpBxTot.ForeColor = System.Drawing.Color.CornflowerBlue;
                this.GrpBxTot.Location = new System.Drawing.Point(15, 343);
                this.GrpBxTot.Name = "GrpBxTot";
                this.GrpBxTot.Size = new System.Drawing.Size(748, 88);
                this.GrpBxTot.TabIndex = 2;
                this.GrpBxTot.TabStop = false;
                this.GrpBxTot.Text = "Totais";
                // 
                // LblVlrBru
                // 
                this.LblVlrBru.AutoSize = true;
                this.LblVlrBru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblVlrBru.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblVlrBru.Location = new System.Drawing.Point(252, 48);
                this.LblVlrBru.Name = "LblVlrBru";
                this.LblVlrBru.Size = new System.Drawing.Size(53, 13);
                this.LblVlrBru.TabIndex = 31;
                this.LblVlrBru.Text = "Vlr. Bruto:";
                // 
                // LblDes
                // 
                this.LblDes.AutoSize = true;
                this.LblDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblDes.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblDes.Location = new System.Drawing.Point(244, 22);
                this.LblDes.Name = "LblDes";
                this.LblDes.Size = new System.Drawing.Size(61, 13);
                this.LblDes.TabIndex = 30;
                this.LblDes.Text = "Descontos:";
                // 
                // TxtBxDes
                // 
                this.TxtBxDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TxtBxDes.Location = new System.Drawing.Point(311, 22);
                this.TxtBxDes.Name = "TxtBxDes";
                this.TxtBxDes.Size = new System.Drawing.Size(83, 20);
                this.TxtBxDes.TabIndex = 29;
                // 
                // TxtBxVlrBru
                // 
                this.TxtBxVlrBru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TxtBxVlrBru.Location = new System.Drawing.Point(311, 51);
                this.TxtBxVlrBru.Name = "TxtBxVlrBru";
                this.TxtBxVlrBru.Size = new System.Drawing.Size(83, 20);
                this.TxtBxVlrBru.TabIndex = 28;
                // 
                // LblVlrFre
                // 
                this.LblVlrFre.AutoSize = true;
                this.LblVlrFre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblVlrFre.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblVlrFre.Location = new System.Drawing.Point(39, 51);
                this.LblVlrFre.Name = "LblVlrFre";
                this.LblVlrFre.Size = new System.Drawing.Size(52, 13);
                this.LblVlrFre.TabIndex = 27;
                this.LblVlrFre.Text = "Vlr. Frete:";
                // 
                // LblVlrMer
                // 
                this.LblVlrMer.AutoSize = true;
                this.LblVlrMer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblVlrMer.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblVlrMer.Location = new System.Drawing.Point(13, 22);
                this.LblVlrMer.Name = "LblVlrMer";
                this.LblVlrMer.Size = new System.Drawing.Size(81, 13);
                this.LblVlrMer.TabIndex = 26;
                this.LblVlrMer.Text = "Vlr. Mercadoria:";
                // 
                // TxtVlrFre
                // 
                this.TxtVlrFre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TxtVlrFre.Location = new System.Drawing.Point(100, 48);
                this.TxtVlrFre.Name = "TxtVlrFre";
                this.TxtVlrFre.Size = new System.Drawing.Size(83, 20);
                this.TxtVlrFre.TabIndex = 25;
                // 
                // TxtVlrMer
                // 
                this.TxtVlrMer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TxtVlrMer.Location = new System.Drawing.Point(100, 19);
                this.TxtVlrMer.Name = "TxtVlrMer";
                this.TxtVlrMer.Size = new System.Drawing.Size(83, 20);
                this.TxtVlrMer.TabIndex = 24;
                // 
                // GrpBxItens
                // 
                this.GrpBxItens.Controls.Add(this.dtGrdVwItensNF);
                this.GrpBxItens.ForeColor = System.Drawing.Color.CornflowerBlue;
                this.GrpBxItens.Location = new System.Drawing.Point(9, 206);
                this.GrpBxItens.Name = "GrpBxItens";
                this.GrpBxItens.Size = new System.Drawing.Size(754, 131);
                this.GrpBxItens.TabIndex = 1;
                this.GrpBxItens.TabStop = false;
                this.GrpBxItens.Text = "Itens Nota Fiscal";
                // 
                // dtGrdVwItensNF
                // 
                this.dtGrdVwItensNF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dtGrdVwItensNF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProduto,
            this.clmDescProd,
            this.clmUnidade,
            this.clmQuantidade,
            this.clmVlrUnitário,
            this.clmVlrTotal});
                this.dtGrdVwItensNF.Dock = System.Windows.Forms.DockStyle.Fill;
                this.dtGrdVwItensNF.Location = new System.Drawing.Point(3, 16);
                this.dtGrdVwItensNF.Name = "dtGrdVwItensNF";
                this.dtGrdVwItensNF.Size = new System.Drawing.Size(748, 112);
                this.dtGrdVwItensNF.TabIndex = 1;
                // 
                // GrpBxInfNotFis
                // 
                this.GrpBxInfNotFis.Controls.Add(this.txtNumNF);
                this.GrpBxInfNotFis.Controls.Add(this.LlblNumNotFis);
                this.GrpBxInfNotFis.Controls.Add(this.LblUfOrigem);
                this.GrpBxInfNotFis.Controls.Add(this.LblDtEmissao);
                this.GrpBxInfNotFis.Controls.Add(this.TxtSerie);
                this.GrpBxInfNotFis.Controls.Add(this.CmbBxUf);
                this.GrpBxInfNotFis.Controls.Add(this.LblSerie);
                this.GrpBxInfNotFis.Controls.Add(this.CmbBxFornecedor);
                this.GrpBxInfNotFis.Controls.Add(this.DtTmPckrDtEmissao);
                this.GrpBxInfNotFis.Controls.Add(this.LblForncedor);
                this.GrpBxInfNotFis.ForeColor = System.Drawing.Color.CornflowerBlue;
                this.GrpBxInfNotFis.Location = new System.Drawing.Point(3, 6);
                this.GrpBxInfNotFis.Name = "GrpBxInfNotFis";
                this.GrpBxInfNotFis.Size = new System.Drawing.Size(757, 65);
                this.GrpBxInfNotFis.TabIndex = 0;
                this.GrpBxInfNotFis.TabStop = false;
                this.GrpBxInfNotFis.Text = "Informações Nota Fiscal";
                this.GrpBxInfNotFis.Enter += new System.EventHandler(this.groupBox1_Enter);
                // 
                // LlblNumNotFis
                // 
                this.LlblNumNotFis.AutoSize = true;
                this.LlblNumNotFis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LlblNumNotFis.ForeColor = System.Drawing.Color.CadetBlue;
                this.LlblNumNotFis.Location = new System.Drawing.Point(21, 16);
                this.LlblNumNotFis.Name = "LlblNumNotFis";
                this.LlblNumNotFis.Size = new System.Drawing.Size(79, 13);
                this.LlblNumNotFis.TabIndex = 24;
                this.LlblNumNotFis.Text = "Número da NF:";
                this.LlblNumNotFis.Click += new System.EventHandler(this.lblNumNotFiscal_Click);
                // 
                // LblUfOrigem
                // 
                this.LblUfOrigem.AutoSize = true;
                this.LblUfOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblUfOrigem.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblUfOrigem.Location = new System.Drawing.Point(612, 16);
                this.LblUfOrigem.Name = "LblUfOrigem";
                this.LblUfOrigem.Size = new System.Drawing.Size(60, 13);
                this.LblUfOrigem.TabIndex = 23;
                this.LblUfOrigem.Text = "UF Origem:";
                // 
                // LblDtEmissao
                // 
                this.LblDtEmissao.AutoSize = true;
                this.LblDtEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblDtEmissao.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblDtEmissao.Location = new System.Drawing.Point(348, 16);
                this.LblDtEmissao.Name = "LblDtEmissao";
                this.LblDtEmissao.Size = new System.Drawing.Size(66, 13);
                this.LblDtEmissao.TabIndex = 21;
                this.LblDtEmissao.Text = "Dt. Emissão:";
                // 
                // TxtSerie
                // 
                this.TxtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TxtSerie.Location = new System.Drawing.Point(283, 33);
                this.TxtSerie.Name = "TxtSerie";
                this.TxtSerie.Size = new System.Drawing.Size(56, 20);
                this.TxtSerie.TabIndex = 20;
                // 
                // CmbBxUf
                // 
                this.CmbBxUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.CmbBxUf.FormattingEnabled = true;
                this.CmbBxUf.Location = new System.Drawing.Point(610, 31);
                this.CmbBxUf.Name = "CmbBxUf";
                this.CmbBxUf.Size = new System.Drawing.Size(56, 21);
                this.CmbBxUf.TabIndex = 27;
                // 
                // LblSerie
                // 
                this.LblSerie.AutoSize = true;
                this.LblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblSerie.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblSerie.Location = new System.Drawing.Point(280, 16);
                this.LblSerie.Name = "LblSerie";
                this.LblSerie.Size = new System.Drawing.Size(34, 13);
                this.LblSerie.TabIndex = 19;
                this.LblSerie.Text = "Série:";
                // 
                // CmbBxFornecedor
                // 
                this.CmbBxFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.CmbBxFornecedor.FormattingEnabled = true;
                this.CmbBxFornecedor.Location = new System.Drawing.Point(474, 32);
                this.CmbBxFornecedor.Name = "CmbBxFornecedor";
                this.CmbBxFornecedor.Size = new System.Drawing.Size(121, 21);
                this.CmbBxFornecedor.TabIndex = 26;
                // 
                // DtTmPckrDtEmissao
                // 
                this.DtTmPckrDtEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.DtTmPckrDtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                this.DtTmPckrDtEmissao.Location = new System.Drawing.Point(351, 32);
                this.DtTmPckrDtEmissao.Name = "DtTmPckrDtEmissao";
                this.DtTmPckrDtEmissao.Size = new System.Drawing.Size(107, 20);
                this.DtTmPckrDtEmissao.TabIndex = 25;
                // 
                // LblForncedor
                // 
                this.LblForncedor.AutoSize = true;
                this.LblForncedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblForncedor.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblForncedor.Location = new System.Drawing.Point(471, 16);
                this.LblForncedor.Name = "LblForncedor";
                this.LblForncedor.Size = new System.Drawing.Size(64, 13);
                this.LblForncedor.TabIndex = 18;
                this.LblForncedor.Text = "Fornecedor:";
                // 
                // TbCntEmiNF
                // 
                this.TbCntEmiNF.Controls.Add(this.TbPgNotFis);
                this.TbCntEmiNF.Location = new System.Drawing.Point(0, 1);
                this.TbCntEmiNF.Name = "TbCntEmiNF";
                this.TbCntEmiNF.SelectedIndex = 0;
                this.TbCntEmiNF.Size = new System.Drawing.Size(805, 499);
                this.TbCntEmiNF.TabIndex = 0;
                // 
                // clmProduto
                // 
                this.clmProduto.HeaderText = "Produto";
                this.clmProduto.Name = "clmProduto";
                // 
                // clmDescProd
                // 
                this.clmDescProd.HeaderText = "Desc. Produto";
                this.clmDescProd.Name = "clmDescProd";
                // 
                // clmUnidade
                // 
                this.clmUnidade.HeaderText = "Unidade";
                this.clmUnidade.Name = "clmUnidade";
                // 
                // clmQuantidade
                // 
                this.clmQuantidade.HeaderText = "Quantidade";
                this.clmQuantidade.Name = "clmQuantidade";
                // 
                // clmVlrUnitário
                // 
                this.clmVlrUnitário.HeaderText = "Vlr. Unitário";
                this.clmVlrUnitário.Name = "clmVlrUnitário";
                // 
                // clmVlrTotal
                // 
                this.clmVlrTotal.HeaderText = "Vlr. Total";
                this.clmVlrTotal.Name = "clmVlrTotal";
                // 
                // txtNumNF
                // 
                this.txtNumNF.getText = "";
                this.txtNumNF.Image = global::Comercial.Properties.Resources.search1;
                this.txtNumNF.Location = new System.Drawing.Point(24, 31);
                this.txtNumNF.Name = "txtNumNF";
                this.txtNumNF.ShowButton = false;
                this.txtNumNF.Size = new System.Drawing.Size(245, 25);
                this.txtNumNF.TabIndex = 28;
                this.txtNumNF.ButtonClick += new System.EventHandler(this.txtNumNF_ButtonClick);
                // 
                // FrmEmiNotFis
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.WhiteSmoke;
                this.ClientSize = new System.Drawing.Size(803, 495);
                this.ControlBox = false;
                this.Controls.Add(this.TbCntEmiNF);
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "FrmEmiNotFis";
                this.Text = "Emissão Nota Fiscal";
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                this.Leave += new System.EventHandler(this.FrmEmiNotFis_Leave);
                this.TbPgNotFis.ResumeLayout(false);
                this.GrpBxDest.ResumeLayout(false);
                this.GrpBxDest.PerformLayout();
                this.GrpBxTot.ResumeLayout(false);
                this.GrpBxTot.PerformLayout();
                this.GrpBxItens.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwItensNF)).EndInit();
                this.GrpBxInfNotFis.ResumeLayout(false);
                this.GrpBxInfNotFis.PerformLayout();
                this.TbCntEmiNF.ResumeLayout(false);
                this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.TabPage TbPgNotFis;
        private System.Windows.Forms.TabControl TbCntEmiNF;
        private System.Windows.Forms.GroupBox GrpBxInfNotFis;
        private System.Windows.Forms.Label LlblNumNotFis;
        private System.Windows.Forms.Label LblUfOrigem;
        private System.Windows.Forms.Label LblDtEmissao;
        private System.Windows.Forms.TextBox TxtSerie;
        private System.Windows.Forms.ComboBox CmbBxUf;
        private System.Windows.Forms.Label LblSerie;
        private System.Windows.Forms.ComboBox CmbBxFornecedor;
        private System.Windows.Forms.DateTimePicker DtTmPckrDtEmissao;
        private System.Windows.Forms.Label LblForncedor;
        private System.Windows.Forms.GroupBox GrpBxItens;
        private System.Windows.Forms.DataGridView dtGrdVwItensNF;
        private System.Windows.Forms.GroupBox GrpBxTot;
        private System.Windows.Forms.Label LblVlrFre;
        private System.Windows.Forms.Label LblVlrMer;
        private System.Windows.Forms.TextBox TxtVlrFre;
        private System.Windows.Forms.TextBox TxtVlrMer;
        private System.Windows.Forms.Label LblVlrBru;
        private System.Windows.Forms.Label LblDes;
        private System.Windows.Forms.TextBox TxtBxDes;
        private System.Windows.Forms.TextBox TxtBxVlrBru;
        private System.Windows.Forms.GroupBox GrpBxDest;
        private System.Windows.Forms.TextBox TxtNomCli;
        private System.Windows.Forms.Label LblNomCli;
        private System.Windows.Forms.MaskedTextBox TxtIeCli;
        private System.Windows.Forms.MaskedTextBox TxtCnpCli;
        private System.Windows.Forms.Label LblIECli;
        private System.Windows.Forms.Label LblCnpCli;
        private System.Windows.Forms.TextBox TxtEndCli;
        private System.Windows.Forms.Label LblEndCli;
        private System.Windows.Forms.TextBox TxtBaiCli;
        private System.Windows.Forms.Label LblBaiCli;
        private System.Windows.Forms.TextBox TxtMunCli;
        private System.Windows.Forms.Label LblMunCli;
        private System.Windows.Forms.MaskedTextBox TxtTelCli;
        private System.Windows.Forms.Label LblTelCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVlrUnitário;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVlrTotal;
        public TextButton txtNumNF;
        }
    }