namespace Comercial
    {
    partial class FrmCadGrpProd
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
                this.TbCntCadBan = new System.Windows.Forms.TabControl();
                this.TbPgCadBancos = new System.Windows.Forms.TabPage();
                this.dESCRICAOTextBox = new System.Windows.Forms.TextBox();
                this.gRUPOPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
                this.lblCodigo = new System.Windows.Forms.Label();
                this.textBox1 = new System.Windows.Forms.TextBox();
                this.label1 = new System.Windows.Forms.Label();
                this.LblNumCon = new System.Windows.Forms.Label();
                this.TbCntCadBan.SuspendLayout();
                this.TbPgCadBancos.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.gRUPOPRODUTOBindingSource)).BeginInit();
                this.SuspendLayout();
                // 
                // TbCntCadBan
                // 
                this.TbCntCadBan.Controls.Add(this.TbPgCadBancos);
                this.TbCntCadBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TbCntCadBan.Location = new System.Drawing.Point(12, 12);
                this.TbCntCadBan.Name = "TbCntCadBan";
                this.TbCntCadBan.SelectedIndex = 0;
                this.TbCntCadBan.Size = new System.Drawing.Size(426, 95);
                this.TbCntCadBan.TabIndex = 0;
                // 
                // TbPgCadBancos
                // 
                this.TbPgCadBancos.AutoScroll = true;
                this.TbPgCadBancos.Controls.Add(this.dESCRICAOTextBox);
                this.TbPgCadBancos.Controls.Add(this.lblCodigo);
                this.TbPgCadBancos.Controls.Add(this.textBox1);
                this.TbPgCadBancos.Controls.Add(this.label1);
                this.TbPgCadBancos.Controls.Add(this.LblNumCon);
                this.TbPgCadBancos.Location = new System.Drawing.Point(4, 22);
                this.TbPgCadBancos.Name = "TbPgCadBancos";
                this.TbPgCadBancos.Padding = new System.Windows.Forms.Padding(3);
                this.TbPgCadBancos.Size = new System.Drawing.Size(418, 69);
                this.TbPgCadBancos.TabIndex = 1;
                this.TbPgCadBancos.Text = "Cadastro de grupo de produto";
                this.TbPgCadBancos.UseVisualStyleBackColor = true;
                // 
                // dESCRICAOTextBox
                // 
                this.dESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gRUPOPRODUTOBindingSource, "DESCRICAO", true));
                this.dESCRICAOTextBox.Location = new System.Drawing.Point(65, 34);
                this.dESCRICAOTextBox.Name = "dESCRICAOTextBox";
                this.dESCRICAOTextBox.Size = new System.Drawing.Size(225, 20);
                this.dESCRICAOTextBox.TabIndex = 72;
                // 
                // gRUPOPRODUTOBindingSource
                // 
                this.gRUPOPRODUTOBindingSource.DataSource = typeof(Comercial.GRUPOPRODUTO);
                // 
                // lblCodigo
                // 
                this.lblCodigo.AutoSize = true;
                this.lblCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gRUPOPRODUTOBindingSource, "CODGRUPOPRODUTO", true));
                this.lblCodigo.ForeColor = System.Drawing.Color.CadetBlue;
                this.lblCodigo.Location = new System.Drawing.Point(3, 37);
                this.lblCodigo.Name = "lblCodigo";
                this.lblCodigo.Size = new System.Drawing.Size(50, 13);
                this.lblCodigo.TabIndex = 71;
                this.lblCodigo.Text = "Código:";
                // 
                // textBox1
                // 
                this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gRUPOPRODUTOBindingSource, "DESCONTO", true));
                this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.textBox1.Location = new System.Drawing.Point(296, 34);
                this.textBox1.Name = "textBox1";
                this.textBox1.Size = new System.Drawing.Size(116, 20);
                this.textBox1.TabIndex = 70;
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label1.ForeColor = System.Drawing.Color.CadetBlue;
                this.label1.Location = new System.Drawing.Point(293, 18);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(61, 13);
                this.label1.TabIndex = 69;
                this.label1.Text = "Desconto";
                // 
                // LblNumCon
                // 
                this.LblNumCon.AutoSize = true;
                this.LblNumCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblNumCon.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblNumCon.Location = new System.Drawing.Point(62, 18);
                this.LblNumCon.Name = "LblNumCon";
                this.LblNumCon.Size = new System.Drawing.Size(58, 13);
                this.LblNumCon.TabIndex = 67;
                this.LblNumCon.Text = "Decrição";
                // 
                // FrmCadGrpProd
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.WhiteSmoke;
                this.ClientSize = new System.Drawing.Size(444, 116);
                this.Controls.Add(this.TbCntCadBan);
                this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.ForeColor = System.Drawing.Color.CornflowerBlue;
                this.Name = "FrmCadGrpProd";
                this.ShowIcon = false;
                this.Text = "Cadastro Grupo Produto";
                this.Load += new System.EventHandler(this.FrmCadGrpProd_Load);
                this.TbCntCadBan.ResumeLayout(false);
                this.TbPgCadBancos.ResumeLayout(false);
                this.TbPgCadBancos.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.gRUPOPRODUTOBindingSource)).EndInit();
                this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.TabControl TbCntCadBan;
        private System.Windows.Forms.TabPage TbPgCadBancos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNumCon;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.BindingSource gRUPOPRODUTOBindingSource;
        private System.Windows.Forms.TextBox dESCRICAOTextBox;

        }
    }

