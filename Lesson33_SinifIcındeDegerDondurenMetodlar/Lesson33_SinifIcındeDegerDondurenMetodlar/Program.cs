using System;

namespace Lesson33_SinifIcındeDegerDondurenMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Islem islem = new Islem();

            islem.topla(7,54);
            islem.topla(1453, 8);
            Console.WriteLine("\n\n");

            islem.kareAlan(8);
            islem.kareAlan(13);
            Console.WriteLine("\n\n");

            Kimlik kimlik = new Kimlik();
            kimlik.AD = "Serdar";
            kimlik.SOYAD = "Yurtseven";
            kimlik.MEMLEKET = "Trabzon";
            kimlik.CINSIYET = 'E';
            kimlik.YAS = 28;

            Console.WriteLine(kimlik.AD);
            Console.WriteLine(kimlik.SOYAD);
            Console.WriteLine(kimlik.MEMLEKET);
            Console.WriteLine(kimlik.YAS);
            Console.WriteLine(kimlik.CINSIYET);






            Console.WriteLine("\n\n");
            string _durum;
            Console.WriteLine("Evlilik Durumu: ");
            _durum = Console.ReadLine();

            string _ad;
            Console.WriteLine("Ad: ");
            _ad = Console.ReadLine();

            string _soyad;
            Console.WriteLine("Soyad: ");
            _soyad = Console.ReadLine();

            string _meslek;
            Console.WriteLine("Meslek: ");
            _meslek = Console.ReadLine();

            int _yas;
            Console.WriteLine("Yaşınız: ");
            _yas = Convert.ToInt32(Console.ReadLine());

            Ogrenci ogrenci = new Ogrenci(_durum, _ad, _soyad, _meslek, _yas);


            Console.WriteLine("\n\n");

            Console.WriteLine("işlem yapmak için birinci sayıyı giriniz.");
            int gSayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("işlem yapmak için ikinci sayıyı giriniz.");
            int gSayi2 = Convert.ToInt32(Console.ReadLine());


            Example4Islem example4Islem = new Example4Islem();

            example4Islem.topla(gSayi1, gSayi2);
            example4Islem.cikar(gSayi1, gSayi2);
            example4Islem.carp(gSayi1, gSayi2);
            example4Islem.bol(gSayi1, gSayi2);
            


        } 
    }
}
