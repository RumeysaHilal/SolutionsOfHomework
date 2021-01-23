using System;
using System.Collections.Generic;
using System.Text;


namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: " + musteri.Ad + "  " + musteri.Soyad+"\n");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: " + musteri.Ad + "  " + musteri.Soyad+"\n");
        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteriler :");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Ad Soyad: " + musteri.Ad + " " + musteri.Soyad + "  Id: " + musteri.Id);
            }
        }

    }
}
