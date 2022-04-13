using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Bisiklet bisiklet = new Bisiklet();//Class tanımı yapıldı
            Bisiklet bisiklet1 = new Bisiklet("Mavi");// ekrana bisikletin rengi mavi yazdıracak
            Console.ReadLine();//Consol açık kalması için
        }
        class Bisiklet// Class oluşturuldu 
        {
            private string _Renk="Kırmızı";//String bir değer girişi için tanımlandı

            public Bisiklet(string Renk)// ctor kullanıldı ve string diye bir değişten tanımladı
            {
                _Renk = Renk;//değişkenleri bir birine eşitlendi
            }
            public Bisiklet()//başka ctor oluşturduk ve parametre vermedik
                //bu ctor değer vermedik çünkü dışarıdan değer girilsede girilmesede bu değer çalıştırılsın.
            {
                Console.WriteLine("Bisikletin rengi {0}",_Renk);//ekrana çıktı verir.
            }
        }
    }
}
