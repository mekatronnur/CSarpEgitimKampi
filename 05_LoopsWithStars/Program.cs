using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 tane yıldız oluşturma

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana yıldız oluşturma

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");
            //}



            #endregion

            #region Her satırda 10 tane yıldız olsun

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik Üçgen
            //Console.WriteLine("Dik üçgenin yüksekliğini girin:");
            //int height = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= height; i++) // Yüksekliğe göre satır sayısı
            //{
            //    for (int j = 1; j <= i; j++) // Her satırda yıldız sayısı
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(); // Satır sonu
            //}


            #endregion

            #region Ters  dik üçgen

            Console.WriteLine("Ters dik üçgenin yüksekliğini girin:");
            int yukseklik = Convert.ToInt32(Console.ReadLine());

            for (int i = yukseklik; i >= 1; i--) // Yüksekliğe göre satır sayısı
            {
                for (int j = 1; j <= i; j++) // Her satırda yıldız sayısı
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // Satır sonu
            }

            #endregion

            #region Elmas Uygulaması
            Console.WriteLine("Elmasın yarı yüksekliğini girin:");
            int yarıYükseklik = Convert.ToInt32(Console.ReadLine());

            // Üst üçgen
            for (int i = 1; i <= yarıYükseklik; i++)
            {
                for (int j = yarıYükseklik; j > i; j--)
                {
                    Console.Write(" "); // Boşluk
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*"); // Yıldız
                }
                Console.WriteLine();
            }

            // Alt üçgen
            for (int i = yarıYükseklik - 1; i >= 1; i--)
            {
                for (int j = yarıYükseklik; j > i; j--)
                {
                    Console.Write(" "); // Boşluk
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*"); // Yıldız
                }
                Console.WriteLine();
            }


            #endregion

            Console.ReadLine();
        }
    }
}
