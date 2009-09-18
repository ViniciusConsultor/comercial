namespace Comercial
    {
    partial class FrmCadConPag
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
                this.tabPage2 = new System.Windows.Forms.TabPage();
                this.TbCntConPag = new System.Windows.Forms.TabControl();
                this.lblCodigo = new System.Windows.Forms.Label();
                this.chckBxEntrada = new System.Windows.Forms.CheckBox();
                this.TxtDiaDes = new System.Windows.Forms.TextBox();
                this.TxtDes = new System.Windows.Forms.TextBox();
                this.LblDiaPCo = new System.Windows.Forms.Label();
                this.LblDes = new System.Windows.Forms.Label();
                this.tabPage2.SuspendLayout();
                this.TbCntConPag.SuspendLayout();
                this.SuspendLayout();
                // 
                // tabPage2
                // 
                this.tabPage2.Controls.Add(this.lblCodigo);
                this.tabPage2.Controls.Add(this.chckBxEntrada);
                this.tabPage2.Controls.Add(this.TxtDiaDes);
                this.tabPage2.Controls.Add(this.TxtDes);
                this.tabPage2.Controls.Add(this.LblDiaPCo);
                this.tabPage2.Controls.Add(this.LblDes);
                this.tabPage2.Location = new System.Drawing.Point(4, 22);
                this.tabPage2.Name = "tabPage2";
                this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
                this.tabPage2.Size = new System.Drawing.Size(508, 50);
                this.tabPage2.TabIndex = 1;
                this.tabPage2.Text = "Cadastro Condições de Pagamento";
                this.tabPage2.UseVisualStyleBackColor = true;
                // 
                // TbCntConPag
                // 
                this.TbCntConPag.Controls.Add(this.tabPage2);
                this.TbCntConPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TbCntConPag.Location = new System.Drawing.Point(12, 12);
                this.TbCntConPag.Name = "TbCntConPag";
                this.TbCntConPag.SelectedIndex = 0;
                this.TbCntConPag.Size = new System.Drawing.Size(516, 76);
                this.TbCntConPag.TabIndex = 0;
                // 
                // lblCodigo
                // 
                this.lblCodigo.AutoSize = true;
                this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblCodigo.ForeColor = System.Drawing.Color.CadetBlue;
                this.lblCodigo.Location = new System.Drawing.Point(6, 23);
                this.lblCodigo.Name = "lblCodigo";
                this.lblCodigo.Size = new System.Drawing.Size(43, 13);
                this.lblCodigo.TabIndex = 47;
                this.lblCodigo.Text = "Código:";
                // 
                // chckBxEntrada
                // 
                this.chckBxEntrada.AutoSize = true;
                this.chckBxEntrada.ForeColor = System.Drawing.Color.CadetBlue;
                this.chckBxEntrada.Location = new System.Drawing.Point(425, 22);
                this.chckBxEntrada.Name = "chckBxEntrada";
                this.chckBxEntrada.Size = new System.Drawing.Size(70, 17);
                this.chckBxEntrada.TabIndex = 46;
                this.chckBxEntrada.Text = "Entrada";
                this.chckBxEntrada.UseVisualStyleBackColor = true;
                // 
                // TxtDiaDes
                // 
                this.TxtDiaDes.Location = new System.Drawing.Point(313, 19);
                this.TxtDiaDes.Name = "TxtDiaDes";
                this.TxtDiaDes.Size = new System.Drawing.Size(106, 20);
                this.TxtDiaDes.TabIndex = 45;
                // 
                // TxtDes
                // 
                this.TxtDes.Location = new System.Drawing.Point(65, 19);
                this.TxtDes.Name = "TxtDes";
                this.TxtDes.Size = new System.Drawing.Size(239, 20);
                this.TxtDes.TabIndex = 44;
                // 
                // LblDiaPCo
                // 
                this.LblDiaPCo.AutoSize = true;
                this.LblDiaPCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblDiaPCo.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblDiaPCo.Location = new System.Drawing.Point(310, 3);
                this.LblDiaPCo.Name = "LblDiaPCo";
                this.LblDiaPCo.Size = new System.Drawing.Size(109, 13);
                this.LblDiaPCo.TabIndex = 43;
                this.LblDiaPCo.Text = "Quantidade vezes";
                // 
                // LblDes
                // 
                this.LblDes.AutoSize = true;
                this.LblDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblDes.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblDes.Location = new System.Drawing.Point(62, 3);
                this.LblDes.Name = "LblDes";
                this.LblDes.Size = new System.Drawing.Size(68, 13);
                this.LblDes.TabIndex = 42;
                this.LblDes.Text = "Descrição:";
                // 
                // FrmCadConPag
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.WhiteSmoke;
                this.ClientSize = new System.Drawing.Size(537, 95);
                this.Controls.Add(this.TbCntConPag);
                this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.ForeColor = System.Drawing.Color.CadetBlue;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "FrmCadConPag";
                this.ShowIcon = false;
                this.ShowInTaskbar = false;
                this.Text = "Cadastro Condições de Pagamento";
                this.tabPage2.ResumeLayout(false);
                this.tabPage2.PerformLayout();
                this.TbCntConPag.ResumeLayout(false);
                this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl TbCntConPag;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.CheckBox chckBxEntrada;
        private System.Windows.Forms.TextBox TxtDiaDes;
        private System.Windows.Forms.TextBox TxtDes;
        private System.Windows.Forms.Label LblDiaPCo;
        private System.Windows.Forms.Label LblDes;


        }
    }