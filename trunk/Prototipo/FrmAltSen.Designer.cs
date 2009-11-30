namespace Comercial
{
    partial class FrmAltSen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltSen));
            this.tbCntrlAltSenha = new System.Windows.Forms.TabControl();
            this.tbPgAltSenha = new System.Windows.Forms.TabPage();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.lblConfNovaSenha = new System.Windows.Forms.Label();
            this.lblSenhaNova = new System.Windows.Forms.Label();
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.LblUsu = new System.Windows.Forms.Label();
            this.txtUsu = new Comercial.TextButton();
            this.tbCntrlAltSenha.SuspendLayout();
            this.tbPgAltSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCntrlAltSenha
            // 
            this.tbCntrlAltSenha.Controls.Add(this.tbPgAltSenha);
            this.tbCntrlAltSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlAltSenha.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlAltSenha.Name = "tbCntrlAltSenha";
            this.tbCntrlAltSenha.SelectedIndex = 0;
            this.tbCntrlAltSenha.Size = new System.Drawing.Size(268, 243);
            this.tbCntrlAltSenha.TabIndex = 0;
            // 
            // tbPgAltSenha
            // 
            this.tbPgAltSenha.Controls.Add(this.txtUsu);
            this.tbPgAltSenha.Controls.Add(this.txtConfSenha);
            this.tbPgAltSenha.Controls.Add(this.txtNovaSenha);
            this.tbPgAltSenha.Controls.Add(this.txtSenhaAtual);
            this.tbPgAltSenha.Controls.Add(this.lblConfNovaSenha);
            this.tbPgAltSenha.Controls.Add(this.lblSenhaNova);
            this.tbPgAltSenha.Controls.Add(this.lblSenhaAtual);
            this.tbPgAltSenha.Controls.Add(this.LblUsu);
            this.tbPgAltSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPgAltSenha.Location = new System.Drawing.Point(4, 22);
            this.tbPgAltSenha.Name = "tbPgAltSenha";
            this.tbPgAltSenha.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgAltSenha.Size = new System.Drawing.Size(260, 217);
            this.tbPgAltSenha.TabIndex = 0;
            this.tbPgAltSenha.Text = "Alteração de senha";
            this.tbPgAltSenha.UseVisualStyleBackColor = true;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfSenha.Location = new System.Drawing.Point(21, 178);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.Size = new System.Drawing.Size(152, 20);
            this.txtConfSenha.TabIndex = 7;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.Location = new System.Drawing.Point(21, 129);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(152, 20);
            this.txtNovaSenha.TabIndex = 6;
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAtual.Location = new System.Drawing.Point(21, 81);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '*';
            this.txtSenhaAtual.Size = new System.Drawing.Size(152, 20);
            this.txtSenhaAtual.TabIndex = 5;
            // 
            // lblConfNovaSenha
            // 
            this.lblConfNovaSenha.AutoSize = true;
            this.lblConfNovaSenha.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblConfNovaSenha.Location = new System.Drawing.Point(18, 162);
            this.lblConfNovaSenha.Name = "lblConfNovaSenha";
            this.lblConfNovaSenha.Size = new System.Drawing.Size(165, 13);
            this.lblConfNovaSenha.TabIndex = 3;
            this.lblConfNovaSenha.Text = "Confirmação da nova senha";
            // 
            // lblSenhaNova
            // 
            this.lblSenhaNova.AutoSize = true;
            this.lblSenhaNova.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblSenhaNova.Location = new System.Drawing.Point(18, 113);
            this.lblSenhaNova.Name = "lblSenhaNova";
            this.lblSenhaNova.Size = new System.Drawing.Size(75, 13);
            this.lblSenhaNova.TabIndex = 2;
            this.lblSenhaNova.Text = "Nova senha";
            this.lblSenhaNova.Click += new System.EventHandler(this.lblSenhaNova_Click);
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblSenhaAtual.Location = new System.Drawing.Point(18, 65);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(75, 13);
            this.lblSenhaAtual.TabIndex = 1;
            this.lblSenhaAtual.Text = "Senha atual";
            this.lblSenhaAtual.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblUsu
            // 
            this.LblUsu.AutoSize = true;
            this.LblUsu.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblUsu.Location = new System.Drawing.Point(18, 16);
            this.LblUsu.Name = "LblUsu";
            this.LblUsu.Size = new System.Drawing.Size(50, 13);
            this.LblUsu.TabIndex = 0;
            this.LblUsu.Text = "Usuário";
            // 
            // txtUsu
            // 
            this.txtUsu.getText = "";
            this.txtUsu.Image = ((System.Drawing.Image)(resources.GetObject("txtUsu.Image")));
            this.txtUsu.Location = new System.Drawing.Point(21, 32);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.ShowButton = false;
            this.txtUsu.Size = new System.Drawing.Size(152, 25);
            this.txtUsu.TabIndex = 45;
            this.txtUsu.Click += new System.EventHandler(this.txtUsu_Click);
            this.txtUsu.ButtonClick += new System.EventHandler(this.txtUsu_ButtonClick);
            // 
            // FrmAltSen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(292, 267);
            this.ControlBox = false;
            this.Controls.Add(this.tbCntrlAltSenha);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltSen";
            this.ShowIcon = false;
            this.Text = "Alteração de senha";
            this.tbCntrlAltSenha.ResumeLayout(false);
            this.tbPgAltSenha.ResumeLayout(false);
            this.tbPgAltSenha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrlAltSenha;
        private System.Windows.Forms.TabPage tbPgAltSenha;
        private System.Windows.Forms.Label LblUsu;
        private System.Windows.Forms.Label lblSenhaAtual;
        private System.Windows.Forms.Label lblConfNovaSenha;
        private System.Windows.Forms.Label lblSenhaNova;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        public TextButton txtUsu;
    }
}