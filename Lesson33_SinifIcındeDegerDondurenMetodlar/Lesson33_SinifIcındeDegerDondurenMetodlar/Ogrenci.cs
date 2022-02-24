using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson33_SinifIcındeDegerDondurenMetodlar
{
    class Ogrenci
    {
        public Ogrenci(string durum, string ad, string soyad, string meslek, int yas)   // ctor constractor method ile sınıf içerisinde bulunan nitelikleri
                           // çalıştırmak için metodla beraber o niteliği çağırmama gerek kalmıyor 
                           // nesnenin kendisini çağırdığımız anda bu değerler gelmiş oluyor.
        {
            Console.WriteLine("Evlilik Durumu: " + durum);
            Console.WriteLine("Adınız: " + ad);
            Console.WriteLine("Soyadınız: " + soyad);
            Console.WriteLine("Mesleğiniz: " + meslek);
            Console.WriteLine("Yaşınız: " + yas);
        }
   
    }
}
