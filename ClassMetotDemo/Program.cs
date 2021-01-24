using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Beyza";
            musteri1.SoyAd = "Baş";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Samet";
            musteri2.SoyAd = "Çavur";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Musa";
            musteri3.SoyAd = "Balın";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad = "Sidal";
            musteri4.SoyAd = "Çakıl";


            Musteri[] musteris = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteriler in musteris)
            {
                Console.WriteLine("Müşteri numarası :"+ musteriler.Id);
                Console.WriteLine("Müşteri adı :" + musteriler.Ad);
                Console.WriteLine("Müşteri soyadı :" + musteriler.SoyAd);
                Console.WriteLine("-----------------------------------");

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add();
            musteriManager.Delete();
            musteriManager.List();

            



        }
    }
}
