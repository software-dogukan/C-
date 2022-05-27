using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Ucretlendirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir otoparka park eden taksinin 1 saati 5TL, minibüsün 1 saati 6TL, ticari aracın 1 saati 6.5TL dir. Taksi 1 saatten sonraki her saat başı için %20 daha fazla, 
            minibüs 1 saatten sonraki her saat başı için toplamda %21.5 ve ticari araç 1 saatten sonraki her saat başı için toplamda %25 daha fazla ödeme yapmaktadır. 
            Buna göre klavyeden girilen araba tipi ve kalınan saat bilgisi girildikten sonra ekrana ödenecek otopark ücretini hesaplayan programın kodlarını yazınız.
             */

            string arac_model;//değişken tanımlandı
            sbyte saat;//Değişken tanımlandı
            Console.WriteLine("Araç Modelini Giriniz (Taksi,Minübüs veya Ticari)");//Ekrana Çıktı Verdi
            arac_model = Console.ReadLine();//Kullanıcıdan girdi istendi
            Console.WriteLine("Kaç Saat Kaldınız?");//Ekrana çıktı verdi
            saat = Convert.ToSByte(Console.ReadLine());//Kullanıcıdan girdi istendi
            arac_model.ToLower();//girilen string bütün harflerini küçük yaptı
            switch (arac_model)//araç modeline göre case yapıldı
            {
                case "taksi":// taksi için case açıldı
                    if (saat == 0 || saat == 1)//kullanıcıdan girilen saat değeri 0 veya 1 ise blok çalışır
                    {
                        Console.WriteLine("5 TL Ödeme Yapınız");//ekrana çıktı verdi
                    }
                    else if (saat >= 2)//Girilen saat değeri 2 veya 2 den büyük ise blok çalışır
                    {
                        double sonuc = (saat - 1) * ( (5.0 / 100 * 20)+5.0)+5.0;//double bir değişken tanımlandı ve işlem yapıldı
                                        
                        Console.WriteLine("{0}TL Ödeme Yapmanız Gerekiyor",sonuc);//ekrana çıktı verdi
                    }

                    else//hiç biri olmadığı taktirde bu blok çalışır
                    {
                        Console.WriteLine("Hatalı Tuşlama Yaptınız!");//ekrana çıktı verir
                    }
                    break;//case bitirir 
                case "minübüs":// münübüs için case açıldı
                    if (saat == 0 || saat == 1)//kullanıcıdan girilen saat değeri 0 veya 1 ise blok çalışır
                    {
                        Console.WriteLine("6 TL Ödeme Yapınız");//ekrana çıktı verdi
                    }
                    else if (saat >= 2)//Girilen saat değeri 2 veya 2 den büyük ise blok çalışır
                    {
                        double sonuc = (saat - 1) * ( (6.0 / 100 * 21.5)+6.0) + 6.0;//double bir değişken tanımlandı ve işlem yapıldı

                        Console.WriteLine("{0} TL Ödeme Yapmanız Gerekiyor",sonuc);//ekrana çıktı verdi
                    }

                    else//hiç biri olmadığı taktirde bu blok çalışır
                    {
                        Console.WriteLine("Hatalı Tuşlama Yaptınız!");//ekrana çıktı verdi
                    }
                    break;//case bitirir 

                case "ticari":// ticari için case açıldı
                    if (saat == 0 || saat == 1)//kullanıcıdan girilen saat değeri 0 veya 1 ise blok çalışır
                    {
                        Console.WriteLine("6,5 TL Ödeme Yapınız");//ekrana çıktı verdi
                    }
                    else if (saat >= 2)//Girilen saat değeri 2 veya 2 den büyük ise blok çalışır
                    {
                        double sonuc = (saat - 1) * ((6.5 / 100 * 25) + 6.5) + 6.5;//double bir değişken tanımlandı ve işlem yapıldı
                        Console.WriteLine("{0} TL Ödeme Yapmanız Gerekiyor",sonuc);//ekrana çıktı verdi
                    }

                    else//hiç biri olmadığı taktirde bu blok çalışır
                    {
                        Console.WriteLine("Hatalı Tuşlama Yaptınız!");//ekrana çıktı verdi
                    }
                    break;//case bitirir 
                default://case hiç birine giremediği taktirde bu blok çalışır
                    Console.WriteLine("Hatala Bir Tuşlama Yaptınız");//ekrana çıktı verdi
                    break;//default bitirir 
            }
            Console.ReadLine();
        }
    }

}
