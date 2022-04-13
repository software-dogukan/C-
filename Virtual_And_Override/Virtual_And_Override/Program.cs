using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_And_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            student1 o1 = new student1();//class tanımlandı 
            o1.İsim();//class metot çağırıldı
            o1.Sinif();//class metot çağırıldı
            Console.ReadLine();//consol açık kalması için
        }
        class Okul//Class oluşturuldu
        {
            public virtual void İsim()//virtual ile bir metot oluşturuldu ve bu metot diğer classlarda değer override yapılması için
            {
                Console.WriteLine("Nükte Sözen Lise");
            }
            public void Sinif()//metot oluşturuldu
            {
                Console.WriteLine("12. Sınıf Öğrenci");
            }
        }

        class student1 : Okul//Class birleştirildi
        {
            public override void İsim()//birleştirilen Class'da override yapılıla birlir metot yapıldı
            {
                Console.WriteLine("Hüseyin Ayaz Lise");
            }
        }
    }
}
