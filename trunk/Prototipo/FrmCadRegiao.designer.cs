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
                this.TBCntCadRediao = new System.Windows.Forms.TabControl();
                this.TbPgCadRegiao = new System.Windows.Forms.TabPage();
                this.lblCodigo = new System.Windows.Forms.Label();
                this.rEGIAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
                this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
                this.TxtDes = new System.Windows.Forms.TextBox();
                this.LblDes = new System.Windows.Forms.Label();
                this.rEGIAOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.REGIAOTableAdapter();
                this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
                this.TBCntCadRediao.SuspendLayout();
                this.TbPgCadRegiao.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.rEGIAOBindingSource)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
                this.SuspendLayout();
                // 
                // TBCntCadRediao
                // 
                this.TBCntCadRediao.Controls.Add(this.TbPgCadRegiao);
                this.TBCntCadRediao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TBCntCadRediao.Location = new System.Drawing.Point(12, 12);
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
                // rEGIAOTableAdapter
                // 
                this.rEGIAOTableAdapter.ClearBeforeFill = true;
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
                this.ClientSize = new System.Drawing.Size(486, 215);
                this.ControlBox = false;
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
                this.ResumeLayout(false);

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

        }
    }