namespace Comercial
{
    partial class FrmConMin
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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("001 - xxx");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("002 - yyy");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("003 - zzz");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Produto", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("01 - Carlos");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("02 - Mario");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Cliente", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("123456 - xx/xx/xxxx");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("654321 - xx/xx/xxxx");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Pedido", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(154, 75);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "+\n-\n>\n<\n=\n>=\n<=\ne\nou\n<>\ndepende de";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operadores";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(188, 30);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(349, 303);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Campos";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(12, 131);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(154, 202);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "Data\nCount(produto)\nproduto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registros";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(558, 30);
            this.treeView1.Name = "treeView1";
            treeNode11.Name = "Node3";
            treeNode11.Text = "001 - xxx";
            treeNode12.Name = "Node4";
            treeNode12.Text = "002 - yyy";
            treeNode13.Name = "Node5";
            treeNode13.Text = "003 - zzz";
            treeNode14.Name = "Node0";
            treeNode14.Text = "Produto";
            treeNode15.Name = "Node8";
            treeNode15.Text = "01 - Carlos";
            treeNode16.Name = "Node9";
            treeNode16.Text = "02 - Mario";
            treeNode17.Name = "Node1";
            treeNode17.Text = "Cliente";
            treeNode18.Name = "Node10";
            treeNode18.Text = "123456 - xx/xx/xxxx";
            treeNode19.Name = "Node11";
            treeNode19.Text = "654321 - xx/xx/xxxx";
            treeNode20.Name = "Node2";
            treeNode20.Text = "Pedido";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode17,
            treeNode20});
            this.treeView1.Size = new System.Drawing.Size(174, 303);
            this.treeView1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Consulta";
            // 
            // FrmConMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 349);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConMin";
            this.ShowIcon = false;
            this.Text = "FrmConMin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label4;
    }
}