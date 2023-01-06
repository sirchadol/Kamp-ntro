using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);
            int ogrenciSayisi = 3200;
            double faizOrani = 3.2;
            bool SistemeGirisYapmismi = false;
            double dolarDun = 18.44;
            double DolarBugun = 18.44;

            if (dolarDun>DolarBugun)
            {
                Console.WriteLine("azalısoku");
            }
            else if (dolarDun<DolarBugun)
            {
                Console.WriteLine("artısoku");
            }
            else
            {
                Console.WriteLine("esittir butonu");
            }
            if (SistemeGirisYapmismi == true)
            {
                Console.WriteLine("Ayarlar Butonu");

            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


         
            
            
            
            
            
   
        }
    }
}
