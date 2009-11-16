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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cOMERCIALDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.modeloTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axChartSpace1 = new AxOWC11.AxChartSpace();
            this.axChartSpace2 = new AxOWC11.AxChartSpace();
            this.tbCntrlMinCon.SuspendLayout();
            this.tbPgResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axChartSpace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axChartSpace2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrlMinCon
            // 
            this.tbCntrlMinCon.Controls.Add(this.tbPgResultado);
            this.tbCntrlMinCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlMinCon.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlMinCon.Name = "tbCntrlMinCon";
            this.tbCntrlMinCon.SelectedIndex = 0;
            this.tbCntrlMinCon.Size = new System.Drawing.Size(1068, 706);
            this.tbCntrlMinCon.TabIndex = 0;
            // 
            // tbPgResultado
            // 
            this.tbPgResultado.Controls.Add(this.panel1);
            this.tbPgResultado.Controls.Add(this.comboBox1);
            this.tbPgResultado.Controls.Add(this.label2);
            this.tbPgResultado.Location = new System.Drawing.Point(4, 22);
            this.tbPgResultado.Name = "tbPgResultado";
            this.tbPgResultado.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgResultado.Size = new System.Drawing.Size(1060, 680);
            this.tbPgResultado.TabIndex = 1;
            this.tbPgResultado.Text = "Resultado";
            this.tbPgResultado.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.modeloBindingSource;
            this.comboBox1.DisplayMember = "estrutura";
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "estrutura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mineração";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.axChartSpace2);
            this.panel1.Controls.Add(this.axChartSpace1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(18, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 626);
            this.panel1.TabIndex = 3;
            // 
            // axChartSpace1
            // 
            this.axChartSpace1.DataSource = null;
            this.axChartSpace1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axChartSpace1.Enabled = true;
            this.axChartSpace1.Location = new System.Drawing.Point(0, 0);
            this.axChartSpace1.Name = "axChartSpace1";
            this.axChartSpace1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axChartSpace1.OcxState")));
            this.axChartSpace1.Size = new System.Drawing.Size(1021, 292);
            this.axChartSpace1.TabIndex = 1;
            // 
            // axChartSpace2
            // 
            this.axChartSpace2.DataSource = null;
            this.axChartSpace2.Dock = System.Windows.Forms.DockStyle.Top;
            this.axChartSpace2.Enabled = true;
            this.axChartSpace2.Location = new System.Drawing.Point(0, 292);
            this.axChartSpace2.Name = "axChartSpace2";
            this.axChartSpace2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axChartSpace2.OcxState")));
            this.axChartSpace2.Size = new System.Drawing.Size(1021, 292);
            this.axChartSpace2.TabIndex = 2;
            // 
            // FrmMinCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1118, 730);
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
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axChartSpace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axChartSpace2)).EndInit();
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
        private AxOWC11.AxChartSpace axChartSpace2;
        private AxOWC11.AxChartSpace axChartSpace1;

    }
}