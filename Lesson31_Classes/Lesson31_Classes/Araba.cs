using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson31_Classes
{
    class Araba: arabaBilgisi   //inheritance
    {
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;
        private int yil;         //Encaptulation
        private string marka;    //Encaptulation

        public int YIL           //Encaptulation
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }

        public string MARKASI   //Encaptulation
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }
    }
}
