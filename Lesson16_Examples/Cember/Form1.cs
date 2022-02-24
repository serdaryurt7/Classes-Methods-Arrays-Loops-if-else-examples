using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cember
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r, alan, cevre;

            const double pi = 3.14159;

            r = Convert.ToDouble(textBox1.Text);

            alan = pi * r * r;

            cevre = 2 * pi * r;

            label2.Text = "Alan : " + alan.ToString() + " " + "Çevre : " + cevre;

        }
    }
}
