﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Önce textboxtan girilen değeri labelda yazdırma.

            char ders;

            ders = Convert.ToChar(textBox1.Text);

            label1.Text = ders.ToString();
        }
    }
}
