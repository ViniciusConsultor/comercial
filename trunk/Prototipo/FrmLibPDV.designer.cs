namespace Comercial
{
    partial class FrmLibPDV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbCntrlPedVend = new System.Windows.Forms.TabControl();
            this.tbPgPDV = new System.Windows.Forms.TabPage();
            this.dtgvListarPedido = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.pEDIDOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.PEDIDOTableAdapter();
            this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
            this.ColStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCntrlPedVend.SuspendLayout();
            this.tbPgPDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListarPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrlPedVend
            // 
            this.tbCntrlPedVend.Controls.Add(this.tbPgPDV);
            this.tbCntrlPedVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlPedVend.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlPedVend.Name = "tbCntrlPedVend";
            this.tbCntrlPedVend.SelectedIndex = 0;
            this.tbCntrlPedVend.Size = new System.Drawing.Size(889, 557);
            this.tbCntrlPedVend.TabIndex = 2001;
            // 
            // tbPgPDV
            // 
            this.tbPgPDV.AutoScroll = true;
            this.tbPgPDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tbPgPDV.Controls.Add(this.dtgvListarPedido);
            this.tbPgPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPgPDV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbPgPDV.Location = new System.Drawing.Point(4, 22);
            this.tbPgPDV.Name = "tbPgPDV";
            this.tbPgPDV.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgPDV.Size = new System.Drawing.Size(881, 531);
            this.tbPgPDV.TabIndex = 0;
            this.tbPgPDV.Text = "Pedidos de Vendas";
            this.tbPgPDV.UseVisualStyleBackColor = true;
            // 
            // dtgvListarPedido
            // 
            this.dtgvListarPedido.AllowUserToAddRows = false;
            this.dtgvListarPedido.AllowUserToDeleteRows = false;
            this.dtgvListarPedido.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgvListarPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListarPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStatus,
            this.ColPedido,
            this.ColTipo,
            this.ColCliente,
            this.ColDtEmissao,
            this.ColDtEntrega,
            this.ColSituacao});
            this.dtgvListarPedido.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvListarPedido.Location = new System.Drawing.Point(6, 6);
            this.dtgvListarPedido.Name = "dtgvListarPedido";
            this.dtgvListarPedido.Size = new System.Drawing.Size(869, 519);
            this.dtgvListarPedido.TabIndex = 0;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "NRPEDIDO";
            this.dataGridViewImageColumn1.HeaderText = "Status";
            this.dataGridViewImageColumn1.Image = global::Comercial.Properties.Resources.BolaVerde;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // pEDIDOBindingSource
            // 
            this.pEDIDOBindingSource.DataMember = "PEDIDO";
            this.pEDIDOBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // cOMERCIALDataSet
            // 
            this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
            this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pEDIDOTableAdapter
            // 
            this.pEDIDOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PEDIDOTableAdapter = this.pEDIDOTableAdapter;
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
            // ColStatus
            // 
            this.ColStatus.DataPropertyName = "ImageStatus";
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            // 
            // ColPedido
            // 
            this.ColPedido.DataPropertyName = "NRPEDIDO";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ColPedido.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColPedido.HeaderText = "Pedido";
            this.ColPedido.Name = "ColPedido";
            // 
            // ColTipo
            // 
            this.ColTipo.DataPropertyName = "TIPO";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.ColTipo.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColTipo.HeaderText = "Tipo";
            this.ColTipo.Name = "ColTipo";
            // 
            // ColCliente
            // 
            this.ColCliente.DataPropertyName = "RAZAOSOCIAL";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.ColCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            // 
            // ColDtEmissao
            // 
            this.ColDtEmissao.DataPropertyName = "DATAEMISSAO";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.ColDtEmissao.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColDtEmissao.HeaderText = "Data Emissão";
            this.ColDtEmissao.Name = "ColDtEmissao";
            // 
            // ColDtEntrega
            // 
            this.ColDtEntrega.DataPropertyName = "DATAENTREGA";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.ColDtEntrega.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColDtEntrega.HeaderText = "Data Entrega";
            this.ColDtEntrega.Name = "ColDtEntrega";
            // 
            // ColSituacao
            // 
            this.ColSituacao.DataPropertyName = "SITUACAO";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.ColSituacao.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColSituacao.HeaderText = "Situação";
            this.ColSituacao.Name = "ColSituacao";
            // 
            // FrmLibPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 577);
            this.Controls.Add(this.tbCntrlPedVend);
            this.Name = "FrmLibPDV";
            this.Text = "FrmLibPDV";
            this.Load += new System.EventHandler(this.FrmLibPDV_Load);
            this.Leave += new System.EventHandler(this.FrmLibPDV_Leave);
            this.tbCntrlPedVend.ResumeLayout(false);
            this.tbPgPDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListarPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrlPedVend;
        private System.Windows.Forms.TabPage tbPgPDV;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource pEDIDOBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.PEDIDOTableAdapter pEDIDOTableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dtgvListarPedido;
        private System.Windows.Forms.DataGridViewImageColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSituacao;

    }
}