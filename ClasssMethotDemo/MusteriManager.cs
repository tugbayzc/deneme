using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasssMethotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " Müşteri eklendi!");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Id);
            Console.WriteLine(musteri.Ad);
            Console.WriteLine(musteri.Soyad);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " Müşteri silindi!");
        }
    }
}
