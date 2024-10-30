using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //Foreach 4 tane parametre alan bir dögüdür
            /*
             1:Değişken Türü
             2:Değişken Adı
             3:In
             4:Liste,Koleksiyon,Dizi
             */
            ////string[] cities = { "Kayseri", "Sivas", "Sinop", "Kırşehir" };
            ////foreach (string city in cities)
            ////{
            ////    Console.WriteLine(city);
            ////}


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach (int i in numbers) { 
            //Console.WriteLine(i);

            //}
            #endregion


            #region Dögüdeki Çift Sayılar
            ////int[] array = { 2, 345, 234, 12, 147, 35, 43, 23, 65, 874, 44323, 3553 };
            ////foreach (int i in array) {

            ////    if (i % 2 == 0)
            ////    {
            ////        Console.WriteLine(i);
            ////    }
            ////}

            #endregion

            #region Dögüdeki toplama İşlemi
            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int sum = 0;
            //foreach (int i in ints)
            //{

            //    if (i % 3 == 0)
            //    {
            //        sum += i;

            //    }




            //}
            //Console.WriteLine("3 ÜN Katları toplamı:" + sum);
            #endregion

            #region Liste Yöntemi
            //List<int> list = new List<int>()
            //{
            //    1,4,5,6,3,7,10

            //};
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Parçalama
            //string word = "Kayseri";
            //foreach (char s in word)
            //{

            //    Console.WriteLine(s);
            //}
            #endregion


            Console.ReadLine();
        }
    }
}
