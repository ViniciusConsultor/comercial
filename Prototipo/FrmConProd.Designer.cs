namespace Comercial
{
    partial class FrmConProd
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
            this.tbCntrlConProd = new System.Windows.Forms.TabControl();
            this.tbPgConProd = new System.Windows.Forms.TabPage();
            this.dtGrdVwConProd = new System.Windows.Forms.DataGridView();
            this.grpBxFiltro = new System.Windows.Forms.GroupBox();
            this.grpBxProd = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdDesc = new System.Windows.Forms.TextBox();
            this.LblDesc = new System.Windows.Forms.Label();
            this.grpBxFab = new System.Windows.Forms.GroupBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmBxOpEstoque = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmBxOpDesconto = new System.Windows.Forms.ComboBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.ClmnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATACADASTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECOCUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECOVENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUEATUAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUEMIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstoque = new Comercial.TextButton();
            this.txtGrupo = new Comercial.TextButton();
            this.tbCntrlConProd.SuspendLayout();
            this.tbPgConProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwConProd)).BeginInit();
            this.grpBxFiltro.SuspendLayout();
            this.grpBxProd.SuspendLayout();
            this.grpBxFab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCntrlConProd
            // 
            this.tbCntrlConProd.Controls.Add(this.tbPgConProd);
            this.tbCntrlConProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlConProd.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlConProd.Name = "tbCntrlConProd";
            this.tbCntrlConProd.SelectedIndex = 0;
            this.tbCntrlConProd.Size = new System.Drawing.Size(737, 465);
            this.tbCntrlConProd.TabIndex = 0;
            // 
            // tbPgConProd
            // 
            this.tbPgConProd.Controls.Add(this.dtGrdVwConProd);
            this.tbPgConProd.Controls.Add(this.grpBxFiltro);
            this.tbPgConProd.Location = new System.Drawing.Point(4, 22);
            this.tbPgConProd.Name = "tbPgConProd";
            this.tbPgConProd.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgConProd.Size = new System.Drawing.Size(729, 439);
            this.tbPgConProd.TabIndex = 0;
            this.tbPgConProd.Text = "Consulta de Desconto permitido por Grupo de Produto - Grupos e produtos";
            this.tbPgConProd.UseVisualStyleBackColor = true;
            // 
            // dtGrdVwConProd
            // 
            this.dtGrdVwConProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwConProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnDesc,
            this.Produto,
            this.DATACADASTRO,
            this.PRECOCUSTO,
            this.PRECOVENDA,
            this.DESCONTO,
            this.ESTOQUEATUAL,
            this.ESTOQUEMIN,
            this.IPI});
            this.dtGrdVwConProd.Location = new System.Drawing.Point(6, 181);
            this.dtGrdVwConProd.Name = "dtGrdVwConProd";
            this.dtGrdVwConProd.Size = new System.Drawing.Size(717, 252);
            this.dtGrdVwConProd.TabIndex = 2;
            // 
            // grpBxFiltro
            // 
            this.grpBxFiltro.Controls.Add(this.grpBxProd);
            this.grpBxFiltro.Controls.Add(this.grpBxFab);
            this.grpBxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxFiltro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxFiltro.Location = new System.Drawing.Point(6, 6);
            this.grpBxFiltro.Name = "grpBxFiltro";
            this.grpBxFiltro.Size = new System.Drawing.Size(717, 169);
            this.grpBxFiltro.TabIndex = 1;
            this.grpBxFiltro.TabStop = false;
            this.grpBxFiltro.Text = "Filtros:";
            // 
            // grpBxProd
            // 
            this.grpBxProd.Controls.Add(this.cmBxOpEstoque);
            this.grpBxProd.Controls.Add(this.txtEstoque);
            this.grpBxProd.Controls.Add(this.label1);
            this.grpBxProd.Controls.Add(this.dateTimePicker2);
            this.grpBxProd.Controls.Add(this.label3);
            this.grpBxProd.Controls.Add(this.txtProdDesc);
            this.grpBxProd.Controls.Add(this.LblDesc);
            this.grpBxProd.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxProd.Location = new System.Drawing.Point(337, 19);
            this.grpBxProd.Name = "grpBxProd";
            this.grpBxProd.Size = new System.Drawing.Size(321, 133);
            this.grpBxProd.TabIndex = 1;
            this.grpBxProd.TabStop = false;
            this.grpBxProd.Text = "Dados Produtos:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(20, 91);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(92, 20);
            this.dateTimePicker2.TabIndex = 17;
            this.dateTimePicker2.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(17, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data de cadastro:";
            // 
            // txtProdDesc
            // 
            this.txtProdDesc.Location = new System.Drawing.Point(20, 38);
            this.txtProdDesc.Name = "txtProdDesc";
            this.txtProdDesc.Size = new System.Drawing.Size(273, 20);
            this.txtProdDesc.TabIndex = 14;
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesc.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblDesc.Location = new System.Drawing.Point(17, 21);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(58, 13);
            this.LblDesc.TabIndex = 13;
            this.LblDesc.Text = "Descrição:";
            // 
            // grpBxFab
            // 
            this.grpBxFab.Controls.Add(this.txtDesconto);
            this.grpBxFab.Controls.Add(this.cmBxOpDesconto);
            this.grpBxFab.Controls.Add(this.label4);
            this.grpBxFab.Controls.Add(this.txtGrupo);
            this.grpBxFab.Controls.Add(this.lblGrupo);
            this.grpBxFab.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxFab.Location = new System.Drawing.Point(24, 19);
            this.grpBxFab.Name = "grpBxFab";
            this.grpBxFab.Size = new System.Drawing.Size(293, 133);
            this.grpBxFab.TabIndex = 0;
            this.grpBxFab.TabStop = false;
            this.grpBxFab.Text = "Dados grupos:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblGrupo.Location = new System.Drawing.Point(17, 21);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(39, 13);
            this.lblGrupo.TabIndex = 4;
            this.lblGrupo.Text = "Grupo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(119, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Estoque:";
            // 
            // cmBxOpEstoque
            // 
            this.cmBxOpEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBxOpEstoque.FormattingEnabled = true;
            this.cmBxOpEstoque.Items.AddRange(new object[] {
            "",
            ">",
            "<",
            "=",
            ">=",
            "<="});
            this.cmBxOpEstoque.Location = new System.Drawing.Point(122, 90);
            this.cmBxOpEstoque.Name = "cmBxOpEstoque";
            this.cmBxOpEstoque.Size = new System.Drawing.Size(51, 21);
            this.cmBxOpEstoque.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(17, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "% Desconto:";
            // 
            // cmBxOpDesconto
            // 
            this.cmBxOpDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBxOpDesconto.FormattingEnabled = true;
            this.cmBxOpDesconto.Items.AddRange(new object[] {
            "",
            ">",
            "<",
            "=",
            ">=",
            "<="});
            this.cmBxOpDesconto.Location = new System.Drawing.Point(22, 91);
            this.cmBxOpDesconto.Name = "cmBxOpDesconto";
            this.cmBxOpDesconto.Size = new System.Drawing.Size(51, 21);
            this.cmBxOpDesconto.TabIndex = 22;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(79, 92);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(60, 20);
            this.txtDesconto.TabIndex = 21;
            // 
            // ClmnDesc
            // 
            this.ClmnDesc.DataPropertyName = "GRUPO";
            this.ClmnDesc.HeaderText = "Grupo";
            this.ClmnDesc.Name = "ClmnDesc";
            this.ClmnDesc.Width = 400;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "PRODUTO";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // DATACADASTRO
            // 
            this.DATACADASTRO.DataPropertyName = "DATACADASTRO";
            this.DATACADASTRO.HeaderText = "Dt Cadastro";
            this.DATACADASTRO.Name = "DATACADASTRO";
            // 
            // PRECOCUSTO
            // 
            this.PRECOCUSTO.DataPropertyName = "PRECOCUSTO";
            this.PRECOCUSTO.HeaderText = "Preço Custo";
            this.PRECOCUSTO.Name = "PRECOCUSTO";
            // 
            // PRECOVENDA
            // 
            this.PRECOVENDA.DataPropertyName = "PRECOVENDA";
            this.PRECOVENDA.HeaderText = "Preço Venda";
            this.PRECOVENDA.Name = "PRECOVENDA";
            // 
            // DESCONTO
            // 
            this.DESCONTO.DataPropertyName = "DESCONTO";
            this.DESCONTO.HeaderText = "% Desconto";
            this.DESCONTO.Name = "DESCONTO";
            // 
            // ESTOQUEATUAL
            // 
            this.ESTOQUEATUAL.DataPropertyName = "ESTOQUEATUAL";
            this.ESTOQUEATUAL.HeaderText = "Estoque Atual";
            this.ESTOQUEATUAL.Name = "ESTOQUEATUAL";
            // 
            // ESTOQUEMIN
            // 
            this.ESTOQUEMIN.DataPropertyName = "ESTOQUEMIN";
            this.ESTOQUEMIN.HeaderText = "Estoque Mínimo";
            this.ESTOQUEMIN.Name = "ESTOQUEMIN";
            // 
            // IPI
            // 
            this.IPI.DataPropertyName = "IPI";
            this.IPI.HeaderText = "IPI";
            this.IPI.Name = "IPI";
            // 
            // txtEstoque
            // 
            this.txtEstoque.getText = "";
            this.txtEstoque.Image = global::Comercial.Properties.Resources.search1;
            this.txtEstoque.Location = new System.Drawing.Point(179, 90);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.ShowButton = false;
            this.txtEstoque.Size = new System.Drawing.Size(64, 25);
            this.txtEstoque.TabIndex = 19;
            // 
            // txtGrupo
            // 
            this.txtGrupo.getText = "";
            this.txtGrupo.Image = global::Comercial.Properties.Resources.search1;
            this.txtGrupo.Location = new System.Drawing.Point(20, 38);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.ShowButton = false;
            this.txtGrupo.Size = new System.Drawing.Size(252, 25);
            this.txtGrupo.TabIndex = 10;
            this.txtGrupo.ButtonClick += new System.EventHandler(this.txtFabricante_ButtonClick);
            // 
            // FrmConProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(771, 489);
            this.ControlBox = false;
            this.Controls.Add(this.tbCntrlConProd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConProd";
            this.ShowIcon = false;
            this.Text = "Consulta de Produto";
            this.Leave += new System.EventHandler(this.FrmConProd_Leave);
            this.tbCntrlConProd.ResumeLayout(false);
            this.tbPgConProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwConProd)).EndInit();
            this.grpBxFiltro.ResumeLayout(false);
            this.grpBxProd.ResumeLayout(false);
            this.grpBxProd.PerformLayout();
            this.grpBxFab.ResumeLayout(false);
            this.grpBxFab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrlConProd;
        private System.Windows.Forms.TabPage tbPgConProd;
        private System.Windows.Forms.GroupBox grpBxFiltro;
        private System.Windows.Forms.GroupBox grpBxFab;
        private System.Windows.Forms.GroupBox grpBxProd;
        private System.Windows.Forms.DataGridView dtGrdVwConProd;
        private TextButton txtGrupo;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.TextBox txtProdDesc;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGrupo;
        private TextButton txtEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBxOpEstoque;
        private System.Windows.Forms.ComboBox cmBxOpDesconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATACADASTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECOCUSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECOVENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUEATUAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUEMIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPI;
    }
}