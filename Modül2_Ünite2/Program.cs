using System;

struct Tarih
{
    public int gun;
    public int ay;
    public int yil;
    public Tarih(int g, int a, int y)
    {
        gun = g;
        ay = a;
        yil = y;
    }
    public void Yaz()
    {
        Console.WriteLine($"Tarih: {gun:D2}/{ay:D2}/{yil}");
    }
}
class Program
{
    static void Main()
    {        
        Tarih bugun = new Tarih(01, 01, 2004);
        bugun.Yaz();
    }
}
