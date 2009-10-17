namespace Comercial
{
    partial class frmConCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConCli));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbCntrlConCli = new System.Windows.Forms.TabControl();
            this.tbPgConCli = new System.Windows.Forms.TabPage();
            this.grpBxFiltro = new System.Windows.Forms.GroupBox();
            this.grpBxPedido = new System.Windows.Forms.GroupBox();
            this.txtNumPed = new System.Windows.Forms.TextBox();
            this.dttmDataPedido = new System.Windows.Forms.DateTimePicker();
            this.lblDataPed = new System.Windows.Forms.Label();
            this.lblNumPed = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtnCancelado = new System.Windows.Forms.RadioButton();
            this.rdbtnPendente = new System.Windows.Forms.RadioButton();
            this.rdbtnEfetivado = new System.Windows.Forms.RadioButton();
            this.cmBxTipoPed = new System.Windows.Forms.ComboBox();
            this.lblTipoPed = new System.Windows.Forms.Label();
            this.grpBxCli = new System.Windows.Forms.GroupBox();
            this.txtCnpjCli = new Comercial.TextButton();
            this.cmbAreaAtuCli = new System.Windows.Forms.ComboBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtRazaoSocialCli = new System.Windows.Forms.TextBox();
            this.lblRazao = new System.Windows.Forms.Label();
            this.txtNomeFantasiaCli = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dtgrdConCli = new System.Windows.Forms.DataGridView();
            this.CNPJCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFantasiaCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnCodPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDtPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnValPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new Comercial.COMERCIALDataSetTableAdapters.CLIENTETableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbCntrlConCli.SuspendLayout();
            this.tbPgConCli.SuspendLayout();
            this.grpBxFiltro.SuspendLayout();
            this.grpBxPedido.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpBxCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdConCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrlConCli
            // 
            this.tbCntrlConCli.Controls.Add(this.tbPgConCli);
            this.tbCntrlConCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlConCli.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlConCli.Name = "tbCntrlConCli";
            this.tbCntrlConCli.SelectedIndex = 0;
            this.tbCntrlConCli.Size = new System.Drawing.Size(906, 488);
            this.tbCntrlConCli.TabIndex = 0;
            // 
            // tbPgConCli
            // 
            this.tbPgConCli.Controls.Add(this.grpBxFiltro);
            this.tbPgConCli.Controls.Add(this.dtgrdConCli);
            this.tbPgConCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPgConCli.ForeColor = System.Drawing.Color.CadetBlue;
            this.tbPgConCli.Location = new System.Drawing.Point(4, 22);
            this.tbPgConCli.Name = "tbPgConCli";
            this.tbPgConCli.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgConCli.Size = new System.Drawing.Size(898, 462);
            this.tbPgConCli.TabIndex = 0;
            this.tbPgConCli.Text = "Consulta de Clientes - Cliente/Pedido";
            this.tbPgConCli.UseVisualStyleBackColor = true;
            // 
            // grpBxFiltro
            // 
            this.grpBxFiltro.Controls.Add(this.grpBxPedido);
            this.grpBxFiltro.Controls.Add(this.grpBxCli);
            this.grpBxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxFiltro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxFiltro.Location = new System.Drawing.Point(6, 6);
            this.grpBxFiltro.Name = "grpBxFiltro";
            this.grpBxFiltro.Size = new System.Drawing.Size(886, 197);
            this.grpBxFiltro.TabIndex = 1;
            this.grpBxFiltro.TabStop = false;
            this.grpBxFiltro.Text = "Filtros:";
            // 
            // grpBxPedido
            // 
            this.grpBxPedido.Controls.Add(this.txtNumPed);
            this.grpBxPedido.Controls.Add(this.dttmDataPedido);
            this.grpBxPedido.Controls.Add(this.lblDataPed);
            this.grpBxPedido.Controls.Add(this.lblNumPed);
            this.grpBxPedido.Controls.Add(this.groupBox2);
            this.grpBxPedido.Controls.Add(this.cmBxTipoPed);
            this.grpBxPedido.Controls.Add(this.lblTipoPed);
            this.grpBxPedido.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxPedido.Location = new System.Drawing.Point(6, 19);
            this.grpBxPedido.Name = "grpBxPedido";
            this.grpBxPedido.Size = new System.Drawing.Size(340, 162);
            this.grpBxPedido.TabIndex = 8;
            this.grpBxPedido.TabStop = false;
            this.grpBxPedido.Text = "Dados Pedido";
            // 
            // txtNumPed
            // 
            this.txtNumPed.Location = new System.Drawing.Point(12, 36);
            this.txtNumPed.Name = "txtNumPed";
            this.txtNumPed.Size = new System.Drawing.Size(80, 20);
            this.txtNumPed.TabIndex = 22;
            // 
            // dttmDataPedido
            // 
            this.dttmDataPedido.Checked = false;
            this.dttmDataPedido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttmDataPedido.Location = new System.Drawing.Point(12, 132);
            this.dttmDataPedido.Name = "dttmDataPedido";
            this.dttmDataPedido.ShowCheckBox = true;
            this.dttmDataPedido.Size = new System.Drawing.Size(115, 20);
            this.dttmDataPedido.TabIndex = 21;
            // 
            // lblDataPed
            // 
            this.lblDataPed.AutoSize = true;
            this.lblDataPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPed.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDataPed.Location = new System.Drawing.Point(9, 116);
            this.lblDataPed.Name = "lblDataPed";
            this.lblDataPed.Size = new System.Drawing.Size(83, 13);
            this.lblDataPed.TabIndex = 20;
            this.lblDataPed.Text = "Data do pedido:";
            // 
            // lblNumPed
            // 
            this.lblNumPed.AutoSize = true;
            this.lblNumPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPed.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNumPed.Location = new System.Drawing.Point(9, 19);
            this.lblNumPed.Name = "lblNumPed";
            this.lblNumPed.Size = new System.Drawing.Size(47, 13);
            this.lblNumPed.TabIndex = 16;
            this.lblNumPed.Text = "Número:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.rdbtnCancelado);
            this.groupBox2.Controls.Add(this.rdbtnPendente);
            this.groupBox2.Controls.Add(this.rdbtnEfetivado);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.Location = new System.Drawing.Point(9, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 42);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Situação do Pedido:";
            // 
            // rdbtnCancelado
            // 
            this.rdbtnCancelado.AutoSize = true;
            this.rdbtnCancelado.Location = new System.Drawing.Point(173, 19);
            this.rdbtnCancelado.Name = "rdbtnCancelado";
            this.rdbtnCancelado.Size = new System.Drawing.Size(76, 17);
            this.rdbtnCancelado.TabIndex = 2;
            this.rdbtnCancelado.TabStop = true;
            this.rdbtnCancelado.Text = "Cancelado";
            this.rdbtnCancelado.UseVisualStyleBackColor = true;
            this.rdbtnCancelado.CheckedChanged += new System.EventHandler(this.rdbtnCancelado_CheckedChanged);
            // 
            // rdbtnPendente
            // 
            this.rdbtnPendente.AutoSize = true;
            this.rdbtnPendente.Location = new System.Drawing.Point(96, 19);
            this.rdbtnPendente.Name = "rdbtnPendente";
            this.rdbtnPendente.Size = new System.Drawing.Size(71, 17);
            this.rdbtnPendente.TabIndex = 1;
            this.rdbtnPendente.TabStop = true;
            this.rdbtnPendente.Text = "Pendente";
            this.rdbtnPendente.UseVisualStyleBackColor = true;
            this.rdbtnPendente.CheckedChanged += new System.EventHandler(this.rdbtnPendente_CheckedChanged);
            // 
            // rdbtnEfetivado
            // 
            this.rdbtnEfetivado.AutoSize = true;
            this.rdbtnEfetivado.Location = new System.Drawing.Point(13, 19);
            this.rdbtnEfetivado.Name = "rdbtnEfetivado";
            this.rdbtnEfetivado.Size = new System.Drawing.Size(70, 17);
            this.rdbtnEfetivado.TabIndex = 0;
            this.rdbtnEfetivado.TabStop = true;
            this.rdbtnEfetivado.Text = "Efetivado";
            this.rdbtnEfetivado.UseVisualStyleBackColor = true;
            this.rdbtnEfetivado.CheckedChanged += new System.EventHandler(this.rdbtnEfetivado_CheckedChanged);
            // 
            // cmBxTipoPed
            // 
            this.cmBxTipoPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBxTipoPed.FormattingEnabled = true;
            this.cmBxTipoPed.Items.AddRange(new object[] {
            "",
            "N = Normal",
            "C = Complemento de preço"});
            this.cmBxTipoPed.Location = new System.Drawing.Point(105, 36);
            this.cmBxTipoPed.Name = "cmBxTipoPed";
            this.cmBxTipoPed.Size = new System.Drawing.Size(173, 21);
            this.cmBxTipoPed.TabIndex = 12;
            // 
            // lblTipoPed
            // 
            this.lblTipoPed.AutoSize = true;
            this.lblTipoPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPed.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTipoPed.Location = new System.Drawing.Point(102, 19);
            this.lblTipoPed.Name = "lblTipoPed";
            this.lblTipoPed.Size = new System.Drawing.Size(81, 13);
            this.lblTipoPed.TabIndex = 7;
            this.lblTipoPed.Text = "Tipo do pedido:";
            // 
            // grpBxCli
            // 
            this.grpBxCli.Controls.Add(this.txtCnpjCli);
            this.grpBxCli.Controls.Add(this.cmbAreaAtuCli);
            this.grpBxCli.Controls.Add(this.lblCNPJ);
            this.grpBxCli.Controls.Add(this.lblArea);
            this.grpBxCli.Controls.Add(this.txtRazaoSocialCli);
            this.grpBxCli.Controls.Add(this.lblRazao);
            this.grpBxCli.Controls.Add(this.txtNomeFantasiaCli);
            this.grpBxCli.Controls.Add(this.lblNome);
            this.grpBxCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxCli.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxCli.Location = new System.Drawing.Point(364, 19);
            this.grpBxCli.Name = "grpBxCli";
            this.grpBxCli.Size = new System.Drawing.Size(516, 162);
            this.grpBxCli.TabIndex = 3;
            this.grpBxCli.TabStop = false;
            this.grpBxCli.Text = "Dados Cliente:";
            // 
            // txtCnpjCli
            // 
            this.txtCnpjCli.getText = "";
            this.txtCnpjCli.Image = ((System.Drawing.Image)(resources.GetObject("txtCnpjCli.Image")));
            this.txtCnpjCli.Location = new System.Drawing.Point(17, 32);
            this.txtCnpjCli.Name = "txtCnpjCli";
            this.txtCnpjCli.ShowButton = false;
            this.txtCnpjCli.Size = new System.Drawing.Size(148, 25);
            this.txtCnpjCli.TabIndex = 91;
            this.txtCnpjCli.ButtonClick += new System.EventHandler(this.txtCnpjCli_ButtonClick);
            // 
            // cmbAreaAtuCli
            // 
            this.cmbAreaAtuCli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAreaAtuCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAreaAtuCli.FormattingEnabled = true;
            this.cmbAreaAtuCli.Items.AddRange(new object[] {
            "",
            "AEROESPACIAL",
            "AUTO - AUTOMOBILÍSTICO",
            "AUTO - RODA/DIREÇÃO",
            "AUTO - SUB-FORNECEDOR",
            "ELÉTRICA",
            "FERRAMENTAS",
            "GERAL- BÉLICA",
            "GERAL - MÁQUINAS/OUTROS",
            "GERAL - MÓVEIS",
            "GERAL - OUTROS",
            "GERAL - PEQUENOS COMPONENTES",
            "GERAL - PRODUTOS AGRICOLAS",
            "GERAL - PRODUTOS MADEIRA",
            "GERAL - PRODUTOS METAL",
            "GERAL - PRODUTOS METAL/MADEIRA",
            "GERAL -REAFIAÇÃO",
            "GERAL - SIDERÚRGICA",
            "GERAL - TRAB. METAL",
            "GERAL - TRAB. MADEIRA",
            "MOLDE - FERRAMENTARIA",
            "MOLDE - JANELAS",
            "MOLDE - PLÁSTICO",
            "VÁLVULAS - PETRÓLEO"});
            this.cmbAreaAtuCli.Location = new System.Drawing.Point(224, 34);
            this.cmbAreaAtuCli.Name = "cmbAreaAtuCli";
            this.cmbAreaAtuCli.Size = new System.Drawing.Size(286, 21);
            this.cmbAreaAtuCli.TabIndex = 29;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblCNPJ.Location = new System.Drawing.Point(14, 19);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(37, 13);
            this.lblCNPJ.TabIndex = 26;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblArea.Location = new System.Drawing.Point(221, 16);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(89, 13);
            this.lblArea.TabIndex = 26;
            this.lblArea.Text = "Área de atuação:";
            // 
            // txtRazaoSocialCli
            // 
            this.txtRazaoSocialCli.Location = new System.Drawing.Point(17, 82);
            this.txtRazaoSocialCli.Name = "txtRazaoSocialCli";
            this.txtRazaoSocialCli.Size = new System.Drawing.Size(493, 20);
            this.txtRazaoSocialCli.TabIndex = 25;
            // 
            // lblRazao
            // 
            this.lblRazao.AutoSize = true;
            this.lblRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazao.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblRazao.Location = new System.Drawing.Point(14, 65);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(73, 13);
            this.lblRazao.TabIndex = 24;
            this.lblRazao.Text = "Razão Social:";
            // 
            // txtNomeFantasiaCli
            // 
            this.txtNomeFantasiaCli.Location = new System.Drawing.Point(20, 133);
            this.txtNomeFantasiaCli.Name = "txtNomeFantasiaCli";
            this.txtNomeFantasiaCli.Size = new System.Drawing.Size(490, 20);
            this.txtNomeFantasiaCli.TabIndex = 23;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNome.Location = new System.Drawing.Point(17, 116);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(81, 13);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "Nome Fantasia:";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtgrdConCli
            // 
            this.dtgrdConCli.AllowUserToAddRows = false;
            this.dtgrdConCli.AllowUserToDeleteRows = false;
            this.dtgrdConCli.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdConCli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrdConCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdConCli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNPJCli,
            this.NomeFantasiaCli,
            this.ClmnCodPed,
            this.ClmnDtPed,
            this.ClmnValPed});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrdConCli.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgrdConCli.Location = new System.Drawing.Point(6, 209);
            this.dtgrdConCli.Name = "dtgrdConCli";
            this.dtgrdConCli.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdConCli.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgrdConCli.Size = new System.Drawing.Size(813, 243);
            this.dtgrdConCli.TabIndex = 0;
            // 
            // CNPJCli
            // 
            this.CNPJCli.DataPropertyName = "CodCliente";
            this.CNPJCli.HeaderText = "Cód. Cliente";
            this.CNPJCli.Name = "CNPJCli";
            this.CNPJCli.ReadOnly = true;
            // 
            // NomeFantasiaCli
            // 
            this.NomeFantasiaCli.DataPropertyName = "NomeFantasia";
            this.NomeFantasiaCli.HeaderText = "Nome Fantasia Cliente";
            this.NomeFantasiaCli.Name = "NomeFantasiaCli";
            this.NomeFantasiaCli.ReadOnly = true;
            this.NomeFantasiaCli.Width = 200;
            // 
            // ClmnCodPed
            // 
            this.ClmnCodPed.DataPropertyName = "NrPedido";
            this.ClmnCodPed.HeaderText = "N°.Ped.";
            this.ClmnCodPed.Name = "ClmnCodPed";
            this.ClmnCodPed.ReadOnly = true;
            // 
            // ClmnDtPed
            // 
            this.ClmnDtPed.DataPropertyName = "DATAEMISSAO";
            this.ClmnDtPed.HeaderText = "Data Ped.";
            this.ClmnDtPed.Name = "ClmnDtPed";
            this.ClmnDtPed.ReadOnly = true;
            this.ClmnDtPed.Width = 120;
            // 
            // ClmnValPed
            // 
            this.ClmnValPed.DataPropertyName = "VALOR";
            this.ClmnValPed.HeaderText = "Valor do Pedido";
            this.ClmnValPed.Name = "ClmnValPed";
            this.ClmnValPed.ReadOnly = true;
            this.ClmnValPed.Width = 160;
            // 
            // cOMERCIALDataSet
            // 
            this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
            this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(111, 1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // frmConCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(922, 498);
            this.ControlBox = false;
            this.Controls.Add(this.tbCntrlConCli);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConCli";
            this.Text = "Consulta de Clientes";
            this.Load += new System.EventHandler(this.frmConCli_Load);
            this.Leave += new System.EventHandler(this.frmConCli_Leave);
            this.tbCntrlConCli.ResumeLayout(false);
            this.tbPgConCli.ResumeLayout(false);
            this.grpBxFiltro.ResumeLayout(false);
            this.grpBxPedido.ResumeLayout(false);
            this.grpBxPedido.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpBxCli.ResumeLayout(false);
            this.grpBxCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdConCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrlConCli;
        private System.Windows.Forms.TabPage tbPgConCli;
        private System.Windows.Forms.GroupBox grpBxFiltro;
        private System.Windows.Forms.DataGridView dtgrdConCli;
        private System.Windows.Forms.GroupBox grpBxCli;
        private System.Windows.Forms.GroupBox grpBxPedido;
        private System.Windows.Forms.Label lblDataPed;
        private System.Windows.Forms.Label lblNumPed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbtnCancelado;
        private System.Windows.Forms.RadioButton rdbtnPendente;
        private System.Windows.Forms.RadioButton rdbtnEfetivado;
        private System.Windows.Forms.ComboBox cmBxTipoPed;
        private System.Windows.Forms.Label lblTipoPed;
        private System.Windows.Forms.DateTimePicker dttmDataPedido;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRazao;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFantasiaCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCodPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDtPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnValPed;
        public TextButton txtCnpjCli;
        public System.Windows.Forms.TextBox txtNomeFantasiaCli;
        public System.Windows.Forms.TextBox txtRazaoSocialCli;
        public System.Windows.Forms.ComboBox cmbAreaAtuCli;
        private System.Windows.Forms.TextBox txtNumPed;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}