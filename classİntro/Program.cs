using System;

namespace classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.MusteriAdi = "enes";
            kurs1.MusteriSoyadi = "kocalar";
            kurs1.MusteriYasi = 26;
            
            Kurs kurs2 = new Kurs();
            kurs2.MusteriAdi = "huriye";
            kurs2.MusteriSoyadi = "kocalar";
            kurs2.MusteriYasi = 50;
            
            Kurs kurs3 = new Kurs();
            kurs3.MusteriAdi = "halil";
            kurs3.MusteriSoyadi = "kocalar";
            kurs3.MusteriYasi = 30;
            //Console.WriteLine(kurs1.MusteriAdi + " " + kurs2.MusteriSoyadi);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (Kurs x in kurslar)
            {
                Console.WriteLine(x.MusteriAdi+" "+x.MusteriSoyadi+" "+x.MusteriYasi);
            }

        }
        
        
    }

    class Kurs
    {
        public string MusteriAdi{ get; set; }
        public string MusteriSoyadi { get; set; }
        public int MusteriYasi { get; set; }
    }

}
