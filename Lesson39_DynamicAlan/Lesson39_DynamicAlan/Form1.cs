using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson39_DynamicAlan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            Point buttonkonum = new Point(20,10);
            button.Location = buttonkonum;
            button.Name = "Button1";
            button.Text = "Tıkla";
            button.BackColor = Color.BlueViolet;
            button.Height = 50;
            button.Width = 75;
            this.Controls.Add(button);

            Label label = new Label();
            Point labelkonum = new Point(250,25);

            label.Location = labelkonum;
            label.Name = "Label1";
            label.Text = "Merhaba";
            label.BackColor = Color.Yellow;
            this.Controls.Add(label);
            label.AutoSize = true;

            

            for (int i = 0; i < 10; i++)
            {
                TextBox textBox = new TextBox();
                Point txtkonum = new Point(350, i*30);
                textBox.Location = txtkonum;
                textBox.Name = "Textbox" + i;
                textBox.Text = i.ToString();
                this.Controls.Add(textBox);
            }
        }
    }
}
