using System;
using System.Collections.Generic;

namespace ClassMetotDemo
    {
        class Program
        {
            static void Main(string[] args)
            {
                Musteri musteri1 = new Musteri();
                musteri1.Ad = "Hilal";
                musteri1.Soyad = "Sevinç";
                musteri1.Id = 1;
                musteri1.Tcno = "1111111111";

                Musteri musteri2 = new Musteri();
                musteri2.Ad = "Rümeysa";
                musteri2.Soyad = "Sevinç";
                musteri2.Id = 2;
                musteri2.Tcno = "12222222222";

                Musteri musteri3 = new Musteri();
                musteri3.Ad = "Rümeysa Hilal";
                musteri3.Soyad = "Sevinç";
                musteri3.Id = 3;
                musteri3.Tcno = "133333333333";

                Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
                MusteriManager manager = new MusteriManager();
                manager.Ekle(musteri1);
                manager.Sil(musteri2);
                manager.Listele(musteriler);
            }
        }
    }
