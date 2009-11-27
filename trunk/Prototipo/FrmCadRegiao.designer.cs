namespace Comercial
    {
    partial class FrmCadRegiao
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadRegiao));
                this.TBCntCadRediao = new System.Windows.Forms.TabControl();
                this.TbPgCadRegiao = new System.Windows.Forms.TabPage();
                this.lblCodigo = new System.Windows.Forms.Label();
                this.rEGIAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
                this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
                this.TxtDes = new System.Windows.Forms.TextBox();
                this.LblDes = new System.Windows.Forms.Label();
                this.consultaRegiaoToolStrip = new System.Windows.Forms.ToolStrip();
                this.dESCRICAOToolStripLabel = new System.Windows.Forms.ToolStripLabel();
                this.dESCRICAOToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
                this.consultaRegiaoToolStripButton = new System.Windows.Forms.ToolStripButton();
                this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
                this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
                this.rEGIAOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.REGIAOTableAdapter();
                this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
                this.TBCntCadRediao.SuspendLayout();
                this.TbPgCadRegiao.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.rEGIAOBindingSource)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
                this.consultaRegiaoToolStrip.SuspendLayout();
                this.SuspendLayout();
                // 
                // TBCntCadRediao
                // 
                this.TBCntCadRediao.Controls.Add(this.TbPgCadRegiao);
                this.TBCntCadRediao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TBCntCadRediao.Location = new System.Drawing.Point(12, 32);
                this.TBCntCadRediao.Name = "TBCntCadRediao";
                this.TBCntCadRediao.SelectedIndex = 0;
                this.TBCntCadRediao.Size = new System.Drawing.Size(463, 195);
                this.TBCntCadRediao.TabIndex = 0;
                // 
                // TbPgCadRegiao
                // 
                this.TbPgCadRegiao.AutoScroll = true;
                this.TbPgCadRegiao.Controls.Add(this.lblCodigo);
                this.TbPgCadRegiao.Controls.Add(this.TxtDes);
                this.TbPgCadRegiao.Controls.Add(this.LblDes);
                this.TbPgCadRegiao.Location = new System.Drawing.Point(4, 22);
                this.TbPgCadRegiao.Name = "TbPgCadRegiao";
                this.TbPgCadRegiao.Padding = new System.Windows.Forms.Padding(3);
                this.TbPgCadRegiao.Size = new System.Drawing.Size(455, 169);
                this.TbPgCadRegiao.TabIndex = 1;
                this.TbPgCadRegiao.Text = "Cadastro de Região";
                this.TbPgCadRegiao.UseVisualStyleBackColor = true;
                // 
                // lblCodigo
                // 
                this.lblCodigo.AutoSize = true;
                this.lblCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rEGIAOBindingSource, "CODREGIAO", true));
                this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblCodigo.ForeColor = System.Drawing.Color.CadetBlue;
                this.lblCodigo.Location = new System.Drawing.Point(6, 26);
                this.lblCodigo.Name = "lblCodigo";
                this.lblCodigo.Size = new System.Drawing.Size(43, 13);
                this.lblCodigo.TabIndex = 50;
                this.lblCodigo.Text = "Código:";
                // 
                // rEGIAOBindingSource
                // 
                this.rEGIAOBindingSource.DataMember = "REGIAO";
                this.rEGIAOBindingSource.DataSource = this.cOMERCIALDataSet;
                // 
                // cOMERCIALDataSet
                // 
                this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
                this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
                // 
                // TxtDes
                // 
                this.TxtDes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rEGIAOBindingSource, "DESCRICAO", true));
                this.TxtDes.Location = new System.Drawing.Point(65, 22);
                this.TxtDes.Name = "TxtDes";
                this.TxtDes.Size = new System.Drawing.Size(349, 20);
                this.TxtDes.TabIndex = 49;
                // 
                // LblDes
                // 
                this.LblDes.AutoSize = true;
                this.LblDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblDes.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblDes.Location = new System.Drawing.Point(62, 6);
                this.LblDes.Name = "LblDes";
                this.LblDes.Size = new System.Drawing.Size(68, 13);
                this.LblDes.TabIndex = 48;
                this.LblDes.Text = "Descrição:";
                // 
                // consultaRegiaoToolStrip
                // 
                this.consultaRegiaoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dESCRICAOToolStripLabel,
            this.dESCRICAOToolStripTextBox,
            this.consultaRegiaoToolStripButton,
            this.toolStripButton3,
            this.toolStripButton2});
                this.consultaRegiaoToolStrip.Location = new System.Drawing.Point(0, 0);
                this.consultaRegiaoToolStrip.Name = "consultaRegiaoToolStrip";
                this.consultaRegiaoToolStrip.Size = new System.Drawing.Size(495, 25);
                this.consultaRegiaoToolStrip.TabIndex = 1;
                this.consultaRegiaoToolStrip.Text = "consultaRegiaoToolStrip";
                this.consultaRegiaoToolStrip.Visible = false;
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
                // consultaRegiaoToolStripButton
                // 
                this.consultaRegiaoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.consultaRegiaoToolStripButton.Image = global::Comercial.Properties.Resources.search1;
                this.consultaRegiaoToolStripButton.Name = "consultaRegiaoToolStripButton";
                this.consultaRegiaoToolStripButton.Size = new System.Drawing.Size(23, 22);
                this.consultaRegiaoToolStripButton.Text = "ConsultaRegiao";
                this.consultaRegiaoToolStripButton.Click += new System.EventHandler(this.consultaRegiaoToolStripButton_Click);
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
                // rEGIAOTableAdapter
                // 
                this.rEGIAOTableAdapter.ClearBeforeFill = true;
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
                this.tableAdapterManager.modeloCampoTableAdapter = null;
                this.tableAdapterManager.modeloTableAdapter = null;
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
                this.tableAdapterManager.VENDEDORTableAdapter = null;
                this.tableAdapterManager.VIATRANSPORTETableAdapter = null;
                // 
                // FrmCadRegiao
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.WhiteSmoke;
                this.ClientSize = new System.Drawing.Size(495, 247);
                this.ControlBox = false;
                this.Controls.Add(this.consultaRegiaoToolStrip);
                this.Controls.Add(this.TBCntCadRediao);
                this.ForeColor = System.Drawing.Color.CadetBlue;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "FrmCadRegiao";
                this.ShowIcon = false;
                this.Text = "Cadastro de Região";
                this.Load += new System.EventHandler(this.Form5_Load);
                this.TBCntCadRediao.ResumeLayout(false);
                this.TbPgCadRegiao.ResumeLayout(false);
                this.TbPgCadRegiao.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.rEGIAOBindingSource)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
                this.consultaRegiaoToolStrip.ResumeLayout(false);
                this.consultaRegiaoToolStrip.PerformLayout();
                this.ResumeLayout(false);
                this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.TabControl TBCntCadRediao;
        private System.Windows.Forms.TabPage TbPgCadRegiao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox TxtDes;
        private System.Windows.Forms.Label LblDes;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource rEGIAOBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.REGIAOTableAdapter rEGIAOTableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripLabel dESCRICAOToolStripLabel;
        private System.Windows.Forms.ToolStripButton consultaRegiaoToolStripButton;
        public System.Windows.Forms.ToolStrip consultaRegiaoToolStrip;
        public System.Windows.Forms.ToolStripTextBox dESCRICAOToolStripTextBox;
        public System.Windows.Forms.ToolStripButton toolStripButton3;
        public System.Windows.Forms.ToolStripButton toolStripButton2;

        }
    }