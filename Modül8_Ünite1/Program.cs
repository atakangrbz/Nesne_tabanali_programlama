delegate void SiralamaTemsilcisi(ref string[] kelimeler);

class Program
{
    static void SiralaAZ(ref string[] kelimeler)
    {
        Array.Sort(kelimeler);
        Console.WriteLine("A-Z sıralandı:");
        foreach (var kelime in kelimeler)
        {
            Console.WriteLine(kelime);
        }
        Console.WriteLine();
    }
    static void SiralaZA(ref string[] kelimeler)
    {
        Array.Sort(kelimeler);
        Array.Reverse(kelimeler);
        Console.WriteLine("Z-A sıralandı:");
        foreach (var kelime in kelimeler)
        {
            Console.WriteLine(kelime);
        }
        Console.WriteLine();
    }
    static void HarfSayisiYazdir(ref string[] kelimeler)
    {
        Console.WriteLine("Her kelimenin harf sayısı:");
        foreach (var kelime in kelimeler)
        {
            Console.WriteLine($"{kelime}: {kelime.Length} harf");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        string[] kelimeler = { "Zeytin", "Armut", "Elma", "Kiraz", "Üzüm" };
        Console.WriteLine("Sıralanmamış dizi:");
        foreach (var kelime in kelimeler)
        {
            Console.WriteLine(kelime);
        }

        SiralamaTemsilcisi temsilci = new SiralamaTemsilcisi(SiralaAZ);
        temsilci(ref kelimeler);
        temsilci += SiralaZA;
        temsilci += HarfSayisiYazdir;
        kelimeler = new string[] { "Zeytin", "Armut", "Elma", "Kiraz", "Üzüm" };

        Console.WriteLine("Dizi yeniden sıralanıyor (çoklu çağrım):");
        temsilci(ref kelimeler);
    }
}