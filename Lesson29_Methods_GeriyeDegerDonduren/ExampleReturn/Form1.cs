using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleReturn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int carp(int sayi1, int sayi2, int sayi3)
        {
            int carpim = sayi1 * sayi2 * sayi3;
            return carpim;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = carp(6,1,4).ToString();
        }
    }
}
