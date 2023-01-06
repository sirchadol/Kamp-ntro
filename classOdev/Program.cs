using System;

namespace classOdev
{
    class Product
    {
        public string productName { get; set; }
        public double productPoint { get; set; }
        public int productViewer { get; set; }
        public double productPrice { get; set; }
        public string productCurrency { get; set; }
    
    
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productName = "Razer 1800 Kulaklık";
            product1.productPoint = 4.1;
            product1.productPrice = 25;
            product1.productViewer = 3500;
            product1.productCurrency = "TL";
            Product product2 = new Product();
            product2.productName = "Razer 2300 Mouse";
            product2.productPoint = 3.2;
            product2.productPrice = 79;
            product2.productViewer = 1500;
            product2.productCurrency = "TL";
            Product product3 = new Product();
            product3.productName = "Steel Series Monitör";
            product3.productPoint = 4.8;
            product3.productPrice = 109;
            product3.productViewer = 500;
            product3.productCurrency = "TL";


            Product[] urunler = new Product[] { product1, product2, product3 };
            foreach (Product komut1 in urunler)
            {
                Console.WriteLine(komut1.productName + " " + komut1.productPoint + " " + komut1.productPrice +komut1.productCurrency+ " " + komut1.productViewer);
            }
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].productName+" "+urunler[i].productPoint+" "+urunler[i].productPrice+urunler[i].productCurrency+" "+urunler[i].productViewer);
            }

        }
    }

}
