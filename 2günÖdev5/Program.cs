using System;

namespace _2günÖdev5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ekrana girilen sayının tek mi çift mi olduğunu bulan kodu yazınız

            double sayi1;
            Console.WriteLine("bir sayı giriniz");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(sayi1 % 2==0? "çift sayı": "tek sayı");
            Console.ReadKey();

           


       
        }
    }
}
