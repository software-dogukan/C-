using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Okul okul = new Okul();//referans verdik
            okul.student = new Ilkokul();//referans verdiğimiz yerde interface prop olduğu için bizden değer istedi ver bizde değer olarak ilkokul class söyledik
            okul.tenefus();//okul class içinde ki tenefus methodunu çalıştırdık.
            Console.ReadLine();//ekran kapanmasın diye
        }
        interface ISinif//interface oluşturduk
        {
            void sinif();//interface metot ismi verdik
        }
        class Okul//class oluşturdul
        {
            public ISinif student { get; set; }//prop değer istedik bu metot için
            public void tenefus()//Metot oluşturduk
            {
                student.sinif();//girilen prop değerin yerine git class çalıştırrr
                Console.WriteLine("Tenefüs vakti");//ekrana çıktı verdi
            }
        }
        class Ilkokul:ISinif// ilkokul için class oluşturuldu ve ISinif interface ekledi
        {
            public void sinif()//interface girilmesi zorunlu olanları buraya ekledi ve değerleri girildi.
            {
                Console.WriteLine("İlkokullar için");//ekrana çıktııı
            }
        }
        class Ortaokul: ISinif// ortaokul için class oluşturuldu ve ISinif interface ekledi
        {
            public void sinif()//interface girilmesi zorunlu olanları buraya ekledi ve değerleri girildi.
            {
                Console.WriteLine("Ortaokullar için");//ekrana çıktııı
            }
        }
        class Lise: ISinif// ortaokul için class oluşturuldu ve ISinif interface ekledi
        {
            public void sinif()//interface girilmesi zorunlu olanları buraya ekledi ve değerleri girildi.
            {
                Console.WriteLine("Liseler için");//ekrana çıktııı
            }
        }
    }
}
