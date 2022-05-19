using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Log
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try//bu blok her zaman çalışır
            {
                int x, y;//Değişken tanımladık
                Console.WriteLine("Bir Sayı Giriniz");//Ekrana çıktı verdik
                x = Convert.ToInt32(Console.ReadLine());//Kullanıcıdan value aldık
                Console.WriteLine("Bir Sayı Giriniz");//Ekrana çıktı verdik
                y = Convert.ToInt32(Console.ReadLine());//Kullanıcıdan value aldık
                Console.WriteLine(x * y);//Ekrana çıktı verdik
            }
            catch (Exception e)//eğer try hata alırsak bunu blok çalışır
            //Genellikle Exception en son kullanılır diğer olabilecek hatalarda sistem ayakta kalması için
            //Exception blok çalıştığı taktirde sistemin neresinde zaviyet var onu anlarız
            {
                StreamWriter Yaz = new StreamWriter("C:\\Users\\USER\\Desktop\\Yeni Metin Belgesi.txt");
                //Bunu referans vere bilmek için yukarıda System.IO eklemen gerekiyor
                //Bu referans verirken gideceği konumu söylemeliyiz o konuma gider ve ne yapmasını isterseniz onu yapar

                Yaz.WriteLine(e.Message);// Dosyaya gir ve yazdır hatayı eğer dosya yoksa dosyayı oluşturur
                Console.WriteLine("Beklenmedik bir hata ile karşılaşıldı!");//kullanıcıya bilgi ver
                Yaz.Close();//Dosyadan çık;
            }
            Console.ReadLine();//bir değer girilmeden ekran kapanmamasın
        }
    }
}
