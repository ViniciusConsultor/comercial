namespace Comercial
{
    partial class FrmCadTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadTra));
            this.TbCntCadTra = new System.Windows.Forms.TabControl();
            this.TbPgCadTra = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpBxViaTrans = new System.Windows.Forms.GroupBox();
            this.chkTerrestre = new System.Windows.Forms.CheckBox();
            this.chkMaritimo = new System.Windows.Forms.CheckBox();
            this.chkFerroviario = new System.Windows.Forms.CheckBox();
            this.chkAereo = new System.Windows.Forms.CheckBox();
            this.txtIeCli = new System.Windows.Forms.MaskedTextBox();
            this.gpbContatotrans = new System.Windows.Forms.GroupBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.cOMPLEMENTOTextBox = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.NumTrans = new System.Windows.Forms.TextBox();
            this.uFComboBox = new System.Windows.Forms.ComboBox();
            this.lblCeptrans = new System.Windows.Forms.Label();
            this.txtTeltrans = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailtrans = new System.Windows.Forms.TextBox();
            this.lblEmailtrans = new System.Windows.Forms.Label();
            this.lblTelefonetrans = new System.Windows.Forms.Label();
            this.lblUftrans = new System.Windows.Forms.Label();
            this.txtMunicipiotrans = new System.Windows.Forms.TextBox();
            this.lblMunicipiotrans = new System.Windows.Forms.Label();
            this.txtBairrotrans = new System.Windows.Forms.TextBox();
            this.txtEndtrans = new System.Windows.Forms.TextBox();
            this.lblBairrotrans = new System.Windows.Forms.Label();
            this.lblEnderecotrans = new System.Windows.Forms.Label();
            this.lblIECliente = new System.Windows.Forms.Label();
            this.txtCnpjTrans = new System.Windows.Forms.MaskedTextBox();
            this.lblCnpjCliente = new System.Windows.Forms.Label();
            this.TxtNomRed = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.LblNomRed = new System.Windows.Forms.Label();
            this.LblNom = new System.Windows.Forms.Label();
            this.consultaTransportadoraToolStrip = new System.Windows.Forms.ToolStrip();
            this.cNPJToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.cNPJToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nomeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nomeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.consultaTransportadoraToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tRANSPORTADORABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.tRANSPORTADORATableAdapter = new Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORATableAdapter();
            this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
            this.tRANSPORTADORAVIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRANSPORTADORAVIATableAdapter = new Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter();
            this.txtCepTrans = new Comercial.TextButton();
            this.TbCntCadTra.SuspendLayout();
            this.TbPgCadTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpBxViaTrans.SuspendLayout();
            this.gpbContatotrans.SuspendLayout();
            this.consultaTransportadoraToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTADORABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTADORAVIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TbCntCadTra
            // 
            this.TbCntCadTra.Controls.Add(this.TbPgCadTra);
            this.TbCntCadTra.Location = new System.Drawing.Point(12, 32);
            this.TbCntCadTra.Name = "TbCntCadTra";
            this.TbCntCadTra.SelectedIndex = 0;
            this.TbCntCadTra.Size = new System.Drawing.Size(596, 346);
            this.TbCntCadTra.TabIndex = 0;
            // 
            // TbPgCadTra
            // 
            this.TbPgCadTra.AutoScroll = true;
            this.TbPgCadTra.Controls.Add(this.pictureBox1);
            this.TbPgCadTra.Controls.Add(this.pictureBox2);
            this.TbPgCadTra.Controls.Add(this.grpBxViaTrans);
            this.TbPgCadTra.Controls.Add(this.txtIeCli);
            this.TbPgCadTra.Controls.Add(this.gpbContatotrans);
            this.TbPgCadTra.Controls.Add(this.lblIECliente);
            this.TbPgCadTra.Controls.Add(this.txtCnpjTrans);
            this.TbPgCadTra.Controls.Add(this.lblCnpjCliente);
            this.TbPgCadTra.Controls.Add(this.TxtNomRed);
            this.TbPgCadTra.Controls.Add(this.TxtNom);
            this.TbPgCadTra.Controls.Add(this.LblNomRed);
            this.TbPgCadTra.Controls.Add(this.LblNom);
            this.TbPgCadTra.Location = new System.Drawing.Point(4, 22);
            this.TbPgCadTra.Name = "TbPgCadTra";
            this.TbPgCadTra.Padding = new System.Windows.Forms.Padding(3);
            this.TbPgCadTra.Size = new System.Drawing.Size(588, 320);
            this.TbPgCadTra.TabIndex = 0;
            this.TbPgCadTra.Text = "Cadastro Transportadora";
            this.TbPgCadTra.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Comercial.Properties.Resources.errado;
            this.pictureBox1.Location = new System.Drawing.Point(135, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Comercial.Properties.Resources.certo;
            this.pictureBox2.Location = new System.Drawing.Point(135, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // grpBxViaTrans
            // 
            this.grpBxViaTrans.Controls.Add(this.chkTerrestre);
            this.grpBxViaTrans.Controls.Add(this.chkMaritimo);
            this.grpBxViaTrans.Controls.Add(this.chkFerroviario);
            this.grpBxViaTrans.Controls.Add(this.chkAereo);
            this.grpBxViaTrans.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxViaTrans.Location = new System.Drawing.Point(414, 6);
            this.grpBxViaTrans.Name = "grpBxViaTrans";
            this.grpBxViaTrans.Size = new System.Drawing.Size(134, 94);
            this.grpBxViaTrans.TabIndex = 78;
            this.grpBxViaTrans.TabStop = false;
            this.grpBxViaTrans.Text = "Via Transporte";
            // 
            // chkTerrestre
            // 
            this.chkTerrestre.AutoSize = true;
            this.chkTerrestre.Location = new System.Drawing.Point(7, 70);
            this.chkTerrestre.Name = "chkTerrestre";
            this.chkTerrestre.Size = new System.Drawing.Size(77, 17);
            this.chkTerrestre.TabIndex = 8;
            this.chkTerrestre.Text = "Terrestre";
            this.chkTerrestre.UseVisualStyleBackColor = true;
            // 
            // chkMaritimo
            // 
            this.chkMaritimo.AutoSize = true;
            this.chkMaritimo.Location = new System.Drawing.Point(7, 52);
            this.chkMaritimo.Name = "chkMaritimo";
            this.chkMaritimo.Size = new System.Drawing.Size(73, 17);
            this.chkMaritimo.TabIndex = 7;
            this.chkMaritimo.Text = "Maritimo";
            this.chkMaritimo.UseVisualStyleBackColor = true;
            // 
            // chkFerroviario
            // 
            this.chkFerroviario.AutoSize = true;
            this.chkFerroviario.Location = new System.Drawing.Point(7, 36);
            this.chkFerroviario.Name = "chkFerroviario";
            this.chkFerroviario.Size = new System.Drawing.Size(86, 17);
            this.chkFerroviario.TabIndex = 6;
            this.chkFerroviario.Text = "Ferroviário";
            this.chkFerroviario.UseVisualStyleBackColor = true;
            // 
            // chkAereo
            // 
            this.chkAereo.AutoSize = true;
            this.chkAereo.Location = new System.Drawing.Point(7, 20);
            this.chkAereo.Name = "chkAereo";
            this.chkAereo.Size = new System.Drawing.Size(59, 17);
            this.chkAereo.TabIndex = 5;
            this.chkAereo.Text = "Aéreo";
            this.chkAereo.UseVisualStyleBackColor = true;
            // 
            // txtIeCli
            // 
            this.txtIeCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "IE", true));
            this.txtIeCli.Location = new System.Drawing.Point(182, 99);
            this.txtIeCli.Mask = "999,999,999,99";
            this.txtIeCli.Name = "txtIeCli";
            this.txtIeCli.PromptChar = ' ';
            this.txtIeCli.Size = new System.Drawing.Size(131, 20);
            this.txtIeCli.TabIndex = 4;
            this.txtIeCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // gpbContatotrans
            // 
            this.gpbContatotrans.Controls.Add(this.txtCepTrans);
            this.gpbContatotrans.Controls.Add(this.lblComplemento);
            this.gpbContatotrans.Controls.Add(this.cOMPLEMENTOTextBox);
            this.gpbContatotrans.Controls.Add(this.lblNumero);
            this.gpbContatotrans.Controls.Add(this.NumTrans);
            this.gpbContatotrans.Controls.Add(this.uFComboBox);
            this.gpbContatotrans.Controls.Add(this.lblCeptrans);
            this.gpbContatotrans.Controls.Add(this.txtTeltrans);
            this.gpbContatotrans.Controls.Add(this.txtEmailtrans);
            this.gpbContatotrans.Controls.Add(this.lblEmailtrans);
            this.gpbContatotrans.Controls.Add(this.lblTelefonetrans);
            this.gpbContatotrans.Controls.Add(this.lblUftrans);
            this.gpbContatotrans.Controls.Add(this.txtMunicipiotrans);
            this.gpbContatotrans.Controls.Add(this.lblMunicipiotrans);
            this.gpbContatotrans.Controls.Add(this.txtBairrotrans);
            this.gpbContatotrans.Controls.Add(this.txtEndtrans);
            this.gpbContatotrans.Controls.Add(this.lblBairrotrans);
            this.gpbContatotrans.Controls.Add(this.lblEnderecotrans);
            this.gpbContatotrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbContatotrans.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gpbContatotrans.Location = new System.Drawing.Point(6, 136);
            this.gpbContatotrans.Name = "gpbContatotrans";
            this.gpbContatotrans.Size = new System.Drawing.Size(556, 163);
            this.gpbContatotrans.TabIndex = 73;
            this.gpbContatotrans.TabStop = false;
            this.gpbContatotrans.Text = "Contato";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblComplemento.Location = new System.Drawing.Point(6, 65);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(82, 13);
            this.lblComplemento.TabIndex = 50;
            this.lblComplemento.Text = "Complemento";
            // 
            // cOMPLEMENTOTextBox
            // 
            this.cOMPLEMENTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "COMPLEMENTO", true));
            this.cOMPLEMENTOTextBox.Location = new System.Drawing.Point(6, 81);
            this.cOMPLEMENTOTextBox.Name = "cOMPLEMENTOTextBox";
            this.cOMPLEMENTOTextBox.Size = new System.Drawing.Size(115, 20);
            this.cOMPLEMENTOTextBox.TabIndex = 12;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNumero.Location = new System.Drawing.Point(477, 26);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(50, 13);
            this.lblNumero.TabIndex = 48;
            this.lblNumero.Text = "Numero";
            // 
            // NumTrans
            // 
            this.NumTrans.AcceptsReturn = true;
            this.NumTrans.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "NUM", true));
            this.NumTrans.Location = new System.Drawing.Point(480, 42);
            this.NumTrans.Name = "NumTrans";
            this.NumTrans.Size = new System.Drawing.Size(56, 20);
            this.NumTrans.TabIndex = 11;
            this.NumTrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumTrans_KeyPress);
            // 
            // uFComboBox
            // 
            this.uFComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "UF", true));
            this.uFComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tRANSPORTADORABindingSource, "UF", true));
            this.uFComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tRANSPORTADORABindingSource, "UF", true));
            this.uFComboBox.FormattingEnabled = true;
            this.uFComboBox.Items.AddRange(new object[] {
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
            this.uFComboBox.Location = new System.Drawing.Point(411, 83);
            this.uFComboBox.Name = "uFComboBox";
            this.uFComboBox.Size = new System.Drawing.Size(121, 21);
            this.uFComboBox.TabIndex = 15;
            // 
            // lblCeptrans
            // 
            this.lblCeptrans.AutoSize = true;
            this.lblCeptrans.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblCeptrans.Location = new System.Drawing.Point(1, 26);
            this.lblCeptrans.Name = "lblCeptrans";
            this.lblCeptrans.Size = new System.Drawing.Size(29, 13);
            this.lblCeptrans.TabIndex = 44;
            this.lblCeptrans.Text = "Cep";
            // 
            // txtTeltrans
            // 
            this.txtTeltrans.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "TELEFONE", true));
            this.txtTeltrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeltrans.Location = new System.Drawing.Point(9, 120);
            this.txtTeltrans.Mask = "(99) 9999-9999";
            this.txtTeltrans.Name = "txtTeltrans";
            this.txtTeltrans.Size = new System.Drawing.Size(89, 20);
            this.txtTeltrans.TabIndex = 16;
            this.txtTeltrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTeltrans.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmailtrans
            // 
            this.txtEmailtrans.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "EMAIL", true));
            this.txtEmailtrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailtrans.Location = new System.Drawing.Point(104, 122);
            this.txtEmailtrans.Name = "txtEmailtrans";
            this.txtEmailtrans.Size = new System.Drawing.Size(430, 20);
            this.txtEmailtrans.TabIndex = 17;
            this.txtEmailtrans.TextChanged += new System.EventHandler(this.txtEmailtrans_TextChanged);
            // 
            // lblEmailtrans
            // 
            this.lblEmailtrans.AutoSize = true;
            this.lblEmailtrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailtrans.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblEmailtrans.Location = new System.Drawing.Point(104, 106);
            this.lblEmailtrans.Name = "lblEmailtrans";
            this.lblEmailtrans.Size = new System.Drawing.Size(42, 13);
            this.lblEmailtrans.TabIndex = 38;
            this.lblEmailtrans.Text = "E-Mail";
            // 
            // lblTelefonetrans
            // 
            this.lblTelefonetrans.AutoSize = true;
            this.lblTelefonetrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonetrans.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTelefonetrans.Location = new System.Drawing.Point(6, 104);
            this.lblTelefonetrans.Name = "lblTelefonetrans";
            this.lblTelefonetrans.Size = new System.Drawing.Size(57, 13);
            this.lblTelefonetrans.TabIndex = 37;
            this.lblTelefonetrans.Text = "Telefone";
            // 
            // lblUftrans
            // 
            this.lblUftrans.AutoSize = true;
            this.lblUftrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUftrans.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblUftrans.Location = new System.Drawing.Point(410, 67);
            this.lblUftrans.Name = "lblUftrans";
            this.lblUftrans.Size = new System.Drawing.Size(23, 13);
            this.lblUftrans.TabIndex = 34;
            this.lblUftrans.Text = "UF";
            // 
            // txtMunicipiotrans
            // 
            this.txtMunicipiotrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMunicipiotrans.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "MUNICIPIO", true));
            this.txtMunicipiotrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipiotrans.Location = new System.Drawing.Point(254, 83);
            this.txtMunicipiotrans.Name = "txtMunicipiotrans";
            this.txtMunicipiotrans.Size = new System.Drawing.Size(151, 20);
            this.txtMunicipiotrans.TabIndex = 14;
            // 
            // lblMunicipiotrans
            // 
            this.lblMunicipiotrans.AutoSize = true;
            this.lblMunicipiotrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipiotrans.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblMunicipiotrans.Location = new System.Drawing.Point(251, 67);
            this.lblMunicipiotrans.Name = "lblMunicipiotrans";
            this.lblMunicipiotrans.Size = new System.Drawing.Size(60, 13);
            this.lblMunicipiotrans.TabIndex = 30;
            this.lblMunicipiotrans.Text = "Municípo";
            // 
            // txtBairrotrans
            // 
            this.txtBairrotrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairrotrans.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "BAIRRO", true));
            this.txtBairrotrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairrotrans.Location = new System.Drawing.Point(127, 82);
            this.txtBairrotrans.Name = "txtBairrotrans";
            this.txtBairrotrans.Size = new System.Drawing.Size(121, 20);
            this.txtBairrotrans.TabIndex = 13;
            // 
            // txtEndtrans
            // 
            this.txtEndtrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndtrans.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "ENDERECO", true));
            this.txtEndtrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndtrans.Location = new System.Drawing.Point(126, 42);
            this.txtEndtrans.Name = "txtEndtrans";
            this.txtEndtrans.Size = new System.Drawing.Size(348, 20);
            this.txtEndtrans.TabIndex = 10;
            // 
            // lblBairrotrans
            // 
            this.lblBairrotrans.AutoSize = true;
            this.lblBairrotrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairrotrans.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblBairrotrans.Location = new System.Drawing.Point(124, 66);
            this.lblBairrotrans.Name = "lblBairrotrans";
            this.lblBairrotrans.Size = new System.Drawing.Size(34, 13);
            this.lblBairrotrans.TabIndex = 27;
            this.lblBairrotrans.Text = "Bairro";
            // 
            // lblEnderecotrans
            // 
            this.lblEnderecotrans.AutoSize = true;
            this.lblEnderecotrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecotrans.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblEnderecotrans.Location = new System.Drawing.Point(123, 26);
            this.lblEnderecotrans.Name = "lblEnderecotrans";
            this.lblEnderecotrans.Size = new System.Drawing.Size(61, 13);
            this.lblEnderecotrans.TabIndex = 26;
            this.lblEnderecotrans.Text = "Endereço";
            // 
            // lblIECliente
            // 
            this.lblIECliente.AutoSize = true;
            this.lblIECliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIECliente.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblIECliente.Location = new System.Drawing.Point(179, 83);
            this.lblIECliente.Name = "lblIECliente";
            this.lblIECliente.Size = new System.Drawing.Size(20, 13);
            this.lblIECliente.TabIndex = 74;
            this.lblIECliente.Text = "I.E";
            // 
            // txtCnpjTrans
            // 
            this.txtCnpjTrans.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "CNPJ", true));
            this.txtCnpjTrans.Location = new System.Drawing.Point(6, 99);
            this.txtCnpjTrans.Mask = "99,999,999/9999-99";
            this.txtCnpjTrans.Name = "txtCnpjTrans";
            this.txtCnpjTrans.PromptChar = ' ';
            this.txtCnpjTrans.Size = new System.Drawing.Size(123, 20);
            this.txtCnpjTrans.TabIndex = 3;
            this.txtCnpjTrans.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCnpjTrans.Leave += new System.EventHandler(this.txtCnpjTrans_Leave);
            // 
            // lblCnpjCliente
            // 
            this.lblCnpjCliente.AutoSize = true;
            this.lblCnpjCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpjCliente.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblCnpjCliente.Location = new System.Drawing.Point(9, 83);
            this.lblCnpjCliente.Name = "lblCnpjCliente";
            this.lblCnpjCliente.Size = new System.Drawing.Size(38, 13);
            this.lblCnpjCliente.TabIndex = 73;
            this.lblCnpjCliente.Text = "CNPJ";
            // 
            // TxtNomRed
            // 
            this.TxtNomRed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "NOMEREDUZIDO", true));
            this.TxtNomRed.Location = new System.Drawing.Point(6, 58);
            this.TxtNomRed.Name = "TxtNomRed";
            this.TxtNomRed.Size = new System.Drawing.Size(402, 20);
            this.TxtNomRed.TabIndex = 2;
            // 
            // TxtNom
            // 
            this.TxtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "NOME", true));
            this.TxtNom.Location = new System.Drawing.Point(6, 19);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(402, 20);
            this.TxtNom.TabIndex = 1;
            this.TxtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged);
            // 
            // LblNomRed
            // 
            this.LblNomRed.AutoSize = true;
            this.LblNomRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomRed.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblNomRed.Location = new System.Drawing.Point(7, 42);
            this.LblNomRed.Name = "LblNomRed";
            this.LblNomRed.Size = new System.Drawing.Size(78, 13);
            this.LblNomRed.TabIndex = 50;
            this.LblNomRed.Text = "Nome Fantasia";
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNom.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblNom.Location = new System.Drawing.Point(3, 3);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(82, 13);
            this.LblNom.TabIndex = 1;
            this.LblNom.Text = "Razão Social";
            // 
            // consultaTransportadoraToolStrip
            // 
            this.consultaTransportadoraToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cNPJToolStripLabel,
            this.cNPJToolStripTextBox,
            this.nomeToolStripLabel,
            this.nomeToolStripTextBox,
            this.consultaTransportadoraToolStripButton,
            this.toolStripButton3,
            this.toolStripButton2});
            this.consultaTransportadoraToolStrip.Location = new System.Drawing.Point(0, 0);
            this.consultaTransportadoraToolStrip.Name = "consultaTransportadoraToolStrip";
            this.consultaTransportadoraToolStrip.Size = new System.Drawing.Size(628, 25);
            this.consultaTransportadoraToolStrip.TabIndex = 1;
            this.consultaTransportadoraToolStrip.Text = "consultaTransportadoraToolStrip";
            this.consultaTransportadoraToolStrip.Visible = false;
            // 
            // cNPJToolStripLabel
            // 
            this.cNPJToolStripLabel.Name = "cNPJToolStripLabel";
            this.cNPJToolStripLabel.Size = new System.Drawing.Size(38, 22);
            this.cNPJToolStripLabel.Text = "CNPJ:";
            // 
            // cNPJToolStripTextBox
            // 
            this.cNPJToolStripTextBox.Name = "cNPJToolStripTextBox";
            this.cNPJToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // nomeToolStripLabel
            // 
            this.nomeToolStripLabel.Name = "nomeToolStripLabel";
            this.nomeToolStripLabel.Size = new System.Drawing.Size(43, 22);
            this.nomeToolStripLabel.Text = "Nome:";
            // 
            // nomeToolStripTextBox
            // 
            this.nomeToolStripTextBox.Name = "nomeToolStripTextBox";
            this.nomeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // consultaTransportadoraToolStripButton
            // 
            this.consultaTransportadoraToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultaTransportadoraToolStripButton.Image = global::Comercial.Properties.Resources.search1;
            this.consultaTransportadoraToolStripButton.Name = "consultaTransportadoraToolStripButton";
            this.consultaTransportadoraToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.consultaTransportadoraToolStripButton.Text = "ConsultaTransportadora";
            this.consultaTransportadoraToolStripButton.Click += new System.EventHandler(this.consultaTransportadoraToolStripButton_Click);
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
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // tRANSPORTADORABindingSource
            // 
            this.tRANSPORTADORABindingSource.DataMember = "TRANSPORTADORA";
            this.tRANSPORTADORABindingSource.DataSource = this.cOMERCIALDataSet;
            this.tRANSPORTADORABindingSource.PositionChanged += new System.EventHandler(this.tRANSPORTADORABindingSource_PositionChanged_1);
            // 
            // cOMERCIALDataSet
            // 
            this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
            this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRANSPORTADORATableAdapter
            // 
            this.tRANSPORTADORATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.ATUCUBOTableAdapter = null;
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
            this.tableAdapterManager.TRANSPORTADORATableAdapter = this.tRANSPORTADORATableAdapter;
            this.tableAdapterManager.TRANSPORTADORAVIATableAdapter = null;
            this.tableAdapterManager.UNIDADEMEDIDATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            this.tableAdapterManager.VENDEDORTableAdapter = null;
            this.tableAdapterManager.VIATRANSPORTETableAdapter = null;
            // 
            // tRANSPORTADORAVIABindingSource
            // 
            this.tRANSPORTADORAVIABindingSource.DataMember = "TRANSPORTADORAVIA";
            this.tRANSPORTADORAVIABindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // tRANSPORTADORAVIATableAdapter
            // 
            this.tRANSPORTADORAVIATableAdapter.ClearBeforeFill = true;
            // 
            // txtCepTrans
            // 
            this.txtCepTrans.getText = "";
            this.txtCepTrans.Image = null;
            this.txtCepTrans.Location = new System.Drawing.Point(6, 42);
            this.txtCepTrans.Name = "txtCepTrans";
            this.txtCepTrans.ShowButton = false;
            this.txtCepTrans.Size = new System.Drawing.Size(117, 25);
            this.txtCepTrans.TabIndex = 51;
            this.txtCepTrans.ButtonClick += new System.EventHandler(this.txtCepTrans_ButtonClick_1);
            // 
            // FrmCadTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(628, 398);
            this.ControlBox = false;
            this.Controls.Add(this.consultaTransportadoraToolStrip);
            this.Controls.Add(this.TbCntCadTra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadTra";
            this.ShowIcon = false;
            this.Text = "Cadastro Transportadora";
            this.Load += new System.EventHandler(this.FrmCadTra_Load);
            this.Shown += new System.EventHandler(this.FrmCadTra_Shown);
            this.TbCntCadTra.ResumeLayout(false);
            this.TbPgCadTra.ResumeLayout(false);
            this.TbPgCadTra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpBxViaTrans.ResumeLayout(false);
            this.grpBxViaTrans.PerformLayout();
            this.gpbContatotrans.ResumeLayout(false);
            this.gpbContatotrans.PerformLayout();
            this.consultaTransportadoraToolStrip.ResumeLayout(false);
            this.consultaTransportadoraToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTADORABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTADORAVIABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TbCntCadTra;
        private System.Windows.Forms.TabPage TbPgCadTra;
        private System.Windows.Forms.TextBox TxtNomRed;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label LblNomRed;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.GroupBox gpbContatotrans;
        private System.Windows.Forms.Label lblCeptrans;
        private System.Windows.Forms.MaskedTextBox txtTeltrans;
        private System.Windows.Forms.TextBox txtEmailtrans;
        private System.Windows.Forms.Label lblEmailtrans;
        private System.Windows.Forms.Label lblTelefonetrans;
        private System.Windows.Forms.Label lblUftrans;
        private System.Windows.Forms.TextBox txtMunicipiotrans;
        private System.Windows.Forms.Label lblMunicipiotrans;
        private System.Windows.Forms.TextBox txtBairrotrans;
        private System.Windows.Forms.TextBox txtEndtrans;
        private System.Windows.Forms.Label lblBairrotrans;
        private System.Windows.Forms.Label lblEnderecotrans;
        private System.Windows.Forms.MaskedTextBox txtIeCli;
        private System.Windows.Forms.Label lblIECliente;
        private System.Windows.Forms.MaskedTextBox txtCnpjTrans;
        private System.Windows.Forms.Label lblCnpjCliente;
        private System.Windows.Forms.GroupBox grpBxViaTrans;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource tRANSPORTADORABindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORATableAdapter tRANSPORTADORATableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox chkTerrestre;
        private System.Windows.Forms.CheckBox chkMaritimo;
        private System.Windows.Forms.CheckBox chkFerroviario;
        private System.Windows.Forms.CheckBox chkAereo;
        private System.Windows.Forms.ComboBox uFComboBox;
        private System.Windows.Forms.BindingSource tRANSPORTADORAVIABindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORAVIATableAdapter tRANSPORTADORAVIATableAdapter;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox cOMPLEMENTOTextBox;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox NumTrans;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripLabel cNPJToolStripLabel;
        private System.Windows.Forms.ToolStripLabel nomeToolStripLabel;
        public System.Windows.Forms.ToolStripButton toolStripButton3;
        public System.Windows.Forms.ToolStripButton toolStripButton2;
        public System.Windows.Forms.ToolStrip consultaTransportadoraToolStrip;
        public System.Windows.Forms.ToolStripTextBox cNPJToolStripTextBox;
        public System.Windows.Forms.ToolStripTextBox nomeToolStripTextBox;
        public System.Windows.Forms.ToolStripButton consultaTransportadoraToolStripButton;
        private TextButton txtCepTrans;

    }
}