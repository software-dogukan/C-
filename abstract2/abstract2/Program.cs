using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tir tr = new Sube1();//class tanımı yapıldı
            Tir tr1 = new Sube2();//class tanımı yapıldı
            tr.Firma();//metot çalıştırır
            tr.Id();//metot çalıştırır
            tr.Sehir();//metot çalıştırır
            tr1.Firma();//metot çalıştırır
            tr1.Id();//metot çalıştırır
            tr1.Sehir();//metot çalıştırır
            Console.ReadLine();//consol açık tutar.

        }

        abstract class Tir//Class oluşturduk ve ismine abstract vererek onun içerisndeki public olanlar bütün hepsinde aynı fakat
            //abstract yazdığu metotlar eşlenen classlarda farklı bir value alacağı anlama geliyor.
            //class'ı class'a sadece 1 kere bağlana biliyor örnek olarak şöyle düşüne biliriz her insanın annesi vardır sadece 1 tane vardır birden fazla
            //kan bağı olan anne olmaz class'lar arasında öyledir.
        {
            public void Firma()//Kullanılacak her yerde metot aynı işlemi yapacak
            {
                Console.WriteLine("Aras");
            }
            abstract public void Id();//kullanılan her class farklı değer alması için yapıldı
            abstract public void Sehir();//kullanılan her class farklı değer alması için yapıldı

        }
        class Sube1 : Tir//Sube1 oğul ve Tir baba classdır. bağlandı birbirlerine 
        {
            public override void Id()//zorunlu oluşturulan metot
            {
                Random rnd = new Random();
                Console.WriteLine(rnd.Next(1,100));
            }

            public override void Sehir()//zorunlu oluşturulan metot
            {
                Console.WriteLine("İstanbul");
            }
        }
        class Sube2 : Tir//Sube2 oğul Tir baba classdır birbirlerine bağlandı
        {
            public override void Id()//zorunlu oluşturulan metot
            {
                Random rnd = new Random();
                Console.WriteLine(rnd.Next(101, 200));
            }

            public override void Sehir()//zorunlu oluşturulan metot
            {
                Console.WriteLine("Ankara");
            }
        }



    }
}
