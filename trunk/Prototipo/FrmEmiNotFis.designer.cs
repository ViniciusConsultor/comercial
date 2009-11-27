namespace Comercial
    {
    partial class FrmEmiNotFis
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
                System.Windows.Forms.Label LblNumPedido;
                this.TbPgNotFis = new System.Windows.Forms.TabPage();
                this.GrpBxTot = new System.Windows.Forms.GroupBox();
                this.GrpBxItens = new System.Windows.Forms.GroupBox();
                this.dtGrdVwItensNF = new System.Windows.Forms.DataGridView();
                this.GrpBxInfNotFis = new System.Windows.Forms.GroupBox();
                this.LlblNumNotFis = new System.Windows.Forms.Label();
                this.TbCntEmiNF = new System.Windows.Forms.TabControl();
                this.clmProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.clmDescProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.clmUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.clmQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.clmVlrUnitário = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.clmVlrTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.txtNumNF = new Comercial.TextButton();
                this.txtNrPedido = new System.Windows.Forms.TextBox();
                this.txtTipoNF = new System.Windows.Forms.TextBox();
                this.lblDtEmissao = new System.Windows.Forms.Label();
                this.txtSerie = new System.Windows.Forms.TextBox();
                this.lblSerie = new System.Windows.Forms.Label();
                this.lblTipo = new System.Windows.Forms.Label();
                this.dtTmPckrDtEmissao = new System.Windows.Forms.DateTimePicker();
                this.lblDescontos = new System.Windows.Forms.Label();
                this.lblVlrFrete = new System.Windows.Forms.Label();
                this.lblVlrMercadoria = new System.Windows.Forms.Label();
                this.txtBxicms = new System.Windows.Forms.TextBox();
                this.txtBxVlrFrete = new System.Windows.Forms.TextBox();
                this.txtBxVlrNota = new System.Windows.Forms.TextBox();
                LblNumPedido = new System.Windows.Forms.Label();
                this.TbPgNotFis.SuspendLayout();
                this.GrpBxTot.SuspendLayout();
                this.GrpBxItens.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwItensNF)).BeginInit();
                this.GrpBxInfNotFis.SuspendLayout();
                this.TbCntEmiNF.SuspendLayout();
                this.SuspendLayout();
                // 
                // TbPgNotFis
                // 
                this.TbPgNotFis.Controls.Add(this.GrpBxTot);
                this.TbPgNotFis.Controls.Add(this.GrpBxItens);
                this.TbPgNotFis.Controls.Add(this.GrpBxInfNotFis);
                this.TbPgNotFis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TbPgNotFis.Location = new System.Drawing.Point(4, 22);
                this.TbPgNotFis.Name = "TbPgNotFis";
                this.TbPgNotFis.Padding = new System.Windows.Forms.Padding(3);
                this.TbPgNotFis.Size = new System.Drawing.Size(797, 473);
                this.TbPgNotFis.TabIndex = 0;
                this.TbPgNotFis.Text = "Emissão Nota Fiscal";
                this.TbPgNotFis.UseVisualStyleBackColor = true;
                // 
                // GrpBxTot
                // 
                this.GrpBxTot.Controls.Add(this.lblDescontos);
                this.GrpBxTot.Controls.Add(this.lblVlrFrete);
                this.GrpBxTot.Controls.Add(this.lblVlrMercadoria);
                this.GrpBxTot.Controls.Add(this.txtBxicms);
                this.GrpBxTot.Controls.Add(this.txtBxVlrFrete);
                this.GrpBxTot.Controls.Add(this.txtBxVlrNota);
                this.GrpBxTot.ForeColor = System.Drawing.Color.CornflowerBlue;
                this.GrpBxTot.Location = new System.Drawing.Point(3, 343);
                this.GrpBxTot.Name = "GrpBxTot";
                this.GrpBxTot.Size = new System.Drawing.Size(757, 117);
                this.GrpBxTot.TabIndex = 2;
                this.GrpBxTot.TabStop = false;
                this.GrpBxTot.Text = "Totais";
                // 
                // GrpBxItens
                // 
                this.GrpBxItens.Controls.Add(this.dtGrdVwItensNF);
                this.GrpBxItens.ForeColor = System.Drawing.Color.CornflowerBlue;
                this.GrpBxItens.Location = new System.Drawing.Point(3, 77);
                this.GrpBxItens.Name = "GrpBxItens";
                this.GrpBxItens.Size = new System.Drawing.Size(757, 260);
                this.GrpBxItens.TabIndex = 1;
                this.GrpBxItens.TabStop = false;
                this.GrpBxItens.Text = "Itens Nota Fiscal";
                // 
                // dtGrdVwItensNF
                // 
                this.dtGrdVwItensNF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dtGrdVwItensNF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProduto,
            this.clmDescProd,
            this.clmUnidade,
            this.clmQuantidade,
            this.clmVlrUnitário,
            this.clmVlrTotal});
                this.dtGrdVwItensNF.Dock = System.Windows.Forms.DockStyle.Fill;
                this.dtGrdVwItensNF.Location = new System.Drawing.Point(3, 16);
                this.dtGrdVwItensNF.Name = "dtGrdVwItensNF";
                this.dtGrdVwItensNF.Size = new System.Drawing.Size(751, 241);
                this.dtGrdVwItensNF.TabIndex = 1;
                // 
                // GrpBxInfNotFis
                // 
                this.GrpBxInfNotFis.Controls.Add(this.dtTmPckrDtEmissao);
                this.GrpBxInfNotFis.Controls.Add(this.txtNrPedido);
                this.GrpBxInfNotFis.Controls.Add(LblNumPedido);
                this.GrpBxInfNotFis.Controls.Add(this.txtTipoNF);
                this.GrpBxInfNotFis.Controls.Add(this.lblDtEmissao);
                this.GrpBxInfNotFis.Controls.Add(this.txtSerie);
                this.GrpBxInfNotFis.Controls.Add(this.lblSerie);
                this.GrpBxInfNotFis.Controls.Add(this.lblTipo);
                this.GrpBxInfNotFis.Controls.Add(this.txtNumNF);
                this.GrpBxInfNotFis.Controls.Add(this.LlblNumNotFis);
                this.GrpBxInfNotFis.ForeColor = System.Drawing.Color.CornflowerBlue;
                this.GrpBxInfNotFis.Location = new System.Drawing.Point(3, 6);
                this.GrpBxInfNotFis.Name = "GrpBxInfNotFis";
                this.GrpBxInfNotFis.Size = new System.Drawing.Size(757, 65);
                this.GrpBxInfNotFis.TabIndex = 0;
                this.GrpBxInfNotFis.TabStop = false;
                this.GrpBxInfNotFis.Text = "Informações Nota Fiscal";
                this.GrpBxInfNotFis.Enter += new System.EventHandler(this.groupBox1_Enter);
                // 
                // LlblNumNotFis
                // 
                this.LlblNumNotFis.AutoSize = true;
                this.LlblNumNotFis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LlblNumNotFis.ForeColor = System.Drawing.Color.CadetBlue;
                this.LlblNumNotFis.Location = new System.Drawing.Point(21, 16);
                this.LlblNumNotFis.Name = "LlblNumNotFis";
                this.LlblNumNotFis.Size = new System.Drawing.Size(79, 13);
                this.LlblNumNotFis.TabIndex = 24;
                this.LlblNumNotFis.Text = "Número da NF:";
                this.LlblNumNotFis.Click += new System.EventHandler(this.lblNumNotFiscal_Click);
                // 
                // TbCntEmiNF
                // 
                this.TbCntEmiNF.Controls.Add(this.TbPgNotFis);
                this.TbCntEmiNF.Location = new System.Drawing.Point(0, 1);
                this.TbCntEmiNF.Name = "TbCntEmiNF";
                this.TbCntEmiNF.SelectedIndex = 0;
                this.TbCntEmiNF.Size = new System.Drawing.Size(805, 499);
                this.TbCntEmiNF.TabIndex = 0;
                // 
                // clmProduto
                // 
                this.clmProduto.HeaderText = "Produto";
                this.clmProduto.Name = "clmProduto";
                // 
                // clmDescProd
                // 
                this.clmDescProd.HeaderText = "Desc. Produto";
                this.clmDescProd.Name = "clmDescProd";
                // 
                // clmUnidade
                // 
                this.clmUnidade.HeaderText = "Unidade";
                this.clmUnidade.Name = "clmUnidade";
                // 
                // clmQuantidade
                // 
                this.clmQuantidade.HeaderText = "Quantidade";
                this.clmQuantidade.Name = "clmQuantidade";
                // 
                // clmVlrUnitário
                // 
                this.clmVlrUnitário.HeaderText = "Vlr. Unitário";
                this.clmVlrUnitário.Name = "clmVlrUnitário";
                // 
                // clmVlrTotal
                // 
                this.clmVlrTotal.HeaderText = "Vlr. Total";
                this.clmVlrTotal.Name = "clmVlrTotal";
                // 
                // txtNumNF
                // 
                this.txtNumNF.getText = "";
                this.txtNumNF.Image = global::Comercial.Properties.Resources.search1;
                this.txtNumNF.Location = new System.Drawing.Point(24, 31);
                this.txtNumNF.Name = "txtNumNF";
                this.txtNumNF.ShowButton = false;
                this.txtNumNF.Size = new System.Drawing.Size(245, 25);
                this.txtNumNF.TabIndex = 28;
                this.txtNumNF.ButtonClick += new System.EventHandler(this.txtNumNF_ButtonClick);
                // 
                // txtNrPedido
                // 
                this.txtNrPedido.Location = new System.Drawing.Point(598, 31);
                this.txtNrPedido.Name = "txtNrPedido";
                this.txtNrPedido.ReadOnly = true;
                this.txtNrPedido.Size = new System.Drawing.Size(80, 20);
                this.txtNrPedido.TabIndex = 38;
                // 
                // LblNumPedido
                // 
                LblNumPedido.AutoSize = true;
                LblNumPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
                LblNumPedido.ForeColor = System.Drawing.Color.CadetBlue;
                LblNumPedido.Location = new System.Drawing.Point(595, 14);
                LblNumPedido.Name = "LblNumPedido";
                LblNumPedido.Size = new System.Drawing.Size(83, 13);
                LblNumPedido.TabIndex = 37;
                LblNumPedido.Text = "Número Pedido:";
                // 
                // txtTipoNF
                // 
                this.txtTipoNF.Location = new System.Drawing.Point(373, 30);
                this.txtTipoNF.Name = "txtTipoNF";
                this.txtTipoNF.ReadOnly = true;
                this.txtTipoNF.Size = new System.Drawing.Size(63, 20);
                this.txtTipoNF.TabIndex = 36;
                // 
                // lblDtEmissao
                // 
                this.lblDtEmissao.AutoSize = true;
                this.lblDtEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblDtEmissao.ForeColor = System.Drawing.Color.CadetBlue;
                this.lblDtEmissao.Location = new System.Drawing.Point(449, 14);
                this.lblDtEmissao.Name = "lblDtEmissao";
                this.lblDtEmissao.Size = new System.Drawing.Size(66, 13);
                this.lblDtEmissao.TabIndex = 34;
                this.lblDtEmissao.Text = "Dt. Emissão:";
                // 
                // txtSerie
                // 
                this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtSerie.Location = new System.Drawing.Point(311, 30);
                this.txtSerie.Name = "txtSerie";
                this.txtSerie.ReadOnly = true;
                this.txtSerie.Size = new System.Drawing.Size(50, 20);
                this.txtSerie.TabIndex = 33;
                // 
                // lblSerie
                // 
                this.lblSerie.AutoSize = true;
                this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblSerie.ForeColor = System.Drawing.Color.CadetBlue;
                this.lblSerie.Location = new System.Drawing.Point(308, 14);
                this.lblSerie.Name = "lblSerie";
                this.lblSerie.Size = new System.Drawing.Size(34, 13);
                this.lblSerie.TabIndex = 32;
                this.lblSerie.Text = "Série:";
                // 
                // lblTipo
                // 
                this.lblTipo.AutoSize = true;
                this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblTipo.ForeColor = System.Drawing.Color.CadetBlue;
                this.lblTipo.Location = new System.Drawing.Point(370, 14);
                this.lblTipo.Name = "lblTipo";
                this.lblTipo.Size = new System.Drawing.Size(48, 13);
                this.lblTipo.TabIndex = 31;
                this.lblTipo.Text = "Tipo NF:";
                // 
                // dtTmPckrDtEmissao
                // 
                this.dtTmPckrDtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
                this.dtTmPckrDtEmissao.Location = new System.Drawing.Point(452, 31);
                this.dtTmPckrDtEmissao.Name = "dtTmPckrDtEmissao";
                this.dtTmPckrDtEmissao.Size = new System.Drawing.Size(123, 20);
                this.dtTmPckrDtEmissao.TabIndex = 39;
                // 
                // lblDescontos
                // 
                this.lblDescontos.AutoSize = true;
                this.lblDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblDescontos.ForeColor = System.Drawing.Color.CadetBlue;
                this.lblDescontos.Location = new System.Drawing.Point(577, 81);
                this.lblDescontos.Name = "lblDescontos";
                this.lblDescontos.Size = new System.Drawing.Size(36, 13);
                this.lblDescontos.TabIndex = 30;
                this.lblDescontos.Text = "ICMS:";
                // 
                // lblVlrFrete
                // 
                this.lblVlrFrete.AutoSize = true;
                this.lblVlrFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblVlrFrete.ForeColor = System.Drawing.Color.CadetBlue;
                this.lblVlrFrete.Location = new System.Drawing.Point(565, 55);
                this.lblVlrFrete.Name = "lblVlrFrete";
                this.lblVlrFrete.Size = new System.Drawing.Size(61, 13);
                this.lblVlrFrete.TabIndex = 29;
                this.lblVlrFrete.Text = "Valor Frete:";
                // 
                // lblVlrMercadoria
                // 
                this.lblVlrMercadoria.AutoSize = true;
                this.lblVlrMercadoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblVlrMercadoria.ForeColor = System.Drawing.Color.CadetBlue;
                this.lblVlrMercadoria.Location = new System.Drawing.Point(560, 26);
                this.lblVlrMercadoria.Name = "lblVlrMercadoria";
                this.lblVlrMercadoria.Size = new System.Drawing.Size(60, 13);
                this.lblVlrMercadoria.TabIndex = 28;
                this.lblVlrMercadoria.Text = "Valor Nota:";
                // 
                // txtBxicms
                // 
                this.txtBxicms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtBxicms.Location = new System.Drawing.Point(647, 78);
                this.txtBxicms.Name = "txtBxicms";
                this.txtBxicms.ReadOnly = true;
                this.txtBxicms.Size = new System.Drawing.Size(83, 20);
                this.txtBxicms.TabIndex = 27;
                // 
                // txtBxVlrFrete
                // 
                this.txtBxVlrFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtBxVlrFrete.Location = new System.Drawing.Point(647, 52);
                this.txtBxVlrFrete.Name = "txtBxVlrFrete";
                this.txtBxVlrFrete.ReadOnly = true;
                this.txtBxVlrFrete.Size = new System.Drawing.Size(83, 20);
                this.txtBxVlrFrete.TabIndex = 26;
                // 
                // txtBxVlrNota
                // 
                this.txtBxVlrNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtBxVlrNota.Location = new System.Drawing.Point(647, 23);
                this.txtBxVlrNota.Name = "txtBxVlrNota";
                this.txtBxVlrNota.ReadOnly = true;
                this.txtBxVlrNota.Size = new System.Drawing.Size(83, 20);
                this.txtBxVlrNota.TabIndex = 25;
                // 
                // FrmEmiNotFis
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.WhiteSmoke;
                this.ClientSize = new System.Drawing.Size(803, 495);
                this.ControlBox = false;
                this.Controls.Add(this.TbCntEmiNF);
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "FrmEmiNotFis";
                this.Text = "Emissão Nota Fiscal";
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                this.Leave += new System.EventHandler(this.FrmEmiNotFis_Leave);
                this.TbPgNotFis.ResumeLayout(false);
                this.GrpBxTot.ResumeLayout(false);
                this.GrpBxTot.PerformLayout();
                this.GrpBxItens.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwItensNF)).EndInit();
                this.GrpBxInfNotFis.ResumeLayout(false);
                this.GrpBxInfNotFis.PerformLayout();
                this.TbCntEmiNF.ResumeLayout(false);
                this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.TabPage TbPgNotFis;
        private System.Windows.Forms.TabControl TbCntEmiNF;
        private System.Windows.Forms.GroupBox GrpBxInfNotFis;
        private System.Windows.Forms.Label LlblNumNotFis;
        private System.Windows.Forms.GroupBox GrpBxItens;
        private System.Windows.Forms.DataGridView dtGrdVwItensNF;
        private System.Windows.Forms.GroupBox GrpBxTot;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVlrUnitário;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVlrTotal;
        public TextButton txtNumNF;
        private System.Windows.Forms.DateTimePicker dtTmPckrDtEmissao;
        public System.Windows.Forms.TextBox txtNrPedido;
        public System.Windows.Forms.TextBox txtTipoNF;
        private System.Windows.Forms.Label lblDtEmissao;
        public System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDescontos;
        private System.Windows.Forms.Label lblVlrFrete;
        private System.Windows.Forms.Label lblVlrMercadoria;
        public System.Windows.Forms.TextBox txtBxicms;
        public System.Windows.Forms.TextBox txtBxVlrFrete;
        public System.Windows.Forms.TextBox txtBxVlrNota;
        }
    }