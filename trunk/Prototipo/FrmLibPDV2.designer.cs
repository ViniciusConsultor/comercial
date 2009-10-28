namespace Comercial
{
    partial class FrmLibPDV2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbCntrlPedVend = new System.Windows.Forms.TabControl();
            this.tbPgPDV = new System.Windows.Forms.TabPage();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.cmbtpPesquisa = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnPesqusiar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.pEDIDOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.PEDIDOTableAdapter();
            this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
            this.ColSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtgvListarPedido = new System.Windows.Forms.DataGridView();
            this.grpSituacao = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblteztoPendente = new System.Windows.Forms.Label();
            this.lblPendente = new System.Windows.Forms.Label();
            this.lblCancelado = new System.Windows.Forms.Label();
            this.lblEfetivado = new System.Windows.Forms.Label();
            this.chkLegenda = new System.Windows.Forms.CheckBox();
            this.tbCntrlPedVend.SuspendLayout();
            this.tbPgPDV.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListarPedido)).BeginInit();
            this.grpSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCntrlPedVend
            // 
            this.tbCntrlPedVend.Controls.Add(this.tbPgPDV);
            this.tbCntrlPedVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlPedVend.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlPedVend.Name = "tbCntrlPedVend";
            this.tbCntrlPedVend.SelectedIndex = 0;
            this.tbCntrlPedVend.Size = new System.Drawing.Size(889, 472);
            this.tbCntrlPedVend.TabIndex = 2001;
            // 
            // tbPgPDV
            // 
            this.tbPgPDV.AutoScroll = true;
            this.tbPgPDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tbPgPDV.Controls.Add(this.grpSituacao);
            this.tbPgPDV.Controls.Add(this.txtPesquisar);
            this.tbPgPDV.Controls.Add(this.cmbtpPesquisa);
            this.tbPgPDV.Controls.Add(this.groupBox1);
            this.tbPgPDV.Controls.Add(this.dtgvListarPedido);
            this.tbPgPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPgPDV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbPgPDV.Location = new System.Drawing.Point(4, 22);
            this.tbPgPDV.Name = "tbPgPDV";
            this.tbPgPDV.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgPDV.Size = new System.Drawing.Size(881, 446);
            this.tbPgPDV.TabIndex = 0;
            this.tbPgPDV.Text = "Pedidos de Vendas";
            this.tbPgPDV.UseVisualStyleBackColor = true;
            this.tbPgPDV.Click += new System.EventHandler(this.tbPgPDV_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(260, 11);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(208, 22);
            this.txtPesquisar.TabIndex = 3;
            // 
            // cmbtpPesquisa
            // 
            this.cmbtpPesquisa.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtpPesquisa.FormattingEnabled = true;
            this.cmbtpPesquisa.Items.AddRange(new object[] {
            "Numero Pedido",
            "Cliente"});
            this.cmbtpPesquisa.Location = new System.Drawing.Point(102, 11);
            this.cmbtpPesquisa.Name = "cmbtpPesquisa";
            this.cmbtpPesquisa.Size = new System.Drawing.Size(151, 21);
            this.cmbtpPesquisa.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLegenda);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnLiberar);
            this.groupBox1.Controls.Add(this.btnVisualizar);
            this.groupBox1.Controls.Add(this.btnPesqusiar);
            this.groupBox1.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(7, 88);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 20);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLiberar
            // 
            this.btnLiberar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiberar.Location = new System.Drawing.Point(6, 62);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(79, 20);
            this.btnLiberar.TabIndex = 2;
            this.btnLiberar.Text = "Liberar";
            this.btnLiberar.UseVisualStyleBackColor = true;
            this.btnLiberar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(7, 36);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(79, 20);
            this.btnVisualizar.TabIndex = 1;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPesqusiar
            // 
            this.btnPesqusiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqusiar.Location = new System.Drawing.Point(7, 11);
            this.btnPesqusiar.Name = "btnPesqusiar";
            this.btnPesqusiar.Size = new System.Drawing.Size(79, 20);
            this.btnPesqusiar.TabIndex = 0;
            this.btnPesqusiar.Text = "Pesquisar";
            this.btnPesqusiar.UseVisualStyleBackColor = true;
            this.btnPesqusiar.Click += new System.EventHandler(this.btnPesqusiar_Click);
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
            // ColSituacao
            // 
            this.ColSituacao.DataPropertyName = "SITUACAO";
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Times New Roman", 9F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Black;
            this.ColSituacao.DefaultCellStyle = dataGridViewCellStyle21;
            this.ColSituacao.HeaderText = "Situação";
            this.ColSituacao.Name = "ColSituacao";
            this.ColSituacao.ReadOnly = true;
            // 
            // ColDtEntrega
            // 
            this.ColDtEntrega.DataPropertyName = "DATAENTREGA";
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Times New Roman", 9F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Black;
            this.ColDtEntrega.DefaultCellStyle = dataGridViewCellStyle20;
            this.ColDtEntrega.HeaderText = "Data Entrega";
            this.ColDtEntrega.Name = "ColDtEntrega";
            this.ColDtEntrega.ReadOnly = true;
            // 
            // ColDtEmissao
            // 
            this.ColDtEmissao.DataPropertyName = "DATAEMISSAO";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Times New Roman", 9F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Black;
            this.ColDtEmissao.DefaultCellStyle = dataGridViewCellStyle19;
            this.ColDtEmissao.HeaderText = "Data Emissão";
            this.ColDtEmissao.Name = "ColDtEmissao";
            this.ColDtEmissao.ReadOnly = true;
            // 
            // ColCliente
            // 
            this.ColCliente.DataPropertyName = "RAZAOSOCIAL";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 9F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Black;
            this.ColCliente.DefaultCellStyle = dataGridViewCellStyle18;
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            // 
            // ColTipo
            // 
            this.ColTipo.DataPropertyName = "TIPO";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Times New Roman", 9F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Black;
            this.ColTipo.DefaultCellStyle = dataGridViewCellStyle17;
            this.ColTipo.HeaderText = "Tipo";
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.ReadOnly = true;
            // 
            // ColPedido
            // 
            this.ColPedido.DataPropertyName = "NRPEDIDO";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 9F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.ColPedido.DefaultCellStyle = dataGridViewCellStyle16;
            this.ColPedido.HeaderText = "Pedido";
            this.ColPedido.Name = "ColPedido";
            this.ColPedido.ReadOnly = true;
            // 
            // ColStatus
            // 
            this.ColStatus.DataPropertyName = "ImageStatus";
            this.ColStatus.HeaderText = "";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            this.ColStatus.Width = 30;
            // 
            // dtgvListarPedido
            // 
            this.dtgvListarPedido.AllowUserToAddRows = false;
            this.dtgvListarPedido.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvListarPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgvListarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvListarPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvListarPedido.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgvListarPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvListarPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgvListarPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStatus,
            this.ColPedido,
            this.ColTipo,
            this.ColCliente,
            this.ColDtEmissao,
            this.ColDtEntrega,
            this.ColSituacao});
            this.dtgvListarPedido.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvListarPedido.Location = new System.Drawing.Point(102, 41);
            this.dtgvListarPedido.Name = "dtgvListarPedido";
            this.dtgvListarPedido.ReadOnly = true;
            this.dtgvListarPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvListarPedido.RowHeadersWidth = 20;
            this.dtgvListarPedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvListarPedido.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvListarPedido.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dtgvListarPedido.Size = new System.Drawing.Size(773, 399);
            this.dtgvListarPedido.TabIndex = 0;
            this.dtgvListarPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListarPedido_CellContentClick);
            // 
            // grpSituacao
            // 
            this.grpSituacao.Controls.Add(this.label2);
            this.grpSituacao.Controls.Add(this.label1);
            this.grpSituacao.Controls.Add(this.lblteztoPendente);
            this.grpSituacao.Controls.Add(this.lblPendente);
            this.grpSituacao.Controls.Add(this.lblCancelado);
            this.grpSituacao.Controls.Add(this.lblEfetivado);
            this.grpSituacao.Enabled = false;
            this.grpSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSituacao.ForeColor = System.Drawing.Color.CadetBlue;
            this.grpSituacao.Location = new System.Drawing.Point(6, 154);
            this.grpSituacao.Name = "grpSituacao";
            this.grpSituacao.Size = new System.Drawing.Size(90, 91);
            this.grpSituacao.TabIndex = 6;
            this.grpSituacao.TabStop = false;
            this.grpSituacao.Text = "Legenda";
            this.grpSituacao.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cancelado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Efetivado";
            // 
            // lblteztoPendente
            // 
            this.lblteztoPendente.AutoSize = true;
            this.lblteztoPendente.Location = new System.Drawing.Point(24, 19);
            this.lblteztoPendente.Name = "lblteztoPendente";
            this.lblteztoPendente.Size = new System.Drawing.Size(61, 13);
            this.lblteztoPendente.TabIndex = 5;
            this.lblteztoPendente.Text = "Pendente";
            // 
            // lblPendente
            // 
            this.lblPendente.AutoSize = true;
            this.lblPendente.Image = global::Comercial.Properties.Resources.BolaAmarela;
            this.lblPendente.Location = new System.Drawing.Point(-3, 19);
            this.lblPendente.MaximumSize = new System.Drawing.Size(30, 30);
            this.lblPendente.MinimumSize = new System.Drawing.Size(30, 0);
            this.lblPendente.Name = "lblPendente";
            this.lblPendente.Size = new System.Drawing.Size(30, 13);
            this.lblPendente.TabIndex = 2;
            // 
            // lblCancelado
            // 
            this.lblCancelado.AutoSize = true;
            this.lblCancelado.Image = global::Comercial.Properties.Resources.BolaVermelho;
            this.lblCancelado.Location = new System.Drawing.Point(-3, 64);
            this.lblCancelado.MaximumSize = new System.Drawing.Size(30, 30);
            this.lblCancelado.MinimumSize = new System.Drawing.Size(30, 0);
            this.lblCancelado.Name = "lblCancelado";
            this.lblCancelado.Size = new System.Drawing.Size(30, 13);
            this.lblCancelado.TabIndex = 4;
            // 
            // lblEfetivado
            // 
            this.lblEfetivado.AutoSize = true;
            this.lblEfetivado.Image = global::Comercial.Properties.Resources.BolaVerde;
            this.lblEfetivado.Location = new System.Drawing.Point(-3, 42);
            this.lblEfetivado.MaximumSize = new System.Drawing.Size(30, 30);
            this.lblEfetivado.MinimumSize = new System.Drawing.Size(30, 0);
            this.lblEfetivado.Name = "lblEfetivado";
            this.lblEfetivado.Size = new System.Drawing.Size(30, 13);
            this.lblEfetivado.TabIndex = 3;
            // 
            // chkLegenda
            // 
            this.chkLegenda.AutoSize = true;
            this.chkLegenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLegenda.Location = new System.Drawing.Point(7, 114);
            this.chkLegenda.Name = "chkLegenda";
            this.chkLegenda.Size = new System.Drawing.Size(75, 17);
            this.chkLegenda.TabIndex = 4;
            this.chkLegenda.Text = "Legenda";
            this.chkLegenda.UseVisualStyleBackColor = true;
            this.chkLegenda.CheckedChanged += new System.EventHandler(this.chkLegenda_CheckedChanged);
            // 
            // FrmLibPDV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 577);
            this.Controls.Add(this.tbCntrlPedVend);
            this.Name = "FrmLibPDV2";
            this.Text = "FrmLibPDV";
            this.Load += new System.EventHandler(this.FrmLibPDV_Load);
            this.Leave += new System.EventHandler(this.FrmLibPDV_Leave);
            this.tbCntrlPedVend.ResumeLayout(false);
            this.tbPgPDV.ResumeLayout(false);
            this.tbPgPDV.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListarPedido)).EndInit();
            this.grpSituacao.ResumeLayout(false);
            this.grpSituacao.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnPesqusiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.ComboBox cmbtpPesquisa;
        private System.Windows.Forms.TextBox txtPesquisar;
        public System.Windows.Forms.DataGridView dtgvListarPedido;
        private System.Windows.Forms.DataGridViewImageColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSituacao;
        private System.Windows.Forms.GroupBox grpSituacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblteztoPendente;
        private System.Windows.Forms.Label lblPendente;
        private System.Windows.Forms.Label lblCancelado;
        private System.Windows.Forms.Label lblEfetivado;
        private System.Windows.Forms.CheckBox chkLegenda;

    }
}