namespace Comercial
{
    partial class FrmCadCli
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
            this.tbCntrlCadCli = new System.Windows.Forms.TabControl();
            this.tbpCadCli = new System.Windows.Forms.TabPage();
            this.cmBxRegiaoCli = new System.Windows.Forms.ComboBox();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.rEGIAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRegiaoCli = new System.Windows.Forms.Label();
            this.txtRazaoSocialCli = new System.Windows.Forms.TextBox();
            this.lblRazaoSocialCliente = new System.Windows.Forms.Label();
            this.chckBxCred = new System.Windows.Forms.CheckBox();
            this.txtLimCredCli = new System.Windows.Forms.MaskedTextBox();
            this.lblPotencialCli = new System.Windows.Forms.Label();
            this.cmbAreaAtuCli = new System.Windows.Forms.ComboBox();
            this.lblAreaAtuCli = new System.Windows.Forms.Label();
            this.grpBxUsuario = new System.Windows.Forms.GroupBox();
            this.txtSenhaCli = new System.Windows.Forms.TextBox();
            this.txtUsuarioCli = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtIeCli = new System.Windows.Forms.MaskedTextBox();
            this.lblIECliente = new System.Windows.Forms.Label();
            this.gpbContatoCli = new System.Windows.Forms.GroupBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCepCli = new Comercial.TextButton();
            this.txtFaxCli = new System.Windows.Forms.MaskedTextBox();
            this.txtTelCli = new System.Windows.Forms.MaskedTextBox();
            this.lblFaxCli = new System.Windows.Forms.Label();
            this.txtEmailCli = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.cmbUfCli = new System.Windows.Forms.ComboBox();
            this.lblUfCliente = new System.Windows.Forms.Label();
            this.txtMunicipioCli = new System.Windows.Forms.TextBox();
            this.lblMunicipioCliente = new System.Windows.Forms.Label();
            this.txtBairroCli = new System.Windows.Forms.TextBox();
            this.txtEndCli = new System.Windows.Forms.TextBox();
            this.lblBairroCliente = new System.Windows.Forms.Label();
            this.lblEnderecoCliente = new System.Windows.Forms.Label();
            this.txtNomeFantCli = new System.Windows.Forms.TextBox();
            this.txtCnpjCli = new System.Windows.Forms.MaskedTextBox();
            this.lblNomeFantasiaCliente = new System.Windows.Forms.Label();
            this.lblCnpjCliente = new System.Windows.Forms.Label();
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new Comercial.COMERCIALDataSetTableAdapters.CLIENTETableAdapter();
            this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
            this.uSUARIOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.USUARIOTableAdapter();
            this.rEGIAOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.REGIAOTableAdapter();
            this.tbCntrlCadCli.SuspendLayout();
            this.tbpCadCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGIAOBindingSource)).BeginInit();
            this.grpBxUsuario.SuspendLayout();
            this.gpbContatoCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrlCadCli
            // 
            this.tbCntrlCadCli.Controls.Add(this.tbpCadCli);
            this.tbCntrlCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlCadCli.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlCadCli.Name = "tbCntrlCadCli";
            this.tbCntrlCadCli.SelectedIndex = 0;
            this.tbCntrlCadCli.Size = new System.Drawing.Size(541, 423);
            this.tbCntrlCadCli.TabIndex = 0;
            // 
            // tbpCadCli
            // 
            this.tbpCadCli.AutoScroll = true;
            this.tbpCadCli.Controls.Add(this.cmBxRegiaoCli);
            this.tbpCadCli.Controls.Add(this.lblRegiaoCli);
            this.tbpCadCli.Controls.Add(this.txtRazaoSocialCli);
            this.tbpCadCli.Controls.Add(this.lblRazaoSocialCliente);
            this.tbpCadCli.Controls.Add(this.chckBxCred);
            this.tbpCadCli.Controls.Add(this.txtLimCredCli);
            this.tbpCadCli.Controls.Add(this.lblPotencialCli);
            this.tbpCadCli.Controls.Add(this.cmbAreaAtuCli);
            this.tbpCadCli.Controls.Add(this.lblAreaAtuCli);
            this.tbpCadCli.Controls.Add(this.grpBxUsuario);
            this.tbpCadCli.Controls.Add(this.txtIeCli);
            this.tbpCadCli.Controls.Add(this.lblIECliente);
            this.tbpCadCli.Controls.Add(this.gpbContatoCli);
            this.tbpCadCli.Controls.Add(this.txtNomeFantCli);
            this.tbpCadCli.Controls.Add(this.txtCnpjCli);
            this.tbpCadCli.Controls.Add(this.lblNomeFantasiaCliente);
            this.tbpCadCli.Controls.Add(this.lblCnpjCliente);
            this.tbpCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpCadCli.Location = new System.Drawing.Point(4, 22);
            this.tbpCadCli.Name = "tbpCadCli";
            this.tbpCadCli.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadCli.Size = new System.Drawing.Size(533, 397);
            this.tbpCadCli.TabIndex = 0;
            this.tbpCadCli.Text = "Cadastro de Clientes";
            this.tbpCadCli.UseVisualStyleBackColor = true;
            // 
            // cmBxRegiaoCli
            // 
            this.cmBxRegiaoCli.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTEBindingSource, "CODREGIAO", true));
            this.cmBxRegiaoCli.DataSource = this.rEGIAOBindingSource;
            this.cmBxRegiaoCli.DisplayMember = "DESCRICAO";
            this.cmBxRegiaoCli.FormattingEnabled = true;
            this.cmBxRegiaoCli.Location = new System.Drawing.Point(325, 18);
            this.cmBxRegiaoCli.Name = "cmBxRegiaoCli";
            this.cmBxRegiaoCli.Size = new System.Drawing.Size(172, 21);
            this.cmBxRegiaoCli.TabIndex = 2;
            this.cmBxRegiaoCli.ValueMember = "CODREGIAO";
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.cOMERCIALDataSet;
            this.cLIENTEBindingSource.PositionChanged += new System.EventHandler(this.cLIENTEBindingSource_PositionChanged);
            // 
            // cOMERCIALDataSet
            // 
            this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
            this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEGIAOBindingSource
            // 
            this.rEGIAOBindingSource.DataMember = "REGIAO";
            this.rEGIAOBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // lblRegiaoCli
            // 
            this.lblRegiaoCli.AutoSize = true;
            this.lblRegiaoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegiaoCli.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblRegiaoCli.Location = new System.Drawing.Point(322, 2);
            this.lblRegiaoCli.Name = "lblRegiaoCli";
            this.lblRegiaoCli.Size = new System.Drawing.Size(51, 13);
            this.lblRegiaoCli.TabIndex = 54;
            this.lblRegiaoCli.Text = "Região:";
            // 
            // txtRazaoSocialCli
            // 
            this.txtRazaoSocialCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "RAZAOSOCIAL", true));
            this.txtRazaoSocialCli.Location = new System.Drawing.Point(232, 58);
            this.txtRazaoSocialCli.Name = "txtRazaoSocialCli";
            this.txtRazaoSocialCli.Size = new System.Drawing.Size(265, 20);
            this.txtRazaoSocialCli.TabIndex = 4;
            // 
            // lblRazaoSocialCliente
            // 
            this.lblRazaoSocialCliente.AutoSize = true;
            this.lblRazaoSocialCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocialCliente.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblRazaoSocialCliente.Location = new System.Drawing.Point(226, 42);
            this.lblRazaoSocialCliente.Name = "lblRazaoSocialCliente";
            this.lblRazaoSocialCliente.Size = new System.Drawing.Size(82, 13);
            this.lblRazaoSocialCliente.TabIndex = 46;
            this.lblRazaoSocialCliente.Text = "Razão Social";
            // 
            // chckBxCred
            // 
            this.chckBxCred.AutoSize = true;
            this.chckBxCred.ForeColor = System.Drawing.Color.CadetBlue;
            this.chckBxCred.Location = new System.Drawing.Point(6, 335);
            this.chckBxCred.Name = "chckBxCred";
            this.chckBxCred.Size = new System.Drawing.Size(108, 17);
            this.chckBxCred.TabIndex = 15;
            this.chckBxCred.Text = "Crédito Aprovado";
            this.chckBxCred.UseVisualStyleBackColor = true;
            this.chckBxCred.CheckedChanged += new System.EventHandler(this.chckBxCred_CheckedChanged);
            // 
            // txtLimCredCli
            // 
            this.txtLimCredCli.BeepOnError = true;
            this.txtLimCredCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "LIMITECRED", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.txtLimCredCli.Enabled = false;
            this.txtLimCredCli.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtLimCredCli.Location = new System.Drawing.Point(125, 335);
            this.txtLimCredCli.Name = "txtLimCredCli";
            this.txtLimCredCli.PromptChar = ' ';
            this.txtLimCredCli.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLimCredCli.Size = new System.Drawing.Size(125, 20);
            this.txtLimCredCli.TabIndex = 14;
            this.txtLimCredCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLimCredCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblPotencialCli
            // 
            this.lblPotencialCli.AutoSize = true;
            this.lblPotencialCli.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblPotencialCli.Location = new System.Drawing.Point(123, 319);
            this.lblPotencialCli.Name = "lblPotencialCli";
            this.lblPotencialCli.Size = new System.Drawing.Size(87, 13);
            this.lblPotencialCli.TabIndex = 42;
            this.lblPotencialCli.Text = "Limite de crédito:";
            // 
            // cmbAreaAtuCli
            // 
            this.cmbAreaAtuCli.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTEBindingSource, "AREAATUACAO", true));
            this.cmbAreaAtuCli.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.cLIENTEBindingSource, "AREAATUACAO", true));
            this.cmbAreaAtuCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "AREAATUACAO", true));
            this.cmbAreaAtuCli.FormattingEnabled = true;
            this.cmbAreaAtuCli.Items.AddRange(new object[] {
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
            this.cmbAreaAtuCli.Location = new System.Drawing.Point(9, 283);
            this.cmbAreaAtuCli.Name = "cmbAreaAtuCli";
            this.cmbAreaAtuCli.Size = new System.Drawing.Size(285, 21);
            this.cmbAreaAtuCli.TabIndex = 13;
            // 
            // lblAreaAtuCli
            // 
            this.lblAreaAtuCli.AutoSize = true;
            this.lblAreaAtuCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaAtuCli.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblAreaAtuCli.Location = new System.Drawing.Point(6, 267);
            this.lblAreaAtuCli.Name = "lblAreaAtuCli";
            this.lblAreaAtuCli.Size = new System.Drawing.Size(89, 13);
            this.lblAreaAtuCli.TabIndex = 41;
            this.lblAreaAtuCli.Text = "Área de atuação:";
            // 
            // grpBxUsuario
            // 
            this.grpBxUsuario.Controls.Add(this.txtSenhaCli);
            this.grpBxUsuario.Controls.Add(this.txtUsuarioCli);
            this.grpBxUsuario.Controls.Add(this.lblSenha);
            this.grpBxUsuario.Controls.Add(this.lblUsuario);
            this.grpBxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxUsuario.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxUsuario.Location = new System.Drawing.Point(325, 270);
            this.grpBxUsuario.Name = "grpBxUsuario";
            this.grpBxUsuario.Size = new System.Drawing.Size(197, 126);
            this.grpBxUsuario.TabIndex = 34;
            this.grpBxUsuario.TabStop = false;
            this.grpBxUsuario.Text = "Login";
            // 
            // txtSenhaCli
            // 
            this.txtSenhaCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCli.Location = new System.Drawing.Point(17, 86);
            this.txtSenhaCli.Name = "txtSenhaCli";
            this.txtSenhaCli.PasswordChar = '*';
            this.txtSenhaCli.Size = new System.Drawing.Size(155, 20);
            this.txtSenhaCli.TabIndex = 17;
            // 
            // txtUsuarioCli
            // 
            this.txtUsuarioCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCli.Location = new System.Drawing.Point(17, 42);
            this.txtUsuarioCli.Name = "txtUsuarioCli";
            this.txtUsuarioCli.Size = new System.Drawing.Size(155, 20);
            this.txtUsuarioCli.TabIndex = 16;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblSenha.Location = new System.Drawing.Point(14, 70);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(43, 13);
            this.lblSenha.TabIndex = 39;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblUsuario.Location = new System.Drawing.Point(14, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 13);
            this.lblUsuario.TabIndex = 38;
            this.lblUsuario.Text = "Usuário";
            // 
            // txtIeCli
            // 
            this.txtIeCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "IE", true));
            this.txtIeCli.Location = new System.Drawing.Point(232, 19);
            this.txtIeCli.Mask = "99,999,999,999";
            this.txtIeCli.Name = "txtIeCli";
            this.txtIeCli.PromptChar = ' ';
            this.txtIeCli.Size = new System.Drawing.Size(87, 20);
            this.txtIeCli.TabIndex = 1;
            this.txtIeCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblIECliente
            // 
            this.lblIECliente.AutoSize = true;
            this.lblIECliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIECliente.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblIECliente.Location = new System.Drawing.Point(232, 3);
            this.lblIECliente.Name = "lblIECliente";
            this.lblIECliente.Size = new System.Drawing.Size(23, 13);
            this.lblIECliente.TabIndex = 16;
            this.lblIECliente.Text = "I.E";
            // 
            // gpbContatoCli
            // 
            this.gpbContatoCli.Controls.Add(this.lblCep);
            this.gpbContatoCli.Controls.Add(this.txtCepCli);
            this.gpbContatoCli.Controls.Add(this.txtFaxCli);
            this.gpbContatoCli.Controls.Add(this.txtTelCli);
            this.gpbContatoCli.Controls.Add(this.lblFaxCli);
            this.gpbContatoCli.Controls.Add(this.txtEmailCli);
            this.gpbContatoCli.Controls.Add(this.lblEmailCliente);
            this.gpbContatoCli.Controls.Add(this.lblTelefoneCliente);
            this.gpbContatoCli.Controls.Add(this.cmbUfCli);
            this.gpbContatoCli.Controls.Add(this.lblUfCliente);
            this.gpbContatoCli.Controls.Add(this.txtMunicipioCli);
            this.gpbContatoCli.Controls.Add(this.lblMunicipioCliente);
            this.gpbContatoCli.Controls.Add(this.txtBairroCli);
            this.gpbContatoCli.Controls.Add(this.txtEndCli);
            this.gpbContatoCli.Controls.Add(this.lblBairroCliente);
            this.gpbContatoCli.Controls.Add(this.lblEnderecoCliente);
            this.gpbContatoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbContatoCli.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gpbContatoCli.Location = new System.Drawing.Point(6, 84);
            this.gpbContatoCli.Name = "gpbContatoCli";
            this.gpbContatoCli.Size = new System.Drawing.Size(510, 180);
            this.gpbContatoCli.TabIndex = 4;
            this.gpbContatoCli.TabStop = false;
            this.gpbContatoCli.Text = "Contato";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblCep.Location = new System.Drawing.Point(3, 26);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(29, 13);
            this.lblCep.TabIndex = 44;
            this.lblCep.Text = "Cep";
            // 
            // txtCepCli
            // 
            this.txtCepCli.getText = "";
            this.txtCepCli.Image = global::Comercial.Properties.Resources.btn_correios;
            this.txtCepCli.Location = new System.Drawing.Point(6, 42);
            this.txtCepCli.Name = "txtCepCli";
            this.txtCepCli.ShowButton = false;
            this.txtCepCli.Size = new System.Drawing.Size(121, 25);
            this.txtCepCli.TabIndex = 5;
            // 
            // txtFaxCli
            // 
            this.txtFaxCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaxCli.Location = new System.Drawing.Point(101, 121);
            this.txtFaxCli.Mask = "(99) 9999-9999";
            this.txtFaxCli.Name = "txtFaxCli";
            this.txtFaxCli.PromptChar = ' ';
            this.txtFaxCli.Size = new System.Drawing.Size(78, 20);
            this.txtFaxCli.TabIndex = 11;
            this.txtFaxCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFaxCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelCli
            // 
            this.txtTelCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "TELEFONE", true));
            this.txtTelCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelCli.Location = new System.Drawing.Point(6, 121);
            this.txtTelCli.Mask = "(99) 9999-9999";
            this.txtTelCli.Name = "txtTelCli";
            this.txtTelCli.PromptChar = ' ';
            this.txtTelCli.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelCli.Size = new System.Drawing.Size(89, 20);
            this.txtTelCli.TabIndex = 10;
            this.txtTelCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblFaxCli
            // 
            this.lblFaxCli.AutoSize = true;
            this.lblFaxCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaxCli.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblFaxCli.Location = new System.Drawing.Point(98, 105);
            this.lblFaxCli.Name = "lblFaxCli";
            this.lblFaxCli.Size = new System.Drawing.Size(27, 13);
            this.lblFaxCli.TabIndex = 42;
            this.lblFaxCli.Text = "Fax:";
            // 
            // txtEmailCli
            // 
            this.txtEmailCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "EMAIL", true));
            this.txtEmailCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCli.Location = new System.Drawing.Point(188, 121);
            this.txtEmailCli.Name = "txtEmailCli";
            this.txtEmailCli.Size = new System.Drawing.Size(308, 20);
            this.txtEmailCli.TabIndex = 12;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblEmailCliente.Location = new System.Drawing.Point(185, 105);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(42, 13);
            this.lblEmailCliente.TabIndex = 38;
            this.lblEmailCliente.Text = "E-Mail";
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCliente.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTelefoneCliente.Location = new System.Drawing.Point(0, 103);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(57, 13);
            this.lblTelefoneCliente.TabIndex = 37;
            this.lblTelefoneCliente.Text = "Telefone";
            // 
            // cmbUfCli
            // 
            this.cmbUfCli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbUfCli.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUfCli.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTEBindingSource, "UF", true));
            this.cmbUfCli.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.cLIENTEBindingSource, "UF", true));
            this.cmbUfCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "UF", true));
            this.cmbUfCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUfCli.FormattingEnabled = true;
            this.cmbUfCli.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cmbUfCli.Location = new System.Drawing.Point(375, 82);
            this.cmbUfCli.Name = "cmbUfCli";
            this.cmbUfCli.Size = new System.Drawing.Size(121, 21);
            this.cmbUfCli.TabIndex = 9;
            this.cmbUfCli.Text = "Selecione...";
            // 
            // lblUfCliente
            // 
            this.lblUfCliente.AutoSize = true;
            this.lblUfCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUfCliente.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblUfCliente.Location = new System.Drawing.Point(372, 66);
            this.lblUfCliente.Name = "lblUfCliente";
            this.lblUfCliente.Size = new System.Drawing.Size(23, 13);
            this.lblUfCliente.TabIndex = 34;
            this.lblUfCliente.Text = "UF";
            // 
            // txtMunicipioCli
            // 
            this.txtMunicipioCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "MUNICIPIO", true));
            this.txtMunicipioCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipioCli.Location = new System.Drawing.Point(170, 82);
            this.txtMunicipioCli.Name = "txtMunicipioCli";
            this.txtMunicipioCli.Size = new System.Drawing.Size(197, 20);
            this.txtMunicipioCli.TabIndex = 8;
            // 
            // lblMunicipioCliente
            // 
            this.lblMunicipioCliente.AutoSize = true;
            this.lblMunicipioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipioCliente.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblMunicipioCliente.Location = new System.Drawing.Point(167, 65);
            this.lblMunicipioCliente.Name = "lblMunicipioCliente";
            this.lblMunicipioCliente.Size = new System.Drawing.Size(60, 13);
            this.lblMunicipioCliente.TabIndex = 30;
            this.lblMunicipioCliente.Text = "Municípo";
            // 
            // txtBairroCli
            // 
            this.txtBairroCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "BAIRRO", true));
            this.txtBairroCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroCli.Location = new System.Drawing.Point(6, 81);
            this.txtBairroCli.Name = "txtBairroCli";
            this.txtBairroCli.Size = new System.Drawing.Size(155, 20);
            this.txtBairroCli.TabIndex = 7;
            // 
            // txtEndCli
            // 
            this.txtEndCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "ENDERECO", true));
            this.txtEndCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndCli.Location = new System.Drawing.Point(133, 42);
            this.txtEndCli.Name = "txtEndCli";
            this.txtEndCli.Size = new System.Drawing.Size(363, 20);
            this.txtEndCli.TabIndex = 6;
            // 
            // lblBairroCliente
            // 
            this.lblBairroCliente.AutoSize = true;
            this.lblBairroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroCliente.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblBairroCliente.Location = new System.Drawing.Point(3, 65);
            this.lblBairroCliente.Name = "lblBairroCliente";
            this.lblBairroCliente.Size = new System.Drawing.Size(34, 13);
            this.lblBairroCliente.TabIndex = 27;
            this.lblBairroCliente.Text = "Bairro";
            // 
            // lblEnderecoCliente
            // 
            this.lblEnderecoCliente.AutoSize = true;
            this.lblEnderecoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoCliente.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblEnderecoCliente.Location = new System.Drawing.Point(130, 26);
            this.lblEnderecoCliente.Name = "lblEnderecoCliente";
            this.lblEnderecoCliente.Size = new System.Drawing.Size(61, 13);
            this.lblEnderecoCliente.TabIndex = 26;
            this.lblEnderecoCliente.Text = "Endereço";
            // 
            // txtNomeFantCli
            // 
            this.txtNomeFantCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "NOMEFANTASIA", true));
            this.txtNomeFantCli.Location = new System.Drawing.Point(9, 58);
            this.txtNomeFantCli.Name = "txtNomeFantCli";
            this.txtNomeFantCli.Size = new System.Drawing.Size(217, 20);
            this.txtNomeFantCli.TabIndex = 3;
            // 
            // txtCnpjCli
            // 
            this.txtCnpjCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CNPJ", true));
            this.txtCnpjCli.Location = new System.Drawing.Point(9, 19);
            this.txtCnpjCli.Mask = "99,999,999/9999-99";
            this.txtCnpjCli.Name = "txtCnpjCli";
            this.txtCnpjCli.PromptChar = ' ';
            this.txtCnpjCli.Size = new System.Drawing.Size(124, 20);
            this.txtCnpjCli.TabIndex = 0;
            this.txtCnpjCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblNomeFantasiaCliente
            // 
            this.lblNomeFantasiaCliente.AutoSize = true;
            this.lblNomeFantasiaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasiaCliente.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNomeFantasiaCliente.Location = new System.Drawing.Point(6, 42);
            this.lblNomeFantasiaCliente.Name = "lblNomeFantasiaCliente";
            this.lblNomeFantasiaCliente.Size = new System.Drawing.Size(91, 13);
            this.lblNomeFantasiaCliente.TabIndex = 14;
            this.lblNomeFantasiaCliente.Text = "Nome Fantasia";
            // 
            // lblCnpjCliente
            // 
            this.lblCnpjCliente.AutoSize = true;
            this.lblCnpjCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpjCliente.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblCnpjCliente.Location = new System.Drawing.Point(6, 3);
            this.lblCnpjCliente.Name = "lblCnpjCliente";
            this.lblCnpjCliente.Size = new System.Drawing.Size(38, 13);
            this.lblCnpjCliente.TabIndex = 15;
            this.lblCnpjCliente.Text = "CNPJ";
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTETableAdapter = this.cLIENTETableAdapter;
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
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // rEGIAOTableAdapter
            // 
            this.rEGIAOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCadCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(580, 439);
            this.ControlBox = false;
            this.Controls.Add(this.tbCntrlCadCli);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadCli";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmCadCli_Load);
            this.Shown += new System.EventHandler(this.FrmCadCli_Shown);
            this.tbCntrlCadCli.ResumeLayout(false);
            this.tbpCadCli.ResumeLayout(false);
            this.tbpCadCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGIAOBindingSource)).EndInit();
            this.grpBxUsuario.ResumeLayout(false);
            this.grpBxUsuario.PerformLayout();
            this.gpbContatoCli.ResumeLayout(false);
            this.gpbContatoCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrlCadCli;
        private System.Windows.Forms.TabPage tbpCadCli;
        private System.Windows.Forms.GroupBox gpbContatoCli;
        private System.Windows.Forms.TextBox txtNomeFantCli;
        private System.Windows.Forms.Label lblIECliente;
        private System.Windows.Forms.Label lblCnpjCliente;
        private System.Windows.Forms.Label lblNomeFantasiaCliente;
        private System.Windows.Forms.Label lblFaxCli;
        private System.Windows.Forms.TextBox txtEmailCli;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.ComboBox cmbUfCli;
        private System.Windows.Forms.Label lblUfCliente;
        private System.Windows.Forms.TextBox txtMunicipioCli;
        private System.Windows.Forms.Label lblMunicipioCliente;
        private System.Windows.Forms.TextBox txtBairroCli;
        private System.Windows.Forms.TextBox txtEndCli;
        private System.Windows.Forms.Label lblBairroCliente;
        private System.Windows.Forms.Label lblEnderecoCliente;
        private System.Windows.Forms.MaskedTextBox txtFaxCli;
        private System.Windows.Forms.MaskedTextBox txtTelCli;
        public System.Windows.Forms.MaskedTextBox txtCnpjCli;
        private System.Windows.Forms.MaskedTextBox txtIeCli;
        private System.Windows.Forms.GroupBox grpBxUsuario;
        public System.Windows.Forms.TextBox txtSenhaCli;
        public System.Windows.Forms.TextBox txtUsuarioCli;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.CheckBox chckBxCred;
        private System.Windows.Forms.Label lblPotencialCli;
        private System.Windows.Forms.ComboBox cmbAreaAtuCli;
        private System.Windows.Forms.Label lblAreaAtuCli;
        private System.Windows.Forms.Label lblCep;
        private TextButton txtCepCli;
        private System.Windows.Forms.TextBox txtRazaoSocialCli;
        private System.Windows.Forms.Label lblRazaoSocialCliente;
        private System.Windows.Forms.ComboBox cmBxRegiaoCli;
        private System.Windows.Forms.Label lblRegiaoCli;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Comercial.COMERCIALDataSetTableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private System.Windows.Forms.BindingSource rEGIAOBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.REGIAOTableAdapter rEGIAOTableAdapter;
        public System.Windows.Forms.MaskedTextBox txtLimCredCli;
    }
}