using System;

namespace Lesson32_SinifIcındeDegerDondurmeyenMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Mesaj mesaj = new Mesaj();

            mesaj.Metin();
            Kisiler kisiler = new Kisiler();
            string ads;
            Console.WriteLine("İsim Giriniz: ");
            ads = Console.ReadLine();
            kisiler.KisiListesi(ads);

            Console.Read();
        }
    }
}
