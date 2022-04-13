using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Index index = new Index("5");//11)index classin içerisinde ki base yollanması için değer girildi ve o değer gitti data class 
            index.Date();//12)index class içerisinde ki date metot çalıştırılması için
            Console.ReadLine();
        }
        class Data//1)class oluşturuldu
        {
            private string _deger;// 2)ctor içinde ki değeri almak için bir string tanımlandı
            public Data(string deger)
            {
                _deger = deger;//3)ctor dışarıdaki degere eşitlendi ctor kullandık ki dışarıdan deger kesin girilsin diye
            }
            public void yazdir()//4)metot oluşturuldu
            {
                Console.WriteLine("{0} Kat Sayisidir",_deger);//5)ctordan alınan değeri al buraya getir ve yazdır diye
            }
        }

        class Index:Data// 6)class birbirine bağlandı
        {
            public Index(string _girdi) : base(_girdi)//7)diğer class ctor bulunduğu için burada metot o base yollanmalı
            {

            }
            public void Date()//8)metot ekrana çıktı verelim diye
            {
                yazdir();//9)bağlantı kurulan class içerisinde ki metot buraya çağırldı
                Console.WriteLine("Kat sayisi kadar veri bulunmakta");//10)ekrana çıktı verildi
            }

        }




    }
}
