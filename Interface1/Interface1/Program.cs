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
            Ilkokul okul1 = new Ilkokul();
            Ortaokul okul2 = new Ortaokul();
            Lise okul3 = new Lise();
            Console.WriteLine(okul1.Ad());
            Console.WriteLine(okul2.Soyad());
            Console.WriteLine(okul3.Sinif());
            Console.ReadLine();
        }

        interface IOgrenci
        {
            string Ad();
            string Soyad();
            string TelNo();
            string Sinif();

        }
        class Ilkokul : IOgrenci
        {
            public string Ad()
            {
                return "Doğukan";
            }

            public string Sinif()
            {
                return "1-C";
            }

            public string Soyad()
            {
                return "ALKAN";
            }

            public string TelNo()
            {
                return "5569874563";
            }
        }
        class Ortaokul : IOgrenci
        {
            public string Ad()
            {
                return "Esma";   
            }

            public string Sinif()
            {
                return "6-E";
            }

            public string Soyad()
            {
                return"USLU";
            }

            public string TelNo()
            {
                return "05986578965";
            }
        }
        class Lise : IOgrenci
        {
            public string Ad()
            {
                return "Mircan";
            }

            public string Sinif()
            {
                return"11-A";
            }

            public string Soyad()
            {
                return "BAYRAK";
            }

            public string TelNo()
            {
                return "05639874521";
            }
        }
  

        

    }
}
