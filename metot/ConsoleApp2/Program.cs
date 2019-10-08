using System;

namespace ConsoleApp2
{
    class Program
    {
        static int sonuc;
        static int Hesapla(int a, int b)
        {
            int x, y;
            x = 3 * a;
            y = b / 2;
            return (x + y);

        }
    
        static void Main(string[] args)
        {
            int n;
            n = Hesapla(4, 8);
            sonuc = n;
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }



    }
}
