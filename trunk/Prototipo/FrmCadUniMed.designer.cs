namespace Comercial
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
                this.TbCntCadUniMed = new System.Windows.Forms.TabControl();
                this.TbPgCadUniMed = new System.Windows.Forms.TabPage();
                this.TxtDesc = new System.Windows.Forms.TextBox();
                this.uNIDADEMEDIDABindingSource = new System.Windows.Forms.BindingSource(this.components);
                this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
                this.TxtNomRed = new System.Windows.Forms.TextBox();
                this.LblDescricao = new System.Windows.Forms.Label();
                this.LblNomRed = new System.Windows.Forms.Label();
                this.uNIDADEMEDIDATableAdapter = new Comercial.COMERCIALDataSetTableAdapters.UNIDADEMEDIDATableAdapter();
                this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
                this.TbCntCadUniMed.SuspendLayout();
                this.TbPgCadUniMed.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.uNIDADEMEDIDABindingSource)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
                this.SuspendLayout();
                // 
                // TbCntCadUniMed
                // 
                this.TbCntCadUniMed.Controls.Add(this.TbPgCadUniMed);
                this.TbCntCadUniMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TbCntCadUniMed.Location = new System.Drawing.Point(12, 12);
                this.TbCntCadUniMed.Name = "TbCntCadUniMed";
                this.TbCntCadUniMed.SelectedIndex = 0;
                this.TbCntCadUniMed.Size = new System.Drawing.Size(411, 78);
                this.TbCntCadUniMed.TabIndex = 0;
                // 
                // TbPgCadUniMed
                // 
                this.TbPgCadUniMed.AutoScroll = true;
                this.TbPgCadUniMed.Controls.Add(this.TxtDesc);
                this.TbPgCadUniMed.Controls.Add(this.TxtNomRed);
                this.TbPgCadUniMed.Controls.Add(this.LblDescricao);
                this.TbPgCadUniMed.Controls.Add(this.LblNomRed);
                this.TbPgCadUniMed.Location = new System.Drawing.Point(4, 22);
                this.TbPgCadUniMed.Name = "TbPgCadUniMed";
                this.TbPgCadUniMed.Padding = new System.Windows.Forms.Padding(3);
                this.TbPgCadUniMed.Size = new System.Drawing.Size(403, 52);
                this.TbPgCadUniMed.TabIndex = 1;
                this.TbPgCadUniMed.Text = "Cadastro Unidade de Medida";
                this.TbPgCadUniMed.UseVisualStyleBackColor = true;
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
                // uNIDADEMEDIDABindingSource
                // 
                this.uNIDADEMEDIDABindingSource.DataMember = "UNIDADEMEDIDA";
                this.uNIDADEMEDIDABindingSource.DataSource = this.cOMERCIALDataSet;
                // 
                // cOMERCIALDataSet
                // 
                this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
                this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
                // 
                // TxtNomRed
                // 
                this.TxtNomRed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uNIDADEMEDIDABindingSource, "DESCRICAO", true));
                this.TxtNomRed.Location = new System.Drawing.Point(141, 19);
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
                this.LblNomRed.Location = new System.Drawing.Point(138, 3);
                this.LblNomRed.Name = "LblNomRed";
                this.LblNomRed.Size = new System.Drawing.Size(68, 13);
                this.LblNomRed.TabIndex = 47;
                this.LblNomRed.Text = "Descrição:";
                // 
                // uNIDADEMEDIDATableAdapter
                // 
                this.uNIDADEMEDIDATableAdapter.ClearBeforeFill = true;
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
                this.ClientSize = new System.Drawing.Size(431, 100);
                this.Controls.Add(this.TbCntCadUniMed);
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "FrmCadUniMed";
                this.ShowIcon = false;
                this.Text = "Cadastro de Unidade de Medida";
                this.Load += new System.EventHandler(this.FrmCadUniMed_Load);
                this.TbCntCadUniMed.ResumeLayout(false);
                this.TbPgCadUniMed.ResumeLayout(false);
                this.TbPgCadUniMed.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.uNIDADEMEDIDABindingSource)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
                this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.TabControl TbCntCadUniMed;
        private System.Windows.Forms.TabPage TbPgCadUniMed;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.TextBox TxtNomRed;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.Label LblNomRed;
        private Comercial.COMERCIALDataSetTableAdapters.UNIDADEMEDIDATableAdapter uNIDADEMEDIDATableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.BindingSource uNIDADEMEDIDABindingSource;
        public COMERCIALDataSet cOMERCIALDataSet;

        }
    }