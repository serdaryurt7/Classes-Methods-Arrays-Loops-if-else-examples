using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dort_Islem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int topla, cikart, carp, bol, sayi1, sayi2;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            topla = sayi1 + sayi2;
            cikart = sayi1 - sayi2;
            bol = sayi1 / sayi2;
            carp = sayi1 * sayi2;

            listBox1.Items.Add("Toplam : " + topla + " " + "Çıkart : " + cikart + " " + "Bölme : " + " " + bol + "Çarpma : " + carp);
        }
    }
}
