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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.vENDEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmBxRegiao = new System.Windows.Forms.ComboBox();
            this.rEGIAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtCnpjCli = new System.Windows.Forms.MaskedTextBox();
            this.grpBxUsuario = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.grpBxContato = new System.Windows.Forms.GroupBox();
            this.cmbUfCli = new System.Windows.Forms.ComboBox();
            this.lblUfCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcep = new Comercial.TextButton();
            this.textBox10 = new System.Windows.Forms.TextBox();
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
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGIAOBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpBxUsuario.SuspendLayout();
            this.grpBxContato.SuspendLayout();
            this.tbCntrlVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.cmBxRegiao);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.txtCnpjCli);
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
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(508, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro de vendedor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // vENDEDORBindingSource
            // 
            this.vENDEDORBindingSource.DataSource = typeof(Comercial.VENDEDOR);
            this.vENDEDORBindingSource.PositionChanged += new System.EventHandler(this.vENDEDORBindingSource_PositionChanged);
            // 
            // cmBxRegiao
            // 
            this.cmBxRegiao.DataSource = this.rEGIAOBindingSource;
            this.cmBxRegiao.DisplayMember = "DESCRICAO";
            this.cmBxRegiao.FormattingEnabled = true;
            this.cmBxRegiao.Location = new System.Drawing.Point(118, 58);
            this.cmBxRegiao.Name = "cmBxRegiao";
            this.cmBxRegiao.Size = new System.Drawing.Size(115, 21);
            this.cmBxRegiao.TabIndex = 54;
            this.cmBxRegiao.ValueMember = "CODREGIAO";
            // 
            // rEGIAOBindingSource
            // 
            this.rEGIAOBindingSource.DataSource = typeof(Comercial.REGIAO);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(327, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 38);
            this.groupBox1.TabIndex = 52;
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
            this.radioButton2.Text = "Feminino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.CadetBlue;
            this.radioButton1.Location = new System.Drawing.Point(8, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtCnpjCli
            // 
            this.txtCnpjCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "CPF", true));
            this.txtCnpjCli.Location = new System.Drawing.Point(376, 19);
            this.txtCnpjCli.Mask = "999,999,999-99";
            this.txtCnpjCli.Name = "txtCnpjCli";
            this.txtCnpjCli.PromptChar = ' ';
            this.txtCnpjCli.Size = new System.Drawing.Size(123, 20);
            this.txtCnpjCli.TabIndex = 51;
            this.txtCnpjCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // grpBxUsuario
            // 
            this.grpBxUsuario.Controls.Add(this.txtSenha);
            this.grpBxUsuario.Controls.Add(this.txtUsu);
            this.grpBxUsuario.Controls.Add(this.lblSenha);
            this.grpBxUsuario.Controls.Add(this.lblUsuario);
            this.grpBxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxUsuario.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxUsuario.Location = new System.Drawing.Point(315, 241);
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
            this.grpBxContato.Controls.Add(this.cmbUfCli);
            this.grpBxContato.Controls.Add(this.lblUfCliente);
            this.grpBxContato.Controls.Add(this.label1);
            this.grpBxContato.Controls.Add(this.txtcep);
            this.grpBxContato.Controls.Add(this.textBox10);
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
            this.grpBxContato.Size = new System.Drawing.Size(492, 150);
            this.grpBxContato.TabIndex = 47;
            this.grpBxContato.TabStop = false;
            this.grpBxContato.Text = "Contato";
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
            this.cmbUfCli.Location = new System.Drawing.Point(356, 75);
            this.cmbUfCli.Name = "cmbUfCli";
            this.cmbUfCli.Size = new System.Drawing.Size(121, 21);
            this.cmbUfCli.TabIndex = 66;
            this.cmbUfCli.Text = "Selecione...";
            // 
            // lblUfCliente
            // 
            this.lblUfCliente.AutoSize = true;
            this.lblUfCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUfCliente.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblUfCliente.Location = new System.Drawing.Point(353, 59);
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
            this.txtcep.getText = "";
            this.txtcep.Image = global::Comercial.Properties.Resources.btn_correios;
            this.txtcep.Location = new System.Drawing.Point(10, 32);
            this.txtcep.Name = "txtcep";
            this.txtcep.ShowButton = false;
            this.txtcep.Size = new System.Drawing.Size(127, 25);
            this.txtcep.TabIndex = 64;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "EMAIL", true));
            this.textBox10.Location = new System.Drawing.Point(222, 118);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(255, 20);
            this.textBox10.TabIndex = 63;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblemail.Location = new System.Drawing.Point(220, 102);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(38, 13);
            this.lblemail.TabIndex = 62;
            this.lblemail.Text = "E-mail:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "ENDERECO", true));
            this.txtEndereco.Location = new System.Drawing.Point(143, 32);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(334, 20);
            this.txtEndereco.TabIndex = 61;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblEndereco.Location = new System.Drawing.Point(140, 16);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(65, 13);
            this.lblEndereco.TabIndex = 60;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtFax
            // 
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "FAX", true));
            this.txtFax.Location = new System.Drawing.Point(116, 118);
            this.txtFax.Mask = "(99)9999-9999";
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 58;
            this.txtFax.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefone
            // 
            this.txtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "TELEFONE", true));
            this.txtTelefone.Location = new System.Drawing.Point(10, 118);
            this.txtTelefone.Mask = "(99)9999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 57;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "MUNICIPIO", true));
            this.txtMunicipio.Location = new System.Drawing.Point(170, 75);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(180, 20);
            this.txtMunicipio.TabIndex = 55;
            // 
            // txtBairro
            // 
            this.txtBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "BAIRRO", true));
            this.txtBairro.Location = new System.Drawing.Point(9, 76);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(155, 20);
            this.txtBairro.TabIndex = 54;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFax.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblFax.Location = new System.Drawing.Point(116, 102);
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
            this.LblMunicipio.Location = new System.Drawing.Point(167, 60);
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
            this.lblRegiao.Location = new System.Drawing.Point(115, 43);
            this.lblRegiao.Name = "lblRegiao";
            this.lblRegiao.Size = new System.Drawing.Size(51, 13);
            this.lblRegiao.TabIndex = 49;
            this.lblRegiao.Text = "Região:";
            // 
            // txtComissao
            // 
            this.txtComissao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "COMISSAO", true));
            this.txtComissao.Location = new System.Drawing.Point(239, 59);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(82, 20);
            this.txtComissao.TabIndex = 45;
            // 
            // txtRg
            // 
            this.txtRg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "RG", true));
            this.txtRg.Location = new System.Drawing.Point(9, 59);
            this.txtRg.Mask = "99,999,999-9";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 20);
            this.txtRg.TabIndex = 44;
            this.txtRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORBindingSource, "NOME", true));
            this.txtNome.Location = new System.Drawing.Point(9, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(361, 20);
            this.txtNome.TabIndex = 28;
            // 
            // lblcomissao
            // 
            this.lblcomissao.AutoSize = true;
            this.lblcomissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomissao.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblcomissao.Location = new System.Drawing.Point(236, 43);
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
            this.tbCntrlVendedor.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlVendedor.Multiline = true;
            this.tbCntrlVendedor.Name = "tbCntrlVendedor";
            this.tbCntrlVendedor.SelectedIndex = 0;
            this.tbCntrlVendedor.Size = new System.Drawing.Size(516, 398);
            this.tbCntrlVendedor.TabIndex = 0;
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataSource = typeof(Comercial.USUARIO);
            // 
            // FrmCadVen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(537, 420);
            this.Controls.Add(this.tbCntrlVendedor);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadVen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de vendedor";
            this.Load += new System.EventHandler(this.FrmCadVen_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGIAOBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBxUsuario.ResumeLayout(false);
            this.grpBxUsuario.PerformLayout();
            this.grpBxContato.ResumeLayout(false);
            this.grpBxContato.PerformLayout();
            this.tbCntrlVendedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.GroupBox grpBxUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblRegiao;
        private System.Windows.Forms.MaskedTextBox txtCnpjCli;
        private System.Windows.Forms.Label label1;
        private TextButton txtcep;
        private System.Windows.Forms.ComboBox cmbUfCli;
        private System.Windows.Forms.Label lblUfCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cmBxRegiao;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.BindingSource vENDEDORBindingSource;
        private System.Windows.Forms.BindingSource rEGIAOBindingSource;
    }
}