using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları
            //    Console.WriteLine("Hello World");

            //    Console.WriteLine("good Morning");

            //    //

            //    Console.WriteLine("*****Yemek Kategorileri ******");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Çorbalar");
            //    Console.WriteLine("2-Ana Yemekler");
            //    Console.WriteLine("3-Soğuk Başlangıçlar");
            //    Console.WriteLine("4-Salatalar");
            //    Console.WriteLine("5-Tatlılar");
            //    Console.WriteLine("6-İçecekler");
            //    Console.WriteLine();
            //    Console.WriteLine("*****Yemek Kategorileri ******");
            #endregion


            #region Değişkenler

            //string

            //string name;

            //name = "merve";

            //Console.WriteLine("Müşteri Adı: "+ name);

            //string customerName;
            //string customerSurname;
            //string customerPhone ;
            //string customerEmail ,district, city;

            //Console.WriteLine("Lütfen bir isim giriniz?");
            //customerName = Console.ReadLine();
            //Console.WriteLine("Lütfen bir soyisim giriniz?");
            //customerSurname = Console.ReadLine();
            ////camelCase!!!!!!
            //Console.WriteLine("Lütfen bir tel no giriniz?");
            //customerPhone = Console.ReadLine();
            //Console.WriteLine("Lütfen bir Email giriniz?");
            //customerEmail = Console.ReadLine();
            //Console.WriteLine("Lütfen bir cadde giriniz?");
            //district = Console.ReadLine();
            //Console.WriteLine("Lütfen bir şehir giriniz?");
            //city = Console.ReadLine();

            //Console.WriteLine("***** Kullanıcı Bilgileri *****");
            //Console.WriteLine();
            //Console.WriteLine("Adı ve Soyadı: " + customerName + " " + customerSurname);

            //Console.WriteLine("Telefon No: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Cadde: " + district);
            //Console.WriteLine("Şehir: " + city);
            //Console.WriteLine();
            //Console.WriteLine("***** Kullanıcı Bilgileri *****");
            #endregion


            #region int değişkenler

            //int

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int LemondPrice = 30;
            int number;
            int number2;
            string approval;
            int add;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("1-----Hamburger: " + hamburgerPrice);
            Console.WriteLine("2-----Kola: " + cokePrice);
            Console.WriteLine("3-----Su: " + waterPrice);
            Console.WriteLine("4-----Kızartma: " + friesPrice);
            Console.WriteLine("5-----Pizza: " + pizzaPrice);
            Console.WriteLine("6-----Limonata: " + LemondPrice);

            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine("Yiyeceklerden hangisini tercih edersiniz? Lütfen numara söyleyiniz");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İçeceklerden hangisini tercih edersiniz? Lütfen numara söyleyiniz");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Patates Kızartması isterminiz? Lütfen numara söyleyiniz");
            approval = Console.ReadLine();

            if (number == 1 && number2 == 2 && approval == "evet")
            {
                Console.WriteLine("Hamburger ve Kola Tolplam Fiyat:" + (hamburgerPrice + cokePrice + friesPrice));
            }
            else if (number == 1 && number2 == 3 && approval == "evet")
            {
                Console.WriteLine("Hamburger ve Su Tolplam Fiyat:" + (hamburgerPrice + waterPrice + friesPrice));
            }
            else if (number == 1 && number2 == 6 && approval == "evet")
            {
                Console.WriteLine("Hamburger ve Limonata Tolplam Fiyat:" + (hamburgerPrice + LemondPrice + friesPrice));
            }
            else if (number == 1 && number2 == 6 && approval == "hayır")
            {
                Console.WriteLine("Hamburger ve Limonata Tolplam Fiyat:" + (hamburgerPrice + LemondPrice));
            }
            else if (number == 1 && number2 == 3 && approval == "hayır")
            {
                Console.WriteLine("Hamburger ve Su Tolplam Fiyat:" + (hamburgerPrice + waterPrice));
            }
            else if (number == 1 && number2 == 2 && approval == "hayır")
            {
                Console.WriteLine("Hamburger ve Kola Tolplam Fiyat:" + (hamburgerPrice + cokePrice));
            }
            #endregion


            Console.Read();
        }
    }
}
