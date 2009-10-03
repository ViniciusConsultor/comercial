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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClmnCodGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBxFiltro = new System.Windows.Forms.GroupBox();
            this.grpBxProd = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.LblDesc = new System.Windows.Forms.Label();
            this.txtCodProd = new Comercial.TextButton();
            this.LblCodProd = new System.Windows.Forms.Label();
            this.grpBxFab = new System.Windows.Forms.GroupBox();
            this.txtFabricante = new Comercial.TextButton();
            this.dtTmPckrDtFim = new System.Windows.Forms.DateTimePicker();
            this.lblAte = new System.Windows.Forms.Label();
            this.dtTmPckrDtIni = new System.Windows.Forms.DateTimePicker();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.tbCntrlConProd.SuspendLayout();
            this.tbPgConProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tbPgConProd.Controls.Add(this.dataGridView1);
            this.tbPgConProd.Controls.Add(this.grpBxFiltro);
            this.tbPgConProd.Location = new System.Drawing.Point(4, 22);
            this.tbPgConProd.Name = "tbPgConProd";
            this.tbPgConProd.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgConProd.Size = new System.Drawing.Size(729, 439);
            this.tbPgConProd.TabIndex = 0;
            this.tbPgConProd.Text = "Consulta de Desconto permitido por Grupo de Produto - Grupos e produtos";
            this.tbPgConProd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnCodGrupo,
            this.ClmnDesc});
            this.dataGridView1.Location = new System.Drawing.Point(6, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 252);
            this.dataGridView1.TabIndex = 2;
            // 
            // ClmnCodGrupo
            // 
            this.ClmnCodGrupo.HeaderText = "Cód. Grupo";
            this.ClmnCodGrupo.Name = "ClmnCodGrupo";
            this.ClmnCodGrupo.Width = 150;
            // 
            // ClmnDesc
            // 
            this.ClmnDesc.HeaderText = "Descrição";
            this.ClmnDesc.Name = "ClmnDesc";
            this.ClmnDesc.Width = 400;
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
            this.grpBxProd.Controls.Add(this.dateTimePicker1);
            this.grpBxProd.Controls.Add(this.label1);
            this.grpBxProd.Controls.Add(this.dateTimePicker2);
            this.grpBxProd.Controls.Add(this.label2);
            this.grpBxProd.Controls.Add(this.label3);
            this.grpBxProd.Controls.Add(this.txtDescricao);
            this.grpBxProd.Controls.Add(this.LblDesc);
            this.grpBxProd.Controls.Add(this.txtCodProd);
            this.grpBxProd.Controls.Add(this.LblCodProd);
            this.grpBxProd.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxProd.Location = new System.Drawing.Point(337, 19);
            this.grpBxProd.Name = "grpBxProd";
            this.grpBxProd.Size = new System.Drawing.Size(321, 133);
            this.grpBxProd.TabIndex = 1;
            this.grpBxProd.TabStop = false;
            this.grpBxProd.Text = "Dados Produtos:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(92, 20);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(155, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Até";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(57, 91);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(92, 20);
            this.dateTimePicker2.TabIndex = 17;
            this.dateTimePicker2.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "De";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(21, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data de cadastro:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(113, 38);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(183, 20);
            this.txtDescricao.TabIndex = 14;
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesc.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblDesc.Location = new System.Drawing.Point(110, 21);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(58, 13);
            this.LblDesc.TabIndex = 13;
            this.LblDesc.Text = "Descrição:";
            // 
            // txtCodProd
            // 
            this.txtCodProd.getText = "";
            this.txtCodProd.Image = global::Comercial.Properties.Resources.search1;
            this.txtCodProd.Location = new System.Drawing.Point(20, 38);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.ShowButton = false;
            this.txtCodProd.Size = new System.Drawing.Size(83, 25);
            this.txtCodProd.TabIndex = 12;
            this.txtCodProd.ButtonClick += new System.EventHandler(this.txtCodProd_ButtonClick);
            // 
            // LblCodProd
            // 
            this.LblCodProd.AutoSize = true;
            this.LblCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodProd.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblCodProd.Location = new System.Drawing.Point(15, 21);
            this.LblCodProd.Name = "LblCodProd";
            this.LblCodProd.Size = new System.Drawing.Size(171, 13);
            this.LblCodProd.TabIndex = 11;
            this.LblCodProd.Text = "CodCondicaoPagamento. Produto:";
            // 
            // grpBxFab
            // 
            this.grpBxFab.Controls.Add(this.txtFabricante);
            this.grpBxFab.Controls.Add(this.dtTmPckrDtFim);
            this.grpBxFab.Controls.Add(this.lblAte);
            this.grpBxFab.Controls.Add(this.dtTmPckrDtIni);
            this.grpBxFab.Controls.Add(this.lblDe);
            this.grpBxFab.Controls.Add(this.lblDtCadastro);
            this.grpBxFab.Controls.Add(this.lblGrupo);
            this.grpBxFab.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxFab.Location = new System.Drawing.Point(24, 19);
            this.grpBxFab.Name = "grpBxFab";
            this.grpBxFab.Size = new System.Drawing.Size(293, 133);
            this.grpBxFab.TabIndex = 0;
            this.grpBxFab.TabStop = false;
            this.grpBxFab.Text = "Dados grupos:";
            // 
            // txtFabricante
            // 
            this.txtFabricante.getText = "";
            this.txtFabricante.Image = global::Comercial.Properties.Resources.search1;
            this.txtFabricante.Location = new System.Drawing.Point(20, 38);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.ShowButton = false;
            this.txtFabricante.Size = new System.Drawing.Size(252, 25);
            this.txtFabricante.TabIndex = 10;
            this.txtFabricante.ButtonClick += new System.EventHandler(this.txtFabricante_ButtonClick);
            // 
            // dtTmPckrDtFim
            // 
            this.dtTmPckrDtFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTmPckrDtFim.Location = new System.Drawing.Point(180, 91);
            this.dtTmPckrDtFim.Name = "dtTmPckrDtFim";
            this.dtTmPckrDtFim.Size = new System.Drawing.Size(92, 20);
            this.dtTmPckrDtFim.TabIndex = 9;
            this.dtTmPckrDtFim.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAte.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblAte.Location = new System.Drawing.Point(151, 95);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(23, 13);
            this.lblAte.TabIndex = 8;
            this.lblAte.Text = "Até";
            // 
            // dtTmPckrDtIni
            // 
            this.dtTmPckrDtIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTmPckrDtIni.Location = new System.Drawing.Point(53, 91);
            this.dtTmPckrDtIni.Name = "dtTmPckrDtIni";
            this.dtTmPckrDtIni.Size = new System.Drawing.Size(92, 20);
            this.dtTmPckrDtIni.TabIndex = 7;
            this.dtTmPckrDtIni.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDe.Location = new System.Drawing.Point(26, 95);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(21, 13);
            this.lblDe.TabIndex = 6;
            this.lblDe.Text = "De";
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCadastro.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDtCadastro.Location = new System.Drawing.Point(17, 72);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(92, 13);
            this.lblDtCadastro.TabIndex = 5;
            this.lblDtCadastro.Text = "Data de cadastro:";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDtCadastro;
        private System.Windows.Forms.DateTimePicker dtTmPckrDtFim;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.DateTimePicker dtTmPckrDtIni;
        private System.Windows.Forms.Label lblDe;
        private TextButton txtFabricante;
        private System.Windows.Forms.Label LblDesc;
        private TextButton txtCodProd;
        private System.Windows.Forms.Label LblCodProd;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCodGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDesc;
    }
}