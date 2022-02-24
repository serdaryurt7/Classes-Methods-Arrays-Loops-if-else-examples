using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mevsime_Gore_Mevsim_Aylari_Getirme_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mevsim = textBox1.Text;
            switch (mevsim)
            {
                case "yaz": label2.Text = "Haziran Temmuz Ağustos"; break;
                case "kış": label2.Text = "Aralık Ocak Şubat"; break;
                case "sonbahar": label2.Text = "Eylül Ekim Kasım"; break;
                case "ilkbahar": label2.Text = "Mart Nisan Mayıs"; break;
                default: label2.Text = "Yanlış Değer Girdiniz."; break;
            }
        }
    }
}
