using System;

namespace switchcaseyapisi
{
    class Program
    {
        static void Main(string[] args)
        {

            // int ilksayi = 20;
            //switch (ilksayi)
            //{
            //    case 10:
            //        Console.WriteLine("girilen sayı:"+ilksayi);
            //        break;
            //    default:
            //        Console.WriteLine("girilen sayı bulunamadı");
            //        break;
            //}




            //string plaka;
            //Console.WriteLine("plaka kodu giriniz");
            //plaka = Console.ReadLine();
            //switch (plaka)
            //{
            //    case "34":
            //        Console.WriteLine("istanbul:"+plaka);
            //        break;
            //    case "52":
            //        Console.WriteLine("ordu:"+plaka);
            //        break;
            //    case "61":
            //        Console.WriteLine("trabzon:"+plaka);
            //        break;
            //    default:
            //        Console.WriteLine(plaka+" hakkında bilgi yok");
            //        break;
            //}
            //Console.ReadKey();

            //double ilkSayi;
            //double ikinciSayi;
            //Console.WriteLine("ilk sayıyı giriniz");
            //ilkSayi =  Convert.ToDouble( Console.ReadLine());
            //Console.WriteLine("ikinci sayıyı giriniz");
            //ikinciSayi =Convert.ToDouble( Console.ReadLine());
            //double s = ilkSayi + ikinciSayi;
            //Console.WriteLine("toplamları:"+s);
            //Console.ReadKey();


            double ilkSayi, ikinciSayi, Sonuc,ekran;
            Console.WriteLine("bir sayı giriniz");
            ilkSayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz");
            ikinciSayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("toplama işlemi için 1 , çıkarma işlemi için 2");
            Sonuc = Convert.ToDouble(Console.ReadLine());
            switch (Sonuc)
            {
                case 1:
                    ekran = ilkSayi + ikinciSayi;
                    Console.WriteLine("toplamları:"+ekran);
                    break;
                case 2:
                    ekran = ilkSayi - ikinciSayi;
                    Console.WriteLine("farkları:" + ekran);
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem");
                    break;
            }
            Console.ReadKey();

        }
    }
}
