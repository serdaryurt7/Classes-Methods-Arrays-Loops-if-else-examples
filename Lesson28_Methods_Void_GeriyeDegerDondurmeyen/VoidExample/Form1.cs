using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoidExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yaz()
        {
            textBox1.Text = "Serdar";
            textBox2.Text = "Yurtseven";
            textBox3.Text = "Trabzonspor";
            textBox4.Text = "Bilgisayar Mühendisi";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yaz();
        }
    }
}
