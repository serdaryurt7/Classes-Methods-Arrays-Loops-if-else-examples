using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirilenSayininFaktoriyeliniAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int faktoriyel = 1;
            int sayi = int.Parse(textBox1.Text);

            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel* i;
            }

            listBox1.Items.Add(faktoriyel);
        }
    }
}
