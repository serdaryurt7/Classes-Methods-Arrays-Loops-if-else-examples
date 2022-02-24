using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson26_Arrays_Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  string[] kisiler = {"Ali","Bilgin", "Ceylan", "Derya", "Efe", "Ferit", "Gülnihal"};
            //  label1.Text = kisiler[7];

            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7};
            // label1.Text = sayilar[3].ToString();

            double[] sayilar = { 1.23, 2.32, 3.14, 4.5, 5.6 };
            label1.Text = sayilar[4].ToString();
        }
    }
}
