﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson30_Methods_KupHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Kup(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return sonuc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
             int s = Convert.ToInt32(textBox1.Text);
            label1.Text = Kup(s).ToString();
        }
    }
}
