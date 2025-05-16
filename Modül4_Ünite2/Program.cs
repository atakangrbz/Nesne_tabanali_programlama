class Program
{
    static void DegerArtir(ref int sayi)
    {
        sayi = sayi + 1; 
    }

    static void Main(string[] args)
    {
        int sayi = 5; 

        Console.WriteLine("Önceki değer: " + sayi);

        DegerArtir(ref sayi);

        Console.WriteLine("Sonraki değer: " + sayi);

    }
}