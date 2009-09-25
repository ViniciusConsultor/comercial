namespace Comercial
{
    partial class FrmConVen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbPgConVen = new System.Windows.Forms.TabPage();
            this.dtGrdVwConVen = new System.Windows.Forms.DataGridView();
            this.ClmnCodPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDtPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnVlVendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnComissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTotalCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBxFiltro = new System.Windows.Forms.GroupBox();
            this.grpBxVendedor = new System.Windows.Forms.GroupBox();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblComissao = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpBxPedido = new System.Windows.Forms.GroupBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.cmBxOperador = new System.Windows.Forms.ComboBox();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblQuantVendas = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cmBxTipoPed = new System.Windows.Forms.ComboBox();
            this.lblTipoPed = new System.Windows.Forms.Label();
            this.tbCntrlConVen = new System.Windows.Forms.TabControl();
            this.tbPgConVen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwConVen)).BeginInit();
            this.grpBxFiltro.SuspendLayout();
            this.grpBxVendedor.SuspendLayout();
            this.grpBxPedido.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbCntrlConVen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPgConVen
            // 
            this.tbPgConVen.Controls.Add(this.dtGrdVwConVen);
            this.tbPgConVen.Controls.Add(this.grpBxFiltro);
            this.tbPgConVen.Location = new System.Drawing.Point(4, 22);
            this.tbPgConVen.Name = "tbPgConVen";
            this.tbPgConVen.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgConVen.Size = new System.Drawing.Size(614, 415);
            this.tbPgConVen.TabIndex = 0;
            this.tbPgConVen.Text = "Consulta Vendedor - Comissão";
            this.tbPgConVen.UseVisualStyleBackColor = true;
            // 
            // dtGrdVwConVen
            // 
            this.dtGrdVwConVen.AllowUserToAddRows = false;
            this.dtGrdVwConVen.AllowUserToDeleteRows = false;
            this.dtGrdVwConVen.AllowUserToOrderColumns = true;
            this.dtGrdVwConVen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwConVen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnCodPed,
            this.ClmnDtPed,
            this.ClmnVlVendido,
            this.ClmnComissao,
            this.ClmnTotalCom});
            this.dtGrdVwConVen.Location = new System.Drawing.Point(6, 164);
            this.dtGrdVwConVen.Name = "dtGrdVwConVen";
            this.dtGrdVwConVen.ReadOnly = true;
            this.dtGrdVwConVen.Size = new System.Drawing.Size(593, 233);
            this.dtGrdVwConVen.TabIndex = 1;
            this.dtGrdVwConVen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClmnCodPed
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClmnCodPed.DefaultCellStyle = dataGridViewCellStyle1;
            this.ClmnCodPed.HeaderText = "Cód. Pedido";
            this.ClmnCodPed.Name = "ClmnCodPed";
            this.ClmnCodPed.ReadOnly = true;
            this.ClmnCodPed.Width = 102;
            // 
            // ClmnDtPed
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.ClmnDtPed.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClmnDtPed.HeaderText = "Data do Pedido";
            this.ClmnDtPed.Name = "ClmnDtPed";
            this.ClmnDtPed.ReadOnly = true;
            this.ClmnDtPed.Width = 120;
            // 
            // ClmnVlVendido
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.ClmnVlVendido.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClmnVlVendido.HeaderText = "Valor Pedido";
            this.ClmnVlVendido.Name = "ClmnVlVendido";
            this.ClmnVlVendido.ReadOnly = true;
            this.ClmnVlVendido.Width = 108;
            // 
            // ClmnComissao
            // 
            this.ClmnComissao.HeaderText = "% Comissão";
            this.ClmnComissao.Name = "ClmnComissao";
            this.ClmnComissao.ReadOnly = true;
            this.ClmnComissao.Width = 98;
            // 
            // ClmnTotalCom
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.ClmnTotalCom.DefaultCellStyle = dataGridViewCellStyle4;
            this.ClmnTotalCom.HeaderText = "Total Comissão";
            this.ClmnTotalCom.Name = "ClmnTotalCom";
            this.ClmnTotalCom.ReadOnly = true;
            this.ClmnTotalCom.Width = 117;
            // 
            // grpBxFiltro
            // 
            this.grpBxFiltro.Controls.Add(this.grpBxVendedor);
            this.grpBxFiltro.Controls.Add(this.grpBxPedido);
            this.grpBxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxFiltro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxFiltro.Location = new System.Drawing.Point(6, 6);
            this.grpBxFiltro.Name = "grpBxFiltro";
            this.grpBxFiltro.Size = new System.Drawing.Size(593, 152);
            this.grpBxFiltro.TabIndex = 0;
            this.grpBxFiltro.TabStop = false;
            this.grpBxFiltro.Text = "Filtros:";
            // 
            // grpBxVendedor
            // 
            this.grpBxVendedor.Controls.Add(this.txtComissao);
            this.grpBxVendedor.Controls.Add(this.txtCPF);
            this.grpBxVendedor.Controls.Add(this.txtNome);
            this.grpBxVendedor.Controls.Add(this.lblComissao);
            this.grpBxVendedor.Controls.Add(this.lblCPF);
            this.grpBxVendedor.Controls.Add(this.lblNome);
            this.grpBxVendedor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxVendedor.Location = new System.Drawing.Point(18, 22);
            this.grpBxVendedor.Name = "grpBxVendedor";
            this.grpBxVendedor.Size = new System.Drawing.Size(254, 110);
            this.grpBxVendedor.TabIndex = 8;
            this.grpBxVendedor.TabStop = false;
            this.grpBxVendedor.Text = "Dados Vendedor";
            // 
            // txtComissao
            // 
            this.txtComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComissao.Location = new System.Drawing.Point(161, 79);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(71, 20);
            this.txtComissao.TabIndex = 8;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(9, 79);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(134, 20);
            this.txtCPF.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(9, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(223, 20);
            this.txtNome.TabIndex = 6;
            // 
            // lblComissao
            // 
            this.lblComissao.AutoSize = true;
            this.lblComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComissao.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblComissao.Location = new System.Drawing.Point(158, 63);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(66, 13);
            this.lblComissao.TabIndex = 5;
            this.lblComissao.Text = "% Comissão:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblCPF.Location = new System.Drawing.Point(6, 62);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNome.Location = new System.Drawing.Point(6, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // grpBxPedido
            // 
            this.grpBxPedido.Controls.Add(this.txtQuant);
            this.grpBxPedido.Controls.Add(this.cmBxOperador);
            this.grpBxPedido.Controls.Add(this.lblOperador);
            this.grpBxPedido.Controls.Add(this.lblQuantVendas);
            this.grpBxPedido.Controls.Add(this.groupBox2);
            this.grpBxPedido.Controls.Add(this.cmBxTipoPed);
            this.grpBxPedido.Controls.Add(this.lblTipoPed);
            this.grpBxPedido.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxPedido.Location = new System.Drawing.Point(278, 22);
            this.grpBxPedido.Name = "grpBxPedido";
            this.grpBxPedido.Size = new System.Drawing.Size(297, 110);
            this.grpBxPedido.TabIndex = 7;
            this.grpBxPedido.TabStop = false;
            this.grpBxPedido.Text = "Dados Pedido";
            // 
            // txtQuant
            // 
            this.txtQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.Location = new System.Drawing.Point(79, 31);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(74, 20);
            this.txtQuant.TabIndex = 18;
            // 
            // cmBxOperador
            // 
            this.cmBxOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBxOperador.FormattingEnabled = true;
            this.cmBxOperador.Items.AddRange(new object[] {
            ">",
            "<",
            "=",
            ">=",
            "<="});
            this.cmBxOperador.Location = new System.Drawing.Point(9, 32);
            this.cmBxOperador.Name = "cmBxOperador";
            this.cmBxOperador.Size = new System.Drawing.Size(51, 21);
            this.cmBxOperador.TabIndex = 17;
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblOperador.Location = new System.Drawing.Point(6, 16);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(54, 13);
            this.lblOperador.TabIndex = 16;
            this.lblOperador.Text = "Operador:";
            // 
            // lblQuantVendas
            // 
            this.lblQuantVendas.AutoSize = true;
            this.lblQuantVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantVendas.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblQuantVendas.Location = new System.Drawing.Point(76, 15);
            this.lblQuantVendas.Name = "lblQuantVendas";
            this.lblQuantVendas.Size = new System.Drawing.Size(77, 13);
            this.lblQuantVendas.TabIndex = 15;
            this.lblQuantVendas.Text = "Quant. vendas";
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
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
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
            this.cmBxTipoPed.Location = new System.Drawing.Point(169, 31);
            this.cmBxTipoPed.Name = "cmBxTipoPed";
            this.cmBxTipoPed.Size = new System.Drawing.Size(121, 21);
            this.cmBxTipoPed.TabIndex = 12;
            // 
            // lblTipoPed
            // 
            this.lblTipoPed.AutoSize = true;
            this.lblTipoPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPed.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTipoPed.Location = new System.Drawing.Point(166, 14);
            this.lblTipoPed.Name = "lblTipoPed";
            this.lblTipoPed.Size = new System.Drawing.Size(81, 13);
            this.lblTipoPed.TabIndex = 7;
            this.lblTipoPed.Text = "Tipo do pedido:";
            // 
            // tbCntrlConVen
            // 
            this.tbCntrlConVen.Controls.Add(this.tbPgConVen);
            this.tbCntrlConVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlConVen.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlConVen.Name = "tbCntrlConVen";
            this.tbCntrlConVen.SelectedIndex = 0;
            this.tbCntrlConVen.Size = new System.Drawing.Size(622, 441);
            this.tbCntrlConVen.TabIndex = 0;
            // 
            // FrmConVen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(646, 470);
            this.Controls.Add(this.tbCntrlConVen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConVen";
            this.ShowIcon = false;
            this.Text = "Consulta de Vendedor";
            this.Leave += new System.EventHandler(this.FrmConVen_Leave);
            this.tbPgConVen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwConVen)).EndInit();
            this.grpBxFiltro.ResumeLayout(false);
            this.grpBxVendedor.ResumeLayout(false);
            this.grpBxVendedor.PerformLayout();
            this.grpBxPedido.ResumeLayout(false);
            this.grpBxPedido.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbCntrlConVen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbPgConVen;
        private System.Windows.Forms.GroupBox grpBxFiltro;
        private System.Windows.Forms.TabControl tbCntrlConVen;
        private System.Windows.Forms.GroupBox grpBxPedido;
        private System.Windows.Forms.GroupBox grpBxVendedor;
        private System.Windows.Forms.Label lblComissao;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipoPed;
        private System.Windows.Forms.DataGridView dtGrdVwConVen;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.ComboBox cmBxTipoPed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.ComboBox cmBxOperador;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblQuantVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCodPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDtPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnVlVendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnComissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnTotalCom;
    }
}