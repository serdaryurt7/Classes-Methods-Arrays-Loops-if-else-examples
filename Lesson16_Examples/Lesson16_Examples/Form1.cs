using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson16_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisaKenar, uzunKenar, alan, cevre;

            kisaKenar = Convert.ToInt32(textBox1.Text);
            uzunKenar = Convert.ToInt32(textBox2.Text);

            alan = kisaKenar * uzunKenar;
            cevre = 2 * kisaKenar + 2 * uzunKenar;

            label4.Text ="Alan : " + alan.ToString() + " " + "Çevre : " + cevre.ToString();
        }
    }
}
