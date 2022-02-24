using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson35_RandomKomutu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sayi1, sayi2, sayi3;

            sayi1 = random.Next(1, 5);   // 1 dahil 5 dahil değil !
            sayi2 = random.Next(1, 5);
            sayi3 = random.Next(1, 5);

            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();

        }
    }
}
