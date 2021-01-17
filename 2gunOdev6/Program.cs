using System;

namespace _2gunOdev6
{
    class Urun
    {
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklamasi { get; set; }
        public string Resmi { get; set; }

    }




    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "A ürünü";
            urun1.Fiyati = 25.25;
            urun1.Aciklamasi = "Açıklama A";
            urun1.Resmi = "A Resmi";

            Urun urun2 = new Urun();
            urun2.Adi = "B ürünü";
            urun2.Fiyati = 45.45;
            urun2.Aciklamasi = "Açıklama B";
            urun2.Resmi = "B Resmi";

            Urun urun3 = new Urun();
            urun3.Adi = "C ürünü";
            urun3.Fiyati = 30.55;
            urun3.Aciklamasi = "Açıklama C";
            urun3.Resmi = "C Resmi";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            Console.WriteLine("--foreach döngüsü--");
            foreach (Urun urunun in urunler)
            {
                Console.WriteLine(urunun.Adi);
                Console.WriteLine(urunun.Fiyati);
                Console.WriteLine(urunun.Aciklamasi);
                Console.WriteLine(urunun.Resmi);
            }

            Console.WriteLine("--for döngüsü--");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].Adi);
                Console.WriteLine(urunler[i].Fiyati);
                Console.WriteLine(urunler[i].Aciklamasi);
                Console.WriteLine(urunler[i].Resmi);
            }

            Console.WriteLine("--while döngüsü--");
            int a = 0;
            while (a<urunler.Length)
            {
                Console.WriteLine(urunler[a].Adi);
                Console.WriteLine(urunler[a].Fiyati);
                Console.WriteLine(urunler[a].Aciklamasi);
                Console.WriteLine(urunler[a].Resmi);
                a++;
            }

        }
    }
}
