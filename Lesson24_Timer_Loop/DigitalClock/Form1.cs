using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hours = 0;
        int minute = 0;
        int second = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            label1.Text = second.ToString();
            if (second == 60)
            {
                minute++;
                label2.Text = minute.ToString();
                second = 00;
                if (minute == 60)
                {
                    hours++;
                    label3.Text = hours.ToString();
                    minute = 00;
                    if (hours == 24)
                    {
                        hours = 00;
                    }
                }
            }

        }
    }
}
