namespace Comercial
{
    partial class FrmCadUsu
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Criar Usúario");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Alterar Senha");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Menu");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Controle Usúario", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Backup");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Calculadora");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Notepad");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Excel");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Utilitários", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Arquivo", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Cliente");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Produto");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Pedido");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Vendedor");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Bancos");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Unidade Medida");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Condição Pagamento");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Transportadora");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("TES");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Ajustes", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Cadastros", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Cliente");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Produto");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Pedido");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Vendedor");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Consulta", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Gerar NF");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Devolução NF");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Liberação Pedido");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Gerar Modelo");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Consultar");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Mineração Dados", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Processos", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Sistema Comercial", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode21,
            treeNode26,
            treeNode33});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadUsu));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpBxMenu = new System.Windows.Forms.GroupBox();
            this.trVwMenu = new System.Windows.Forms.TreeView();
            this.btnDesAll = new System.Windows.Forms.Button();
            this.btnMarAll = new System.Windows.Forms.Button();
            this.grpBxInfor = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chckBxUsublq = new System.Windows.Forms.CheckBox();
            this.txtConSenha = new System.Windows.Forms.TextBox();
            this.lblConSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblUsua = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbCntrlCtrUsu = new System.Windows.Forms.TabControl();
            this.txtBxSenhaAntiga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsu = new Comercial.TextButton();
            this.tabPage1.SuspendLayout();
            this.grpBxMenu.SuspendLayout();
            this.grpBxInfor.SuspendLayout();
            this.tbCntrlCtrUsu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpBxMenu);
            this.tabPage1.Controls.Add(this.grpBxInfor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Identificação";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpBxMenu
            // 
            this.grpBxMenu.Controls.Add(this.trVwMenu);
            this.grpBxMenu.Controls.Add(this.btnDesAll);
            this.grpBxMenu.Controls.Add(this.btnMarAll);
            this.grpBxMenu.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxMenu.Location = new System.Drawing.Point(273, 6);
            this.grpBxMenu.Name = "grpBxMenu";
            this.grpBxMenu.Size = new System.Drawing.Size(250, 238);
            this.grpBxMenu.TabIndex = 3;
            this.grpBxMenu.TabStop = false;
            this.grpBxMenu.Text = "Menu";
            // 
            // trVwMenu
            // 
            this.trVwMenu.CheckBoxes = true;
            this.trVwMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.trVwMenu.Location = new System.Drawing.Point(6, 13);
            this.trVwMenu.Name = "trVwMenu";
            treeNode1.Name = "Nó9";
            treeNode1.Text = "Criar Usúario";
            treeNode2.Name = "Nó6";
            treeNode2.Text = "Alterar Senha";
            treeNode3.Name = "Nó7";
            treeNode3.Text = "Menu";
            treeNode4.Name = "Nó4";
            treeNode4.Text = "Controle Usúario";
            treeNode5.Name = "Nó10";
            treeNode5.Text = "Backup";
            treeNode6.Name = "Nó14";
            treeNode6.Text = "Calculadora";
            treeNode7.Name = "Nó15";
            treeNode7.Text = "Notepad";
            treeNode8.Name = "Nó16";
            treeNode8.Text = "Excel";
            treeNode9.Name = "Nó13";
            treeNode9.Text = "Utilitários";
            treeNode10.Name = "Nó1";
            treeNode10.Text = "Arquivo";
            treeNode11.Name = "Nó18";
            treeNode11.Text = "Cliente";
            treeNode12.Name = "Nó19";
            treeNode12.Text = "Produto";
            treeNode13.Name = "Nó20";
            treeNode13.Text = "Pedido";
            treeNode14.Name = "Nó21";
            treeNode14.Text = "Vendedor";
            treeNode15.Name = "Nó23";
            treeNode15.Text = "Bancos";
            treeNode16.Name = "Nó24";
            treeNode16.Text = "Unidade Medida";
            treeNode17.Name = "Nó25";
            treeNode17.Text = "Condição Pagamento";
            treeNode18.Name = "Nó26";
            treeNode18.Text = "Transportadora";
            treeNode19.Name = "Nó27";
            treeNode19.Text = "TES";
            treeNode20.Name = "Nó22";
            treeNode20.Text = "Ajustes";
            treeNode21.Name = "Nó17";
            treeNode21.Text = "Cadastros";
            treeNode22.Name = "Nó29";
            treeNode22.Text = "Cliente";
            treeNode23.Name = "Nó30";
            treeNode23.Text = "Produto";
            treeNode24.Name = "Nó31";
            treeNode24.Text = "Pedido";
            treeNode25.Name = "Nó32";
            treeNode25.Text = "Vendedor";
            treeNode26.Name = "Nó28";
            treeNode26.Text = "Consulta";
            treeNode27.Name = "Nó34";
            treeNode27.Text = "Gerar NF";
            treeNode28.Name = "Nó35";
            treeNode28.Text = "Devolução NF";
            treeNode29.Name = "Nó36";
            treeNode29.Text = "Liberação Pedido";
            treeNode30.Name = "Nó38";
            treeNode30.Text = "Gerar Modelo";
            treeNode31.Name = "Nó39";
            treeNode31.Text = "Consultar";
            treeNode32.Name = "Nó37";
            treeNode32.Text = "Mineração Dados";
            treeNode33.Name = "Nó33";
            treeNode33.Text = "Processos";
            treeNode34.Name = "Nó0";
            treeNode34.Text = "Sistema Comercial";
            this.trVwMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode34});
            this.trVwMenu.Size = new System.Drawing.Size(238, 159);
            this.trVwMenu.TabIndex = 3;
            // 
            // btnDesAll
            // 
            this.btnDesAll.ForeColor = System.Drawing.Color.Black;
            this.btnDesAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesAll.Location = new System.Drawing.Point(134, 178);
            this.btnDesAll.Name = "btnDesAll";
            this.btnDesAll.Size = new System.Drawing.Size(110, 23);
            this.btnDesAll.TabIndex = 2;
            this.btnDesAll.Text = "Desmarcar Todos";
            this.btnDesAll.UseVisualStyleBackColor = true;
            // 
            // btnMarAll
            // 
            this.btnMarAll.ForeColor = System.Drawing.Color.Black;
            this.btnMarAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarAll.Location = new System.Drawing.Point(6, 178);
            this.btnMarAll.Name = "btnMarAll";
            this.btnMarAll.Size = new System.Drawing.Size(103, 23);
            this.btnMarAll.TabIndex = 1;
            this.btnMarAll.Text = "Marcar Todos";
            this.btnMarAll.UseVisualStyleBackColor = true;
            // 
            // grpBxInfor
            // 
            this.grpBxInfor.Controls.Add(this.txtBxSenhaAntiga);
            this.grpBxInfor.Controls.Add(this.label1);
            this.grpBxInfor.Controls.Add(this.checkBox1);
            this.grpBxInfor.Controls.Add(this.txtUsu);
            this.grpBxInfor.Controls.Add(this.chckBxUsublq);
            this.grpBxInfor.Controls.Add(this.txtConSenha);
            this.grpBxInfor.Controls.Add(this.lblConSenha);
            this.grpBxInfor.Controls.Add(this.txtSenha);
            this.grpBxInfor.Controls.Add(this.lblUsua);
            this.grpBxInfor.Controls.Add(this.lblSenha);
            this.grpBxInfor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxInfor.Location = new System.Drawing.Point(6, 6);
            this.grpBxInfor.Name = "grpBxInfor";
            this.grpBxInfor.Size = new System.Drawing.Size(245, 238);
            this.grpBxInfor.TabIndex = 0;
            this.grpBxInfor.TabStop = false;
            this.grpBxInfor.Text = "Informação";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.CadetBlue;
            this.checkBox1.Location = new System.Drawing.Point(11, 213);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 45;
            this.checkBox1.Text = "Privilegiado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chckBxUsublq
            // 
            this.chckBxUsublq.AutoSize = true;
            this.chckBxUsublq.ForeColor = System.Drawing.Color.CadetBlue;
            this.chckBxUsublq.Location = new System.Drawing.Point(11, 184);
            this.chckBxUsublq.Name = "chckBxUsublq";
            this.chckBxUsublq.Size = new System.Drawing.Size(116, 17);
            this.chckBxUsublq.TabIndex = 43;
            this.chckBxUsublq.Text = "Usuário Bloqueado";
            this.chckBxUsublq.UseVisualStyleBackColor = true;
            // 
            // txtConSenha
            // 
            this.txtConSenha.Location = new System.Drawing.Point(11, 152);
            this.txtConSenha.Name = "txtConSenha";
            this.txtConSenha.Size = new System.Drawing.Size(100, 20);
            this.txtConSenha.TabIndex = 42;
            // 
            // lblConSenha
            // 
            this.lblConSenha.AutoSize = true;
            this.lblConSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConSenha.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblConSenha.Location = new System.Drawing.Point(11, 136);
            this.lblConSenha.Name = "lblConSenha";
            this.lblConSenha.Size = new System.Drawing.Size(108, 13);
            this.lblConSenha.TabIndex = 41;
            this.lblConSenha.Text = "Confirmar Senha :";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(11, 113);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 40;
            // 
            // lblUsua
            // 
            this.lblUsua.AutoSize = true;
            this.lblUsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsua.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblUsua.Location = new System.Drawing.Point(11, 19);
            this.lblUsua.Name = "lblUsua";
            this.lblUsua.Size = new System.Drawing.Size(58, 13);
            this.lblUsua.TabIndex = 36;
            this.lblUsua.Text = "Usuário :";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblSenha.Location = new System.Drawing.Point(11, 97);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(55, 13);
            this.lblSenha.TabIndex = 31;
            this.lblSenha.Text = "Senha : ";
            // 
            // tbCntrlCtrUsu
            // 
            this.tbCntrlCtrUsu.Controls.Add(this.tabPage1);
            this.tbCntrlCtrUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlCtrUsu.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlCtrUsu.Name = "tbCntrlCtrUsu";
            this.tbCntrlCtrUsu.SelectedIndex = 0;
            this.tbCntrlCtrUsu.Size = new System.Drawing.Size(537, 281);
            this.tbCntrlCtrUsu.TabIndex = 0;
            // 
            // txtBxSenhaAntiga
            // 
            this.txtBxSenhaAntiga.Location = new System.Drawing.Point(11, 74);
            this.txtBxSenhaAntiga.Name = "txtBxSenhaAntiga";
            this.txtBxSenhaAntiga.Size = new System.Drawing.Size(100, 20);
            this.txtBxSenhaAntiga.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Senha antiga: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsu
            // 
            this.txtUsu.getText = "";
            this.txtUsu.Image = ((System.Drawing.Image)(resources.GetObject("txtUsu.Image")));
            this.txtUsu.Location = new System.Drawing.Point(11, 35);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.ShowButton = false;
            this.txtUsu.Size = new System.Drawing.Size(181, 25);
            this.txtUsu.TabIndex = 44;
            this.txtUsu.ButtonClick += new System.EventHandler(this.txtBtnUsu_ButtonClick);
            // 
            // FrmCadUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 302);
            this.Controls.Add(this.tbCntrlCtrUsu);
            this.Name = "FrmCadUsu";
            this.Text = "Controle de usuários";
            this.tabPage1.ResumeLayout(false);
            this.grpBxMenu.ResumeLayout(false);
            this.grpBxInfor.ResumeLayout(false);
            this.grpBxInfor.PerformLayout();
            this.tbCntrlCtrUsu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpBxMenu;
        private System.Windows.Forms.TreeView trVwMenu;
        private System.Windows.Forms.Button btnDesAll;
        private System.Windows.Forms.Button btnMarAll;
        private System.Windows.Forms.GroupBox grpBxInfor;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chckBxUsublq;
        private System.Windows.Forms.TextBox txtConSenha;
        private System.Windows.Forms.Label lblConSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblUsua;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TabControl tbCntrlCtrUsu;
        private System.Windows.Forms.TextBox txtBxSenhaAntiga;
        private System.Windows.Forms.Label label1;
        public TextButton txtUsu;

    }
}