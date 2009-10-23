namespace Comercial
{
    partial class FrmCadVen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadVen));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.vENDEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.cmBxRegiao = new System.Windows.Forms.ComboBox();
            this.rEGIAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grpBxUsuario = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.grpBxContato = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cOMPLEMENTOTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUfCli = new System.Windows.Forms.ComboBox();
            this.lblUfCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcep = new Comercial.TextButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.LblMunicipio = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblRegiao = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblcomissao = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbCntrlVendedor = new System.Windows.Forms.TabControl();
            this.vENDEDORTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.VENDEDORTableAdapter();
            this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
            this.rEGIAOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.REGIAOTableAdapter();
            this.cnsltTlStrpConsulta = new System.Windows.Forms.ToolStrip();
            this.cpfToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.cpfToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nomeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nomeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGIAOBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpBxUsuario.SuspendLayout();
            this.grpBxContato.SuspendLayout();
            this.tbCntrlVendedor.SuspendLayout();
            this.cnsltTlStrpConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.txtCPF);
            this.tabPage2.Controls.Add(this.cmBxRegiao);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.grpBxUsuario);
            this.tabPage2.Controls.Add(this.grpBxContato);
            this.tabPage2.Controls.Add(this.lblRegiao);
            this.tabPage2.Controls.Add(this.txtComissao);
            this.tabPage2.Controls.Add(this.txtRg);
            this.tabPage2.Controls.Add(this.txtNome);
            this.tabPage2.Controls.Add(this.lblcomissao);
            this.tabPage2.Controls.Add(this.lblRG);
            this.tabPage2.Controls.Add(this.lblCPF);
            this.tabPage2.Controls.Add(this.lblNome);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(563, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro de vendedor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCPF
            // 
            this.txtCPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "CPF", true));
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(376, 19);
            this.txtCPF.Mask = "999,999,999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(123, 20);
            this.txtCPF.TabIndex = 2;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // vENDEDORBindingSource
            // 
            this.vENDEDORBindingSource.DataMember = "VENDEDOR";
            this.vENDEDORBindingSource.DataSource = this.cOMERCIALDataSet;
            this.vENDEDORBindingSource.PositionChanged += new System.EventHandler(this.vENDEDORBindingSource_PositionChanged);
            // 
            // cOMERCIALDataSet
            // 
            this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
            this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmBxRegiao
            // 
            this.cmBxRegiao.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vENDEDORBindingSource, "CODREGIAO", true));
            this.cmBxRegiao.DataSource = this.rEGIAOBindingSource;
            this.cmBxRegiao.DisplayMember = "DESCRICAO";
            this.cmBxRegiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBxRegiao.FormattingEnabled = true;
            this.cmBxRegiao.Location = new System.Drawing.Point(130, 57);
            this.cmBxRegiao.Name = "cmBxRegiao";
            this.cmBxRegiao.Size = new System.Drawing.Size(115, 21);
            this.cmBxRegiao.TabIndex = 4;
            this.cmBxRegiao.ValueMember = "CODREGIAO";
            // 
            // rEGIAOBindingSource
            // 
            this.rEGIAOBindingSource.DataMember = "REGIAO";
            this.rEGIAOBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(379, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 38);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.CadetBlue;
            this.radioButton2.Location = new System.Drawing.Point(96, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Feminino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.CadetBlue;
            this.radioButton1.Location = new System.Drawing.Point(8, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // grpBxUsuario
            // 
            this.grpBxUsuario.Controls.Add(this.txtSenha);
            this.grpBxUsuario.Controls.Add(this.txtUsu);
            this.grpBxUsuario.Controls.Add(this.lblSenha);
            this.grpBxUsuario.Controls.Add(this.lblUsuario);
            this.grpBxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxUsuario.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxUsuario.Location = new System.Drawing.Point(374, 249);
            this.grpBxUsuario.Name = "grpBxUsuario";
            this.grpBxUsuario.Size = new System.Drawing.Size(183, 121);
            this.grpBxUsuario.TabIndex = 48;
            this.grpBxUsuario.TabStop = false;
            this.grpBxUsuario.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(13, 86);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(155, 20);
            this.txtSenha.TabIndex = 41;
            // 
            // txtUsu
            // 
            this.txtUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.Location = new System.Drawing.Point(13, 42);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(155, 20);
            this.txtUsu.TabIndex = 40;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblSenha.Location = new System.Drawing.Point(10, 70);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 13);
            this.lblSenha.TabIndex = 39;
            this.lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblUsuario.Location = new System.Drawing.Point(10, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 13);
            this.lblUsuario.TabIndex = 38;
            this.lblUsuario.Text = "Usuário:";
            // 
            // grpBxContato
            // 
            this.grpBxContato.Controls.Add(this.maskedTextBox1);
            this.grpBxContato.Controls.Add(this.label4);
            this.grpBxContato.Controls.Add(this.cOMPLEMENTOTextBox);
            this.grpBxContato.Controls.Add(this.label3);
            this.grpBxContato.Controls.Add(this.txtnum);
            this.grpBxContato.Controls.Add(this.label2);
            this.grpBxContato.Controls.Add(this.cmbUfCli);
            this.grpBxContato.Controls.Add(this.lblUfCliente);
            this.grpBxContato.Controls.Add(this.label1);
            this.grpBxContato.Controls.Add(this.txtcep);
            this.grpBxContato.Controls.Add(this.txtEmail);
            this.grpBxContato.Controls.Add(this.lblemail);
            this.grpBxContato.Controls.Add(this.txtEndereco);
            this.grpBxContato.Controls.Add(this.lblEndereco);
            this.grpBxContato.Controls.Add(this.txtFax);
            this.grpBxContato.Controls.Add(this.txtTelefone);
            this.grpBxContato.Controls.Add(this.txtMunicipio);
            this.grpBxContato.Controls.Add(this.txtBairro);
            this.grpBxContato.Controls.Add(this.lblFax);
            this.grpBxContato.Controls.Add(this.lblTelefone);
            this.grpBxContato.Controls.Add(this.LblMunicipio);
            this.grpBxContato.Controls.Add(this.lblBairro);
            this.grpBxContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxContato.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxContato.Location = new System.Drawing.Point(6, 85);
            this.grpBxContato.Name = "grpBxContato";
            this.grpBxContato.Size = new System.Drawing.Size(551, 158);
            this.grpBxContato.TabIndex = 47;
            this.grpBxContato.TabStop = false;
            this.grpBxContato.Text = "Contato";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "CELULAR", true));
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(215, 118);
            this.maskedTextBox1.Mask = "(99)9999-9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(212, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Celular:";
            // 
            // cOMPLEMENTOTextBox
            // 
            this.cOMPLEMENTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "COMPLEMENTO", true));
            this.cOMPLEMENTOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOMPLEMENTOTextBox.Location = new System.Drawing.Point(382, 76);
            this.cOMPLEMENTOTextBox.Name = "cOMPLEMENTOTextBox";
            this.cOMPLEMENTOTextBox.Size = new System.Drawing.Size(163, 20);
            this.cOMPLEMENTOTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(379, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Complemento:";
            // 
            // txtnum
            // 
            this.txtnum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "NUM", true));
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(467, 32);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(78, 20);
            this.txtnum.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(467, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Num.:";
            // 
            // cmbUfCli
            // 
            this.cmbUfCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "UF", true));
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
            this.cmbUfCli.Location = new System.Drawing.Point(138, 76);
            this.cmbUfCli.Name = "cmbUfCli";
            this.cmbUfCli.Size = new System.Drawing.Size(89, 21);
            this.cmbUfCli.TabIndex = 11;
            this.cmbUfCli.Text = "Selecione...";
            // 
            // lblUfCliente
            // 
            this.lblUfCliente.AutoSize = true;
            this.lblUfCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUfCliente.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblUfCliente.Location = new System.Drawing.Point(135, 60);
            this.lblUfCliente.Name = "lblUfCliente";
            this.lblUfCliente.Size = new System.Drawing.Size(23, 13);
            this.lblUfCliente.TabIndex = 67;
            this.lblUfCliente.Text = "UF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Cep";
            // 
            // txtcep
            // 
            this.txtcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcep.getText = "";
            this.txtcep.Image = global::Comercial.Properties.Resources.btn_correios;
            this.txtcep.Location = new System.Drawing.Point(10, 32);
            this.txtcep.Name = "txtcep";
            this.txtcep.ShowButton = false;
            this.txtcep.Size = new System.Drawing.Size(108, 25);
            this.txtcep.TabIndex = 7;
            this.txtcep.ButtonClick += new System.EventHandler(this.txtcep_ButtonClick);
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "EMAIL", true));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(322, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblemail.Location = new System.Drawing.Point(319, 102);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(38, 13);
            this.lblemail.TabIndex = 62;
            this.lblemail.Text = "E-mail:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "ENDERECO", true));
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(138, 32);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(323, 20);
            this.txtEndereco.TabIndex = 8;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblEndereco.Location = new System.Drawing.Point(135, 16);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(65, 13);
            this.lblEndereco.TabIndex = 60;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtFax
            // 
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "FAX", true));
            this.txtFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Location = new System.Drawing.Point(109, 118);
            this.txtFax.Mask = "(99)9999-9999";
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 15;
            this.txtFax.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefone
            // 
            this.txtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "TELEFONE", true));
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(10, 118);
            this.txtTelefone.Mask = "(99)9999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(93, 20);
            this.txtTelefone.TabIndex = 14;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "MUNICIPIO", true));
            this.txtMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipio.Location = new System.Drawing.Point(233, 76);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(143, 20);
            this.txtMunicipio.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "BAIRRO", true));
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(9, 76);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(121, 20);
            this.txtBairro.TabIndex = 10;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFax.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblFax.Location = new System.Drawing.Point(109, 102);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(27, 13);
            this.lblFax.TabIndex = 53;
            this.lblFax.Text = "Fax:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTelefone.Location = new System.Drawing.Point(7, 99);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 52;
            this.lblTelefone.Text = "Telefone:";
            // 
            // LblMunicipio
            // 
            this.LblMunicipio.AutoSize = true;
            this.LblMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMunicipio.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblMunicipio.Location = new System.Drawing.Point(231, 60);
            this.LblMunicipio.Name = "LblMunicipio";
            this.LblMunicipio.Size = new System.Drawing.Size(67, 13);
            this.LblMunicipio.TabIndex = 49;
            this.LblMunicipio.Text = "Município:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblBairro.Location = new System.Drawing.Point(7, 60);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 13);
            this.lblBairro.TabIndex = 48;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblRegiao
            // 
            this.lblRegiao.AutoSize = true;
            this.lblRegiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegiao.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblRegiao.Location = new System.Drawing.Point(127, 41);
            this.lblRegiao.Name = "lblRegiao";
            this.lblRegiao.Size = new System.Drawing.Size(51, 13);
            this.lblRegiao.TabIndex = 49;
            this.lblRegiao.Text = "Região:";
            // 
            // txtComissao
            // 
            this.txtComissao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "COMISSAO", true));
            this.txtComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComissao.Location = new System.Drawing.Point(269, 58);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(82, 20);
            this.txtComissao.TabIndex = 5;
            // 
            // txtRg
            // 
            this.txtRg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "RG", true));
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(9, 59);
            this.txtRg.Mask = "99,999,999-9";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 20);
            this.txtRg.TabIndex = 3;
            this.txtRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "NOME", true));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(9, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(361, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblcomissao
            // 
            this.lblcomissao.AutoSize = true;
            this.lblcomissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomissao.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblcomissao.Location = new System.Drawing.Point(266, 42);
            this.lblcomissao.Name = "lblcomissao";
            this.lblcomissao.Size = new System.Drawing.Size(85, 13);
            this.lblcomissao.TabIndex = 27;
            this.lblcomissao.Text = "Comissão (%):";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblRG.Location = new System.Drawing.Point(6, 43);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(29, 13);
            this.lblRG.TabIndex = 24;
            this.lblRG.Text = "RG:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblCPF.Location = new System.Drawing.Point(373, 3);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 13);
            this.lblCPF.TabIndex = 23;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNome.Location = new System.Drawing.Point(6, 3);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome:";
            // 
            // tbCntrlVendedor
            // 
            this.tbCntrlVendedor.Controls.Add(this.tabPage2);
            this.tbCntrlVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlVendedor.Location = new System.Drawing.Point(12, 41);
            this.tbCntrlVendedor.Multiline = true;
            this.tbCntrlVendedor.Name = "tbCntrlVendedor";
            this.tbCntrlVendedor.SelectedIndex = 0;
            this.tbCntrlVendedor.Size = new System.Drawing.Size(571, 410);
            this.tbCntrlVendedor.TabIndex = 0;
            // 
            // vENDEDORTableAdapter
            // 
            this.vENDEDORTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.REGIAOTableAdapter = this.rEGIAOTableAdapter;
            this.tableAdapterManager.TRANSPORTADORATableAdapter = null;
            this.tableAdapterManager.TRANSPORTADORAVIATableAdapter = null;
            this.tableAdapterManager.UNIDADEMEDIDATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            this.tableAdapterManager.VENDEDORTableAdapter = this.vENDEDORTableAdapter;
            this.tableAdapterManager.VIATRANSPORTETableAdapter = null;
            // 
            // rEGIAOTableAdapter
            // 
            this.rEGIAOTableAdapter.ClearBeforeFill = true;
            // 
            // cnsltTlStrpConsulta
            // 
            this.cnsltTlStrpConsulta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cpfToolStripLabel,
            this.cpfToolStripTextBox,
            this.nomeToolStripLabel,
            this.nomeToolStripTextBox,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton2});
            this.cnsltTlStrpConsulta.Location = new System.Drawing.Point(0, 0);
            this.cnsltTlStrpConsulta.Name = "cnsltTlStrpConsulta";
            this.cnsltTlStrpConsulta.Size = new System.Drawing.Size(595, 25);
            this.cnsltTlStrpConsulta.TabIndex = 1;
            this.cnsltTlStrpConsulta.Text = "consultaToolStrip";
            this.cnsltTlStrpConsulta.Visible = false;
            // 
            // cpfToolStripLabel
            // 
            this.cpfToolStripLabel.Name = "cpfToolStripLabel";
            this.cpfToolStripLabel.Size = new System.Drawing.Size(30, 22);
            this.cpfToolStripLabel.Text = "CPF:";
            // 
            // cpfToolStripTextBox
            // 
            this.cpfToolStripTextBox.MaxLength = 11;
            this.cpfToolStripTextBox.Name = "cpfToolStripTextBox";
            this.cpfToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // nomeToolStripLabel
            // 
            this.nomeToolStripLabel.Name = "nomeToolStripLabel";
            this.nomeToolStripLabel.Size = new System.Drawing.Size(38, 22);
            this.nomeToolStripLabel.Text = "Nome:";
            // 
            // nomeToolStripTextBox
            // 
            this.nomeToolStripTextBox.Name = "nomeToolStripTextBox";
            this.nomeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Pesquisar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Limpar";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Cancelar";
            this.toolStripButton2.ToolTipText = "Cancelar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // FrmCadVen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(595, 463);
            this.ControlBox = false;
            this.Controls.Add(this.cnsltTlStrpConsulta);
            this.Controls.Add(this.tbCntrlVendedor);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadVen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de vendedor";
            this.Load += new System.EventHandler(this.FrmCadVen_Load);
            this.Shown += new System.EventHandler(this.FrmCadVen_Shown);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGIAOBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBxUsuario.ResumeLayout(false);
            this.grpBxUsuario.PerformLayout();
            this.grpBxContato.ResumeLayout(false);
            this.grpBxContato.PerformLayout();
            this.tbCntrlVendedor.ResumeLayout(false);
            this.cnsltTlStrpConsulta.ResumeLayout(false);
            this.cnsltTlStrpConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tbCntrlVendedor;
        private System.Windows.Forms.Label lblcomissao;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.MaskedTextBox txtComissao;
        private System.Windows.Forms.GroupBox grpBxContato;
        private System.Windows.Forms.MaskedTextBox txtFax;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label LblMunicipio;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.GroupBox grpBxUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblRegiao;
        private System.Windows.Forms.Label label1;
        private TextButton txtcep;
        private System.Windows.Forms.ComboBox cmbUfCli;
        private System.Windows.Forms.Label lblUfCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.TextBox txtUsu;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource vENDEDORBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.VENDEDORTableAdapter vENDEDORTableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmBxRegiao;
        private Comercial.COMERCIALDataSetTableAdapters.REGIAOTableAdapter rEGIAOTableAdapter;
        private System.Windows.Forms.BindingSource rEGIAOBindingSource;
        private System.Windows.Forms.ToolStripLabel cpfToolStripLabel;
        private System.Windows.Forms.ToolStripLabel nomeToolStripLabel;
        public System.Windows.Forms.ToolStrip cnsltTlStrpConsulta;
        public System.Windows.Forms.ToolStripTextBox cpfToolStripTextBox;
        public System.Windows.Forms.ToolStripTextBox nomeToolStripTextBox;
        public System.Windows.Forms.ToolStripButton toolStripButton1;
        public System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cOMPLEMENTOTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.MaskedTextBox txtCPF;
    }
}