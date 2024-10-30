using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double değişkeni

            //double number;
            //number = 4.45;

            //Console.WriteLine(number);

            //double orangePrice;

            //double applePrice;

            //double bananaPrice;

            //double cheryPrice;


            //Console.WriteLine("Portakal fiyatını öğrenebilir miyim?");

            //orangePrice = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Elma fiyatını öğrenebilir miyim?");
            //applePrice = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Muz fiyatını öğrenebilir miyim?");
            //bananaPrice = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Kiraz fiyatını öğrenebilir miyim?");
            //cheryPrice = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("***** Fiyat  Listesi *****");
            //Console.WriteLine();
            //Console.WriteLine("Portakal: " + orangePrice);
            //Console.WriteLine("Elma: " + applePrice);
            //Console.WriteLine("Muz: " + bananaPrice);
            //Console.WriteLine("Kiraz: " + cheryPrice);


            //Console.WriteLine("3 kilo portakal ,4 kilo elma 2 kilo muz 2 kio da kiraz fiyatı ne kadar?");
            //Console.WriteLine("Toplam fiyat:" + (orangePrice * 3 + applePrice * 4 + bananaPrice * 2 + cheryPrice * 2));


            #endregion


            #region Char Değişkenleri
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden veri girişleri
            //Console.WriteLine("***** CSharp Hava Yolları Bilgisi *****");

            //string passengerName;
            //string passengerSurname;
            //string passengerDistrict;
            //string passengerCountry;
            //string passengerAge;
            //string passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Semt:");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Ülke:");
            //passengerCountry = Console.ReadLine();
            //Console.Write("Tc Kimlik No:");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.Write("Yaş:");
            //passengerAge = Console.ReadLine();

            //Console.WriteLine("**********************************************");

            //Console.WriteLine();
            //Console.WriteLine("Yolcunun Adı Soyadı:" + passengerName + " " +passengerSurname);
            //Console.WriteLine("Semti:" +passengerDistrict);
            //Console.WriteLine("Ülke:" + passengerCountry);
            //Console.WriteLine("TC Kimlik No:"+ passengerIdentityNumber);
            //Console.WriteLine("Yaş:"+ passengerAge);

            //Console.WriteLine("************ İYİ YOLCULULUKLAR DİLERİZ **************");
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 200;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.WriteLine("Lütfen aldığınız ayskkabı sayısını giriniz.");
            //shoesCount= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Aldığım Ayakkabı Sayısı " +  shoesCount + " adet");
            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz");
            //computerCount=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Aldığım Ayakkabı Sayısı " + computerCount + " adet");
            //Console.WriteLine("Lütfen aldığınız sandalye saysını giriniz");
            //chairCount= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Aldığım Ayakkabı Sayısı " + chairCount + " adet");
            //Console.WriteLine("Lütfen aldığınız tv sayısını giriniz");
            //tvCount= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Aldığım Ayakkabı Sayısı " + tvCount + " adet");

            //Console.WriteLine("Ödeyeceğiniz toplam tutar:" + ((shoesCount* shoesPrice) +(computerCount*computerPrice)+ (chairCount*chairPrice)+(tvPrice* tvCount)));

            #endregion

            #region Klaveden ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;
            //Console.WriteLine(" Lütfen birinci sınav notunu giriniz");
            //exam1 =double.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sınav notunu girniz");
            //exam2 =double.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen üçüncü sınav notunu giriniz");
            //exam3 =double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav Sonucunuz:"+ result);
            //if (result >= 50)
            //{
            //    Console.WriteLine("Tebrikler sınavı geçtiniz!!!!!");

            //}
            //else
            //{

            //        Console.WriteLine("Sınavdan Kaldınız daha sıkı çalışmalısınız");


            //}
            #endregion


            #region Klavyeden Karakter girişleri
            //char gender;
            //Console.WriteLine("Lütfen cinsiyet giriniz");
            //gender=char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğniz Cinsiyet: " + gender);

            #endregion



            Console.ReadLine();

        }
    }
}
