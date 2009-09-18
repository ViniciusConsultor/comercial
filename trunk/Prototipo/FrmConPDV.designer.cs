namespace Comercial
{
    partial class FrmConPDV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbCntrlConPDV = new System.Windows.Forms.TabControl();
            this.tbPgConCli = new System.Windows.Forms.TabPage();
            this.grpBxFiltro = new System.Windows.Forms.GroupBox();
            this.grpBxTpRel = new System.Windows.Forms.GroupBox();
            this.rdbProd = new System.Windows.Forms.RadioButton();
            this.rdbped = new System.Windows.Forms.RadioButton();
            this.grpBxCli = new System.Windows.Forms.GroupBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodCli = new Comercial.TextButton();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.grpBxPedido = new System.Windows.Forms.GroupBox();
            this.dtTmPckrDataate = new System.Windows.Forms.DateTimePicker();
            this.lblDataate = new System.Windows.Forms.Label();
            this.dtTmPckrDatade = new System.Windows.Forms.DateTimePicker();
            this.lblDataPed = new System.Windows.Forms.Label();
            this.txtCodPed = new Comercial.TextButton();
            this.lblCod = new System.Windows.Forms.Label();
            this.grpBxSitPDV = new System.Windows.Forms.GroupBox();
            this.rdbCanc = new System.Windows.Forms.RadioButton();
            this.rdbPend = new System.Windows.Forms.RadioButton();
            this.rdbEfet = new System.Windows.Forms.RadioButton();
            this.cmBxTipoPed = new System.Windows.Forms.ComboBox();
            this.lblTipoPed = new System.Windows.Forms.Label();
            this.dtGrdConPDV = new System.Windows.Forms.DataGridView();
            this.ClmnCodPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDtPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtEmissão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrFaturado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnValPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCntrlConPDV.SuspendLayout();
            this.tbPgConCli.SuspendLayout();
            this.grpBxFiltro.SuspendLayout();
            this.grpBxTpRel.SuspendLayout();
            this.grpBxCli.SuspendLayout();
            this.grpBxPedido.SuspendLayout();
            this.grpBxSitPDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdConPDV)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrlConPDV
            // 
            this.tbCntrlConPDV.Controls.Add(this.tbPgConCli);
            this.tbCntrlConPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlConPDV.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlConPDV.Name = "tbCntrlConPDV";
            this.tbCntrlConPDV.SelectedIndex = 0;
            this.tbCntrlConPDV.Size = new System.Drawing.Size(670, 464);
            this.tbCntrlConPDV.TabIndex = 1;
            // 
            // tbPgConCli
            // 
            this.tbPgConCli.Controls.Add(this.grpBxFiltro);
            this.tbPgConCli.Controls.Add(this.dtGrdConPDV);
            this.tbPgConCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPgConCli.ForeColor = System.Drawing.Color.CadetBlue;
            this.tbPgConCli.Location = new System.Drawing.Point(4, 22);
            this.tbPgConCli.Name = "tbPgConCli";
            this.tbPgConCli.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgConCli.Size = new System.Drawing.Size(662, 438);
            this.tbPgConCli.TabIndex = 0;
            this.tbPgConCli.Text = "Consulta Pedido de Venda - Pedido / Cliente";
            this.tbPgConCli.UseVisualStyleBackColor = true;
            this.tbPgConCli.Click += new System.EventHandler(this.tbPgConCli_Click);
            // 
            // grpBxFiltro
            // 
            this.grpBxFiltro.Controls.Add(this.grpBxTpRel);
            this.grpBxFiltro.Controls.Add(this.grpBxCli);
            this.grpBxFiltro.Controls.Add(this.grpBxPedido);
            this.grpBxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxFiltro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxFiltro.Location = new System.Drawing.Point(6, 6);
            this.grpBxFiltro.Name = "grpBxFiltro";
            this.grpBxFiltro.Size = new System.Drawing.Size(648, 198);
            this.grpBxFiltro.TabIndex = 1;
            this.grpBxFiltro.TabStop = false;
            this.grpBxFiltro.Text = "Filtros:";
            // 
            // grpBxTpRel
            // 
            this.grpBxTpRel.Controls.Add(this.rdbProd);
            this.grpBxTpRel.Controls.Add(this.rdbped);
            this.grpBxTpRel.Location = new System.Drawing.Point(441, 131);
            this.grpBxTpRel.Name = "grpBxTpRel";
            this.grpBxTpRel.Size = new System.Drawing.Size(201, 53);
            this.grpBxTpRel.TabIndex = 10;
            this.grpBxTpRel.TabStop = false;
            this.grpBxTpRel.Text = "Tipo Relatório";
            // 
            // rdbProd
            // 
            this.rdbProd.AutoSize = true;
            this.rdbProd.ForeColor = System.Drawing.Color.CadetBlue;
            this.rdbProd.Location = new System.Drawing.Point(89, 28);
            this.rdbProd.Name = "rdbProd";
            this.rdbProd.Size = new System.Drawing.Size(65, 17);
            this.rdbProd.TabIndex = 1;
            this.rdbProd.TabStop = true;
            this.rdbProd.Text = "Poduto";
            this.rdbProd.UseVisualStyleBackColor = true;
            // 
            // rdbped
            // 
            this.rdbped.AutoSize = true;
            this.rdbped.ForeColor = System.Drawing.Color.CadetBlue;
            this.rdbped.Location = new System.Drawing.Point(6, 28);
            this.rdbped.Name = "rdbped";
            this.rdbped.Size = new System.Drawing.Size(64, 17);
            this.rdbped.TabIndex = 0;
            this.rdbped.TabStop = true;
            this.rdbped.Text = "Pedido";
            this.rdbped.UseVisualStyleBackColor = true;
            // 
            // grpBxCli
            // 
            this.grpBxCli.Controls.Add(this.txtDesc);
            this.grpBxCli.Controls.Add(this.lblNome);
            this.grpBxCli.Controls.Add(this.txtCodCli);
            this.grpBxCli.Controls.Add(this.lblCodCli);
            this.grpBxCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxCli.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxCli.Location = new System.Drawing.Point(318, 19);
            this.grpBxCli.Name = "grpBxCli";
            this.grpBxCli.Size = new System.Drawing.Size(324, 76);
            this.grpBxCli.TabIndex = 9;
            this.grpBxCli.TabStop = false;
            this.grpBxCli.Text = "Dados Produto:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(123, 36);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(187, 20);
            this.txtDesc.TabIndex = 23;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNome.Location = new System.Drawing.Point(120, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 13);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "Descrição:";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Image = global::Comercial.Properties.Resources.search1;
            this.txtCodCli.Location = new System.Drawing.Point(17, 36);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.ShowButton = false;
            this.txtCodCli.Size = new System.Drawing.Size(86, 25);
            this.txtCodCli.TabIndex = 21;
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCli.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblCodCli.Location = new System.Drawing.Point(12, 19);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(43, 13);
            this.lblCodCli.TabIndex = 20;
            this.lblCodCli.Text = "Código:";
            // 
            // grpBxPedido
            // 
            this.grpBxPedido.Controls.Add(this.dtTmPckrDataate);
            this.grpBxPedido.Controls.Add(this.lblDataate);
            this.grpBxPedido.Controls.Add(this.dtTmPckrDatade);
            this.grpBxPedido.Controls.Add(this.lblDataPed);
            this.grpBxPedido.Controls.Add(this.txtCodPed);
            this.grpBxPedido.Controls.Add(this.lblCod);
            this.grpBxPedido.Controls.Add(this.grpBxSitPDV);
            this.grpBxPedido.Controls.Add(this.cmBxTipoPed);
            this.grpBxPedido.Controls.Add(this.lblTipoPed);
            this.grpBxPedido.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxPedido.Location = new System.Drawing.Point(6, 19);
            this.grpBxPedido.Name = "grpBxPedido";
            this.grpBxPedido.Size = new System.Drawing.Size(305, 170);
            this.grpBxPedido.TabIndex = 8;
            this.grpBxPedido.TabStop = false;
            this.grpBxPedido.Text = "Dados Pedido";
            // 
            // dtTmPckrDataate
            // 
            this.dtTmPckrDataate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTmPckrDataate.Location = new System.Drawing.Point(113, 127);
            this.dtTmPckrDataate.Name = "dtTmPckrDataate";
            this.dtTmPckrDataate.Size = new System.Drawing.Size(91, 20);
            this.dtTmPckrDataate.TabIndex = 23;
            // 
            // lblDataate
            // 
            this.lblDataate.AutoSize = true;
            this.lblDataate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataate.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDataate.Location = new System.Drawing.Point(110, 112);
            this.lblDataate.Name = "lblDataate";
            this.lblDataate.Size = new System.Drawing.Size(51, 13);
            this.lblDataate.TabIndex = 22;
            this.lblDataate.Text = "Data até:";
            // 
            // dtTmPckrDatade
            // 
            this.dtTmPckrDatade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTmPckrDatade.Location = new System.Drawing.Point(12, 128);
            this.dtTmPckrDatade.Name = "dtTmPckrDatade";
            this.dtTmPckrDatade.Size = new System.Drawing.Size(95, 20);
            this.dtTmPckrDatade.TabIndex = 21;
            // 
            // lblDataPed
            // 
            this.lblDataPed.AutoSize = true;
            this.lblDataPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPed.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDataPed.Location = new System.Drawing.Point(9, 112);
            this.lblDataPed.Name = "lblDataPed";
            this.lblDataPed.Size = new System.Drawing.Size(48, 13);
            this.lblDataPed.TabIndex = 20;
            this.lblDataPed.Text = "Data de:";
            // 
            // txtCodPed
            // 
            this.txtCodPed.Image = global::Comercial.Properties.Resources.search1;
            this.txtCodPed.Location = new System.Drawing.Point(12, 36);
            this.txtCodPed.Name = "txtCodPed";
            this.txtCodPed.ShowButton = false;
            this.txtCodPed.Size = new System.Drawing.Size(90, 25);
            this.txtCodPed.TabIndex = 19;
            this.txtCodPed.ButtonClick += new System.EventHandler(this.txtCodPed_ButtonClick);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblCod.Location = new System.Drawing.Point(9, 19);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 16;
            this.lblCod.Text = "Código:";
            // 
            // grpBxSitPDV
            // 
            this.grpBxSitPDV.Controls.Add(this.rdbCanc);
            this.grpBxSitPDV.Controls.Add(this.rdbPend);
            this.grpBxSitPDV.Controls.Add(this.rdbEfet);
            this.grpBxSitPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxSitPDV.ForeColor = System.Drawing.Color.CadetBlue;
            this.grpBxSitPDV.Location = new System.Drawing.Point(12, 67);
            this.grpBxSitPDV.Name = "grpBxSitPDV";
            this.grpBxSitPDV.Size = new System.Drawing.Size(281, 42);
            this.grpBxSitPDV.TabIndex = 14;
            this.grpBxSitPDV.TabStop = false;
            this.grpBxSitPDV.Text = "Situação do Pedido:";
            // 
            // rdbCanc
            // 
            this.rdbCanc.AutoSize = true;
            this.rdbCanc.Location = new System.Drawing.Point(190, 19);
            this.rdbCanc.Name = "rdbCanc";
            this.rdbCanc.Size = new System.Drawing.Size(76, 17);
            this.rdbCanc.TabIndex = 2;
            this.rdbCanc.TabStop = true;
            this.rdbCanc.Text = "Cancelado";
            this.rdbCanc.UseVisualStyleBackColor = true;
            // 
            // rdbPend
            // 
            this.rdbPend.AutoSize = true;
            this.rdbPend.Location = new System.Drawing.Point(96, 19);
            this.rdbPend.Name = "rdbPend";
            this.rdbPend.Size = new System.Drawing.Size(71, 17);
            this.rdbPend.TabIndex = 1;
            this.rdbPend.TabStop = true;
            this.rdbPend.Text = "Pendente";
            this.rdbPend.UseVisualStyleBackColor = true;
            // 
            // rdbEfet
            // 
            this.rdbEfet.AutoSize = true;
            this.rdbEfet.Location = new System.Drawing.Point(7, 19);
            this.rdbEfet.Name = "rdbEfet";
            this.rdbEfet.Size = new System.Drawing.Size(70, 17);
            this.rdbEfet.TabIndex = 0;
            this.rdbEfet.TabStop = true;
            this.rdbEfet.Text = "Efetivado";
            this.rdbEfet.UseVisualStyleBackColor = true;
            // 
            // cmBxTipoPed
            // 
            this.cmBxTipoPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBxTipoPed.FormattingEnabled = true;
            this.cmBxTipoPed.Items.AddRange(new object[] {
            "N = Normal",
            "C = Complemento de preço"});
            this.cmBxTipoPed.Location = new System.Drawing.Point(108, 36);
            this.cmBxTipoPed.Name = "cmBxTipoPed";
            this.cmBxTipoPed.Size = new System.Drawing.Size(121, 21);
            this.cmBxTipoPed.TabIndex = 12;
            // 
            // lblTipoPed
            // 
            this.lblTipoPed.AutoSize = true;
            this.lblTipoPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPed.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTipoPed.Location = new System.Drawing.Point(105, 20);
            this.lblTipoPed.Name = "lblTipoPed";
            this.lblTipoPed.Size = new System.Drawing.Size(81, 13);
            this.lblTipoPed.TabIndex = 7;
            this.lblTipoPed.Text = "Tipo do pedido:";
            // 
            // dtGrdConPDV
            // 
            this.dtGrdConPDV.AllowUserToAddRows = false;
            this.dtGrdConPDV.AllowUserToDeleteRows = false;
            this.dtGrdConPDV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdConPDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrdConPDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdConPDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnCodPed,
            this.ClmnDtPed,
            this.Cliente,
            this.DtEmissão,
            this.VrFaturado,
            this.ClmnValPed});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrdConPDV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrdConPDV.Location = new System.Drawing.Point(6, 210);
            this.dtGrdConPDV.Name = "dtGrdConPDV";
            this.dtGrdConPDV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdConPDV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGrdConPDV.Size = new System.Drawing.Size(648, 222);
            this.dtGrdConPDV.TabIndex = 0;
            // 
            // ClmnCodPed
            // 
            this.ClmnCodPed.HeaderText = "Num Ped.";
            this.ClmnCodPed.Name = "ClmnCodPed";
            this.ClmnCodPed.ReadOnly = true;
            // 
            // ClmnDtPed
            // 
            this.ClmnDtPed.HeaderText = "Tipo Ped.";
            this.ClmnDtPed.Name = "ClmnDtPed";
            this.ClmnDtPed.ReadOnly = true;
            this.ClmnDtPed.Width = 120;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // DtEmissão
            // 
            this.DtEmissão.HeaderText = "Data Emissão";
            this.DtEmissão.Name = "DtEmissão";
            this.DtEmissão.ReadOnly = true;
            // 
            // VrFaturado
            // 
            this.VrFaturado.HeaderText = "Valor Faturado";
            this.VrFaturado.Name = "VrFaturado";
            this.VrFaturado.ReadOnly = true;
            // 
            // ClmnValPed
            // 
            this.ClmnValPed.HeaderText = "Valor do Pedido";
            this.ClmnValPed.Name = "ClmnValPed";
            this.ClmnValPed.ReadOnly = true;
            this.ClmnValPed.Width = 160;
            // 
            // FrmConPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 487);
            this.Controls.Add(this.tbCntrlConPDV);
            this.Name = "FrmConPDV";
            this.Text = "Consulta Pedido de Vendas";
            this.Leave += new System.EventHandler(this.FrmConPDV_Leave);
            this.tbCntrlConPDV.ResumeLayout(false);
            this.tbPgConCli.ResumeLayout(false);
            this.grpBxFiltro.ResumeLayout(false);
            this.grpBxTpRel.ResumeLayout(false);
            this.grpBxTpRel.PerformLayout();
            this.grpBxCli.ResumeLayout(false);
            this.grpBxCli.PerformLayout();
            this.grpBxPedido.ResumeLayout(false);
            this.grpBxPedido.PerformLayout();
            this.grpBxSitPDV.ResumeLayout(false);
            this.grpBxSitPDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdConPDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrlConPDV;
        private System.Windows.Forms.TabPage tbPgConCli;
        private System.Windows.Forms.GroupBox grpBxFiltro;
        private System.Windows.Forms.GroupBox grpBxPedido;
        private System.Windows.Forms.DateTimePicker dtTmPckrDatade;
        private System.Windows.Forms.Label lblDataPed;
        private TextButton txtCodPed;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.GroupBox grpBxSitPDV;
        private System.Windows.Forms.RadioButton rdbCanc;
        private System.Windows.Forms.RadioButton rdbPend;
        private System.Windows.Forms.RadioButton rdbEfet;
        private System.Windows.Forms.ComboBox cmBxTipoPed;
        private System.Windows.Forms.Label lblTipoPed;
        private System.Windows.Forms.DataGridView dtGrdConPDV;
        private System.Windows.Forms.DateTimePicker dtTmPckrDataate;
        private System.Windows.Forms.Label lblDataate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCodPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDtPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtEmissão;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrFaturado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnValPed;
        private System.Windows.Forms.GroupBox grpBxCli;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblNome;
        private TextButton txtCodCli;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.GroupBox grpBxTpRel;
        private System.Windows.Forms.RadioButton rdbProd;
        private System.Windows.Forms.RadioButton rdbped;
    }
}