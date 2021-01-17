using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Bircan";
            musteri1.MusteriSoyAdi = "Çiftçi";
            musteri1.KimlikNumarasi = "456897568923";
            musteri1.Yas = 22;
            musteri1.Adresi = "İstanbul";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Serhat";
            musteri2.MusteriSoyAdi = "Deveci";
            musteri2.KimlikNumarasi = "45689569923";
            musteri2.Yas = 23;
            musteri2.Adresi = "İstanbul";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Gülçin Yaren";
            musteri3.MusteriSoyAdi = "Derin";
            musteri3.KimlikNumarasi = "45689756756";
            musteri3.Yas = 26;
            musteri3.Adresi = "Ankara";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyAdi);
                Console.WriteLine(musteri.KimlikNumarasi);
                Console.WriteLine(musteri.Yas);
                Console.WriteLine(musteri.Adresi);
                Console.WriteLine("-----------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("---------------------");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);

            Console.WriteLine("---------------------");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
        }
    }
}
