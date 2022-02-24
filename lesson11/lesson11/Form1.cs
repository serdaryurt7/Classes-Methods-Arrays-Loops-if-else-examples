using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Double değeri kod kısmından girerken NOKTA ile kullanılır.
            // Klavyeden girerken VİRGÜL ile ayrılır.

            double s1, s2, s3, average;

            s1 = 89;
            s2 = 91;
            s3 = 76;

            average = (s1 + s2 + s3) / 3;

            label1.Text = average.ToString("0.00");  // Bunu yaptığımızda virgülden sonra 2 basamağı görürüz.

            //double number = Convert.ToDouble(textBox1.Text);

            //label1.Text = number.ToString("0.00");
        }
    }
}
