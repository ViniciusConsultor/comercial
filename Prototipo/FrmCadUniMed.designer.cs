﻿namespace Comercial
    {
    partial class FrmCadUniMed
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadUniMed));
                this.TbCntCadUniMed = new System.Windows.Forms.TabControl();
                this.TbPgCadUniMed = new System.Windows.Forms.TabPage();
                this.label1 = new System.Windows.Forms.Label();
                this.CkBoxInteiro = new System.Windows.Forms.CheckBox();
                this.TxtDesc = new System.Windows.Forms.TextBox();
                this.TxtNomRed = new System.Windows.Forms.TextBox();
                this.LblDescricao = new System.Windows.Forms.Label();
                this.LblNomRed = new System.Windows.Forms.Label();
                this.consultaunidadeToolStrip = new System.Windows.Forms.ToolStrip();
                this.cODUNIDADEMEDIDAToolStripLabel = new System.Windows.Forms.ToolStripLabel();
                this.cODUNIDADEMEDIDAToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
                this.dESCRICAOToolStripLabel = new System.Windows.Forms.ToolStripLabel();
                this.dESCRICAOToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
                this.consultaunidadeToolStripButton = new System.Windows.Forms.ToolStripButton();
                this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
                this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
                this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
                this.uNIDADEMEDIDABindingSource = new System.Windows.Forms.BindingSource(this.components);
                this.uNIDADEMEDIDATableAdapter = new Comercial.COMERCIALDataSetTableAdapters.UNIDADEMEDIDATableAdapter();
                this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
                this.TbCntCadUniMed.SuspendLayout();
                this.TbPgCadUniMed.SuspendLayout();
                this.consultaunidadeToolStrip.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.uNIDADEMEDIDABindingSource)).BeginInit();
                this.SuspendLayout();
                // 
                // TbCntCadUniMed
                // 
                this.TbCntCadUniMed.Controls.Add(this.TbPgCadUniMed);
                this.TbCntCadUniMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TbCntCadUniMed.Location = new System.Drawing.Point(12, 35);
                this.TbCntCadUniMed.Name = "TbCntCadUniMed";
                this.TbCntCadUniMed.SelectedIndex = 0;
                this.TbCntCadUniMed.Size = new System.Drawing.Size(560, 98);
                this.TbCntCadUniMed.TabIndex = 0;
                // 
                // TbPgCadUniMed
                // 
                this.TbPgCadUniMed.AutoScroll = true;
                this.TbPgCadUniMed.Controls.Add(this.label1);
                this.TbPgCadUniMed.Controls.Add(this.CkBoxInteiro);
                this.TbPgCadUniMed.Controls.Add(this.TxtDesc);
                this.TbPgCadUniMed.Controls.Add(this.TxtNomRed);
                this.TbPgCadUniMed.Controls.Add(this.LblDescricao);
                this.TbPgCadUniMed.Controls.Add(this.LblNomRed);
                this.TbPgCadUniMed.Location = new System.Drawing.Point(4, 22);
                this.TbPgCadUniMed.Name = "TbPgCadUniMed";
                this.TbPgCadUniMed.Padding = new System.Windows.Forms.Padding(3);
                this.TbPgCadUniMed.Size = new System.Drawing.Size(552, 72);
                this.TbPgCadUniMed.TabIndex = 1;
                this.TbPgCadUniMed.Text = "Cadastro Unidade de Medida";
                this.TbPgCadUniMed.UseVisualStyleBackColor = true;
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label1.ForeColor = System.Drawing.Color.CadetBlue;
                this.label1.Location = new System.Drawing.Point(380, 1);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(132, 13);
                this.label1.TabIndex = 52;
                this.label1.Text = "Tipo Unidade Medida:";
                // 
                // CkBoxInteiro
                // 
                this.CkBoxInteiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold);
                this.CkBoxInteiro.ForeColor = System.Drawing.Color.CadetBlue;
                this.CkBoxInteiro.Location = new System.Drawing.Point(396, 15);
                this.CkBoxInteiro.Name = "CkBoxInteiro";
                this.CkBoxInteiro.Size = new System.Drawing.Size(126, 24);
                this.CkBoxInteiro.TabIndex = 51;
                this.CkBoxInteiro.Text = "Inteiro";
                this.CkBoxInteiro.UseVisualStyleBackColor = true;
                // 
                // TxtDesc
                // 
                this.TxtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uNIDADEMEDIDABindingSource, "CODUNIDADEMEDIDA", true));
                this.TxtDesc.Location = new System.Drawing.Point(15, 19);
                this.TxtDesc.MaxLength = 3;
                this.TxtDesc.Name = "TxtDesc";
                this.TxtDesc.Size = new System.Drawing.Size(92, 20);
                this.TxtDesc.TabIndex = 50;
                // 
                // TxtNomRed
                // 
                this.TxtNomRed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uNIDADEMEDIDABindingSource, "DESCRICAO", true));
                this.TxtNomRed.Location = new System.Drawing.Point(128, 19);
                this.TxtNomRed.Name = "TxtNomRed";
                this.TxtNomRed.Size = new System.Drawing.Size(246, 20);
                this.TxtNomRed.TabIndex = 49;
                // 
                // LblDescricao
                // 
                this.LblDescricao.AutoSize = true;
                this.LblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblDescricao.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblDescricao.Location = new System.Drawing.Point(12, 3);
                this.LblDescricao.Name = "LblDescricao";
                this.LblDescricao.Size = new System.Drawing.Size(95, 13);
                this.LblDescricao.TabIndex = 48;
                this.LblDescricao.Text = "Nome reduzido:";
                this.LblDescricao.Click += new System.EventHandler(this.LblDescricao_Click);
                // 
                // LblNomRed
                // 
                this.LblNomRed.AutoSize = true;
                this.LblNomRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblNomRed.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblNomRed.Location = new System.Drawing.Point(125, 3);
                this.LblNomRed.Name = "LblNomRed";
                this.LblNomRed.Size = new System.Drawing.Size(68, 13);
                this.LblNomRed.TabIndex = 47;
                this.LblNomRed.Text = "Descrição:";
                // 
                // consultaunidadeToolStrip
                // 
                this.consultaunidadeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cODUNIDADEMEDIDAToolStripLabel,
            this.cODUNIDADEMEDIDAToolStripTextBox,
            this.dESCRICAOToolStripLabel,
            this.dESCRICAOToolStripTextBox,
            this.consultaunidadeToolStripButton,
            this.toolStripButton3,
            this.toolStripButton2});
                this.consultaunidadeToolStrip.Location = new System.Drawing.Point(0, 0);
                this.consultaunidadeToolStrip.Name = "consultaunidadeToolStrip";
                this.consultaunidadeToolStrip.Size = new System.Drawing.Size(580, 25);
                this.consultaunidadeToolStrip.TabIndex = 1;
                this.consultaunidadeToolStrip.Text = "consultaunidadeToolStrip";
                this.consultaunidadeToolStrip.Visible = false;
                // 
                // cODUNIDADEMEDIDAToolStripLabel
                // 
                this.cODUNIDADEMEDIDAToolStripLabel.Name = "cODUNIDADEMEDIDAToolStripLabel";
                this.cODUNIDADEMEDIDAToolStripLabel.Size = new System.Drawing.Size(44, 22);
                this.cODUNIDADEMEDIDAToolStripLabel.Text = "Codigo:";
                // 
                // cODUNIDADEMEDIDAToolStripTextBox
                // 
                this.cODUNIDADEMEDIDAToolStripTextBox.Name = "cODUNIDADEMEDIDAToolStripTextBox";
                this.cODUNIDADEMEDIDAToolStripTextBox.Size = new System.Drawing.Size(100, 25);
                // 
                // dESCRICAOToolStripLabel
                // 
                this.dESCRICAOToolStripLabel.Name = "dESCRICAOToolStripLabel";
                this.dESCRICAOToolStripLabel.Size = new System.Drawing.Size(57, 22);
                this.dESCRICAOToolStripLabel.Text = "Descrição:";
                // 
                // dESCRICAOToolStripTextBox
                // 
                this.dESCRICAOToolStripTextBox.Name = "dESCRICAOToolStripTextBox";
                this.dESCRICAOToolStripTextBox.Size = new System.Drawing.Size(100, 25);
                // 
                // consultaunidadeToolStripButton
                // 
                this.consultaunidadeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.consultaunidadeToolStripButton.Image = global::Comercial.Properties.Resources.search1;
                this.consultaunidadeToolStripButton.Name = "consultaunidadeToolStripButton";
                this.consultaunidadeToolStripButton.Size = new System.Drawing.Size(23, 22);
                this.consultaunidadeToolStripButton.Text = "consultaunidade";
                // 
                // toolStripButton3
                // 
                this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
                this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.toolStripButton3.Name = "toolStripButton3";
                this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
                this.toolStripButton3.Text = "Limpar";
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
                // 
                // cOMERCIALDataSet
                // 
                this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
                this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
                // 
                // uNIDADEMEDIDABindingSource
                // 
                this.uNIDADEMEDIDABindingSource.DataMember = "UNIDADEMEDIDA";
                this.uNIDADEMEDIDABindingSource.DataSource = this.cOMERCIALDataSet;
                this.uNIDADEMEDIDABindingSource.PositionChanged += new System.EventHandler(this.uNIDADEMEDIDABindingSource_PositionChanged);
                // 
                // uNIDADEMEDIDATableAdapter
                // 
                this.uNIDADEMEDIDATableAdapter.ClearBeforeFill = true;
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
                this.tableAdapterManager.REGIAOTableAdapter = null;
                this.tableAdapterManager.TRANSPORTADORATableAdapter = null;
                this.tableAdapterManager.TRANSPORTADORAVIATableAdapter = null;
                this.tableAdapterManager.UNIDADEMEDIDATableAdapter = this.uNIDADEMEDIDATableAdapter;
                this.tableAdapterManager.UpdateOrder = Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
                this.tableAdapterManager.USUARIOTableAdapter = null;
                this.tableAdapterManager.VENDEDORTableAdapter = null;
                this.tableAdapterManager.VIATRANSPORTETableAdapter = null;
                // 
                // FrmCadUniMed
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.WhiteSmoke;
                this.ClientSize = new System.Drawing.Size(580, 145);
                this.Controls.Add(this.consultaunidadeToolStrip);
                this.Controls.Add(this.TbCntCadUniMed);
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "FrmCadUniMed";
                this.ShowIcon = false;
                this.Text = "Cadastro de Unidade de Medida";
                this.Load += new System.EventHandler(this.FrmCadUniMed_Load_1);
                this.TbCntCadUniMed.ResumeLayout(false);
                this.TbPgCadUniMed.ResumeLayout(false);
                this.TbPgCadUniMed.PerformLayout();
                this.consultaunidadeToolStrip.ResumeLayout(false);
                this.consultaunidadeToolStrip.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.uNIDADEMEDIDABindingSource)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.TabControl TbCntCadUniMed;
        private System.Windows.Forms.TabPage TbPgCadUniMed;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.TextBox TxtNomRed;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.Label LblNomRed;
        public COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.ToolStripLabel cODUNIDADEMEDIDAToolStripLabel;
        private System.Windows.Forms.ToolStripLabel dESCRICAOToolStripLabel;
        private System.Windows.Forms.ToolStripButton consultaunidadeToolStripButton;
        public System.Windows.Forms.ToolStripButton toolStripButton3;
        public System.Windows.Forms.ToolStripButton toolStripButton2;
        public System.Windows.Forms.ToolStrip consultaunidadeToolStrip;
        public System.Windows.Forms.ToolStripTextBox cODUNIDADEMEDIDAToolStripTextBox;
        public System.Windows.Forms.ToolStripTextBox dESCRICAOToolStripTextBox;
        private System.Windows.Forms.CheckBox CkBoxInteiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource uNIDADEMEDIDABindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.UNIDADEMEDIDATableAdapter uNIDADEMEDIDATableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;

        }
    }