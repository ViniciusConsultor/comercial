namespace Comercial
{
    partial class FrmPermissoesUsu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPermissoesUsu));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpBxInfor = new System.Windows.Forms.GroupBox();
            this.chckBxPriv = new System.Windows.Forms.CheckBox();
            this.chckBxUsublq = new System.Windows.Forms.CheckBox();
            this.lblUsua = new System.Windows.Forms.Label();
            this.tbCntrlCtrUsu = new System.Windows.Forms.TabControl();
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.USUARIOTableAdapter();
            this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
            this.txtUsu = new Comercial.TextButton();
            this.tabPage1.SuspendLayout();
            this.grpBxInfor.SuspendLayout();
            this.tbCntrlCtrUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.grpBxInfor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Permissões";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpBxInfor
            // 
            this.grpBxInfor.Controls.Add(this.chckBxPriv);
            this.grpBxInfor.Controls.Add(this.txtUsu);
            this.grpBxInfor.Controls.Add(this.chckBxUsublq);
            this.grpBxInfor.Controls.Add(this.lblUsua);
            this.grpBxInfor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxInfor.Location = new System.Drawing.Point(6, 6);
            this.grpBxInfor.Name = "grpBxInfor";
            this.grpBxInfor.Size = new System.Drawing.Size(443, 108);
            this.grpBxInfor.TabIndex = 0;
            this.grpBxInfor.TabStop = false;
            this.grpBxInfor.Text = "Informação";
            // 
            // chckBxPriv
            // 
            this.chckBxPriv.AutoSize = true;
            this.chckBxPriv.ForeColor = System.Drawing.Color.CadetBlue;
            this.chckBxPriv.Location = new System.Drawing.Point(198, 35);
            this.chckBxPriv.Name = "chckBxPriv";
            this.chckBxPriv.Size = new System.Drawing.Size(80, 17);
            this.chckBxPriv.TabIndex = 45;
            this.chckBxPriv.Text = "Privilegiado";
            this.chckBxPriv.UseVisualStyleBackColor = true;
            // 
            // chckBxUsublq
            // 
            this.chckBxUsublq.AutoSize = true;
            this.chckBxUsublq.ForeColor = System.Drawing.Color.CadetBlue;
            this.chckBxUsublq.Location = new System.Drawing.Point(284, 35);
            this.chckBxUsublq.Name = "chckBxUsublq";
            this.chckBxUsublq.Size = new System.Drawing.Size(116, 17);
            this.chckBxUsublq.TabIndex = 43;
            this.chckBxUsublq.Text = "Usuário Bloqueado";
            this.chckBxUsublq.UseVisualStyleBackColor = true;
            // 
            // lblUsua
            // 
            this.lblUsua.AutoSize = true;
            this.lblUsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsua.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblUsua.Location = new System.Drawing.Point(11, 19);
            this.lblUsua.Name = "lblUsua";
            this.lblUsua.Size = new System.Drawing.Size(50, 13);
            this.lblUsua.TabIndex = 36;
            this.lblUsua.Text = "Usuário";
            // 
            // tbCntrlCtrUsu
            // 
            this.tbCntrlCtrUsu.Controls.Add(this.tabPage1);
            this.tbCntrlCtrUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlCtrUsu.Location = new System.Drawing.Point(12, 5);
            this.tbCntrlCtrUsu.Name = "tbCntrlCtrUsu";
            this.tbCntrlCtrUsu.SelectedIndex = 0;
            this.tbCntrlCtrUsu.Size = new System.Drawing.Size(530, 238);
            this.tbCntrlCtrUsu.TabIndex = 0;
            // 
            // cOMERCIALDataSet
            // 
            this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
            this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.UNIDADEMEDIDATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = this.uSUARIOTableAdapter;
            this.tableAdapterManager.VENDEDORTableAdapter = null;
            this.tableAdapterManager.VIATRANSPORTETableAdapter = null;
            // 
            // txtUsu
            // 
            this.txtUsu.getText = "";
            this.txtUsu.Image = ((System.Drawing.Image)(resources.GetObject("txtUsu.Image")));
            this.txtUsu.Location = new System.Drawing.Point(11, 35);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.ShowButton = false;
            this.txtUsu.Size = new System.Drawing.Size(181, 25);
            this.txtUsu.TabIndex = 44;
            this.txtUsu.ButtonClick += new System.EventHandler(this.txtBtnUsu_ButtonClick);
            // 
            // FrmPermissoesUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 348);
            this.ControlBox = false;
            this.Controls.Add(this.tbCntrlCtrUsu);
            this.Name = "FrmPermissoesUsu";
            this.Text = "Controle de usuários";
            this.Load += new System.EventHandler(this.FrmPermissoesUsu_Load);
            this.Shown += new System.EventHandler(this.FrmPermissoesUsu_Shown);
            this.Leave += new System.EventHandler(this.FrmPermissoesUsu_Leave);
            this.tabPage1.ResumeLayout(false);
            this.grpBxInfor.ResumeLayout(false);
            this.grpBxInfor.PerformLayout();
            this.tbCntrlCtrUsu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpBxInfor;
        private System.Windows.Forms.Label lblUsua;
        private System.Windows.Forms.TabControl tbCntrlCtrUsu;
        public TextButton txtUsu;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.CheckBox chckBxPriv;
        public System.Windows.Forms.CheckBox chckBxUsublq;

    }
}