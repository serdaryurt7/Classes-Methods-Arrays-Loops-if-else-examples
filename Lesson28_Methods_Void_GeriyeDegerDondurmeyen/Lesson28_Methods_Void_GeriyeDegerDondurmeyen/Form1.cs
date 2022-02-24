﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson28_Methods_Void_GeriyeDegerDondurmeyen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temizle()
        {
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");
            textBox4.Text = ("");
            textBox1.Focus();
        }

        void renklendir()  // Private tanımlanır önünde bir şey yoksa.
        {
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.BurlyWood;
            textBox3.BackColor = Color.GreenYellow;
            textBox4.BackColor = Color.Lavender;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }
    }
}
