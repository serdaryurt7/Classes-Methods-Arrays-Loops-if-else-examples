using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson33_SinifIcındeDegerDondurenMetodlar
{
    class Kimlik
    {
        string ad, soyad, memleket;
        int yas;
        char cinsiyet;

        public string AD { get { return ad; } set { ad = value.ToLower(); } }    // prop

        public string SOYAD { get { return soyad; } set { soyad = value.ToUpper(); } }

        public string MEMLEKET { get { return memleket; } set { memleket = value; } }

        public int YAS { get { return yas; } set { yas = Math.Abs(value); } }  // sayının mutlak değerini döndürür.

        public char CINSIYET { get { return cinsiyet; } set {cinsiyet = value; } }

        public Kimlik()
        {
            ad = "Null";                 // Ekrana Değer girilmediğinde kabul edilen parametreler.
            soyad = "Null";             // Ekrana Değer girilmediğinde kabul edilen parametreler.
            yas = 18;                  // Ekrana Değer girilmediğinde kabul edilen parametreler.
            cinsiyet = 'E';           // Ekrana Değer girilmediğinde kabul edilen parametreler.
            memleket = "İstanbul";   // Ekrana Değer girilmediğinde kabul edilen parametreler.

        }

    }
}
