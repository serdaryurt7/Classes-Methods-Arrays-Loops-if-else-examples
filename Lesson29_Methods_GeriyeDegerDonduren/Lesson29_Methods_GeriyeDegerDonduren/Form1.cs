using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson29_Methods_GeriyeDegerDonduren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Toplam(int s1, int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Toplam(53,8).ToString();
            label2.Text = Toplam(1453, 8).ToString();
            label3.Text = Toplam(1959, 8).ToString();
        }
    }
}
