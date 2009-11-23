namespace Comercial
{
    partial class FrmMinCon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMinCon));
            this.tbCntrlMinCon = new System.Windows.Forms.TabControl();
            this.tbPgResultado = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartHist = new AxOWC11.AxChartSpace();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Index1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartPrev = new AxOWC11.AxChartSpace();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.modeloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cOMERCIALDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.modeloTableAdapter();
            this.tbCntrlMinCon.SuspendLayout();
            this.tbPgResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHist)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrlMinCon
            // 
            this.tbCntrlMinCon.Controls.Add(this.tbPgResultado);
            this.tbCntrlMinCon.Controls.Add(this.tabPage1);
            this.tbCntrlMinCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlMinCon.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlMinCon.Name = "tbCntrlMinCon";
            this.tbCntrlMinCon.SelectedIndex = 0;
            this.tbCntrlMinCon.Size = new System.Drawing.Size(898, 497);
            this.tbCntrlMinCon.TabIndex = 0;
            // 
            // tbPgResultado
            // 
            this.tbPgResultado.AutoScroll = true;
            this.tbPgResultado.Controls.Add(this.dataGridView1);
            this.tbPgResultado.Controls.Add(this.panel1);
            this.tbPgResultado.Controls.Add(this.comboBox1);
            this.tbPgResultado.Controls.Add(this.label2);
            this.tbPgResultado.Location = new System.Drawing.Point(4, 22);
            this.tbPgResultado.Name = "tbPgResultado";
            this.tbPgResultado.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgResultado.Size = new System.Drawing.Size(890, 471);
            this.tbPgResultado.TabIndex = 1;
            this.tbPgResultado.Text = "Resultado";
            this.tbPgResultado.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Data,
            this.Valor});
            this.dataGridView1.Location = new System.Drawing.Point(18, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(866, 198);
            this.dataGridView1.TabIndex = 4;
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartHist);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(18, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 223);
            this.panel1.TabIndex = 3;
            // 
            // chartHist
            // 
            this.chartHist.DataSource = null;
            this.chartHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartHist.Enabled = true;
            this.chartHist.Location = new System.Drawing.Point(0, 0);
            this.chartHist.Name = "chartHist";
            this.chartHist.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("chartHist.OcxState")));
            this.chartHist.Size = new System.Drawing.Size(866, 223);
            this.chartHist.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            " "});
            this.comboBox1.Location = new System.Drawing.Point(87, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mineração";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(890, 471);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Previsão";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index1,
            this.Dt,
            this.Qtde});
            this.dataGridView2.Location = new System.Drawing.Point(13, 278);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(871, 187);
            this.dataGridView2.TabIndex = 9;
            // 
            // Index1
            // 
            this.Index1.HeaderText = "Index";
            this.Index1.Name = "Index1";
            this.Index1.ReadOnly = true;
            // 
            // Dt
            // 
            this.Dt.HeaderText = "Data";
            this.Dt.Name = "Dt";
            this.Dt.ReadOnly = true;
            // 
            // Qtde
            // 
            this.Qtde.HeaderText = "Valor";
            this.Qtde.Name = "Qtde";
            this.Qtde.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartPrev);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(13, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 240);
            this.panel2.TabIndex = 8;
            // 
            // chartPrev
            // 
            this.chartPrev.DataSource = null;
            this.chartPrev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPrev.Enabled = true;
            this.chartPrev.Location = new System.Drawing.Point(0, 0);
            this.chartPrev.Name = "chartPrev";
            this.chartPrev.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("chartPrev.OcxState")));
            this.chartPrev.Size = new System.Drawing.Size(871, 240);
            this.chartPrev.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(49, 6);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Step";
            // 
            // modeloBindingSource1
            // 
            this.modeloBindingSource1.DataMember = "modelo";
            this.modeloBindingSource1.DataSource = this.cOMERCIALDataSetBindingSource;
            // 
            // cOMERCIALDataSetBindingSource
            // 
            this.cOMERCIALDataSetBindingSource.DataSource = this.cOMERCIALDataSet;
            this.cOMERCIALDataSetBindingSource.Position = 0;
            // 
            // cOMERCIALDataSet
            // 
            this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
            this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataMember = "modelo";
            this.modeloBindingSource.DataSource = this.cOMERCIALDataSetBindingSource;
            // 
            // modeloTableAdapter
            // 
            this.modeloTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMinCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(914, 538);
            this.Controls.Add(this.tbCntrlMinCon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMinCon";
            this.ShowIcon = false;
            this.Text = "Consulta Data Mining";
            this.Load += new System.EventHandler(this.FrmMinCon_Load);
            this.Shown += new System.EventHandler(this.FrmMinCon_Shown);
            this.Leave += new System.EventHandler(this.FrmMinCon_Leave);
            this.tbCntrlMinCon.ResumeLayout(false);
            this.tbPgResultado.ResumeLayout(false);
            this.tbPgResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHist)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrlMinCon;
        private System.Windows.Forms.TabPage tbPgResultado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource cOMERCIALDataSetBindingSource;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.modeloTableAdapter modeloTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource modeloBindingSource1;
        private AxOWC11.AxChartSpace chartHist;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private AxOWC11.AxChartSpace chartPrev;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;

    }
}