using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ilkokul okul1 = new Ilkokul();// Class tanımladık 
            Ortaokul okul2 = new Ortaokul();//Class tanımladık
            Lise okul3 = new Lise();//Class tanımladık
            Console.WriteLine(okul1.Ad());//Ekrana çıktı olarak class içerisindeki ad metot çalıştırdı
            Console.WriteLine(okul2.Soyad());//Ekrana çıktı olarak class içerisindeki soyad metot çalıştırdı
            Console.WriteLine(okul3.Sinif());//Ekrana çıktı olarak class içerisindeki sinif metot çalıştırdı
            Console.ReadLine();//ekranı açık kalması için yapılıyor
        }

        interface IOgrenci// Interface tanımladık ve içeriklerini girdik
        {
            string Ad();
            string Soyad();
            string TelNo();
            string Sinif();

        }
        class Ilkokul : IOgrenci// class oluşturduk ve interface bununla bağlantı sağladık interface ki string burada bizden metot oluşturmamızı istedi
        {
            public string Ad()// Ad diye bir metot oluşturdum
            {
                return "Doğukan";
            }

            public string Sinif()//Sınıf dite bir metot oluşturdum
            {
                return "1-C";
            }

            public string Soyad()//Soyad diye bir Metot oluşturdum
            {
                return "ALKAN";
            }

            public string TelNo()// TelNo diye bir Metot oluşturdum.
            {
                return "5569874563";
            }
        }
        class Ortaokul : IOgrenci// class oluşturduk ve interface bununla bağlantı sağladık interface ki string burada bizden metot oluşturmamızı istedi
        {
            public string Ad()// Ad diye bir metot oluşturdum
            {
                return "Esma";   
            }

            public string Sinif()//Sınıf dite bir metot oluşturdum
            {
                return "6-E";
            }

            public string Soyad()//Soyad diye bir Metot oluşturdum
            {
                return"USLU";
            }

            public string TelNo()// TelNo diye bir Metot oluşturdum.
            {
                return "05986578965";
            }
        }
        class Lise : IOgrenci// class oluşturduk ve interface bununla bağlantı sağladık interface ki string burada bizden metot oluşturmamızı istedi
        {
            public string Ad()// Ad diye bir metot oluşturdum
            {
                return "Mircan";
            }

            public string Sinif()//Sınıf dite bir metot oluşturdum
            {
                return"11-A";
            }

            public string Soyad()//Soyad diye bir Metot oluşturdum
            {
                return "BAYRAK";
            }

            public string TelNo()// TelNo diye bir Metot oluşturdum.
            {
                return "05639874521";
            }
        }
  

        

    }
}
