namespace Comercial
    {
    partial class FrmCadGrpProd
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
                this.TbCntCadBan = new System.Windows.Forms.TabControl();
                this.TbPgCadBancos = new System.Windows.Forms.TabPage();
                this.lblCodigo = new System.Windows.Forms.Label();
                this.gRUPOPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
                this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
                this.textBox1 = new System.Windows.Forms.TextBox();
                this.label1 = new System.Windows.Forms.Label();
                this.TxtNumCon = new System.Windows.Forms.TextBox();
                this.LblNumCon = new System.Windows.Forms.Label();
                this.gRUPOPRODUTOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.GRUPOPRODUTOTableAdapter();
                this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
                this.TbCntCadBan.SuspendLayout();
                this.TbPgCadBancos.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.gRUPOPRODUTOBindingSource)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
                this.SuspendLayout();
                // 
                // TbCntCadBan
                // 
                this.TbCntCadBan.Controls.Add(this.TbPgCadBancos);
                this.TbCntCadBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TbCntCadBan.Location = new System.Drawing.Point(12, 12);
                this.TbCntCadBan.Name = "TbCntCadBan";
                this.TbCntCadBan.SelectedIndex = 0;
                this.TbCntCadBan.Size = new System.Drawing.Size(426, 95);
                this.TbCntCadBan.TabIndex = 0;
                // 
                // TbPgCadBancos
                // 
                this.TbPgCadBancos.AutoScroll = true;
                this.TbPgCadBancos.Controls.Add(this.lblCodigo);
                this.TbPgCadBancos.Controls.Add(this.textBox1);
                this.TbPgCadBancos.Controls.Add(this.label1);
                this.TbPgCadBancos.Controls.Add(this.TxtNumCon);
                this.TbPgCadBancos.Controls.Add(this.LblNumCon);
                this.TbPgCadBancos.Location = new System.Drawing.Point(4, 22);
                this.TbPgCadBancos.Name = "TbPgCadBancos";
                this.TbPgCadBancos.Padding = new System.Windows.Forms.Padding(3);
                this.TbPgCadBancos.Size = new System.Drawing.Size(418, 69);
                this.TbPgCadBancos.TabIndex = 1;
                this.TbPgCadBancos.Text = "Cadastro de grupo de produto";
                this.TbPgCadBancos.UseVisualStyleBackColor = true;
                this.TbPgCadBancos.Click += new System.EventHandler(this.TbPgCadBancos_Click);
                // 
                // lblCodigo
                // 
                this.lblCodigo.AutoSize = true;
                this.lblCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gRUPOPRODUTOBindingSource, "CODGRUPOPRODUTO", true));
                this.lblCodigo.ForeColor = System.Drawing.Color.CadetBlue;
                this.lblCodigo.Location = new System.Drawing.Point(3, 37);
                this.lblCodigo.Name = "lblCodigo";
                this.lblCodigo.Size = new System.Drawing.Size(50, 13);
                this.lblCodigo.TabIndex = 71;
                this.lblCodigo.Text = "Código:";
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
                // textBox1
                // 
                this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gRUPOPRODUTOBindingSource, "DESCONTO", true));
                this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.textBox1.Location = new System.Drawing.Point(296, 34);
                this.textBox1.Name = "textBox1";
                this.textBox1.Size = new System.Drawing.Size(116, 20);
                this.textBox1.TabIndex = 70;
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label1.ForeColor = System.Drawing.Color.CadetBlue;
                this.label1.Location = new System.Drawing.Point(293, 18);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(61, 13);
                this.label1.TabIndex = 69;
                this.label1.Text = "Desconto";
                // 
                // TxtNumCon
                // 
                this.TxtNumCon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gRUPOPRODUTOBindingSource, "DESCRICAO", true));
                this.TxtNumCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TxtNumCon.Location = new System.Drawing.Point(65, 34);
                this.TxtNumCon.Name = "TxtNumCon";
                this.TxtNumCon.Size = new System.Drawing.Size(225, 20);
                this.TxtNumCon.TabIndex = 68;
                // 
                // LblNumCon
                // 
                this.LblNumCon.AutoSize = true;
                this.LblNumCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblNumCon.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblNumCon.Location = new System.Drawing.Point(62, 18);
                this.LblNumCon.Name = "LblNumCon";
                this.LblNumCon.Size = new System.Drawing.Size(58, 13);
                this.LblNumCon.TabIndex = 67;
                this.LblNumCon.Text = "Decrição";
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
                this.tableAdapterManager.UNIDADEMEDIDATableAdapter = null;
                this.tableAdapterManager.UpdateOrder = Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
                this.tableAdapterManager.USUARIOTableAdapter = null;
                this.tableAdapterManager.VENDEDORTableAdapter = null;
                // 
                // FrmCadGrpProd
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.WhiteSmoke;
                this.ClientSize = new System.Drawing.Size(444, 116);
                this.Controls.Add(this.TbCntCadBan);
                this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.ForeColor = System.Drawing.Color.CornflowerBlue;
                this.Name = "FrmCadGrpProd";
                this.ShowIcon = false;
                this.Text = "Cadastro Bancos";
                this.Load += new System.EventHandler(this.FrmCadBan_Load);
                this.Shown += new System.EventHandler(this.FrmCadGrpProd_Shown);
                this.TbCntCadBan.ResumeLayout(false);
                this.TbPgCadBancos.ResumeLayout(false);
                this.TbPgCadBancos.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.gRUPOPRODUTOBindingSource)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
                this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.TabControl TbCntCadBan;
        private System.Windows.Forms.TabPage TbPgCadBancos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumCon;
        private System.Windows.Forms.Label LblNumCon;
        private System.Windows.Forms.Label lblCodigo;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource gRUPOPRODUTOBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.GRUPOPRODUTOTableAdapter gRUPOPRODUTOTableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;

        }
    }

