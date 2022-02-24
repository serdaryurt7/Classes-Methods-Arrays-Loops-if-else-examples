using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson33_SinifIcındeDegerDondurenMetodlar
{
    class Islem
    {
        public int topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç: " + toplam);
            return toplam;
        }

        public int kareAlan(int kenar)
        {
            int sonuc = kenar * kenar;
            Console.WriteLine("Karenin Alanı: " + sonuc);
            return sonuc;
        }
    }
}
