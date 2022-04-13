using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Saat saat = new Saat("Doğukan");
            saat.Begeni();
            saat.zaman();
            Console.ReadLine();
        }
        class Kisi
        {
            private string _isim;
            public Kisi(string isim)
            {
                _isim = isim;
            }
            public void Begeni()
            {
                Console.WriteLine("{0} Kullanıcı Fotoğrafınızı Beğendi",_isim);
            }
        }
        class Saat:Kisi
        {
            public Saat(string _girdi) : base(_girdi)
            {

            }
            public  void zaman() {
                Console.WriteLine(DateTime.Today);
            }
        }
    }
}
