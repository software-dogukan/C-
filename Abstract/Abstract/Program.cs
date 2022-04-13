using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi k1 = new Ilkokul();//class tanımı yapıldı 
            Kisi k2 = new Ortaokul();//class tanımı yapıldı 
            Kisi k3 = new Lise();//class tanımı yapıldı 
            k1.Isim();//metot çalıştırıldı
            k2.Soyisim();//metot çalıştırıldı
            k3.Yas();//metot çalıştırıldı
            Console.ReadLine();//consol açık kalması için yapılır.
        }

        abstract class Kisi//abstract class kullanarak classlara bağladığımızda zorunlu olarak girilmesi gereken metotlar olacak
        {
            abstract public void Isim();//zorunlu metot oluşturulacak
            abstract public void Soyisim();//zorunlu metot oluşturulacak
            public void Yas()//bağlantı sağlanılan classlar bu metot barındaracak
            {
                Console.WriteLine("Yaş aralığı 7-18");
            }

        }
        class Ortaokul : Kisi//Ortaokul ile Kisi class bağlantı sağlanıldı ve kalıtım yapıldı
        {
            public override void Isim()//override ile metot ezildi 
            {
                Console.WriteLine("Doğukan");
            }

            public override void Soyisim()//override ile metot ezildi 
            {
                Console.WriteLine("ALKAN");
            }
        }
        class Ilkokul : Kisi//Ilkokul ile Kisi class bağlantı sağlanıldı ve kalıtım yapıldı
        {
            public override void Isim()//override ile metot ezildi 
            {
                Console.WriteLine("Sena");
            }

            public override void Soyisim()//override ile metot ezildi 
            {
                Console.WriteLine("BAYRAKTAR");
            }
        }
        class Lise : Kisi//Lise ile Kisi class bağlantı sağlanıldı ve kalıtım yapıldı
        {
            public override void Isim()//override ile metot ezildi 
            {
                Console.WriteLine("Mehmet");
            }

            public override void Soyisim()//override ile metot ezildi 
            {
                Console.WriteLine("AÇIK");
            }
        }




    }
}
