namespace Comercial
    {
    partial class FrmCadConPag
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadConPag));
                this.tabPage2 = new System.Windows.Forms.TabPage();
                this.chkEntrada = new System.Windows.Forms.CheckBox();
                this.lblCodigo = new System.Windows.Forms.Label();
                this.TxtDiaDes = new System.Windows.Forms.TextBox();
                this.TxtDes = new System.Windows.Forms.TextBox();
                this.LblDiaPCo = new System.Windows.Forms.Label();
                this.LblDes = new System.Windows.Forms.Label();
                this.TbCntConPag = new System.Windows.Forms.TabControl();
                this.consultaCondicaoToolStrip = new System.Windows.Forms.ToolStrip();
                this.dESCRICAOToolStripLabel = new System.Windows.Forms.ToolStripLabel();
                this.dESCRICAOToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
                this.consultaCondicaoToolStripButton = new System.Windows.Forms.ToolStripButton();
                this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
                this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
                this.cONDICAOPAGAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
                this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
                this.cONDICAOPAGAMENTOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.CONDICAOPAGAMENTOTableAdapter();
                this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
                this.tabPage2.SuspendLayout();
                this.TbCntConPag.SuspendLayout();
                this.consultaCondicaoToolStrip.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.cONDICAOPAGAMENTOBindingSource)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
                this.SuspendLayout();
                // 
                // tabPage2
                // 
                this.tabPage2.AutoScroll = true;
                this.tabPage2.Controls.Add(this.chkEntrada);
                this.tabPage2.Controls.Add(this.lblCodigo);
                this.tabPage2.Controls.Add(this.TxtDiaDes);
                this.tabPage2.Controls.Add(this.TxtDes);
                this.tabPage2.Controls.Add(this.LblDiaPCo);
                this.tabPage2.Controls.Add(this.LblDes);
                this.tabPage2.Location = new System.Drawing.Point(4, 22);
                this.tabPage2.Name = "tabPage2";
                this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
                this.tabPage2.Size = new System.Drawing.Size(541, 74);
                this.tabPage2.TabIndex = 1;
                this.tabPage2.Text = "Cadastro Condições de Pagamento";
                this.tabPage2.UseVisualStyleBackColor = true;
                // 
                // chkEntrada
                // 
                this.chkEntrada.Location = new System.Drawing.Point(425, 19);
                this.chkEntrada.Name = "chkEntrada";
                this.chkEntrada.Size = new System.Drawing.Size(104, 24);
                this.chkEntrada.TabIndex = 48;
                this.chkEntrada.Text = "Entrada";
                this.chkEntrada.UseVisualStyleBackColor = true;
                // 
                // lblCodigo
                // 
                this.lblCodigo.AutoSize = true;
                this.lblCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONDICAOPAGAMENTOBindingSource, "CODCONDICAOPAGAMENTO", true));
                this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblCodigo.ForeColor = System.Drawing.Color.CadetBlue;
                this.lblCodigo.Location = new System.Drawing.Point(6, 23);
                this.lblCodigo.Name = "lblCodigo";
                this.lblCodigo.Size = new System.Drawing.Size(43, 13);
                this.lblCodigo.TabIndex = 47;
                this.lblCodigo.Text = "Código:";
                // 
                // TxtDiaDes
                // 
                this.TxtDiaDes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONDICAOPAGAMENTOBindingSource, "QTDEVEZES", true));
                this.TxtDiaDes.Location = new System.Drawing.Point(313, 19);
                this.TxtDiaDes.Name = "TxtDiaDes";
                this.TxtDiaDes.Size = new System.Drawing.Size(106, 20);
                this.TxtDiaDes.TabIndex = 45;
                this.TxtDiaDes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDiaDes_KeyPress);
                // 
                // TxtDes
                // 
                this.TxtDes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONDICAOPAGAMENTOBindingSource, "DESCRICAO", true));
                this.TxtDes.Location = new System.Drawing.Point(65, 19);
                this.TxtDes.Name = "TxtDes";
                this.TxtDes.Size = new System.Drawing.Size(239, 20);
                this.TxtDes.TabIndex = 44;
                // 
                // LblDiaPCo
                // 
                this.LblDiaPCo.AutoSize = true;
                this.LblDiaPCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblDiaPCo.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblDiaPCo.Location = new System.Drawing.Point(310, 3);
                this.LblDiaPCo.Name = "LblDiaPCo";
                this.LblDiaPCo.Size = new System.Drawing.Size(109, 13);
                this.LblDiaPCo.TabIndex = 43;
                this.LblDiaPCo.Text = "Quantidade vezes";
                // 
                // LblDes
                // 
                this.LblDes.AutoSize = true;
                this.LblDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblDes.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblDes.Location = new System.Drawing.Point(62, 3);
                this.LblDes.Name = "LblDes";
                this.LblDes.Size = new System.Drawing.Size(68, 13);
                this.LblDes.TabIndex = 42;
                this.LblDes.Text = "Descrição:";
                // 
                // TbCntConPag
                // 
                this.TbCntConPag.Controls.Add(this.tabPage2);
                this.TbCntConPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TbCntConPag.Location = new System.Drawing.Point(12, 32);
                this.TbCntConPag.Name = "TbCntConPag";
                this.TbCntConPag.SelectedIndex = 0;
                this.TbCntConPag.Size = new System.Drawing.Size(549, 100);
                this.TbCntConPag.TabIndex = 0;
                // 
                // consultaCondicaoToolStrip
                // 
                this.consultaCondicaoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dESCRICAOToolStripLabel,
            this.dESCRICAOToolStripTextBox,
            this.consultaCondicaoToolStripButton,
            this.toolStripButton3,
            this.toolStripButton2});
                this.consultaCondicaoToolStrip.Location = new System.Drawing.Point(0, 0);
                this.consultaCondicaoToolStrip.Name = "consultaCondicaoToolStrip";
                this.consultaCondicaoToolStrip.Size = new System.Drawing.Size(581, 25);
                this.consultaCondicaoToolStrip.TabIndex = 1;
                this.consultaCondicaoToolStrip.Text = "consultaCondicaoToolStrip";
                this.consultaCondicaoToolStrip.Visible = false;
                // 
                // dESCRICAOToolStripLabel
                // 
                this.dESCRICAOToolStripLabel.Name = "dESCRICAOToolStripLabel";
                this.dESCRICAOToolStripLabel.Size = new System.Drawing.Size(61, 22);
                this.dESCRICAOToolStripLabel.Text = "Descrição:";
                // 
                // dESCRICAOToolStripTextBox
                // 
                this.dESCRICAOToolStripTextBox.Name = "dESCRICAOToolStripTextBox";
                this.dESCRICAOToolStripTextBox.Size = new System.Drawing.Size(100, 25);
                // 
                // consultaCondicaoToolStripButton
                // 
                this.consultaCondicaoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.consultaCondicaoToolStripButton.Image = global::Comercial.Properties.Resources.search1;
                this.consultaCondicaoToolStripButton.Name = "consultaCondicaoToolStripButton";
                this.consultaCondicaoToolStripButton.Size = new System.Drawing.Size(23, 22);
                this.consultaCondicaoToolStripButton.Text = "ConsultaCondicao";
                this.consultaCondicaoToolStripButton.Click += new System.EventHandler(this.consultaCondicaoToolStripButton_Click);
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
                // cONDICAOPAGAMENTOBindingSource
                // 
                this.cONDICAOPAGAMENTOBindingSource.DataMember = "CONDICAOPAGAMENTO";
                this.cONDICAOPAGAMENTOBindingSource.DataSource = this.cOMERCIALDataSet;
                this.cONDICAOPAGAMENTOBindingSource.PositionChanged += new System.EventHandler(this.cONDICAOPAGAMENTOBindingSource_PositionChanged);
                // 
                // cOMERCIALDataSet
                // 
                this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
                this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
                // 
                // cONDICAOPAGAMENTOTableAdapter
                // 
                this.cONDICAOPAGAMENTOTableAdapter.ClearBeforeFill = true;
                // 
                // tableAdapterManager
                // 
                this.tableAdapterManager.ACESSOTableAdapter = null;
                this.tableAdapterManager.ATUCUBOTableAdapter = null;
                this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
                this.tableAdapterManager.CLIENTETableAdapter = null;
                this.tableAdapterManager.CONDICAOPAGAMENTOTableAdapter = this.cONDICAOPAGAMENTOTableAdapter;
                this.tableAdapterManager.GRUPOPRODUTOTableAdapter = null;
                this.tableAdapterManager.ICMSTableAdapter = null;
                this.tableAdapterManager.ItemNotaFiscalTableAdapter = null;
                this.tableAdapterManager.ITEMPEDIDOTableAdapter = null;
                this.tableAdapterManager.modeloCampoTableAdapter = null;
                this.tableAdapterManager.modeloTableAdapter = null;
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
                // FrmCadConPag
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.WhiteSmoke;
                this.ClientSize = new System.Drawing.Size(581, 152);
                this.Controls.Add(this.consultaCondicaoToolStrip);
                this.Controls.Add(this.TbCntConPag);
                this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.ForeColor = System.Drawing.Color.CadetBlue;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "FrmCadConPag";
                this.ShowIcon = false;
                this.ShowInTaskbar = false;
                this.Text = "Cadastro Condições de Pagamento";
                this.Load += new System.EventHandler(this.FrmCadConPag_Load);
                this.Shown += new System.EventHandler(this.FrmCadConPag_Shown);
                this.tabPage2.ResumeLayout(false);
                this.tabPage2.PerformLayout();
                this.TbCntConPag.ResumeLayout(false);
                this.consultaCondicaoToolStrip.ResumeLayout(false);
                this.consultaCondicaoToolStrip.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.cONDICAOPAGAMENTOBindingSource)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl TbCntConPag;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox TxtDiaDes;
        private System.Windows.Forms.TextBox TxtDes;
        private System.Windows.Forms.Label LblDiaPCo;
        private System.Windows.Forms.Label LblDes;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource cONDICAOPAGAMENTOBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.CONDICAOPAGAMENTOTableAdapter cONDICAOPAGAMENTOTableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox chkEntrada;
        private System.Windows.Forms.ToolStripButton consultaCondicaoToolStripButton;
        public System.Windows.Forms.ToolStrip consultaCondicaoToolStrip;
        public System.Windows.Forms.ToolStripLabel dESCRICAOToolStripLabel;
        public System.Windows.Forms.ToolStripTextBox dESCRICAOToolStripTextBox;
        public System.Windows.Forms.ToolStripButton toolStripButton3;
        public System.Windows.Forms.ToolStripButton toolStripButton2;


        }
    }