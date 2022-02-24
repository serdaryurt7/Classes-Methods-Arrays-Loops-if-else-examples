using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForeachExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 10 elemanlı bir dizide 4 e bölünen sayıları listeleyin.
        // Bu dizide 4 e bölünebilen kaç tane sayı olduğunu listeleyin.
        // 4 e tam bölünen sayıların toplamını hesaplayıp label a yazdır.  

        private void button1_Click(object sender, EventArgs e)
        {
            //int toplam = 0;
            //int ortalama = 0;
            //int[] sayilar = { 12, 67, 57, 24, 36, 45, 78, 34, 44, 56 };

            //foreach(int sayi in sayilar)
            //{
            //    if (sayi % 4 == 0)
            //    {
            //        listBox1.Items.Add(sayi);
            //        toplam += sayi;
            //        ortalama = toplam / sayilar.Length;
            //    }
            //}
            //label1.Text = toplam.ToString();           
            //label2.Text = ortalama.ToString();
            int toplam = 0, toplamBolunen = 0;
            int[] sayilar = { 12, 67, 57, 24, 36, 45, 78, 34, 44, 56 };

            foreach (int sayi in sayilar)
            {
                if (sayi % 4 == 0)
                {
                    listBox1.Items.Add(sayi.ToString());
                    toplam += sayi;
                    toplamBolunen++;
                }
            }
            label1.Text = toplam.ToString();
            label2.Text = (toplam / toplamBolunen).ToString();
        }
    }
}
