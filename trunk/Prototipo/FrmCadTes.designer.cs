namespace Comercial
    {
    partial class FrmCadTes
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
                this.TBCntCadTes = new System.Windows.Forms.TabControl();
                this.TbPgCadTes = new System.Windows.Forms.TabPage();
                this.GrpBxCadTes = new System.Windows.Forms.GroupBox();
                this.TxtFin = new System.Windows.Forms.TextBox();
                this.TxtTipMov = new System.Windows.Forms.TextBox();
                this.CmbTes = new System.Windows.Forms.ComboBox();
                this.LblFin = new System.Windows.Forms.Label();
                this.lLblTipMov = new System.Windows.Forms.Label();
                this.LblTipTes = new System.Windows.Forms.Label();
                this.lblCodigo = new System.Windows.Forms.Label();
                this.ChbIcm = new System.Windows.Forms.CheckBox();
                this.ChbCreIpi = new System.Windows.Forms.CheckBox();
                this.ChbAtuAti = new System.Windows.Forms.CheckBox();
                this.chbAtuPre = new System.Windows.Forms.CheckBox();
                this.ChbAtuEst = new System.Windows.Forms.CheckBox();
                this.ChbGerDup = new System.Windows.Forms.CheckBox();
                this.TBCntCadTes.SuspendLayout();
                this.TbPgCadTes.SuspendLayout();
                this.GrpBxCadTes.SuspendLayout();
                this.SuspendLayout();
                // 
                // TBCntCadTes
                // 
                this.TBCntCadTes.Controls.Add(this.TbPgCadTes);
                this.TBCntCadTes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TBCntCadTes.Location = new System.Drawing.Point(12, 12);
                this.TBCntCadTes.Name = "TBCntCadTes";
                this.TBCntCadTes.SelectedIndex = 0;
                this.TBCntCadTes.Size = new System.Drawing.Size(463, 195);
                this.TBCntCadTes.TabIndex = 0;
                // 
                // TbPgCadTes
                // 
                this.TbPgCadTes.Controls.Add(this.GrpBxCadTes);
                this.TbPgCadTes.Location = new System.Drawing.Point(4, 22);
                this.TbPgCadTes.Name = "TbPgCadTes";
                this.TbPgCadTes.Padding = new System.Windows.Forms.Padding(3);
                this.TbPgCadTes.Size = new System.Drawing.Size(455, 169);
                this.TbPgCadTes.TabIndex = 1;
                this.TbPgCadTes.Text = "Cadastro TES";
                this.TbPgCadTes.UseVisualStyleBackColor = true;
                // 
                // GrpBxCadTes
                // 
                this.GrpBxCadTes.Controls.Add(this.ChbIcm);
                this.GrpBxCadTes.Controls.Add(this.ChbCreIpi);
                this.GrpBxCadTes.Controls.Add(this.ChbAtuAti);
                this.GrpBxCadTes.Controls.Add(this.chbAtuPre);
                this.GrpBxCadTes.Controls.Add(this.ChbAtuEst);
                this.GrpBxCadTes.Controls.Add(this.ChbGerDup);
                this.GrpBxCadTes.Controls.Add(this.lblCodigo);
                this.GrpBxCadTes.Controls.Add(this.TxtFin);
                this.GrpBxCadTes.Controls.Add(this.TxtTipMov);
                this.GrpBxCadTes.Controls.Add(this.CmbTes);
                this.GrpBxCadTes.Controls.Add(this.LblFin);
                this.GrpBxCadTes.Controls.Add(this.lLblTipMov);
                this.GrpBxCadTes.Controls.Add(this.LblTipTes);
                this.GrpBxCadTes.ForeColor = System.Drawing.Color.CornflowerBlue;
                this.GrpBxCadTes.Location = new System.Drawing.Point(6, 6);
                this.GrpBxCadTes.Name = "GrpBxCadTes";
                this.GrpBxCadTes.Size = new System.Drawing.Size(442, 152);
                this.GrpBxCadTes.TabIndex = 0;
                this.GrpBxCadTes.TabStop = false;
                this.GrpBxCadTes.Text = "Tipo de Entrada e Saída";
                // 
                // TxtFin
                // 
                this.TxtFin.Location = new System.Drawing.Point(9, 72);
                this.TxtFin.Name = "TxtFin";
                this.TxtFin.Size = new System.Drawing.Size(425, 20);
                this.TxtFin.TabIndex = 41;
                // 
                // TxtTipMov
                // 
                this.TxtTipMov.Location = new System.Drawing.Point(193, 32);
                this.TxtTipMov.Name = "TxtTipMov";
                this.TxtTipMov.Size = new System.Drawing.Size(237, 20);
                this.TxtTipMov.TabIndex = 40;
                // 
                // CmbTes
                // 
                this.CmbTes.FormattingEnabled = true;
                this.CmbTes.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
                this.CmbTes.Location = new System.Drawing.Point(64, 32);
                this.CmbTes.Name = "CmbTes";
                this.CmbTes.Size = new System.Drawing.Size(121, 21);
                this.CmbTes.TabIndex = 37;
                // 
                // LblFin
                // 
                this.LblFin.AutoSize = true;
                this.LblFin.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblFin.Location = new System.Drawing.Point(6, 56);
                this.LblFin.Name = "LblFin";
                this.LblFin.Size = new System.Drawing.Size(69, 13);
                this.LblFin.TabIndex = 32;
                this.LblFin.Text = "Finalidade:";
                // 
                // lLblTipMov
                // 
                this.lLblTipMov.AutoSize = true;
                this.lLblTipMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lLblTipMov.ForeColor = System.Drawing.Color.CadetBlue;
                this.lLblTipMov.Location = new System.Drawing.Point(190, 16);
                this.lLblTipMov.Name = "lLblTipMov";
                this.lLblTipMov.Size = new System.Drawing.Size(101, 13);
                this.lLblTipMov.TabIndex = 31;
                this.lLblTipMov.Text = "Tipo Movimento:";
                // 
                // LblTipTes
                // 
                this.LblTipTes.AutoSize = true;
                this.LblTipTes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LblTipTes.ForeColor = System.Drawing.Color.CadetBlue;
                this.LblTipTes.Location = new System.Drawing.Point(61, 16);
                this.LblTipTes.Name = "LblTipTes";
                this.LblTipTes.Size = new System.Drawing.Size(64, 13);
                this.LblTipTes.TabIndex = 30;
                this.LblTipTes.Text = "Tipo TES:";
                // 
                // lblCodigo
                // 
                this.lblCodigo.AutoSize = true;
                this.lblCodigo.ForeColor = System.Drawing.Color.CadetBlue;
                this.lblCodigo.Location = new System.Drawing.Point(8, 35);
                this.lblCodigo.Name = "lblCodigo";
                this.lblCodigo.Size = new System.Drawing.Size(50, 13);
                this.lblCodigo.TabIndex = 42;
                this.lblCodigo.Text = "Código:";
                // 
                // ChbIcm
                // 
                this.ChbIcm.AutoSize = true;
                this.ChbIcm.ForeColor = System.Drawing.Color.CadetBlue;
                this.ChbIcm.Location = new System.Drawing.Point(10, 98);
                this.ChbIcm.Name = "ChbIcm";
                this.ChbIcm.Size = new System.Drawing.Size(86, 17);
                this.ChbIcm.TabIndex = 48;
                this.ChbIcm.Text = "Cred ICMS";
                this.ChbIcm.UseVisualStyleBackColor = true;
                // 
                // ChbCreIpi
                // 
                this.ChbCreIpi.AutoSize = true;
                this.ChbCreIpi.ForeColor = System.Drawing.Color.CadetBlue;
                this.ChbCreIpi.Location = new System.Drawing.Point(138, 98);
                this.ChbCreIpi.Name = "ChbCreIpi";
                this.ChbCreIpi.Size = new System.Drawing.Size(72, 17);
                this.ChbCreIpi.TabIndex = 47;
                this.ChbCreIpi.Text = "Cred IPI";
                this.ChbCreIpi.UseVisualStyleBackColor = true;
                // 
                // ChbAtuAti
                // 
                this.ChbAtuAti.AutoSize = true;
                this.ChbAtuAti.ForeColor = System.Drawing.Color.CadetBlue;
                this.ChbAtuAti.Location = new System.Drawing.Point(315, 121);
                this.ChbAtuAti.Name = "ChbAtuAti";
                this.ChbAtuAti.Size = new System.Drawing.Size(104, 17);
                this.ChbAtuAti.TabIndex = 46;
                this.ChbAtuAti.Text = "Atualiza Ativo";
                this.ChbAtuAti.UseVisualStyleBackColor = true;
                // 
                // chbAtuPre
                // 
                this.chbAtuPre.AutoSize = true;
                this.chbAtuPre.ForeColor = System.Drawing.Color.CadetBlue;
                this.chbAtuPre.Location = new System.Drawing.Point(137, 121);
                this.chbAtuPre.Name = "chbAtuPre";
                this.chbAtuPre.Size = new System.Drawing.Size(172, 17);
                this.chbAtuPre.TabIndex = 45;
                this.chbAtuPre.Text = "Atualiza Preço de Compra";
                this.chbAtuPre.UseVisualStyleBackColor = true;
                // 
                // ChbAtuEst
                // 
                this.ChbAtuEst.AutoSize = true;
                this.ChbAtuEst.ForeColor = System.Drawing.Color.CadetBlue;
                this.ChbAtuEst.Location = new System.Drawing.Point(11, 121);
                this.ChbAtuEst.Name = "ChbAtuEst";
                this.ChbAtuEst.Size = new System.Drawing.Size(121, 17);
                this.ChbAtuEst.TabIndex = 44;
                this.ChbAtuEst.Text = "Atualiza Estoque";
                this.ChbAtuEst.UseVisualStyleBackColor = true;
                // 
                // ChbGerDup
                // 
                this.ChbGerDup.AutoSize = true;
                this.ChbGerDup.ForeColor = System.Drawing.Color.CadetBlue;
                this.ChbGerDup.Location = new System.Drawing.Point(315, 98);
                this.ChbGerDup.Name = "ChbGerDup";
                this.ChbGerDup.Size = new System.Drawing.Size(115, 17);
                this.ChbGerDup.TabIndex = 43;
                this.ChbGerDup.Text = "Gerar Duplicata";
                this.ChbGerDup.UseVisualStyleBackColor = true;
                // 
                // FrmCadTes
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.WhiteSmoke;
                this.ClientSize = new System.Drawing.Size(486, 215);
                this.Controls.Add(this.TBCntCadTes);
                this.ForeColor = System.Drawing.Color.CadetBlue;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "FrmCadTes";
                this.ShowIcon = false;
                this.Text = "Cadastro TES (Tipo de Entrada e Saída)";
                this.Load += new System.EventHandler(this.Form5_Load);
                this.TBCntCadTes.ResumeLayout(false);
                this.TbPgCadTes.ResumeLayout(false);
                this.GrpBxCadTes.ResumeLayout(false);
                this.GrpBxCadTes.PerformLayout();
                this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.TabControl TBCntCadTes;
        private System.Windows.Forms.TabPage TbPgCadTes;
        private System.Windows.Forms.GroupBox GrpBxCadTes;
        private System.Windows.Forms.TextBox TxtFin;
        private System.Windows.Forms.TextBox TxtTipMov;
        private System.Windows.Forms.ComboBox CmbTes;
        private System.Windows.Forms.Label LblFin;
        private System.Windows.Forms.Label lLblTipMov;
        private System.Windows.Forms.Label LblTipTes;
        private System.Windows.Forms.CheckBox ChbIcm;
        private System.Windows.Forms.CheckBox ChbCreIpi;
        private System.Windows.Forms.CheckBox ChbAtuAti;
        private System.Windows.Forms.CheckBox chbAtuPre;
        private System.Windows.Forms.CheckBox ChbAtuEst;
        private System.Windows.Forms.CheckBox ChbGerDup;
        private System.Windows.Forms.Label lblCodigo;

        }
    }