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
                this.tRANSPORTADORABindingSource = new System.Windows.Forms.BindingSource(this.components);
                this.lblIECliente = new System.Windows.Forms.Label();
                this.lblCnpjCliente = new System.Windows.Forms.Label();
                this.LblNomRed = new System.Windows.Forms.Label();
                this.LblNom = new System.Windows.Forms.Label();
                this.nOMETextBox = new System.Windows.Forms.TextBox();
                this.nOMEREDUZIDOTextBox = new System.Windows.Forms.TextBox();
                this.cNPJTextBox = new System.Windows.Forms.TextBox();
                this.iETextBox = new System.Windows.Forms.TextBox();
                this.lblEnderecotrans = new System.Windows.Forms.Label();
                this.lblBairrotrans = new System.Windows.Forms.Label();
                this.lblMunicipiotrans = new System.Windows.Forms.Label();
                this.lblUftrans = new System.Windows.Forms.Label();
                this.lblTelefonetrans = new System.Windows.Forms.Label();
                this.lblEmailtrans = new System.Windows.Forms.Label();
                this.lblFaxtrans = new System.Windows.Forms.Label();
                this.lblCeptrans = new System.Windows.Forms.Label();
                this.cEPTextBox = new System.Windows.Forms.TextBox();
                this.eNDERECOTextBox = new System.Windows.Forms.TextBox();
                this.bAIRROTextBox = new System.Windows.Forms.TextBox();
                this.mUNICIPIOTextBox = new System.Windows.Forms.TextBox();
                this.tELEFONETextBox = new System.Windows.Forms.TextBox();
                this.gpbContatotrans = new System.Windows.Forms.GroupBox();
                this.fAXTextBox = new System.Windows.Forms.TextBox();
                this.eMAILTextBox = new System.Windows.Forms.TextBox();
                this.cmbUfTrans = new System.Windows.Forms.ComboBox();
                this.TbCntCadTra.SuspendLayout();
                this.TbPgCadTra.SuspendLayout();
                this.grpBxViaTrans.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTADORABindingSource)).BeginInit();
                this.gpbContatotrans.SuspendLayout();
                this.SuspendLayout();
                // 
                // TbCntCadTra
                // 
                this.TbCntCadTra.Controls.Add(this.TbPgCadTra);
                this.TbCntCadTra.Location = new System.Drawing.Point(12, 12);
                this.TbCntCadTra.Name = "TbCntCadTra";
                this.TbCntCadTra.SelectedIndex = 0;
                this.TbCntCadTra.Size = new System.Drawing.Size(546, 305);
                this.TbCntCadTra.TabIndex = 0;
                // 
                // TbPgCadTra
                // 
                this.TbPgCadTra.AutoScroll = true;
                this.TbPgCadTra.Controls.Add(this.iETextBox);
                this.TbPgCadTra.Controls.Add(this.cNPJTextBox);
                this.TbPgCadTra.Controls.Add(this.nOMEREDUZIDOTextBox);
                this.TbPgCadTra.Controls.Add(this.nOMETextBox);
                this.TbPgCadTra.Controls.Add(this.grpBxViaTrans);
                this.TbPgCadTra.Controls.Add(this.gpbContatotrans);
                this.TbPgCadTra.Controls.Add(this.lblIECliente);
                this.TbPgCadTra.Controls.Add(this.lblCnpjCliente);
                this.TbPgCadTra.Controls.Add(this.LblNomRed);
                this.TbPgCadTra.Controls.Add(this.LblNom);
                this.TbPgCadTra.Location = new System.Drawing.Point(4, 22);
                this.TbPgCadTra.Name = "TbPgCadTra";
                this.TbPgCadTra.Padding = new System.Windows.Forms.Padding(3);
                this.TbPgCadTra.Size = new System.Drawing.Size(538, 279);
                this.TbPgCadTra.TabIndex = 0;
                this.TbPgCadTra.Text = "Cadastro Transportadora";
                this.TbPgCadTra.UseVisualStyleBackColor = true;
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
                // tRANSPORTADORABindingSource
                // 
                this.tRANSPORTADORABindingSource.DataSource = typeof(Comercial.TRANSPORTADORA);
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
                // nOMETextBox
                // 
                this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "NOME", true));
                this.nOMETextBox.Location = new System.Drawing.Point(6, 19);
                this.nOMETextBox.Name = "nOMETextBox";
                this.nOMETextBox.Size = new System.Drawing.Size(380, 20);
                this.nOMETextBox.TabIndex = 79;
                // 
                // nOMEREDUZIDOTextBox
                // 
                this.nOMEREDUZIDOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "NOMEREDUZIDO", true));
                this.nOMEREDUZIDOTextBox.Location = new System.Drawing.Point(6, 58);
                this.nOMEREDUZIDOTextBox.Name = "nOMEREDUZIDOTextBox";
                this.nOMEREDUZIDOTextBox.Size = new System.Drawing.Size(120, 20);
                this.nOMEREDUZIDOTextBox.TabIndex = 80;
                // 
                // cNPJTextBox
                // 
                this.cNPJTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "CNPJ", true));
                this.cNPJTextBox.Location = new System.Drawing.Point(132, 58);
                this.cNPJTextBox.Name = "cNPJTextBox";
                this.cNPJTextBox.Size = new System.Drawing.Size(117, 20);
                this.cNPJTextBox.TabIndex = 81;
                // 
                // iETextBox
                // 
                this.iETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "IE", true));
                this.iETextBox.Location = new System.Drawing.Point(255, 58);
                this.iETextBox.Name = "iETextBox";
                this.iETextBox.Size = new System.Drawing.Size(131, 20);
                this.iETextBox.TabIndex = 82;
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
                // lblMunicipiotrans
                // 
                this.lblMunicipiotrans.AutoSize = true;
                this.lblMunicipiotrans.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "MUNICIPIO", true));
                this.lblMunicipiotrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblMunicipiotrans.ForeColor = System.Drawing.Color.CadetBlue;
                this.lblMunicipiotrans.Location = new System.Drawing.Point(167, 65);
                this.lblMunicipiotrans.Name = "lblMunicipiotrans";
                this.lblMunicipiotrans.Size = new System.Drawing.Size(60, 13);
                this.lblMunicipiotrans.TabIndex = 30;
                this.lblMunicipiotrans.Text = "Municípo";
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
                // lblEmailtrans
                // 
                this.lblEmailtrans.AutoSize = true;
                this.lblEmailtrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblEmailtrans.ForeColor = System.Drawing.Color.CadetBlue;
                this.lblEmailtrans.Location = new System.Drawing.Point(185, 105);
                this.lblEmailtrans.Name = "lblEmailtrans";
                this.lblEmailtrans.Size = new System.Drawing.Size(42, 13);
                this.lblEmailtrans.TabIndex = 38;
                this.lblEmailtrans.Text = "E-Mail";
                // 
                // lblFaxtrans
                // 
                this.lblFaxtrans.AutoSize = true;
                this.lblFaxtrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblFaxtrans.ForeColor = System.Drawing.Color.CadetBlue;
                this.lblFaxtrans.Location = new System.Drawing.Point(98, 105);
                this.lblFaxtrans.Name = "lblFaxtrans";
                this.lblFaxtrans.Size = new System.Drawing.Size(27, 13);
                this.lblFaxtrans.TabIndex = 42;
                this.lblFaxtrans.Text = "Fax:";
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
                // cEPTextBox
                // 
                this.cEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "CEP", true));
                this.cEPTextBox.Location = new System.Drawing.Point(3, 42);
                this.cEPTextBox.Name = "cEPTextBox";
                this.cEPTextBox.Size = new System.Drawing.Size(122, 20);
                this.cEPTextBox.TabIndex = 46;
                // 
                // eNDERECOTextBox
                // 
                this.eNDERECOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "ENDERECO", true));
                this.eNDERECOTextBox.Location = new System.Drawing.Point(131, 42);
                this.eNDERECOTextBox.Name = "eNDERECOTextBox";
                this.eNDERECOTextBox.Size = new System.Drawing.Size(365, 20);
                this.eNDERECOTextBox.TabIndex = 47;
                // 
                // bAIRROTextBox
                // 
                this.bAIRROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "BAIRRO", true));
                this.bAIRROTextBox.Location = new System.Drawing.Point(3, 80);
                this.bAIRROTextBox.Name = "bAIRROTextBox";
                this.bAIRROTextBox.Size = new System.Drawing.Size(158, 20);
                this.bAIRROTextBox.TabIndex = 83;
                // 
                // mUNICIPIOTextBox
                // 
                this.mUNICIPIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "MUNICIPIO", true));
                this.mUNICIPIOTextBox.Location = new System.Drawing.Point(170, 80);
                this.mUNICIPIOTextBox.Name = "mUNICIPIOTextBox";
                this.mUNICIPIOTextBox.Size = new System.Drawing.Size(199, 20);
                this.mUNICIPIOTextBox.TabIndex = 83;
                // 
                // tELEFONETextBox
                // 
                this.tELEFONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "TELEFONE", true));
                this.tELEFONETextBox.Location = new System.Drawing.Point(4, 121);
                this.tELEFONETextBox.Name = "tELEFONETextBox";
                this.tELEFONETextBox.Size = new System.Drawing.Size(91, 20);
                this.tELEFONETextBox.TabIndex = 85;
                // 
                // gpbContatotrans
                // 
                this.gpbContatotrans.Controls.Add(this.cmbUfTrans);
                this.gpbContatotrans.Controls.Add(this.eMAILTextBox);
                this.gpbContatotrans.Controls.Add(this.fAXTextBox);
                this.gpbContatotrans.Controls.Add(this.tELEFONETextBox);
                this.gpbContatotrans.Controls.Add(this.mUNICIPIOTextBox);
                this.gpbContatotrans.Controls.Add(this.bAIRROTextBox);
                this.gpbContatotrans.Controls.Add(this.eNDERECOTextBox);
                this.gpbContatotrans.Controls.Add(this.cEPTextBox);
                this.gpbContatotrans.Controls.Add(this.lblCeptrans);
                this.gpbContatotrans.Controls.Add(this.lblFaxtrans);
                this.gpbContatotrans.Controls.Add(this.lblEmailtrans);
                this.gpbContatotrans.Controls.Add(this.lblTelefonetrans);
                this.gpbContatotrans.Controls.Add(this.lblUftrans);
                this.gpbContatotrans.Controls.Add(this.lblMunicipiotrans);
                this.gpbContatotrans.Controls.Add(this.lblBairrotrans);
                this.gpbContatotrans.Controls.Add(this.lblEnderecotrans);
                this.gpbContatotrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.gpbContatotrans.ForeColor = System.Drawing.Color.CornflowerBlue;
                this.gpbContatotrans.Location = new System.Drawing.Point(6, 106);
                this.gpbContatotrans.Name = "gpbContatotrans";
                this.gpbContatotrans.Size = new System.Drawing.Size(520, 166);
                this.gpbContatotrans.TabIndex = 73;
                this.gpbContatotrans.TabStop = false;
                this.gpbContatotrans.Text = "Contato";
                // 
                // fAXTextBox
                // 
                this.fAXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "FAX", true));
                this.fAXTextBox.Location = new System.Drawing.Point(101, 121);
                this.fAXTextBox.Name = "fAXTextBox";
                this.fAXTextBox.Size = new System.Drawing.Size(81, 20);
                this.fAXTextBox.TabIndex = 86;
                // 
                // eMAILTextBox
                // 
                this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "EMAIL", true));
                this.eMAILTextBox.Location = new System.Drawing.Point(188, 121);
                this.eMAILTextBox.Name = "eMAILTextBox";
                this.eMAILTextBox.Size = new System.Drawing.Size(308, 20);
                this.eMAILTextBox.TabIndex = 87;
                // 
                // cmbUfTrans
                // 
                this.cmbUfTrans.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTADORABindingSource, "UF", true));
                this.cmbUfTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.cmbUfTrans.FormattingEnabled = true;
                this.cmbUfTrans.Items.AddRange(new object[] {
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
                this.cmbUfTrans.Location = new System.Drawing.Point(375, 82);
                this.cmbUfTrans.Name = "cmbUfTrans";
                this.cmbUfTrans.Size = new System.Drawing.Size(121, 21);
                this.cmbUfTrans.TabIndex = 88;
                this.cmbUfTrans.Text = "Selecione...";
                // 
                // FrmCadTra
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.WhiteSmoke;
                this.ClientSize = new System.Drawing.Size(567, 326);
                this.Controls.Add(this.TbCntCadTra);
                this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "FrmCadTra";
                this.ShowIcon = false;
                this.Text = "Cadastro Transportadora";
                this.Load += new System.EventHandler(this.FrmCadTra_Load);
                this.TbCntCadTra.ResumeLayout(false);
                this.TbPgCadTra.ResumeLayout(false);
                this.TbPgCadTra.PerformLayout();
                this.grpBxViaTrans.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTADORABindingSource)).EndInit();
                this.gpbContatotrans.ResumeLayout(false);
                this.gpbContatotrans.PerformLayout();
                this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.TabControl TbCntCadTra;
        private System.Windows.Forms.TabPage TbPgCadTra;
        private System.Windows.Forms.Label LblNomRed;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label lblIECliente;
        private System.Windows.Forms.Label lblCnpjCliente;
        private System.Windows.Forms.GroupBox grpBxViaTrans;
        private System.Windows.Forms.CheckedListBox chkltViatrans;
        private System.Windows.Forms.BindingSource tRANSPORTADORABindingSource;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.TextBox nOMEREDUZIDOTextBox;
        private System.Windows.Forms.TextBox iETextBox;
        private System.Windows.Forms.TextBox cNPJTextBox;
        private System.Windows.Forms.GroupBox gpbContatotrans;
        private System.Windows.Forms.TextBox tELEFONETextBox;
        private System.Windows.Forms.TextBox mUNICIPIOTextBox;
        private System.Windows.Forms.TextBox bAIRROTextBox;
        private System.Windows.Forms.TextBox eNDERECOTextBox;
        private System.Windows.Forms.TextBox cEPTextBox;
        private System.Windows.Forms.Label lblCeptrans;
        private System.Windows.Forms.Label lblFaxtrans;
        private System.Windows.Forms.Label lblEmailtrans;
        private System.Windows.Forms.Label lblTelefonetrans;
        private System.Windows.Forms.Label lblUftrans;
        private System.Windows.Forms.Label lblMunicipiotrans;
        private System.Windows.Forms.Label lblBairrotrans;
        private System.Windows.Forms.Label lblEnderecotrans;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox fAXTextBox;
        private System.Windows.Forms.ComboBox cmbUfTrans;

        }
    }