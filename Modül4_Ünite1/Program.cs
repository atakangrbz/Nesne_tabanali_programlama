internal class Program
{

    class Bisiklet
    {
        int hiz = 0;
        int vites = 0;

        public Bisiklet()
        {
            vites = 18;
        }

        public void Hizlan(int artis)
        {
            hiz += artis;
        }

        public void BilgileriYaz()
        {
            Console.WriteLine("Vites: {0}, Hız: {1}", vites, hiz);
        }
    }

    static void Main(string[] args)
    {
        Bisiklet bisiklet1 = new Bisiklet();
        Bisiklet bisiklet2 = bisiklet1;
        bisiklet1.Hizlan(10);
        Console.WriteLine("bisiklet1 bilgileri:");
        bisiklet1.BilgileriYaz();

        Console.WriteLine("bisiklet2 bilgileri:");
        bisiklet2.BilgileriYaz();


    }
}