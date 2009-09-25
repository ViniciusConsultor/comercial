namespace Comercial
{
    partial class frmConCli
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
            this.tbCntrlConCli = new System.Windows.Forms.TabControl();
            this.tbPgConCli = new System.Windows.Forms.TabPage();
            this.grpBxFiltro = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.grpBxPedido = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDataPed = new System.Windows.Forms.Label();
            this.txtCodPed = new Comercial.TextButton();
            this.lblCod = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cmBxTipoPed = new System.Windows.Forms.ComboBox();
            this.lblTipoPed = new System.Windows.Forms.Label();
            this.grpBxCli = new System.Windows.Forms.GroupBox();
            this.txtAreaAtu = new Comercial.TextButton();
            this.lblArea = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblRazao = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodCli = new Comercial.TextButton();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClmnCodPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDtPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnValPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCntrlConCli.SuspendLayout();
            this.tbPgConCli.SuspendLayout();
            this.grpBxFiltro.SuspendLayout();
            this.grpBxPedido.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpBxCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrlConCli
            // 
            this.tbCntrlConCli.Controls.Add(this.tbPgConCli);
            this.tbCntrlConCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlConCli.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlConCli.Name = "tbCntrlConCli";
            this.tbCntrlConCli.SelectedIndex = 0;
            this.tbCntrlConCli.Size = new System.Drawing.Size(772, 488);
            this.tbCntrlConCli.TabIndex = 0;
            // 
            // tbPgConCli
            // 
            this.tbPgConCli.Controls.Add(this.grpBxFiltro);
            this.tbPgConCli.Controls.Add(this.dataGridView1);
            this.tbPgConCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPgConCli.ForeColor = System.Drawing.Color.CadetBlue;
            this.tbPgConCli.Location = new System.Drawing.Point(4, 22);
            this.tbPgConCli.Name = "tbPgConCli";
            this.tbPgConCli.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgConCli.Size = new System.Drawing.Size(764, 462);
            this.tbPgConCli.TabIndex = 0;
            this.tbPgConCli.Text = "Consulta de Clientes - Cliente/Pedido";
            this.tbPgConCli.UseVisualStyleBackColor = true;
            // 
            // grpBxFiltro
            // 
            this.grpBxFiltro.Controls.Add(this.textBox3);
            this.grpBxFiltro.Controls.Add(this.lblCNPJ);
            this.grpBxFiltro.Controls.Add(this.grpBxPedido);
            this.grpBxFiltro.Controls.Add(this.grpBxCli);
            this.grpBxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxFiltro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxFiltro.Location = new System.Drawing.Point(6, 6);
            this.grpBxFiltro.Name = "grpBxFiltro";
            this.grpBxFiltro.Size = new System.Drawing.Size(722, 197);
            this.grpBxFiltro.TabIndex = 1;
            this.grpBxFiltro.TabStop = false;
            this.grpBxFiltro.Text = "Filtros:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(535, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(101, 20);
            this.textBox3.TabIndex = 27;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblCNPJ.Location = new System.Drawing.Point(532, 83);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(37, 13);
            this.lblCNPJ.TabIndex = 26;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // grpBxPedido
            // 
            this.grpBxPedido.Controls.Add(this.dateTimePicker1);
            this.grpBxPedido.Controls.Add(this.lblDataPed);
            this.grpBxPedido.Controls.Add(this.txtCodPed);
            this.grpBxPedido.Controls.Add(this.lblCod);
            this.grpBxPedido.Controls.Add(this.groupBox2);
            this.grpBxPedido.Controls.Add(this.cmBxTipoPed);
            this.grpBxPedido.Controls.Add(this.lblTipoPed);
            this.grpBxPedido.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxPedido.Location = new System.Drawing.Point(6, 19);
            this.grpBxPedido.Name = "grpBxPedido";
            this.grpBxPedido.Size = new System.Drawing.Size(297, 162);
            this.grpBxPedido.TabIndex = 8;
            this.grpBxPedido.TabStop = false;
            this.grpBxPedido.Text = "Dados Pedido";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // lblDataPed
            // 
            this.lblDataPed.AutoSize = true;
            this.lblDataPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPed.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDataPed.Location = new System.Drawing.Point(9, 116);
            this.lblDataPed.Name = "lblDataPed";
            this.lblDataPed.Size = new System.Drawing.Size(83, 13);
            this.lblDataPed.TabIndex = 20;
            this.lblDataPed.Text = "Data do pedido:";
            // 
            // txtCodPed
            // 
            this.txtCodPed.Image = global::Comercial.Properties.Resources.search1;
            this.txtCodPed.Location = new System.Drawing.Point(12, 36);
            this.txtCodPed.Name = "txtCodPed";
            this.txtCodPed.ShowButton = false;
            this.txtCodPed.Size = new System.Drawing.Size(74, 25);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.Location = new System.Drawing.Point(9, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 42);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Situação do Pedido:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(190, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(76, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Cancelado";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(96, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pendente";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Efetivado";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // cmBxTipoPed
            // 
            this.cmBxTipoPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBxTipoPed.FormattingEnabled = true;
            this.cmBxTipoPed.Items.AddRange(new object[] {
            "N = Normal",
            "C = Complemento de preço"});
            this.cmBxTipoPed.Location = new System.Drawing.Point(105, 36);
            this.cmBxTipoPed.Name = "cmBxTipoPed";
            this.cmBxTipoPed.Size = new System.Drawing.Size(121, 21);
            this.cmBxTipoPed.TabIndex = 12;
            // 
            // lblTipoPed
            // 
            this.lblTipoPed.AutoSize = true;
            this.lblTipoPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPed.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTipoPed.Location = new System.Drawing.Point(102, 19);
            this.lblTipoPed.Name = "lblTipoPed";
            this.lblTipoPed.Size = new System.Drawing.Size(81, 13);
            this.lblTipoPed.TabIndex = 7;
            this.lblTipoPed.Text = "Tipo do pedido:";
            // 
            // grpBxCli
            // 
            this.grpBxCli.Controls.Add(this.txtAreaAtu);
            this.grpBxCli.Controls.Add(this.lblArea);
            this.grpBxCli.Controls.Add(this.textBox2);
            this.grpBxCli.Controls.Add(this.lblRazao);
            this.grpBxCli.Controls.Add(this.textBox1);
            this.grpBxCli.Controls.Add(this.lblNome);
            this.grpBxCli.Controls.Add(this.txtCodCli);
            this.grpBxCli.Controls.Add(this.lblCodCli);
            this.grpBxCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxCli.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxCli.Location = new System.Drawing.Point(326, 19);
            this.grpBxCli.Name = "grpBxCli";
            this.grpBxCli.Size = new System.Drawing.Size(324, 162);
            this.grpBxCli.TabIndex = 3;
            this.grpBxCli.TabStop = false;
            this.grpBxCli.Text = "Dados Cliente:";
            // 
            // txtAreaAtu
            // 
            this.txtAreaAtu.Image = global::Comercial.Properties.Resources.search1;
            this.txtAreaAtu.Location = new System.Drawing.Point(17, 132);
            this.txtAreaAtu.Name = "txtAreaAtu";
            this.txtAreaAtu.ShowButton = false;
            this.txtAreaAtu.Size = new System.Drawing.Size(174, 25);
            this.txtAreaAtu.TabIndex = 27;
            this.txtAreaAtu.ButtonClick += new System.EventHandler(this.txtAreaAtu_ButtonClick);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblArea.Location = new System.Drawing.Point(14, 115);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(89, 13);
            this.lblArea.TabIndex = 26;
            this.lblArea.Text = "Área de atuação:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 25;
            // 
            // lblRazao
            // 
            this.lblRazao.AutoSize = true;
            this.lblRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazao.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblRazao.Location = new System.Drawing.Point(14, 65);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(73, 13);
            this.lblRazao.TabIndex = 24;
            this.lblRazao.Text = "Razão Social:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 23;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNome.Location = new System.Drawing.Point(120, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(81, 13);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "Nome Fantasia:";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCodCli
            // 
            this.txtCodCli.Image = global::Comercial.Properties.Resources.search1;
            this.txtCodCli.Location = new System.Drawing.Point(17, 36);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.ShowButton = false;
            this.txtCodCli.Size = new System.Drawing.Size(86, 25);
            this.txtCodCli.TabIndex = 21;
            this.txtCodCli.ButtonClick += new System.EventHandler(this.txtCodCli_ButtonClick);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnCodPed,
            this.ClmnDtPed,
            this.ClmnValPed});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(722, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // ClmnCodPed
            // 
            this.ClmnCodPed.HeaderText = "Cód. Ped.";
            this.ClmnCodPed.Name = "ClmnCodPed";
            this.ClmnCodPed.ReadOnly = true;
            // 
            // ClmnDtPed
            // 
            this.ClmnDtPed.HeaderText = "Data Ped.";
            this.ClmnDtPed.Name = "ClmnDtPed";
            this.ClmnDtPed.ReadOnly = true;
            this.ClmnDtPed.Width = 120;
            // 
            // ClmnValPed
            // 
            this.ClmnValPed.HeaderText = "Valor do Pedido";
            this.ClmnValPed.Name = "ClmnValPed";
            this.ClmnValPed.ReadOnly = true;
            this.ClmnValPed.Width = 160;
            // 
            // frmConCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(922, 498);
            this.Controls.Add(this.tbCntrlConCli);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConCli";
            this.Text = "Consulta de Clientes";
            this.Leave += new System.EventHandler(this.frmConCli_Leave);
            this.tbCntrlConCli.ResumeLayout(false);
            this.tbPgConCli.ResumeLayout(false);
            this.grpBxFiltro.ResumeLayout(false);
            this.grpBxFiltro.PerformLayout();
            this.grpBxPedido.ResumeLayout(false);
            this.grpBxPedido.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpBxCli.ResumeLayout(false);
            this.grpBxCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrlConCli;
        private System.Windows.Forms.TabPage tbPgConCli;
        private System.Windows.Forms.GroupBox grpBxFiltro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpBxCli;
        private System.Windows.Forms.GroupBox grpBxPedido;
        private System.Windows.Forms.Label lblDataPed;
        private TextButton txtCodPed;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cmBxTipoPed;
        private System.Windows.Forms.Label lblTipoPed;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private TextButton txtCodCli;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblRazao;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCNPJ;
        private TextButton txtAreaAtu;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCodPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDtPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnValPed;
    }
}