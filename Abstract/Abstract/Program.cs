using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi k1 = new Ilkokul();
            Kisi k2 = new Ortaokul();
            Kisi k3 = new Lise();
            k1.Isim();
            k2.Soyisim();
            k3.Yas();
            Console.ReadLine();
        }

        abstract class Kisi
        {
            abstract public void Isim();
            abstract public void Soyisim();
            public void Yas()
            {
                Console.WriteLine("Yaş aralığı 7-18");
            }

        }
        class Ortaokul : Kisi
        {
            public override void Isim()
            {
                Console.WriteLine("Doğukan");
            }

            public override void Soyisim()
            {
                Console.WriteLine("ALKAN");
            }
        }
        class Ilkokul : Kisi
        {
            public override void Isim()
            {
                Console.WriteLine("Sena");
            }

            public override void Soyisim()
            {
                Console.WriteLine("BAYRAKTAR");
            }
        }
        class Lise : Kisi
        {
            public override void Isim()
            {
                Console.WriteLine("Mehmet");
            }

            public override void Soyisim()
            {
                Console.WriteLine("AÇIK");
            }
        }




    }
}
