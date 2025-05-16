class Program
{
    static void Main(string[] args)
    {
        int sayi = 25;
        Console.WriteLine("İnt değer: " + sayi);
        object Sayi1 = sayi;
        Console.WriteLine("Boxing sonrası object türündeki değer: " + Sayi1);
        int Sayi2 = (int)Sayi1;
        Console.WriteLine("Unboxing sonrası int değer: " + Sayi2);

        object obj1 = "Merhaba";
        object obj2 = 123.45;
        object obj3 = 100;

        if (obj1 is string)
        {
            Console.WriteLine("obj1 string türündedir.");
        }

        if (obj2 is double)
        {
            Console.WriteLine("obj2 double türündedir.");
        }

        if (obj3 is int)
        {
            Console.WriteLine("obj3 int türündedir.");
        }


        string str1 = obj1 as string;
        if (str1 != null)
        {
            Console.WriteLine("obj1 'as' ile string'e başarıyla dönüştürüldü: " + str1);
        }

        string str2 = obj2 as string;
        if (str2 == null)
        {
            Console.WriteLine("obj2 'as' ile string'e dönüştürülemedi.");
        }

    }
}