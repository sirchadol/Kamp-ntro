using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "bilgisayar kursu";
            string kurs2 = "binicilik kursu";
            string kurs3 = "java";
            string[] kurslar = new string[] { "bilgisayar kursu", "binicilik kursu", "java" };
            




            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            foreach (string komut1 in kurslar)
            {
                Console.WriteLine(komut1);

            }
        }
    }
}
