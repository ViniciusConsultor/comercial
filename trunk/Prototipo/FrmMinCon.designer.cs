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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.modeloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cOMERCIALDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.modeloTableAdapter();
            this.chartHist = new AxOWC11.AxChartSpace();
            this.chartPrev = new AxOWC11.AxChartSpace();
            this.tbCntrlMinCon.SuspendLayout();
            this.tbPgResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrev)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrlMinCon
            // 
            this.tbCntrlMinCon.Controls.Add(this.tbPgResultado);
            this.tbCntrlMinCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlMinCon.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlMinCon.Name = "tbCntrlMinCon";
            this.tbCntrlMinCon.SelectedIndex = 0;
            this.tbCntrlMinCon.Size = new System.Drawing.Size(898, 666);
            this.tbCntrlMinCon.TabIndex = 0;
            // 
            // tbPgResultado
            // 
            this.tbPgResultado.AutoScroll = true;
            this.tbPgResultado.Controls.Add(this.numericUpDown1);
            this.tbPgResultado.Controls.Add(this.label1);
            this.tbPgResultado.Controls.Add(this.panel1);
            this.tbPgResultado.Controls.Add(this.comboBox1);
            this.tbPgResultado.Controls.Add(this.label2);
            this.tbPgResultado.Location = new System.Drawing.Point(4, 22);
            this.tbPgResultado.Name = "tbPgResultado";
            this.tbPgResultado.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgResultado.Size = new System.Drawing.Size(890, 640);
            this.tbPgResultado.TabIndex = 1;
            this.tbPgResultado.Text = "Resultado";
            this.tbPgResultado.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(386, 11);
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
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(347, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Step";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartPrev);
            this.panel1.Controls.Add(this.chartHist);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(18, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 596);
            this.panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.modeloBindingSource1;
            this.comboBox1.DisplayMember = "estrutura";
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "estrutura";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
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
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataMember = "modelo";
            this.modeloBindingSource.DataSource = this.cOMERCIALDataSetBindingSource;
            // 
            // modeloTableAdapter
            // 
            this.modeloTableAdapter.ClearBeforeFill = true;
            // 
            // chartHist
            // 
            this.chartHist.DataSource = null;
            this.chartHist.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartHist.Enabled = true;
            this.chartHist.Location = new System.Drawing.Point(0, 0);
            this.chartHist.Name = "chartHist";
            this.chartHist.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("chartHist.OcxState")));
            this.chartHist.Size = new System.Drawing.Size(866, 271);
            this.chartHist.TabIndex = 0;
            // 
            // chartPrev
            // 
            this.chartPrev.DataSource = null;
            this.chartPrev.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartPrev.Enabled = true;
            this.chartPrev.Location = new System.Drawing.Point(0, 271);
            this.chartPrev.Name = "chartPrev";
            this.chartPrev.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("chartPrev.OcxState")));
            this.chartPrev.Size = new System.Drawing.Size(866, 322);
            this.chartPrev.TabIndex = 1;
            // 
            // FrmMinCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(914, 730);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrev)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private AxOWC11.AxChartSpace chartHist;
        private AxOWC11.AxChartSpace chartPrev;

    }
}