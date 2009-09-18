namespace Comercial
    {
    partial class FrmPesPedNF
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
            this.TbCntPesPedNF = new System.Windows.Forms.TabControl();
            this.TbPgPesPedNF = new System.Windows.Forms.TabPage();
            this.BtnGerarNotFis = new System.Windows.Forms.Button();
            this.GrpBxIten = new System.Windows.Forms.GroupBox();
            this.dtgrdvItenspven = new System.Windows.Forms.DataGridView();
            this.ClmItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrcUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrcTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmIPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmVlrFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtGrdVwItensNotFiscal = new System.Windows.Forms.DataGridView();
            this.clmFoiAlterado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVlrUnitário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVlrTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpBxPesPedNF = new System.Windows.Forms.GroupBox();
            this.TxtStaPed = new System.Windows.Forms.TextBox();
            this.LblStaPed = new System.Windows.Forms.Label();
            this.TxtNumPed = new System.Windows.Forms.TextBox();
            this.LblNumPed = new System.Windows.Forms.Label();
            this.LblCli = new System.Windows.Forms.Label();
            this.TxtCli = new System.Windows.Forms.TextBox();
            this.TbCntPesPedNF.SuspendLayout();
            this.TbPgPesPedNF.SuspendLayout();
            this.GrpBxIten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvItenspven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwItensNotFiscal)).BeginInit();
            this.GrpBxPesPedNF.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbCntPesPedNF
            // 
            this.TbCntPesPedNF.Controls.Add(this.TbPgPesPedNF);
            this.TbCntPesPedNF.Location = new System.Drawing.Point(0, 0);
            this.TbCntPesPedNF.Name = "TbCntPesPedNF";
            this.TbCntPesPedNF.SelectedIndex = 0;
            this.TbCntPesPedNF.Size = new System.Drawing.Size(735, 366);
            this.TbCntPesPedNF.TabIndex = 0;
            // 
            // TbPgPesPedNF
            // 
            this.TbPgPesPedNF.Controls.Add(this.BtnGerarNotFis);
            this.TbPgPesPedNF.Controls.Add(this.GrpBxIten);
            this.TbPgPesPedNF.Controls.Add(this.GrpBxPesPedNF);
            this.TbPgPesPedNF.Location = new System.Drawing.Point(4, 22);
            this.TbPgPesPedNF.Name = "TbPgPesPedNF";
            this.TbPgPesPedNF.Padding = new System.Windows.Forms.Padding(3);
            this.TbPgPesPedNF.Size = new System.Drawing.Size(727, 340);
            this.TbPgPesPedNF.TabIndex = 0;
            this.TbPgPesPedNF.Text = "Pesquisa de Pedido para Emissão de Nota Fiscal";
            this.TbPgPesPedNF.UseVisualStyleBackColor = true;
            // 
            // BtnGerarNotFis
            // 
            this.BtnGerarNotFis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerarNotFis.ForeColor = System.Drawing.Color.CadetBlue;
           // this.BtnGerarNotFis.Image = global::Prototipo.Properties.Resources.chart_accept;
            this.BtnGerarNotFis.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnGerarNotFis.Location = new System.Drawing.Point(537, 288);
            this.BtnGerarNotFis.Name = "BtnGerarNotFis";
            this.BtnGerarNotFis.Size = new System.Drawing.Size(168, 30);
            this.BtnGerarNotFis.TabIndex = 2;
            this.BtnGerarNotFis.Text = "   Gerar Nota Fiscal";
            this.BtnGerarNotFis.UseVisualStyleBackColor = true;
            // 
            // GrpBxIten
            // 
            this.GrpBxIten.Controls.Add(this.dtgrdvItenspven);
            this.GrpBxIten.Controls.Add(this.dtGrdVwItensNotFiscal);
            this.GrpBxIten.Location = new System.Drawing.Point(8, 111);
            this.GrpBxIten.Name = "GrpBxIten";
            this.GrpBxIten.Size = new System.Drawing.Size(711, 146);
            this.GrpBxIten.TabIndex = 1;
            this.GrpBxIten.TabStop = false;
            this.GrpBxIten.Text = "Itens Pedido";
            // 
            // dtgrdvItenspven
            // 
            this.dtgrdvItenspven.AllowUserToAddRows = false;
            this.dtgrdvItenspven.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvItenspven.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrdvItenspven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvItenspven.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmItem,
            this.ClmCodProd,
            this.ClmQtde,
            this.ClmPrcUnit,
            this.ClmPrcTotal,
            this.ClmIPI,
            this.ClmVlrFinal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrdvItenspven.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrdvItenspven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrdvItenspven.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtgrdvItenspven.Location = new System.Drawing.Point(3, 16);
            this.dtgrdvItenspven.Name = "dtgrdvItenspven";
            this.dtgrdvItenspven.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvItenspven.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrdvItenspven.Size = new System.Drawing.Size(705, 127);
            this.dtgrdvItenspven.TabIndex = 24;
            // 
            // ClmItem
            // 
            this.ClmItem.HeaderText = "Item";
            this.ClmItem.Name = "ClmItem";
            this.ClmItem.ReadOnly = true;
            this.ClmItem.Width = 35;
            // 
            // ClmCodProd
            // 
            this.ClmCodProd.HeaderText = "Código Produto";
            this.ClmCodProd.Name = "ClmCodProd";
            this.ClmCodProd.ReadOnly = true;
            this.ClmCodProd.Width = 125;
            // 
            // ClmQtde
            // 
            this.ClmQtde.HeaderText = "Quantidade";
            this.ClmQtde.Name = "ClmQtde";
            this.ClmQtde.ReadOnly = true;
            // 
            // ClmPrcUnit
            // 
            this.ClmPrcUnit.HeaderText = "Preço Unitário";
            this.ClmPrcUnit.Name = "ClmPrcUnit";
            this.ClmPrcUnit.ReadOnly = true;
            // 
            // ClmPrcTotal
            // 
            this.ClmPrcTotal.HeaderText = "Preço Total";
            this.ClmPrcTotal.Name = "ClmPrcTotal";
            this.ClmPrcTotal.ReadOnly = true;
            // 
            // ClmIPI
            // 
            this.ClmIPI.HeaderText = "% IPI";
            this.ClmIPI.Name = "ClmIPI";
            this.ClmIPI.ReadOnly = true;
            // 
            // ClmVlrFinal
            // 
            this.ClmVlrFinal.HeaderText = "Valor Final";
            this.ClmVlrFinal.Name = "ClmVlrFinal";
            this.ClmVlrFinal.ReadOnly = true;
            // 
            // dtGrdVwItensNotFiscal
            // 
            this.dtGrdVwItensNotFiscal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwItensNotFiscal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFoiAlterado,
            this.clmProduto,
            this.clmDescProd,
            this.clmUnidade,
            this.clmQuantidade,
            this.clmVlrUnitário,
            this.clmVlrTotal});
            this.dtGrdVwItensNotFiscal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrdVwItensNotFiscal.Location = new System.Drawing.Point(3, 16);
            this.dtGrdVwItensNotFiscal.Name = "dtGrdVwItensNotFiscal";
            this.dtGrdVwItensNotFiscal.Size = new System.Drawing.Size(705, 127);
            this.dtGrdVwItensNotFiscal.TabIndex = 1;
            // 
            // clmFoiAlterado
            // 
            this.clmFoiAlterado.HeaderText = "";
            this.clmFoiAlterado.Name = "clmFoiAlterado";
            this.clmFoiAlterado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmFoiAlterado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmFoiAlterado.Width = 50;
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
            // GrpBxPesPedNF
            // 
            this.GrpBxPesPedNF.Controls.Add(this.TxtCli);
            this.GrpBxPesPedNF.Controls.Add(this.LblCli);
            this.GrpBxPesPedNF.Controls.Add(this.TxtStaPed);
            this.GrpBxPesPedNF.Controls.Add(this.LblStaPed);
            this.GrpBxPesPedNF.Controls.Add(this.TxtNumPed);
            this.GrpBxPesPedNF.Controls.Add(this.LblNumPed);
            this.GrpBxPesPedNF.Location = new System.Drawing.Point(6, 6);
            this.GrpBxPesPedNF.Name = "GrpBxPesPedNF";
            this.GrpBxPesPedNF.Size = new System.Drawing.Size(710, 99);
            this.GrpBxPesPedNF.TabIndex = 0;
            this.GrpBxPesPedNF.TabStop = false;
            this.GrpBxPesPedNF.Text = "Pedido para Emissão de NF";
            this.GrpBxPesPedNF.Enter += new System.EventHandler(this.GrpBxPesPedNF_Enter);
            // 
            // TxtStaPed
            // 
            this.TxtStaPed.Enabled = false;
            this.TxtStaPed.Location = new System.Drawing.Point(304, 47);
            this.TxtStaPed.Name = "TxtStaPed";
            this.TxtStaPed.Size = new System.Drawing.Size(176, 20);
            this.TxtStaPed.TabIndex = 3;
            // 
            // LblStaPed
            // 
            this.LblStaPed.AutoSize = true;
            this.LblStaPed.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblStaPed.Location = new System.Drawing.Point(301, 32);
            this.LblStaPed.Name = "LblStaPed";
            this.LblStaPed.Size = new System.Drawing.Size(76, 13);
            this.LblStaPed.TabIndex = 2;
            this.LblStaPed.Text = "Status Pedido:";
            // 
            // TxtNumPed
            // 
            this.TxtNumPed.Location = new System.Drawing.Point(48, 48);
            this.TxtNumPed.Name = "TxtNumPed";
            this.TxtNumPed.Size = new System.Drawing.Size(166, 20);
            this.TxtNumPed.TabIndex = 1;
            // 
            // LblNumPed
            // 
            this.LblNumPed.AutoSize = true;
            this.LblNumPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumPed.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblNumPed.Location = new System.Drawing.Point(45, 32);
            this.LblNumPed.Name = "LblNumPed";
            this.LblNumPed.Size = new System.Drawing.Size(115, 13);
            this.LblNumPed.TabIndex = 0;
            this.LblNumPed.Text = "Número do Pedido:";
            // 
            // LblCli
            // 
            this.LblCli.AutoSize = true;
            this.LblCli.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblCli.Location = new System.Drawing.Point(557, 31);
            this.LblCli.Name = "LblCli";
            this.LblCli.Size = new System.Drawing.Size(42, 13);
            this.LblCli.TabIndex = 4;
            this.LblCli.Text = "Cliente:";
            // 
            // TxtCli
            // 
            this.TxtCli.Enabled = false;
            this.TxtCli.Location = new System.Drawing.Point(560, 47);
            this.TxtCli.Name = "TxtCli";
            this.TxtCli.Size = new System.Drawing.Size(139, 20);
            this.TxtCli.TabIndex = 5;
            // 
            // FrmPesPedNF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(735, 364);
            this.Controls.Add(this.TbCntPesPedNF);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPesPedNF";
            this.Text = "Pesquisa de Pedido para Nota Fiscal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TbCntPesPedNF.ResumeLayout(false);
            this.TbPgPesPedNF.ResumeLayout(false);
            this.GrpBxIten.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvItenspven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwItensNotFiscal)).EndInit();
            this.GrpBxPesPedNF.ResumeLayout(false);
            this.GrpBxPesPedNF.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.TabControl TbCntPesPedNF;
        private System.Windows.Forms.TabPage TbPgPesPedNF;
        private System.Windows.Forms.GroupBox GrpBxPesPedNF;
        private System.Windows.Forms.Label LblNumPed;
        private System.Windows.Forms.TextBox TxtNumPed;
        private System.Windows.Forms.TextBox TxtStaPed;
        private System.Windows.Forms.Label LblStaPed;
        private System.Windows.Forms.GroupBox GrpBxIten;
        private System.Windows.Forms.DataGridView dtGrdVwItensNotFiscal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmFoiAlterado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVlrUnitário;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVlrTotal;
        private System.Windows.Forms.DataGridView dtgrdvItenspven;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrcUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrcTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmVlrFinal;
        private System.Windows.Forms.Button BtnGerarNotFis;
        private System.Windows.Forms.TextBox TxtCli;
        private System.Windows.Forms.Label LblCli;
        }
    }