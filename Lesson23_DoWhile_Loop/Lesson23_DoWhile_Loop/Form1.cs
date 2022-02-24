using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson23_DoWhile_Loop
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
            do   // şart sağlanmasa bile en az bir kere çalıştırır Do While 
                // while ile do while arasındaki fark +1 fazla
            {
                listBox1.Items.Add("HelloWorld!");
                i++;
            }
            while (i<=10);
        }
    }
}
