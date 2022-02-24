using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8
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
            int kisaKenar, uzunKenar, dikdortgenAlan, dikdortgenCevre;

            kisaKenar = 10;
            uzunKenar = 20;

            dikdortgenAlan = kisaKenar * uzunKenar;

            dikdortgenCevre = (kisaKenar * 2) + (uzunKenar * 2);

            label1.Text = "Alanı: " + dikdortgenAlan + "  " + "Çevresi: " + dikdortgenCevre;



            int sinav1, sinav2, sinav3, ortalama;

            sinav1 = 79;
            sinav2 = 79;
            sinav3 = 86;

            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            label2.Text = "Ortalama: " + ortalama;

            // label2.Text = ortalama.ToString();   // OR ==   label2.Text = "Ortalama: " + ortalama; 


            // Herhangi bir metin kutusuna herhangi bir string ifadeyi yazdırırken
            // string bir ifade kullanılırsa .ToString() yapmamıza gerek kalmaz...
            // "Alan" gibi.

        }
    }
}
