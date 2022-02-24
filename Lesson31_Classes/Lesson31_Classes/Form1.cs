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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba araba = new Araba(); 

            araba.renk = "Mavi";
            araba.durum = 's';
            araba.fiyat = 50000;
            araba.hiz = 160;
            araba.motor = 1245.56;
            araba.YIL = -2016;                      //Encaptulation
            araba.MARKASI = "Golf";                 //Encaptulation

            araba.muayene = 2017;                   //inheritance
            araba.plaka = "34 TS 1967";             //inheritance
            araba.sahip = "Salih Yurtseven";        //inheritance


            label1.Text = araba.renk;
            label2.Text = araba.durum.ToString();
            label3.Text = araba.fiyat.ToString();
            label4.Text = araba.hiz.ToString();
            label5.Text = araba.motor.ToString();
            label6.Text = araba.YIL.ToString();     //Encaptulation
            label7.Text = araba.MARKASI;            //Encaptulation

            label8.Text = araba.muayene.ToString();     //inheritance
            label9.Text = araba.plaka;                  //inheritance
            label10.Text = araba.sahip;                 //inheritance
            pictureBox1.BackColor = Color.CadetBlue;
        }
    }
}
