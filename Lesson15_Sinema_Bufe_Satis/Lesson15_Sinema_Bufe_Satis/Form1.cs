using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson15_Sinema_Bufe_Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasaTutar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;

            misir = Convert.ToInt32(TxtMisir.Text);
            bilet = Convert.ToInt32(TxtBilet.Text);
            cay = Convert.ToInt32(TxtCay.Text);
            su = Convert.ToInt32(TxtSu.Text);

            toplam = misir * 10 + bilet * 25 + cay * 3 + su * 2;

            LblToplam.Text = toplam.ToString() + " TL";

            kasaTutar = kasaTutar + toplam;
            LblKasa.Text = kasaTutar.ToString() + " TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            TxtCay.Text = "";
            TxtSu.Text = "";
            TxtMisir.Text = "";
            LblToplam.Text = "00 TL";
            LblKasa.Text = "00 TL";

            TxtMisir.Focus();
        }
    }
}
