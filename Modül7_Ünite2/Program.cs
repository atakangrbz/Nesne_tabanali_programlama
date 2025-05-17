using Modül7.Ünite1;

class Program
{
    static void Main(string[] args)
    {
        Ogrenci birOgrenci = new Ogrenci();
        Ogretmen birOgretmen = new Ogretmen();

        birOgrenci.Buyu();
        birOgretmen.Buyu();

        birOgrenci.Oku();
        birOgretmen.Oku(); 

        Console.ReadLine(); 
    }
}