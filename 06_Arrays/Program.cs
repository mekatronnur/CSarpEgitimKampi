using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2,4,6,8
            //sarı ,kırmızı,mavi,turuncu, beyaz
            //Değişken Türü [] Dizi Adı =new Değişken Türü[Eleman Sayısı]
            //string[] colors = new string[4];

            //colors[0] = "KIrmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Turuncu";
            //colors[3] = "Pembe";



            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Kayseri";
            //cities[1] = "Nevşehir";
            //cities[2] = "Sinop";
            //cities[3] = "Kırşehir";

            //Console.WriteLine(cities[3]);

            ////string[] cities = { "C#", "Pyhton", "Java", "C++" };

            //Console.WriteLine(cities[0]);

            #endregion

            #region Dizideki Tüm elemanları Listelemenmesi

            //string [] colors = { "Sarı", "Kırmızı", "Beyaz", "Siyah" };
            //for (int i = 0; i < cities.Length; i++) 
            //    {
            //      Console.WriteLine(colors[i]);
            //    }

            ////int[] number = { 6, 34, 32, 2, 12, 21, 4562, 23, 23, 1, 3, 564, 32, 345, 56, 54, 35 };

            ////for (int i = 0; i < number.Length; i++)
            ////{
            ////    {
            ////        if (number[i] % 3 == 0)
            ////        {
            ////            Console.WriteLine(number[i]);
            ////        }

            ////    }
            #endregion

            #region Hangisi Büyük
            ////   int[] myArray = { 45, 34, 54, 2, 31, 567, 23, 46, 123 };

            ////   int maxNumber=myArray[0];

            //// for(int i = 0; i < myArray.Length; i++) 
            ////       {
            ////       if(myArray[i] > maxNumber)
            ////       {
            ////           maxNumber = myArray[i];
            ////       }
            ////       }
            ////Console.WriteLine(maxNumber);
            #endregion

            #region Arrays.Short

            //int[] number = { 1, 5, 434, 23, 32, 12, 13, 4, 7, 90, 56, 78 };
            //Array.Sort(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}
            Console.WriteLine();
            #endregion

            #region Arrays.Reserve

            ////int[] number = { 1, 5, 434, 23, 32, 12, 13, 4, 7, 90, 56, 78 };
            ////Array.Reverse(number);
            ////for (int i = 0; i < number.Length; i++) 
            ////{

            ////    Console.WriteLine(number[i]);
            ////}

            #endregion

            #region IndexOf Methodu

            //string[] name= { "nursel", "fatma", "merve", "nisa", "esma" };
            //int index = Array.IndexOf(name, "esma");
            //Console.WriteLine(index);

            #endregion

            #region Max ve min Methodu
            //int[] numbers = { 1, 5, 56, 455, 221, 43, 23, 21 };

            //Console.WriteLine("Dizinin En büyük Elemanı: " + numbers.Max() + "  Dizinin en küçük elemanı:" + numbers.Min());
            #endregion

            #region Dizi oluşturup toplama
            ////int sum = 0;
            ////int[] numbers = new int[4];
            ////for (int i = 0; i < numbers.Length; i++)
            ////{
            ////    Console.WriteLine($"Lütfen dizinin {i + 1}. elemanını giriniz");
            ////    numbers[i] = int.Parse(Console.ReadLine());


            ////}
            ////for (int i = 0; i < numbers.Length; i++) 
            ////{
            ////    Console.WriteLine(numbers[i]);
            ////    sum += numbers[i];

            ////}
            ////Console.WriteLine("TOplam:" + sum);
            #endregion

            #region Tek Çİft Sayılar
            //int[] ints = new int[4];

            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen diziniin {i + 1}. terimini yazınız");
            //    ints[i] = int.Parse(Console.ReadLine());

            //}

            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] % 2 == 0)
            //    {
            //        Console.WriteLine(ints[i]);
            //    }
            //}

            #endregion


            Console.ReadLine();
        }
    }
}

