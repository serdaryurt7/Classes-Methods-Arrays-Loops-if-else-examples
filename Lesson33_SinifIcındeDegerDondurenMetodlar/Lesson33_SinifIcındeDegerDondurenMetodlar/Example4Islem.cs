using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson33_SinifIcındeDegerDondurenMetodlar
{
    class Example4Islem
    {
        public int topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Sonuç: " + sonuc);
            return sonuc;
        }
        public int cikar(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Sonuç: " + sonuc);
            return sonuc;
        }
        public int carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Sonuç: " + sonuc);
            return sonuc;
        }
        public int bol(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            Console.WriteLine("Sonuç: " + sonuc);
            return sonuc;
        }
    }
}
