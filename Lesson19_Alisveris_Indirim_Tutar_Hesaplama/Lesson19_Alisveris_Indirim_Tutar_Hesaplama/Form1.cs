﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson19_Alisveris_Indirim_Tutar_Hesaplama
{
    public partial class Form1 : Form
    {

        // 0-20 ==> %20
        // 21-40 ==> %40
        // 41 ++ ==> %50
        // kitabın tanesi = 8 TL.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;
            kitapadet = Convert.ToInt32(textBox1.Text);

            if (kitapadet >= 0 && kitapadet <= 20)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.20);  // % 20 indirim.
                label3.Text = toplam + "TL";
            }

            if (kitapadet >= 21 && kitapadet <= 40)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.40);  // % 40 indirim.
                label3.Text = toplam + "TL";
            }

            if (kitapadet >= 41)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.50);  // % 50 indirim.
                label3.Text = toplam + "TL";
            }

        }
    }
}