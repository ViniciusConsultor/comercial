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
                this.tabPage2 = new System.Windows.Forms.TabPage();
                this.lblCodigo = new System.Windows.Forms.Label();
                this.cONDICAOPAGAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
                this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
                this.TxtDiaDes = new System.Windows.Forms.TextBox();
                this.TxtDes = new System.Windows.Forms.TextBox();
                this.LblDiaPCo = new System.Windows.Forms.Label();
                this.LblDes = new System.Windows.Forms.Label();
                this.TbCntConPag = new System.Windows.Forms.TabControl();
                this.cONDICAOPAGAMENTOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.CONDICAOPAGAMENTOTableAdapter();
                this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
                this.eNTRADACheckBox = new System.Windows.Forms.CheckBox();
                this.tabPage2.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.cONDICAOPAGAMENTOBindingSource)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
                this.TbCntConPag.SuspendLayout();
                this.SuspendLayout();
                // 
                // tabPage2
                // 
                this.tabPage2.AutoScroll = true;
                this.tabPage2.Controls.Add(this.eNTRADACheckBox);
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
                // cONDICAOPAGAMENTOBindingSource
                // 
                this.cONDICAOPAGAMENTOBindingSource.DataMember = "CONDICAOPAGAMENTO";
                this.cONDICAOPAGAMENTOBindingSource.DataSource = this.cOMERCIALDataSet;
                // 
                // cOMERCIALDataSet
                // 
                this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
                this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
                // 
                // TxtDiaDes
                // 
                this.TxtDiaDes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONDICAOPAGAMENTOBindingSource, "QTDEVEZES", true));
                this.TxtDiaDes.Location = new System.Drawing.Point(313, 19);
                this.TxtDiaDes.Name = "TxtDiaDes";
                this.TxtDiaDes.Size = new System.Drawing.Size(106, 20);
                this.TxtDiaDes.TabIndex = 45;
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
                this.TbCntConPag.Location = new System.Drawing.Point(12, 12);
                this.TbCntConPag.Name = "TbCntConPag";
                this.TbCntConPag.SelectedIndex = 0;
                this.TbCntConPag.Size = new System.Drawing.Size(549, 100);
                this.TbCntConPag.TabIndex = 0;
                // 
                // cONDICAOPAGAMENTOTableAdapter
                // 
                this.cONDICAOPAGAMENTOTableAdapter.ClearBeforeFill = true;
                // 
                // tableAdapterManager
                // 
                this.tableAdapterManager.ACESSOTableAdapter = null;
                this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
                this.tableAdapterManager.CLIENTETableAdapter = null;
                this.tableAdapterManager.CONDICAOPAGAMENTOTableAdapter = this.cONDICAOPAGAMENTOTableAdapter;
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
                this.tableAdapterManager.UNIDADEMEDIDATableAdapter = null;
                this.tableAdapterManager.UpdateOrder = Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
                this.tableAdapterManager.USUARIOTableAdapter = null;
                this.tableAdapterManager.VENDEDORTableAdapter = null;
                this.tableAdapterManager.VIATRANSPORTETableAdapter = null;
                // 
                // eNTRADACheckBox
                // 
                this.eNTRADACheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cONDICAOPAGAMENTOBindingSource, "ENTRADA", true));
                this.eNTRADACheckBox.Location = new System.Drawing.Point(425, 19);
                this.eNTRADACheckBox.Name = "eNTRADACheckBox";
                this.eNTRADACheckBox.Size = new System.Drawing.Size(104, 24);
                this.eNTRADACheckBox.TabIndex = 48;
                this.eNTRADACheckBox.Text = "Entrada";
                this.eNTRADACheckBox.UseVisualStyleBackColor = true;
                // 
                // FrmCadConPag
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.WhiteSmoke;
                this.ClientSize = new System.Drawing.Size(573, 124);
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
                ((System.ComponentModel.ISupportInitialize)(this.cONDICAOPAGAMENTOBindingSource)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
                this.TbCntConPag.ResumeLayout(false);
                this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox eNTRADACheckBox;


        }
    }