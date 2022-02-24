using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLamb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        int sayac;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 1)
            {
                this.BackColor = Color.Red;
            }
            if (sayac == 20)
            {
                this.BackColor = Color.Green;
            }
            if (sayac == 40)
            {
                this.BackColor = Color.Yellow;
            }
            if (sayac == 60)
            {
                sayac = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
