﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtalamaHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3, ortalama;

            sinav1 = Convert.ToInt32(textBox1.Text);
            sinav2 = Convert.ToInt32(textBox2.Text);
            sinav3 = Convert.ToInt32(textBox3.Text);

            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            
            label4.Text = "Ortalamanız : " + ortalama;
        }
    }
}
