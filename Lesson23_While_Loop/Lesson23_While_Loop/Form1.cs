using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson23_While_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while(i<=5)
            {
                listBox1.Items.Add("Hello Developer");
                listBox2.Items.Add(i);
                i++;  // i değerini arttırmazsak sonsuz döngüye girer.
            }

            int j = 1;
            int toplam = 0;

            while(j<=10)
            {      
                toplam += j;
                j++;        
            }
            MessageBox.Show(toplam.ToString());
        }
    }
}
