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
            this.TbCntCadTra = new System.Windows.Forms.TabControl();
            this.TbPgCadTra = new System.Windows.Forms.TabPage();
            this.grpBxViaTrans = new System.Windows.Forms.GroupBox();
            this.chkltViatrans = new System.Windows.Forms.CheckedListBox();
            this.txtIeCli = new System.Windows.Forms.MaskedTextBox();
            this.gpbContatotrans = new System.Windows.Forms.GroupBox();
            this.lblCeptrans = new System.Windows.Forms.Label();
            this.txtTeltrans = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailtrans = new System.Windows.Forms.TextBox();
            this.lblEmailtrans = new System.Windows.Forms.Label();
            this.lblTelefonetrans = new System.Windows.Forms.Label();
            this.cmbUftrans = new System.Windows.Forms.ComboBox();
            this.lblUftrans = new System.Windows.Forms.Label();
            this.txtMunicipiotrans = new System.Windows.Forms.TextBox();
            this.lblMunicipiotrans = new System.Windows.Forms.Label();
            this.txtBairrotrans = new System.Windows.Forms.TextBox();
            this.txtEndtrans = new System.Windows.Forms.TextBox();
            this.lblBairrotrans = new System.Windows.Forms.Label();
            this.lblEnderecotrans = new System.Windows.Forms.Label();
            this.lblIECliente = new System.Windows.Forms.Label();
            this.txtCnpjCli = new System.Windows.Forms.MaskedTextBox();
            this.lblCnpjCliente = new System.Windows.Forms.Label();
            this.TxtNomRed = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.LblNomRed = new System.Windows.Forms.Label();
            this.LblNom = new System.Windows.Forms.Label();
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.tRANSPORTADORABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRANSPORTADORATableAdapter = new Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORATableAdapter();
            this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
            this.cEPTextBox = new System.Windows.Forms.TextBox();
            this.txtceptrans = new Comercial.TextButton();
            this.TbCntCadTra.SuspendLayout();
            this.TbPgCadTra.SuspendLayout();
            this.grpBxViaTrans.SuspendLayout();
            this.gpbContatotrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTADORABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TbCntCadTra
            // 
            this.TbCntCadTra.Controls.Add(this.TbPgCadTra);
            this.TbCntCadTra.Location = new System.Drawing.Point(12, 12);
            this.TbCntCadTra.Name = "TbCntCadTra";
            this.TbCntCadTra.SelectedIndex = 0;
            this.TbCntCadTra.Size = new System.Drawing.Size(544, 304);
            this.TbCntCadTra.TabIndex = 0;
            // 
            // TbPgCadTra
            // 
            this.TbPgCadTra.AutoScroll = true;
            this.TbPgCadTra.Controls.Add(this.grpBxViaTrans);
            this.TbPgCadTra.Controls.Add(this.txtIeCli);
            this.TbPgCadTra.Controls.Add(this.gpbContatotrans);
            this.TbPgCadTra.Controls.Add(this.lblIECliente);
            this.TbPgCadTra.Controls.Add(this.txtCnpjCli);
            this.TbPgCadTra.Controls.Add(this.lblCnpjCliente);
            this.TbPgCadTra.Controls.Add(this.TxtNomRed);
            this.TbPgCadTra.Controls.Add(this.TxtNom);
            this.TbPgCadTra.Controls.Add(this.LblNomRed);
            this.TbPgCadTra.Controls.Add(this.LblNom);
            this.TbPgCadTra.Location = new System.Drawing.Point(4, 22);
            this.TbPgCadTra.Name = "TbPgCadTra";
            this.TbPgCadTra.Padding = new System.Windows.Forms.Padding(3);
            this.TbPgCadTra.Size = new System.Drawing.Size(536, 278);
            this.TbPgCadTra.TabIndex = 0;
            this.TbPgCadTra.Text = "Cadastro Transportadora";
            this.TbPgCadTra.UseVisualStyleBackColor = true;
            this.TbPgCadTra.Click += new System.EventHandler(this.TbPgCadTra_Click);
            // 
            // grpBxViaTrans
            // 
            this.grpBxViaTrans.Controls.Add(this.chkltViatrans);
            this.grpBxViaTrans.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxViaTrans.Location = new System.Drawing.Point(392, 6);
            this.grpBxViaTrans.Name = "grpBxViaTrans";
            this.grpBxViaTrans.Size = new System.Drawing.Size(134, 94);
            this.grpBxViaTrans.TabIndex = 78;
            this.grpBxViaTrans.TabStop = false;
            this.grpBxViaTrans.Text = "Via Transporte";
            // 
            // chkltViatrans
            // 
            this.chkltViatrans.ForeColor = System.Drawing.Color.CadetBlue;
            this.chkltViatrans.FormattingEnabled = true;
            this.chkltViatrans.Items.AddRange(new object[] {
            "Aéreo",
            "Ferroviário",
            "Maritimo",
            "Terrestre"});
            this.chkltViatrans.Location = new System.Drawing.Point(8, 19);
            this.chkltViatrans.Name = "chkltViatrans";
            this.chkltViatrans.Size = new System.Drawing.Size(120, 64);
            this.chkltViatrans.TabIndex = 77;
            // 
            // txtIeCli
            // 
            this.txtIeCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "IE", true));
            this.txtIeCli.Location = new System.Drawing.Point(255, 58);
            this.txtIeCli.Mask = "999,999,999,999";
            this.txtIeCli.Name = "txtIeCli";
            this.txtIeCli.PromptChar = ' ';
            this.txtIeCli.Size = new System.Drawing.Size(131, 20);
            this.txtIeCli.TabIndex = 76;
            this.txtIeCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // gpbContatotrans
            // 
            this.gpbContatotrans.Controls.Add(this.cEPTextBox);
            this.gpbContatotrans.Controls.Add(this.lblCeptrans);
            this.gpbContatotrans.Controls.Add(this.txtceptrans);
            this.gpbContatotrans.Controls.Add(this.txtTeltrans);
            this.gpbContatotrans.Controls.Add(this.txtEmailtrans);
            this.gpbContatotrans.Controls.Add(this.lblEmailtrans);
            this.gpbContatotrans.Controls.Add(this.lblTelefonetrans);
            this.gpbContatotrans.Controls.Add(this.cmbUftrans);
            this.gpbContatotrans.Controls.Add(this.lblUftrans);
            this.gpbContatotrans.Controls.Add(this.txtMunicipiotrans);
            this.gpbContatotrans.Controls.Add(this.lblMunicipiotrans);
            this.gpbContatotrans.Controls.Add(this.txtBairrotrans);
            this.gpbContatotrans.Controls.Add(this.txtEndtrans);
            this.gpbContatotrans.Controls.Add(this.lblBairrotrans);
            this.gpbContatotrans.Controls.Add(this.lblEnderecotrans);
            this.gpbContatotrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbContatotrans.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gpbContatotrans.Location = new System.Drawing.Point(6, 106);
            this.gpbContatotrans.Name = "gpbContatotrans";
            this.gpbContatotrans.Size = new System.Drawing.Size(520, 163);
            this.gpbContatotrans.TabIndex = 73;
            this.gpbContatotrans.TabStop = false;
            this.gpbContatotrans.Text = "Contato";
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
            this.txtTeltrans.Location = new System.Drawing.Point(6, 121);
            this.txtTeltrans.Mask = "(99) 9999-9999";
            this.txtTeltrans.Name = "txtTeltrans";
            this.txtTeltrans.Size = new System.Drawing.Size(89, 20);
            this.txtTeltrans.TabIndex = 28;
            this.txtTeltrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTeltrans.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmailtrans
            // 
            this.txtEmailtrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmailtrans.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "EMAIL", true));
            this.txtEmailtrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailtrans.Location = new System.Drawing.Point(101, 121);
            this.txtEmailtrans.Name = "txtEmailtrans";
            this.txtEmailtrans.Size = new System.Drawing.Size(395, 20);
            this.txtEmailtrans.TabIndex = 30;
            // 
            // lblEmailtrans
            // 
            this.lblEmailtrans.AutoSize = true;
            this.lblEmailtrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailtrans.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblEmailtrans.Location = new System.Drawing.Point(98, 104);
            this.lblEmailtrans.Name = "lblEmailtrans";
            this.lblEmailtrans.Size = new System.Drawing.Size(42, 13);
            this.lblEmailtrans.TabIndex = 38;
            this.lblEmailtrans.Text = "E-Mail";
            this.lblEmailtrans.Click += new System.EventHandler(this.lblEmailCliente_Click);
            // 
            // lblTelefonetrans
            // 
            this.lblTelefonetrans.AutoSize = true;
            this.lblTelefonetrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonetrans.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTelefonetrans.Location = new System.Drawing.Point(0, 103);
            this.lblTelefonetrans.Name = "lblTelefonetrans";
            this.lblTelefonetrans.Size = new System.Drawing.Size(57, 13);
            this.lblTelefonetrans.TabIndex = 37;
            this.lblTelefonetrans.Text = "Telefone";
            // 
            // cmbUftrans
            // 
            this.cmbUftrans.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tRANSPORTADORABindingSource, "UF", true));
            this.cmbUftrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUftrans.FormattingEnabled = true;
            this.cmbUftrans.Items.AddRange(new object[] {
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
            this.cmbUftrans.Location = new System.Drawing.Point(375, 82);
            this.cmbUftrans.Name = "cmbUftrans";
            this.cmbUftrans.Size = new System.Drawing.Size(121, 21);
            this.cmbUftrans.TabIndex = 27;
            this.cmbUftrans.Text = "Selecione...";
            // 
            // lblUftrans
            // 
            this.lblUftrans.AutoSize = true;
            this.lblUftrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUftrans.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblUftrans.Location = new System.Drawing.Point(372, 66);
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
            this.txtMunicipiotrans.Location = new System.Drawing.Point(170, 82);
            this.txtMunicipiotrans.Name = "txtMunicipiotrans";
            this.txtMunicipiotrans.Size = new System.Drawing.Size(197, 20);
            this.txtMunicipiotrans.TabIndex = 25;
            // 
            // lblMunicipiotrans
            // 
            this.lblMunicipiotrans.AutoSize = true;
            this.lblMunicipiotrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipiotrans.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblMunicipiotrans.Location = new System.Drawing.Point(167, 65);
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
            this.txtBairrotrans.Location = new System.Drawing.Point(6, 81);
            this.txtBairrotrans.Name = "txtBairrotrans";
            this.txtBairrotrans.Size = new System.Drawing.Size(155, 20);
            this.txtBairrotrans.TabIndex = 24;
            // 
            // txtEndtrans
            // 
            this.txtEndtrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndtrans.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "ENDERECO", true));
            this.txtEndtrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndtrans.Location = new System.Drawing.Point(131, 42);
            this.txtEndtrans.Name = "txtEndtrans";
            this.txtEndtrans.Size = new System.Drawing.Size(365, 20);
            this.txtEndtrans.TabIndex = 23;
            // 
            // lblBairrotrans
            // 
            this.lblBairrotrans.AutoSize = true;
            this.lblBairrotrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairrotrans.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblBairrotrans.Location = new System.Drawing.Point(3, 65);
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
            this.lblEnderecotrans.Location = new System.Drawing.Point(128, 26);
            this.lblEnderecotrans.Name = "lblEnderecotrans";
            this.lblEnderecotrans.Size = new System.Drawing.Size(61, 13);
            this.lblEnderecotrans.TabIndex = 26;
            this.lblEnderecotrans.Text = "Endereço";
            // 
            // lblIECliente
            // 
            this.lblIECliente.AutoSize = true;
            this.lblIECliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIECliente.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblIECliente.Location = new System.Drawing.Point(252, 42);
            this.lblIECliente.Name = "lblIECliente";
            this.lblIECliente.Size = new System.Drawing.Size(23, 13);
            this.lblIECliente.TabIndex = 74;
            this.lblIECliente.Text = "I.E";
            // 
            // txtCnpjCli
            // 
            this.txtCnpjCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "CNPJ", true));
            this.txtCnpjCli.Location = new System.Drawing.Point(126, 58);
            this.txtCnpjCli.Mask = "99,999,999/9999-99";
            this.txtCnpjCli.Name = "txtCnpjCli";
            this.txtCnpjCli.PromptChar = ' ';
            this.txtCnpjCli.Size = new System.Drawing.Size(123, 20);
            this.txtCnpjCli.TabIndex = 75;
            this.txtCnpjCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCnpjCliente
            // 
            this.lblCnpjCliente.AutoSize = true;
            this.lblCnpjCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpjCliente.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblCnpjCliente.Location = new System.Drawing.Point(129, 42);
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
            this.TxtNomRed.Size = new System.Drawing.Size(114, 20);
            this.TxtNomRed.TabIndex = 62;
            // 
            // TxtNom
            // 
            this.TxtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "NOME", true));
            this.TxtNom.Location = new System.Drawing.Point(6, 19);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(380, 20);
            this.TxtNom.TabIndex = 61;
            // 
            // LblNomRed
            // 
            this.LblNomRed.AutoSize = true;
            this.LblNomRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomRed.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblNomRed.Location = new System.Drawing.Point(3, 42);
            this.LblNomRed.Name = "LblNomRed";
            this.LblNomRed.Size = new System.Drawing.Size(81, 13);
            this.LblNomRed.TabIndex = 50;
            this.LblNomRed.Text = "Nome Fantasia:";
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNom.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblNom.Location = new System.Drawing.Point(3, 3);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(43, 13);
            this.LblNom.TabIndex = 49;
            this.LblNom.Text = "Nome:";
            // 
            // cOMERCIALDataSet
            // 
            this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
            this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRANSPORTADORABindingSource
            // 
            this.tRANSPORTADORABindingSource.DataMember = "TRANSPORTADORA";
            this.tRANSPORTADORABindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // tRANSPORTADORATableAdapter
            // 
            this.tRANSPORTADORATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.REGIAOTableAdapter = null;
            this.tableAdapterManager.TRANSPORTADORATableAdapter = this.tRANSPORTADORATableAdapter;
            this.tableAdapterManager.TRANSPORTADORAVIATableAdapter = null;
            this.tableAdapterManager.UNIDADEMEDIDATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            this.tableAdapterManager.VENDEDORTableAdapter = null;
            this.tableAdapterManager.VIATRANSPORTETableAdapter = null;
            // 
            // cEPTextBox
            // 
            this.cEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "CEP", true));
            this.cEPTextBox.Location = new System.Drawing.Point(6, 42);
            this.cEPTextBox.Name = "cEPTextBox";
            this.cEPTextBox.Size = new System.Drawing.Size(119, 20);
            this.cEPTextBox.TabIndex = 45;
            // 
            // txtceptrans
            // 
            this.txtceptrans.getText = "";
            this.txtceptrans.Image = global::Comercial.Properties.Resources.btn_correios;
            this.txtceptrans.Location = new System.Drawing.Point(5, 42);
            this.txtceptrans.Name = "txtceptrans";
            this.txtceptrans.ShowButton = false;
            this.txtceptrans.Size = new System.Drawing.Size(135, 25);
            this.txtceptrans.TabIndex = 43;
            this.txtceptrans.Visible = false;
            this.txtceptrans.Load += new System.EventHandler(this.textButton1_Load);
            // 
            // FrmCadTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(565, 324);
            this.Controls.Add(this.TbCntCadTra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadTra";
            this.ShowIcon = false;
            this.Text = "Cadastro Transportadora";
            this.Shown += new System.EventHandler(this.FrmCadTra_Shown);
            this.TbCntCadTra.ResumeLayout(false);
            this.TbPgCadTra.ResumeLayout(false);
            this.TbPgCadTra.PerformLayout();
            this.grpBxViaTrans.ResumeLayout(false);
            this.gpbContatotrans.ResumeLayout(false);
            this.gpbContatotrans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTADORABindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox cmbUftrans;
        private System.Windows.Forms.Label lblUftrans;
        private System.Windows.Forms.TextBox txtMunicipiotrans;
        private System.Windows.Forms.Label lblMunicipiotrans;
        private System.Windows.Forms.TextBox txtBairrotrans;
        private System.Windows.Forms.TextBox txtEndtrans;
        private System.Windows.Forms.Label lblBairrotrans;
        private System.Windows.Forms.Label lblEnderecotrans;
        private System.Windows.Forms.MaskedTextBox txtIeCli;
        private System.Windows.Forms.Label lblIECliente;
        private System.Windows.Forms.MaskedTextBox txtCnpjCli;
        private System.Windows.Forms.Label lblCnpjCliente;
        private System.Windows.Forms.GroupBox grpBxViaTrans;
        private System.Windows.Forms.CheckedListBox chkltViatrans;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource tRANSPORTADORABindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.TRANSPORTADORATableAdapter tRANSPORTADORATableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cEPTextBox;
        private TextButton txtceptrans;

    }
}