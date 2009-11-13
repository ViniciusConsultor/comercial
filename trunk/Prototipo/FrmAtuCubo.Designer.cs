namespace Comercial
{
    partial class FrmAtuCubo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPgHistorico = new System.Windows.Forms.TabPage();
            this.dtgrdAtuCubo = new System.Windows.Forms.DataGridView();
            this.NrAtualiacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPgAtuCubo = new System.Windows.Forms.TabPage();
            this.grpBxStatus = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtuCubo = new System.Windows.Forms.Button();
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.tabControl1.SuspendLayout();
            this.tbPgHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdAtuCubo)).BeginInit();
            this.tbPgAtuCubo.SuspendLayout();
            this.grpBxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPgHistorico);
            this.tabControl1.Controls.Add(this.tbPgAtuCubo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 349);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPgHistorico
            // 
            this.tbPgHistorico.Controls.Add(this.dtgrdAtuCubo);
            this.tbPgHistorico.Location = new System.Drawing.Point(4, 22);
            this.tbPgHistorico.Name = "tbPgHistorico";
            this.tbPgHistorico.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgHistorico.Size = new System.Drawing.Size(547, 323);
            this.tbPgHistorico.TabIndex = 0;
            this.tbPgHistorico.Text = "Histórico de Atualizações";
            this.tbPgHistorico.UseVisualStyleBackColor = true;
            this.tbPgHistorico.Click += new System.EventHandler(this.tbPgHistorico_Click);
            // 
            // dtgrdAtuCubo
            // 
            this.dtgrdAtuCubo.AllowUserToDeleteRows = false;
            this.dtgrdAtuCubo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdAtuCubo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NrAtualiacao,
            this.Usuario,
            this.Data});
            this.dtgrdAtuCubo.Location = new System.Drawing.Point(7, 7);
            this.dtgrdAtuCubo.Name = "dtgrdAtuCubo";
            this.dtgrdAtuCubo.ReadOnly = true;
            this.dtgrdAtuCubo.Size = new System.Drawing.Size(534, 282);
            this.dtgrdAtuCubo.TabIndex = 0;
            // 
            // NrAtualiacao
            // 
            this.NrAtualiacao.DataPropertyName = "NRATUALIZACAO";
            this.NrAtualiacao.HeaderText = "N° Atualização";
            this.NrAtualiacao.Name = "NrAtualiacao";
            this.NrAtualiacao.ReadOnly = true;
            this.NrAtualiacao.Width = 125;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "USUARIO";
            this.Usuario.HeaderText = "Usuário";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "DATAATUALIZACAO";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // tbPgAtuCubo
            // 
            this.tbPgAtuCubo.Controls.Add(this.grpBxStatus);
            this.tbPgAtuCubo.Controls.Add(this.btnAtuCubo);
            this.tbPgAtuCubo.Location = new System.Drawing.Point(4, 22);
            this.tbPgAtuCubo.Name = "tbPgAtuCubo";
            this.tbPgAtuCubo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgAtuCubo.Size = new System.Drawing.Size(547, 323);
            this.tbPgAtuCubo.TabIndex = 1;
            this.tbPgAtuCubo.Text = "Atualizar Cubo";
            this.tbPgAtuCubo.UseVisualStyleBackColor = true;
            // 
            // grpBxStatus
            // 
            this.grpBxStatus.Controls.Add(this.pictureBox1);
            this.grpBxStatus.Controls.Add(this.pictureBox2);
            this.grpBxStatus.Controls.Add(this.label2);
            this.grpBxStatus.Controls.Add(this.label1);
            this.grpBxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxStatus.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxStatus.Location = new System.Drawing.Point(98, 76);
            this.grpBxStatus.Name = "grpBxStatus";
            this.grpBxStatus.Size = new System.Drawing.Size(350, 181);
            this.grpBxStatus.TabIndex = 1;
            this.grpBxStatus.TabStop = false;
            this.grpBxStatus.Text = "Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Comercial.Properties.Resources.certo;
            this.pictureBox1.Location = new System.Drawing.Point(40, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Comercial.Properties.Resources.certo;
            this.pictureBox2.Location = new System.Drawing.Point(40, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cubo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dimensões";
            // 
            // btnAtuCubo
            // 
            this.btnAtuCubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtuCubo.Location = new System.Drawing.Point(168, 30);
            this.btnAtuCubo.Name = "btnAtuCubo";
            this.btnAtuCubo.Size = new System.Drawing.Size(210, 23);
            this.btnAtuCubo.TabIndex = 0;
            this.btnAtuCubo.Text = "Atualizar Cubo";
            this.btnAtuCubo.UseVisualStyleBackColor = true;
            this.btnAtuCubo.Click += new System.EventHandler(this.btnAtuCubo_Click);
            // 
            // cOMERCIALDataSet
            // 
            this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
            this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmAtuCubo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 374);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmAtuCubo";
            this.Text = "FrmatuCubo";
            this.Load += new System.EventHandler(this.FrmatuCubo_Load);
            this.Leave += new System.EventHandler(this.FrmAtuCubo_Leave);
            this.tabControl1.ResumeLayout(false);
            this.tbPgHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdAtuCubo)).EndInit();
            this.tbPgAtuCubo.ResumeLayout(false);
            this.grpBxStatus.ResumeLayout(false);
            this.grpBxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPgHistorico;
        private System.Windows.Forms.TabPage tbPgAtuCubo;
        private System.Windows.Forms.DataGridView dtgrdAtuCubo;
        private System.Windows.Forms.Button btnAtuCubo;
        private System.Windows.Forms.GroupBox grpBxStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrAtualiacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
    }
}