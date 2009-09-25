using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comercial
{
    public partial class TextButton : UserControl
    {


        public event EventHandler ButtonClick;

        public Image Image
        {
            get
            {

                return button1.Image;
            }

            set
            {
                button1.Image = value;

            }
        }

        public string getText
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        public bool ShowButton
        {
            get
            {
                return button1.Visible;
            }
            set
            {
                button1.Visible = value;
                TextButton_Resize(null, null);
            }
        }

        public TextButton()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            ShowButton = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            ShowButton = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClick(this, null);
        }

        private void TextButton_Resize(object sender, EventArgs e)
        {

            if (ShowButton)
            {
                button1.Left = this.Width - button1.Width;
                textBox1.Width = button1.Left - 3;

            }
            else
            {
                textBox1.Width = this.Width - 3;

            }
            if (this.Height != 25)
            {
                this.Height = 25;
            }
            
        }

        private void TextButton_Load(object sender, EventArgs e)
        {

        }
    }
}
