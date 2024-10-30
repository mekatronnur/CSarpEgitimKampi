using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler

            #region For Döngüsü

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 3; i < 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("lÜTFEN EKRANA YAZILMASINI İSTEDİĞNİZ ADEDİ yazınız");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yazılım");
            //}
            #endregion

            #region  For Döngüsü İle Karar Yapıları

            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 0; i < 25; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //       totalValue += i;

            //    }

            //}
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {

            //        Console.WriteLine(i);
            //        count++;


            //    }
            //}

            //---------------------------------------------
            //int bacterium = 1;
            //for (int i = 1; i < 24; i++)
            //{
            //    bacterium *= 2;

            //    Console.WriteLine((i+ ".Saat Sonunda:" +bacterium));
            //}

            //----------------------------------------------------


            #endregion

            #region While Döngüsü

            //While
            //int i = 1;

            //while (i<=10)
            //{
            //    Console.WriteLine("bU BİR WHİLE DÖGÜSÜDÜR");
            //    i++;
            //    ;
            //}

            //int i = 1;
            //int toplam=0;
            //while (i <= 10)
            //{
            //    if(i % 3==0)
            //    {
            //        toplam +=i ;

            //    }
            //    i++;
            //}
            //Console.WriteLine(toplam);
            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen üç basamaklı sayının basamakları toplamını hesaplayan kodu yazınız

            Console.WriteLine("Üç basamaklı bir sayı girin:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi >= 100 && sayi <= 999)
            {
                int birler = sayi % 10;
                int onlar = (sayi / 10) % 10;
                int yüzler = sayi / 100;

                int toplam = birler + onlar + yüzler;
                Console.WriteLine($"Basamakların toplamı: {toplam}");
            }
            else
            {
                Console.WriteLine("Lütfen üç basamaklı bir sayı girin.");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
