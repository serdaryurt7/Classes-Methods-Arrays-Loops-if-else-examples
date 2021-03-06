using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleCaptcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g", "h", "i" };
            string[] sembol2 = { "^", "+", "%", "&", "/", "(", ")", "]", "{", "}" };
            string[] sembol5 = { "A", "B", "C", "D", "F", "G" };

            int s1, s2, s3, s4, s5;

            s1 = random.Next(0, sembol1.Length);
            s2 = random.Next(0, sembol2.Length);
            s3 = random.Next(0, 10);
            s4 = random.Next(0, 3);
            s5 = random.Next(0, sembol5.Length);

            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString() + s4.ToString() + sembol5[s5].ToString();
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Hide();
            
        }
    }
}
