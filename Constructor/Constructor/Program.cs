using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Bisiklet bisiklet = new Bisiklet();
            Bisiklet bisiklet1 = new Bisiklet("Mavi");
            Console.ReadLine();
        }
        class Bisiklet
        {
            private string _Renk="Kırmızı";
            public Bisiklet(string Renk)
            {
                _Renk = Renk;
            }
            public Bisiklet()
            {
                Console.WriteLine("Bisikletin rengi {0}", _Renk);
            }
        }
    }
}
