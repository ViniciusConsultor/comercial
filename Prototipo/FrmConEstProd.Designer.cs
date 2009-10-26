namespace Comercial
{
    partial class FrmConEstProd
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
            this.tbCntrlConProd = new System.Windows.Forms.TabControl();
            this.tbPgConProd = new System.Windows.Forms.TabPage();
            this.dtGrdVwConProd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBxFiltro = new System.Windows.Forms.GroupBox();
            this.grpBxProd = new System.Windows.Forms.GroupBox();
            this.lblGrpProd = new System.Windows.Forms.Label();
            this.cmbGrupoProd = new System.Windows.Forms.ComboBox();
            this.gRUPOPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.txtBtnCodProd = new Comercial.TextButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtProdDesc = new System.Windows.Forms.TextBox();
            this.cmBxOpEstoque = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTPckrDtCadastro = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.LblDesc = new System.Windows.Forms.Label();
            this.gRUPOPRODUTOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.GRUPOPRODUTOTableAdapter();
            this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
            this.tbCntrlConProd.SuspendLayout();
            this.tbPgConProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwConProd)).BeginInit();
            this.grpBxFiltro.SuspendLayout();
            this.grpBxProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRUPOPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrlConProd
            // 
            this.tbCntrlConProd.Controls.Add(this.tbPgConProd);
            this.tbCntrlConProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlConProd.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlConProd.Name = "tbCntrlConProd";
            this.tbCntrlConProd.SelectedIndex = 0;
            this.tbCntrlConProd.Size = new System.Drawing.Size(737, 465);
            this.tbCntrlConProd.TabIndex = 0;
            // 
            // tbPgConProd
            // 
            this.tbPgConProd.Controls.Add(this.dtGrdVwConProd);
            this.tbPgConProd.Controls.Add(this.grpBxFiltro);
            this.tbPgConProd.Location = new System.Drawing.Point(4, 22);
            this.tbPgConProd.Name = "tbPgConProd";
            this.tbPgConProd.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgConProd.Size = new System.Drawing.Size(729, 439);
            this.tbPgConProd.TabIndex = 0;
            this.tbPgConProd.Text = "Consulta - Estoque";
            this.tbPgConProd.UseVisualStyleBackColor = true;
            // 
            // dtGrdVwConProd
            // 
            this.dtGrdVwConProd.AllowUserToAddRows = false;
            this.dtGrdVwConProd.AllowUserToDeleteRows = false;
            this.dtGrdVwConProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwConProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtGrdVwConProd.Location = new System.Drawing.Point(6, 181);
            this.dtGrdVwConProd.Name = "dtGrdVwConProd";
            this.dtGrdVwConProd.ReadOnly = true;
            this.dtGrdVwConProd.Size = new System.Drawing.Size(717, 252);
            this.dtGrdVwConProd.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CODPRODUTO";
            this.Column1.HeaderText = "Código Produto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DESCRICAO";
            this.Column2.HeaderText = "Descrição Produto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PRECOCUSTO";
            this.Column3.HeaderText = "Preço Custo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DATACADASTRO";
            this.Column7.HeaderText = "Data Cadastro";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CODGRUPOPRODUTO";
            this.Column4.HeaderText = "Codigo Grupo Produto";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GRPDESC";
            this.Column5.HeaderText = "Descrição Grupo Produto";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ESTOQUEATUAL";
            this.Column6.HeaderText = "Estoque Atual";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // grpBxFiltro
            // 
            this.grpBxFiltro.Controls.Add(this.grpBxProd);
            this.grpBxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxFiltro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxFiltro.Location = new System.Drawing.Point(6, 6);
            this.grpBxFiltro.Name = "grpBxFiltro";
            this.grpBxFiltro.Size = new System.Drawing.Size(717, 169);
            this.grpBxFiltro.TabIndex = 1;
            this.grpBxFiltro.TabStop = false;
            this.grpBxFiltro.Text = "Filtros:";
            // 
            // grpBxProd
            // 
            this.grpBxProd.Controls.Add(this.lblGrpProd);
            this.grpBxProd.Controls.Add(this.cmbGrupoProd);
            this.grpBxProd.Controls.Add(this.txtBtnCodProd);
            this.grpBxProd.Controls.Add(this.label2);
            this.grpBxProd.Controls.Add(this.txtEstoque);
            this.grpBxProd.Controls.Add(this.txtProdDesc);
            this.grpBxProd.Controls.Add(this.cmBxOpEstoque);
            this.grpBxProd.Controls.Add(this.label1);
            this.grpBxProd.Controls.Add(this.dtTPckrDtCadastro);
            this.grpBxProd.Controls.Add(this.label3);
            this.grpBxProd.Controls.Add(this.LblDesc);
            this.grpBxProd.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxProd.Location = new System.Drawing.Point(6, 19);
            this.grpBxProd.Name = "grpBxProd";
            this.grpBxProd.Size = new System.Drawing.Size(569, 133);
            this.grpBxProd.TabIndex = 1;
            this.grpBxProd.TabStop = false;
            this.grpBxProd.Text = "Dados Produtos:";
            // 
            // lblGrpProd
            // 
            this.lblGrpProd.AutoSize = true;
            this.lblGrpProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrpProd.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblGrpProd.Location = new System.Drawing.Point(284, 17);
            this.lblGrpProd.Name = "lblGrpProd";
            this.lblGrpProd.Size = new System.Drawing.Size(79, 13);
            this.lblGrpProd.TabIndex = 30;
            this.lblGrpProd.Text = "Grupo Produto:";
            // 
            // cmbGrupoProd
            // 
            this.cmbGrupoProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gRUPOPRODUTOBindingSource, "CODGRUPOPRODUTO", true));
            this.cmbGrupoProd.DataSource = this.gRUPOPRODUTOBindingSource;
            this.cmbGrupoProd.DisplayMember = "DESCRICAO";
            this.cmbGrupoProd.FormattingEnabled = true;
            this.cmbGrupoProd.Location = new System.Drawing.Point(287, 33);
            this.cmbGrupoProd.Name = "cmbGrupoProd";
            this.cmbGrupoProd.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupoProd.TabIndex = 29;
            this.cmbGrupoProd.ValueMember = "CODGRUPOPRODUTO";
            // 
            // gRUPOPRODUTOBindingSource
            // 
            this.gRUPOPRODUTOBindingSource.DataMember = "GRUPOPRODUTO";
            this.gRUPOPRODUTOBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // cOMERCIALDataSet
            // 
            this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
            this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBtnCodProd
            // 
            this.txtBtnCodProd.getText = "";
            this.txtBtnCodProd.Image = global::Comercial.Properties.Resources.search1;
            this.txtBtnCodProd.Location = new System.Drawing.Point(9, 32);
            this.txtBtnCodProd.Name = "txtBtnCodProd";
            this.txtBtnCodProd.ShowButton = false;
            this.txtBtnCodProd.Size = new System.Drawing.Size(45, 25);
            this.txtBtnCodProd.TabIndex = 28;
            this.txtBtnCodProd.ButtonClick += new System.EventHandler(this.txtNumPed_ButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Código:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(263, 76);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(60, 20);
            this.txtEstoque.TabIndex = 26;
            this.txtEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoque_KeyPress);
            // 
            // txtProdDesc
            // 
            this.txtProdDesc.Location = new System.Drawing.Point(60, 33);
            this.txtProdDesc.Name = "txtProdDesc";
            this.txtProdDesc.Size = new System.Drawing.Size(212, 20);
            this.txtProdDesc.TabIndex = 26;
            // 
            // cmBxOpEstoque
            // 
            this.cmBxOpEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBxOpEstoque.FormattingEnabled = true;
            this.cmBxOpEstoque.Items.AddRange(new object[] {
            "",
            ">",
            "<",
            "=",
            ">=",
            "<="});
            this.cmBxOpEstoque.Location = new System.Drawing.Point(202, 76);
            this.cmBxOpEstoque.Name = "cmBxOpEstoque";
            this.cmBxOpEstoque.Size = new System.Drawing.Size(51, 21);
            this.cmBxOpEstoque.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(199, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Estoque:";
            // 
            // dtTPckrDtCadastro
            // 
            this.dtTPckrDtCadastro.Checked = false;
            this.dtTPckrDtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTPckrDtCadastro.Location = new System.Drawing.Point(11, 76);
            this.dtTPckrDtCadastro.Name = "dtTPckrDtCadastro";
            this.dtTPckrDtCadastro.ShowCheckBox = true;
            this.dtTPckrDtCadastro.Size = new System.Drawing.Size(119, 20);
            this.dtTPckrDtCadastro.TabIndex = 17;
            this.dtTPckrDtCadastro.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data de cadastro:";
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesc.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblDesc.Location = new System.Drawing.Point(57, 16);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(58, 13);
            this.LblDesc.TabIndex = 13;
            this.LblDesc.Text = "Descrição:";
            // 
            // gRUPOPRODUTOTableAdapter
            // 
            this.gRUPOPRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.CONDICAOPAGAMENTOTableAdapter = null;
            this.tableAdapterManager.GRUPOPRODUTOTableAdapter = this.gRUPOPRODUTOTableAdapter;
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
            this.tableAdapterManager.USUARIOTableAdapter = null;
            this.tableAdapterManager.VENDEDORTableAdapter = null;
            this.tableAdapterManager.VIATRANSPORTETableAdapter = null;
            // 
            // FrmConEstProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(771, 489);
            this.ControlBox = false;
            this.Controls.Add(this.tbCntrlConProd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConEstProd";
            this.ShowIcon = false;
            this.Text = "Consulta de Estoque";
            this.Load += new System.EventHandler(this.FrmConEstProd_Load_1);
            this.Leave += new System.EventHandler(this.FrmConProd_Leave);
            this.tbCntrlConProd.ResumeLayout(false);
            this.tbPgConProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwConProd)).EndInit();
            this.grpBxFiltro.ResumeLayout(false);
            this.grpBxProd.ResumeLayout(false);
            this.grpBxProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRUPOPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrlConProd;
        private System.Windows.Forms.TabPage tbPgConProd;
        private System.Windows.Forms.GroupBox grpBxFiltro;
        private System.Windows.Forms.GroupBox grpBxProd;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.DateTimePicker dtTPckrDtCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBxOpEstoque;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label2;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource gRUPOPRODUTOBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.GRUPOPRODUTOTableAdapter gRUPOPRODUTOTableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbGrupoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lblGrpProd;
        public System.Windows.Forms.TextBox txtProdDesc;
        public TextButton txtBtnCodProd;
        public System.Windows.Forms.DataGridView dtGrdVwConProd;
    }
}