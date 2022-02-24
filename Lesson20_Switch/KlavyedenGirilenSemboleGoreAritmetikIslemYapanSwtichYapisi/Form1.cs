using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlavyedenGirilenSemboleGoreAritmetikIslemYapanSwtichYapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 30, sayi2 = 10;

            string operators = textBox1.Text;

            switch (operators)
            {
                case "+": label2.Text = "Sonuç: " + (sayi1 + sayi2); break;
                case "-": label2.Text = "Sonuç: " + (sayi1 - sayi2); break;
                case "*": label2.Text = "Sonuç: " + (sayi1 * sayi2); break;
                case "/": label2.Text = "Sonuç: " + (sayi1 / sayi2); break;
                default: label2.Text = "Geçersiz Parametre"; break;
            }
        }
    }
}
