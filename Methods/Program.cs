using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Selamla();
            //Selamla();
            //Selamla();
            //Selamla();
            //Selamla();
            //Selamla();
            //selamla.Selamla2();

            Console.WriteLine(Carpma(2,4,2));
            Console.ReadKey();
        }

        static void Selamla()
        {
            Console.WriteLine("Merhaba!");
        }

        static int Topla(int sayi1=3, int sayi2=5)
        {
            return sayi1+sayi2;
        }

        static int Carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        static int Carpma(int sayi1, int sayi2, int sayi3)
        {
            return (sayi1 * sayi2) + sayi3;
        }
    }
}
