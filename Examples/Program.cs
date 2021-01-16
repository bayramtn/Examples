using System;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ternary Operator
            double dolarDun = 7.50;
            double dolarBugun = 7.40;
            bool sonuc1 = dolarBugun > dolarDun ? true : false;
            Console.WriteLine(sonuc1 ? "Artış var": "Artış yok" );

            string kullaniciDurumu = "Giriş yapmadı";
            string sonuc2 = kullaniciDurumu;
            Console.WriteLine(sonuc2 == kullaniciDurumu  ? "Giriş yapınız": "Hoşgeldiniz");

            int girilenSayi = 54;
            Console.WriteLine(girilenSayi % 2 == 0 ? "Sayı Çiftir" : "Sayı Tektir") ;

            int a = 3;
            int b = 2;
            int sonuc3 = a % b;
            //Console.WriteLine(sonuc3);
            //a = a + 1;
            //a++;
            //int c = a++; //suffix
            //Console.WriteLine(a); //4
            //Console.WriteLine(c); //3
            //int d = ++b; //prefix
            //Console.WriteLine(b); //3
            //Console.WriteLine(d); //3
            //bool durum = a < b;
            //Console.WriteLine(durum); //false
            bool durum = a != b; // a b den farklı mıdır?
            Console.WriteLine(durum); //true

            //double e = 88;
            //double f = 2;
            //double g = e / f;
            //Console.WriteLine(g);
            //Console.WriteLine(g is double? "çift" : "tek"); //çift
            //bool h = a is int; // a int midir?
            //Console.WriteLine(h);
            object obj = "merhaba";
            Console.WriteLine(obj);
            string str = obj as string;
            bool durum1 = str is string;
            Console.WriteLine(durum1);
            //mantıksal operatörler bool ile çalışır
            // && || !
            bool m1 = true;
            bool m2 = false;
            bool m3 = m1 && m2; //m1 ve m2 yani true ve false
            //Console.WriteLine(m3); //biri false oldugu için sanuc false
            bool m4 = m1 || m2; //veya  or biri true ise sonuc true
            //Console.WriteLine(m4); //biri true oldugu için sonuc true
            bool m5 = !m1;
            Console.WriteLine("m1:"+m1);
            Console.WriteLine("m5:"+m5);
            int x = 5;
            x = x + 1;
            Console.WriteLine("x:"+x); //6
            x ++;
            Console.WriteLine("x:" + x); //7
            //x = x + 3;
            x += 3; // x i 3 arttır
            Console.WriteLine("x:"+x); // x:10
            x *= 10; //x i 10 ile çarp
            Console.WriteLine("x:"+x); //x:100
            int sayi = 3;
            string s = (sayi % 2 == 0) ? "çift" : "tek";
            Console.WriteLine(s);










        }
    }
}
