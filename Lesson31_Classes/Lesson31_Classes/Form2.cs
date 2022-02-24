using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson31_Classes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba araba2 = new Araba();

            araba2.renk = "Yeşil";
            araba2.durum = 'i';
            araba2.fiyat = 35000;
            araba2.hiz = 140;
            araba2.motor = 1220.36;

            label1.Text = araba2.renk;
            label2.Text = araba2.durum.ToString();
            label3.Text = araba2.fiyat.ToString();
            label4.Text = araba2.hiz.ToString();
            label5.Text = araba2.motor.ToString();

            pictureBox1.BackColor = Color.LightSeaGreen;
        }
    }
}
