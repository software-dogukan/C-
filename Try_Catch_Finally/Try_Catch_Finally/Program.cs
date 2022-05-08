using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;//Değişken tanımladım
            try//Bu bloğu çalıştır eğer hata olursa catch bloklarını çalıştır
            {
                Console.WriteLine("Bir Sayı Giriniz");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bir Sayı Giriniz");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x * y);
            }
            catch (FormatException)//Yapılan işlemlerde Format hatası verirse program ekrana şu çıktıyı ver
            {
                Console.WriteLine("Yanlış formatta değer girdiniz Sayı giriniz");

            }
            catch (Exception)//format hatası olmaz ise herhangi hata olursa bloğu çalıştır ekrana çıktıyı ver
            {
                Console.WriteLine("Sistemde Beklenmeyen Bir Hata oldu!!!");
            }
            finally//Try veya catch çalıştırıldıktan sonra final olarak bu bloğu çalıştır ve ekrana çıktıyı ver 
            {
                Console.WriteLine("Tekrar Görüşmek Üzere:)");
            }
            Console.ReadLine();

        }
    }
}
