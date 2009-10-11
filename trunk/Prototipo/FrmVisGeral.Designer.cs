namespace Comercial
{
    partial class FrmVisGeral
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.grpBxFiltro = new System.Windows.Forms.GroupBox();
            this.rdBtnNome = new System.Windows.Forms.RadioButton();
            this.rdBtnCod = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPes = new System.Windows.Forms.Label();
            this.dtGrdVwVis = new System.Windows.Forms.DataGridView();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.grpBxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwVis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.grpBxFiltro);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.lblPes);
            this.groupBox1.Controls.Add(this.dtGrdVwVis);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 315);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar:";
            this.groupBox1.UseWaitCursor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.Image = global::Comercial.Properties.Resources.search1;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(347, 276);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(86, 33);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.UseWaitCursor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // grpBxFiltro
            // 
            this.grpBxFiltro.Controls.Add(this.rdBtnNome);
            this.grpBxFiltro.Controls.Add(this.rdBtnCod);
            this.grpBxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxFiltro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxFiltro.Location = new System.Drawing.Point(268, 23);
            this.grpBxFiltro.Name = "grpBxFiltro";
            this.grpBxFiltro.Size = new System.Drawing.Size(165, 44);
            this.grpBxFiltro.TabIndex = 13;
            this.grpBxFiltro.TabStop = false;
            this.grpBxFiltro.Text = "Filtro";
            this.grpBxFiltro.UseWaitCursor = true;
            // 
            // rdBtnNome
            // 
            this.rdBtnNome.AutoSize = true;
            this.rdBtnNome.Checked = true;
            this.rdBtnNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnNome.ForeColor = System.Drawing.Color.CadetBlue;
            this.rdBtnNome.Location = new System.Drawing.Point(18, 19);
            this.rdBtnNome.Name = "rdBtnNome";
            this.rdBtnNome.Size = new System.Drawing.Size(53, 17);
            this.rdBtnNome.TabIndex = 1;
            this.rdBtnNome.TabStop = true;
            this.rdBtnNome.Text = "Nome";
            this.rdBtnNome.UseVisualStyleBackColor = true;
            this.rdBtnNome.UseWaitCursor = true;
            // 
            // rdBtnCod
            // 
            this.rdBtnCod.AutoSize = true;
            this.rdBtnCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnCod.ForeColor = System.Drawing.Color.CadetBlue;
            this.rdBtnCod.Location = new System.Drawing.Point(91, 19);
            this.rdBtnCod.Name = "rdBtnCod";
            this.rdBtnCod.Size = new System.Drawing.Size(58, 17);
            this.rdBtnCod.TabIndex = 0;
            this.rdBtnCod.TabStop = true;
            this.rdBtnCod.Text = "Código";
            this.rdBtnCod.UseVisualStyleBackColor = true;
            this.rdBtnCod.UseWaitCursor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtPesquisar.Location = new System.Drawing.Point(11, 44);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(251, 20);
            this.txtPesquisar.TabIndex = 10;
            this.txtPesquisar.UseWaitCursor = true;
            // 
            // lblPes
            // 
            this.lblPes.AutoSize = true;
            this.lblPes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPes.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblPes.Location = new System.Drawing.Point(11, 23);
            this.lblPes.Name = "lblPes";
            this.lblPes.Size = new System.Drawing.Size(62, 13);
            this.lblPes.TabIndex = 12;
            this.lblPes.Text = "Pesquisar";
            this.lblPes.UseWaitCursor = true;
            // 
            // dtGrdVwVis
            // 
            this.dtGrdVwVis.AllowUserToAddRows = false;
            this.dtGrdVwVis.AllowUserToDeleteRows = false;
            this.dtGrdVwVis.AllowUserToOrderColumns = true;
            this.dtGrdVwVis.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtGrdVwVis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwVis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2});
            this.dtGrdVwVis.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dtGrdVwVis.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGrdVwVis.Location = new System.Drawing.Point(11, 83);
            this.dtGrdVwVis.MultiSelect = false;
            this.dtGrdVwVis.Name = "dtGrdVwVis";
            this.dtGrdVwVis.ReadOnly = true;
            this.dtGrdVwVis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwVis.ShowCellErrors = false;
            this.dtGrdVwVis.ShowCellToolTips = false;
            this.dtGrdVwVis.ShowEditingIcon = false;
            this.dtGrdVwVis.ShowRowErrors = false;
            this.dtGrdVwVis.Size = new System.Drawing.Size(422, 187);
            this.dtGrdVwVis.TabIndex = 11;
            this.dtGrdVwVis.UseWaitCursor = true;
            this.dtGrdVwVis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVwVis_CellDoubleClick);
            // 
            // col2
            // 
            this.col2.HeaderText = "col2";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            this.col2.Width = 260;
            // 
            // col1
            // 
            this.col1.HeaderText = "col1";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            // 
            // FrmVisGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(459, 338);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVisGeral";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Cadastro Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBxFiltro.ResumeLayout(false);
            this.grpBxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwVis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBxFiltro;
        private System.Windows.Forms.RadioButton rdBtnNome;
        private System.Windows.Forms.RadioButton rdBtnCod;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPes;
        private System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.DataGridView dtGrdVwVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
    }
}