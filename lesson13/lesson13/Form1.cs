using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int urunFiyati, yuzdeOnsekizKDV, yuzdeSekizKDV;
            string urunAdi = textBox1.Text;

            urunFiyati = Convert.ToInt32(textBox2.Text);

            yuzdeOnsekizKDV = ((urunFiyati * 18 / 100)+urunFiyati);

            yuzdeSekizKDV = ((urunFiyati * 8 / 100)+ urunFiyati);

            listBox1.Items.Add("Ürün Adı: " + urunAdi + "  " + "% 18 KDV Fiyatı: " + yuzdeOnsekizKDV + "  " + "% 8 KDV Fiyatı: " + yuzdeSekizKDV);
        }
    }
}
