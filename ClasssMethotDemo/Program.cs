using System;

namespace ClasssMethotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            {
                musteri1.Id = 1;
                musteri1.Ad = "Tuğba";
                musteri1.Soyad = "Yazıcı";
            }
            Musteri musteri2 = new Musteri();
            {
                musteri2.Id = 2;
                musteri2.Ad = "Emel";
                musteri2.Soyad = "Yazıcı";
            }
            Musteri musteri3 = new Musteri();
            {
                musteri3.Id = 3;
                musteri3.Ad = "Tuncel";
                musteri3.Soyad = "Yazıcı";
            }

            Musteri[] musteriler = new Musteri[3] { musteri1, musteri2, musteri3 };
            MusteriManager musteriIslem = new MusteriManager();
            
            Console.WriteLine("--ekle--");
            musteriIslem.Ekle(musteri1);
            
            Console.WriteLine("--listele--");
            musteriIslem.Listele(musteri2);
            
            Console.WriteLine("--sil--");
            musteriIslem.Sil(musteri3);
        }
    }
}
