using Metods;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amassya  Elması";
            Urun urun2 = new Urun();
            urun2.Adi = "KArpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Adana Karpuzu";

            Urun []urunler = new Urun[] {urun1,urun2 };
            foreach (Urun komut1 in urunler)
            {
                Console.WriteLine(komut1.Adi);
                Console.WriteLine(komut1.Fiyati);
                Console.WriteLine(komut1.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("--------Metodlar----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);



        
        }

    }
}
