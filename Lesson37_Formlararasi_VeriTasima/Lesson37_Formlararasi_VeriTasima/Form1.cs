﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson37_Formlararasi_VeriTasima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.mesaj = textBox1.Text;
            frm.kimden = textBox2.Text;
            frm.uzayli = textBox3.Text;
            frm.uzayli1 = textBox4.Text;
            frm.uzayli2 = textBox5.Text;
            frm.Show();
            this.Hide();

            
        }
    }
}