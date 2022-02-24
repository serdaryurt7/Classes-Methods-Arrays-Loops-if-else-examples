using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            KisiBilgisi kisiBilgisi = new KisiBilgisi();
            string ad, soyad, meslek;
            int yas;

            Console.WriteLine("İsim Giriniz.");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadı Giriniz.");
            soyad = Console.ReadLine();
            Console.WriteLine("Yaşınız.");
            yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mesleğiniz.");
            meslek = Console.ReadLine();



            kisiBilgisi.kisiVerisiMethodu(ad, soyad, yas, meslek); // Methodu çağırdık ve yazdırdık.
        }
    }
}
