using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson18_Ogrenci_Sinav_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, sinav3, ortalama;
            string durum;

            sinav1 = Convert.ToDouble(textBox1.Text);
            sinav2 = Convert.ToDouble(textBox2.Text);
            sinav3 = Convert.ToDouble(textBox3.Text);

            ortalama = (sinav1 + sinav2 + sinav3) / 3;

            if(ortalama>=50)
            {
                durum = "Geçti";
            }

            else
            {
                durum = "Kaldı";
            }

            textBox4.Text = ortalama.ToString("0.00") + " / " + durum;
        }
    }
}
