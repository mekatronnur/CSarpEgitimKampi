using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.WriteLine("Lütfen Şifreyi Giriniz:");

            //string password;

            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}
            //*********************************************

            //string capital, country;

            //Console.WriteLine("Lütfen bir başkent giriniz:");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülke giriniz:");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("VERİLER DOĞRU");
            //}
            //else
            //{
            //    Console.WriteLine("veriler hatalı!!!!");
            //}
            //***************************************************

            //Console.WriteLine("*****Öğrenci Karnesi*****");
            //Console.WriteLine();
            //Console.WriteLine("Lütfen öğrencinin adını giriniz");
            //string name;
            //name = Console.ReadLine();
            //Console.WriteLine("Lütfen öğrencinin soyadını giriniz");
            //string surname;
            //surname= Console.ReadLine();
            //Console.WriteLine("Lütfen öğrencinin numarasını giriniz");
            //string number;
            //number= Console.ReadLine();

            //int exam1, exam2, exam3, avarage;

            //Console.WriteLine("Lütfen öğrencinin birinci sınav notunu giriniz");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen öğrencinin ikinci sınav notunu giriniz");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen öğrencinin üçüncü sınav notunu giriniz");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;



            //if (avarage>0 & avarage<25)

            //{
            //    Console.WriteLine("Sınavdan Kaldınız");
            //    Console.WriteLine("Harf Notunuz: FF");
            //}
            //else if (avarage > 25 & avarage < 50)
            //{
            //    Console.WriteLine("Sınavdan Kaldınız");
            //    Console.WriteLine("Harf Notunuz: DD");
            //}
            //else if (avarage >50 & avarage < 75)
            //{
            //    Console.WriteLine("Sınavdan Geçtiniz");
            //    Console.WriteLine("Harf Notunuz: CC");
            //}
            //else if (avarage > 75 & avarage <= 100)
            //{
            //    Console.WriteLine("Sınavdan Başarıyla Geçtiniz");
            //    Console.WriteLine("Harf Notunuz: AA");
            //}

            //Console.WriteLine("***** Sonuç Ekranı ******");
            //Console.WriteLine("Öğrencinin Adı Soyadı:" +name +" " +surname);
            //Console.WriteLine("Öğrencinin Numarası:" + number);
            //Console.WriteLine("Öğrencinin Birinci Sınav Notu: " + exam1);
            //Console.WriteLine("Öğrencinin İkinci Sınav Notu: " + exam2);
            //Console.WriteLine("Öğrencinin Üçüncü Sınav Notu: " + exam3);
            //Console.WriteLine("Öğrencinin Sınav Ortalaması: " + avarage);
            //if (avarage > 0 & avarage < 25)

            //{
            //    Console.WriteLine("Sınavdan Kaldınız");
            //    Console.WriteLine("Harf Notunuz: FF");
            //}
            //else if (avarage > 25 & avarage < 50)
            //{
            //    Console.WriteLine("Sınavdan Kaldınız");
            //    Console.WriteLine("Harf Notunuz: DD");
            //}
            //else if (avarage > 50 & avarage < 75)
            //{
            //    Console.WriteLine("Sınavdan Geçtiniz");
            //    Console.WriteLine("Harf Notunuz: CC");
            //}
            //else if (avarage > 75 & avarage <= 100)
            //{
            //    Console.WriteLine("Sınavdan Başarıyla Geçtiniz");
            //    Console.WriteLine("Harf Notunuz: AA");
            //}
            //*******************************************************************


            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 34;

            //int result = number % 5;
            //Console.WriteLine(result);

            int number1;

            //Console.WriteLine("Lütfen Bir Sayı girinz");
            //number1 = int.Parse(Console.ReadLine());

            //if(number1 % 2==0)
            //{
            //    Console.WriteLine("Bu sayı bir çift sayıdır");
            //}
            //else
            //{
            //    Console.WriteLine("Bu sayı çift sayı değildir");
            //}

            #endregion

            #region Char İle karar değişkeni

            //char team;
            //Console.WriteLine("Lütfen bir harf giriniz");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("GALATASARAY!!!!!!!");
            //}
            //if (team == 'k' | team == 'K')
            //{
            //    Console.WriteLine("KAYSERİSPOR!!!!!!!");
            //}



            #endregion

            #region Menü Seçimi

            //Console.WriteLine("***** Menü Kategori Listesi *****");
            //Console.WriteLine("1-Başlangıçlar");
            //Console.WriteLine("2-Makarnalar");
            //Console.WriteLine("3-Ana Yemekler");
            //Console.WriteLine("4-Tatlılar");


            //Console.WriteLine("lÜTFEN BİR SEÇİM YAPINIZ");
            //Console.WriteLine();
            //int selection;
            //selection = int.Parse(Console.ReadLine());
            //Console.WriteLine("Yaptığınız Seçim: " + selection);
            //if (selection == 1)
            //{
            //    Console.WriteLine("--------- BAŞLANGIÇLAR -----------");

            //    Console.WriteLine();
            //    Console.WriteLine("Moules Mariniere");
            //    Console.WriteLine("Kurutulmuş Boşnak Eti");
            //    Console.WriteLine("Foie Gras");
            //}
            //if (selection == 2)
            //{
            //    Console.WriteLine("--------- MAKARNALAR -----------");

            //    Console.WriteLine();
            //    Console.WriteLine("Hot Tempura Seraser Roll");
            //    Console.WriteLine("Crispy Roll");
            //    Console.WriteLine("Salmon Nigiri");
            //}
            //if (selection == 3)
            //{
            //    Console.WriteLine("--------- ANA YEMEKLER -----------");

            //    Console.WriteLine();
            //    Console.WriteLine("Kebab-ı Seraser");
            //    Console.WriteLine("Fırınlanmış Akdeniz Gridası");
            //    Console.WriteLine("Bonfser");
            //}
            //if (selection == 4)
            //{
            //    Console.WriteLine("--------- TATLILAR -----------");

            //    Console.WriteLine();
            //    Console.WriteLine("Modern Baklava");
            //    Console.WriteLine("Tarte Tatin");
            //    Console.WriteLine("Trio Dondurma Tabağı");
            //}

            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen Ay Girişi Yapınız");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //   default: Console.WriteLine("Hatalı Veri Griişi");break;
            //}

            #endregion

            #region Hesap Makinası

            //Console.WriteLine("İlk sayıyı giriniz..");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz..");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Toplama işlemi için 1'e \n" +
            //                  "Çıkartma işlemi için 2'ye \n" +
            //                  "Çarpma işlemi için 3'e \n" +
            //                  "Bölme işlemi için 4'e basınız..");

            //int islem = Convert.ToInt32(Console.ReadLine());

            //int c;

            //switch (islem)
            //{
            //    case 1:
            //        c = a + b;
            //        Console.WriteLine("Girdiğiniz iki sayının toplamı: " + c);
            //        break;
            //    case 2:
            //        c = a - b;
            //        Console.WriteLine("Girdiğiniz iki sayının farkı: " + c);
            //        break;
            //    case 3:
            //        c = a * b;
            //        Console.WriteLine("Girdiğiniz iki sayının çarpımı: " + c);
            //        break;
            //    case 4:
            //        c = a / b;
            //        Console.WriteLine("Girdiğiniz iki sayının bölümü: " + c);
            //        break;
            //    default:
            //        Console.WriteLine("Lütfen verilen aralıkta bir işlem giriniz");
            //        break;




            // }
            #endregion
            Console.ReadLine();
        }
    }
}
