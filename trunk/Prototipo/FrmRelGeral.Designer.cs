namespace Comercial
{
    partial class FrmRelGeral
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
            this.crstlRprtVwrRel = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crstlRprtVwrRel
            // 
            this.crstlRprtVwrRel.ActiveViewIndex = -1;
            this.crstlRprtVwrRel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crstlRprtVwrRel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crstlRprtVwrRel.Location = new System.Drawing.Point(0, 0);
            this.crstlRprtVwrRel.Name = "crstlRprtVwrRel";
            this.crstlRprtVwrRel.SelectionFormula = "";
            this.crstlRprtVwrRel.Size = new System.Drawing.Size(465, 389);
            this.crstlRprtVwrRel.TabIndex = 0;
            this.crstlRprtVwrRel.ViewTimeSelectionFormula = "";
            // 
            // FrmRelGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(465, 389);
            this.Controls.Add(this.crstlRprtVwrRel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelGeral";
            this.ShowIcon = false;
            this.Text = "FrmRelGeral";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelGeral_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crstlRprtVwrRel;
    }
}