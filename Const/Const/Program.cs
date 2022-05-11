using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const
{
    class Program
    {
        static void Main(string[] args)
        {
            var deger = new Const(11, 13);//var türünde tanımladık gelecek değeri bilmediğimizden dolayı ve isim verdik class ismini verdiğimizde
            //bizden int türünde p1 ve p2 değer atamamı istedi zorunlu olarak
            Console.WriteLine(deger.y);//tanımladığımız sınıfın ismi deger olduğu için orada belirlediğimiz DEĞİŞKENLERİ referans vererek çağıra biliriz
            Console.WriteLine(deger.x);//tanımladığımız sınıfın ismi deger olduğu için orada belirlediğimiz DEĞİŞKENLERİ referans vererek çağıra biliriz
            Console.WriteLine(Const.sabit);//sabit değerleri clas ismini vermeden çağırılamaz. Referans ile çağırılamaz 
            Console.WriteLine(Const.sabit1);//sabit değerleri clas ismini vermeden çağırılamaz. Referans ile çağırılamaz 
            Console.ReadLine();
        }
    }
    class Const
    {
        public const int sabit = 5;//sabit int belirledik
        public const int sabit1 = 10;    //sabit int belirledik
        public int y;//değişken int belirledik
        public int x;//değişken int tanımladık
        public Const(int p1,int p2)//ctor oluşturuk ve bu metot çalıştırıldığında p1 ve p2 int türünden değer alıcak
        {
            x = p1;//p1 verilen değer x atanacak
            y = p2;//p2 verilen değer y atanacak
        }
    }
}
