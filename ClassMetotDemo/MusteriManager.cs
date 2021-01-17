using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Ekleme Başarılı");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Liste");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silme Başarılı");
        }
    }
}
