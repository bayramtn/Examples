using System;

namespace WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 den 10  sıralı yazdırma

            //int a = 1;
            //while (a<=10)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}


            //Girilen iki sayı arasındaki sayıları teker teker yazdırma

            //int IlkSayi, IkinciSayi;
            //Console.WriteLine("1.sayıyı giriniz");
            //IlkSayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayıyı giriniz");
            //IkinciSayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("1.sayı ve 2.sayı arasındaki sayılar");
            //while (IlkSayi<IkinciSayi-1)
            //{
            //    IlkSayi++;
            //    Console.WriteLine(IlkSayi);
            //    
            //}


            // 1 ile 100 arasındaki 3 ün katlarını yazdırma
            int a = 1;
            while (a<=100)
            {
                if (a%3==0)
                {
                    Console.WriteLine(a);
                }
                a++;
            }




        }
    }
}
