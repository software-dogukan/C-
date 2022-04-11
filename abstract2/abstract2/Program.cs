using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tir tr = new Sube1();
            Tir tr1 = new Sube2();
            tr.Firma();
            tr.Id();
            tr.Sehir();
            tr1.Firma();
            tr1.Id();
            tr1.Sehir();
            Console.ReadLine();

        }

        abstract class Tir
        {
            public void Firma()
            {
                Console.WriteLine("Aras");
            }
            abstract public void Id();
            abstract public void Sehir();
        
        }
        class Sube1 : Tir
        {
            public override void Id()
            {
                Random rnd = new Random();
                Console.WriteLine(rnd.Next(1,100));
            }

            public override void Sehir()
            {
                Console.WriteLine("İstanbul");
            }
        }
        class Sube2 : Tir
        {
            public override void Id()
            {
                Random rnd = new Random();
                Console.WriteLine(rnd.Next(101, 200));
            }

            public override void Sehir()
            {
                Console.WriteLine("Ankara");
            }
        }



    }
}
