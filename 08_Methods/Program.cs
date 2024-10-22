using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //()
            //Geriye değer Dödürmeyen metodlar
            //Customer-listeleme-ekle-sil-güncelle
            //Void
            #region Void Metodlar
            //string[] customers = { "nursel,merve", "buse", "fatma" };
            //CustomerLİst();


            //void CustomerLİst()
            //{
            //    foreach (var customer in customers)
            //    {
            //        Console.WriteLine(customer);
            //    }
            //}

            #endregion


            #region Void Sum
            ////Calculation();
            //void Calculation()
            //{
            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int number = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Lütfen bir sayı daha giriniz");
            //    int number2 = int.Parse(Console.ReadLine());

            //    int sum = number + number2;
            //    Console.WriteLine("Toplam:"+ sum);

            //    int multiplication = number * number2;
            //    Console.WriteLine("Çarpım:"+ multiplication);
            //    if (number > number2)
            //    {
            //        int extraction = number - number2;
            //        int splitting = number / number2;
            //        Console.WriteLine("Çıkarma" +extraction);
            //        Console.WriteLine("Bölme"+ splitting);

            //    }
            //    else
            //    {
            //        int extraction = number2 - number;
            //        int splitting = number2 / number;
            //        Console.WriteLine(extraction);
            //        Console.WriteLine(splitting);
            //    }
            //}



            #endregion

            #region Geriye değer döndürmeyen parametreli değerler
            ////string _name;
            ////string _surname;
            ////string _gender;
            ////int _number;
            ////Console.WriteLine("Lütfen isminizi giriniz");
            ////_name = Console.ReadLine();
            ////Console.WriteLine("Lütfen soyisminizi girniz");
            ////_surname = Console.ReadLine();
            ////Console.WriteLine("Lütfen okul numaranızı giriniz");
            ////_number = int.Parse(Console.ReadLine());
            ////Console.WriteLine("Lüffen cinsiyeti seçiniz");
            ////_gender = Console.ReadLine();

            ////if (_gender == "k")
            ////{
            ////    _gender = "KIZ";
            ////}
            ////else
            ////{
            ////    _gender = "ERKEK";
            ////}
            ////Students(_name, _number, _surname, _gender) ;
            ////void Students( string name, int number,string surname,string gender)
            ////{
            ////     _name = name;
            ////    _gender = gender;
            ////    _surname = surname;
            ////     _number = number;


            ////    Console.WriteLine("isim soyisim:" + name +" " + surname);
            ////    Console.WriteLine("Numara: " + number);
            ////    Console.WriteLine("Cinsiyet: " + gender);
            ////}
            #endregion

            #region Geriye Değer Döndüren Methodlar

            //////Console.Write( Student("Nursel","Düzdar"));
            ////// string Student(string name,string surname)
            ////// {
            //////     return name + " " + surname;

            ////// }
            #endregion

            #region Parametreli Metodlar
            //DateTime year;
            //DateTime yearNow = DateTime.Now;

            //Console.WriteLine("Lütfen Doğum Tarihinizi Giriniz (örn: 2001-01-01):");
            //year = DateTime.Parse(Console.ReadLine());

            //int age = CalculateAge(yearNow, year);
            //Console.WriteLine("Yaşınız: " + age);
            #endregion

            #region Örnek Uygulama
            string _name;
            string _surname;
            int _number;
            int _exam1;
            int _exam2;
            int _exam3;

            Console.WriteLine("Lütfen öğrenci isimi girniz");
            _name = Console.ReadLine();
            Console.WriteLine("Lütfen bir soyisim giriniz");
            _surname = Console.ReadLine();
            Console.WriteLine("Lütfen okul numarası giriniz");
            _number=int.Parse(Console.ReadLine());
            _exam1 = int.Parse(Console.ReadLine());
            _exam2 = int.Parse(Console.ReadLine());
            _exam3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Birinci sınav Motu:" + _exam1);
            Console.WriteLine("İkinci sınav Motu:" + _exam2);
            Console.WriteLine("Üçüncü sınav Motu:" + _exam3);
            Console.WriteLine(Student(_name,_surname,_number,_exam1,_exam2,_exam3));



            int Student(string name, string surname, int number, int exam1, int exam2, int exam3) {

                Console.WriteLine("İsim ve Soyisim: " + name + " " + surname);
                Console.WriteLine("Okul Numarası:"+ number);

                int avarage=(exam1 + exam2 + exam3)/3;
                if (avarage < 50)
                {
                    Console.WriteLine("öĞRENCİ BAŞARISIZ");
                }
                else {
                    Console.WriteLine("öĞRENCİ BAŞARILI");
                }
                return avarage;

                
            }

            #endregion

            Console.ReadLine();
        }
        //static int CalculateAge(DateTime currentDate, DateTime birthDate)
        //{
        //    int age = currentDate.Year - birthDate.Year;

        //    // Eğer doğum günü bu yıl geçmemişse yaşı bir azalt
        //    if (currentDate < birthDate.AddYears(age))
        //    {
        //        age--;
        //    }

        //    return age;
        //}
    }
}
