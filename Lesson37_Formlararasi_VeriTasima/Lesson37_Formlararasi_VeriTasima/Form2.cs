using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string mesaj;
        public string kimden;
        public string uzayli;
        public string uzayli1;
        public string uzayli2;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = mesaj;
            label2.Text = kimden;
            comboBox1.Items.Add(uzayli);
            comboBox1.Items.Add(uzayli1);
            comboBox1.Items.Add(uzayli2);
        }
    }
}
