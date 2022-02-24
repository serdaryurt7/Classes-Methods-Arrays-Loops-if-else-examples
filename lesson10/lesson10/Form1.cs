using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, topla, carp, cikar, bol;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            topla = sayi1 + sayi2;
            carp = sayi1 * sayi2;
            cikar = sayi1 - sayi2;
            bol = sayi1 / sayi2;   // birbirine bölünmeyecek 2 sayı olursa int'da ondalıklı kısmı almaz mesela 16/10  = 1 olur.

            MessageBox.Show("Toplam: " + topla + "\n" + "Çarpım: " + carp + " \n" + "Çıkarma: " + cikar + " \n " + "Bölüm: " + bol);
        }
    }
}
