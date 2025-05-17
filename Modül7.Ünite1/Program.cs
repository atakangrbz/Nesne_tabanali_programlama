using System;
using Modül7.Ünite1;

namespace Modül7.Ünite1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci birOgrenci = new Ogrenci("Ali UZUN");

            Console.WriteLine("Adı");
            Console.WriteLine("{0}", birOgrenci.Ad);

            Console.WriteLine("Boyu");
            Console.WriteLine("{0}", birOgrenci.Boy);

            Console.WriteLine("Kilosu");
            Console.WriteLine("{0}", birOgrenci.Kilo);

            Console.WriteLine("\n");

            Daire daire = new Daire(3.0);
            Console.WriteLine("Dairenin Alanı:");
            Console.WriteLine("{0}", daire.Alan());
        }
    }
}
