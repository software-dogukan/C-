using System;
using System.Collections.Generic;//list yapmak istediğimizde bu kütüphaneyi eklememiz gerekiyor
using System.Collections;//arraylist yapmak istiyorsakda bu kütüphaneyi eklememiz gerekiyor


namespace ArrayList_And_List
{
    class Program
    {
        static void Main(string[] args)
        {
            arraylist al = new arraylist();//class tanımı yaptık
            al.Cikti();//class metot çalıştırdık
            list list = new list();//class tanımı yaptık
            list.Cikti1();//class metot çalıştırdık
            Console.ReadLine();//consol ekran açık kalması için yapıyoruz
        }
    }
    class arraylist
    {
        public void Cikti()
        {
            ArrayList arrayList = new ArrayList();//arraylist tanımını yaptık
            arrayList.Add("Doğukan");// add kullanarak listeye ekliyoruz veriyi
            arrayList.Add(1);//hata vermez çünkü array list bütün değişkenleri içinde barındırır.
            foreach (var item in arrayList)//ekrana çıktı için foreach içindekini tek tek ekrana yazdırır
            {
                Console.WriteLine("{0}", item);
            }
        }
    }
    class list
    {
        public void Cikti1()
        {
            List<string> list = new List<string>();//list veri listesi yapıyoruz
                                                   //ve bu veri listesini sadece string değerler girmesini istiyoruz
            list.Add("Alkan");// add kullanarak listeye ekliyoruz veriyi
            //list.Add(1);    hata verir sebebi yukarıda string bir yapısı olduğunu söyledim
            foreach (var item in list)//ekrana çıktı için foreach içindekini tek tek ekrana yazdırır
            {
                Console.WriteLine(item);
            }
        }
    }
}
