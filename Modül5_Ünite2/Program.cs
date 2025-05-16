class Program
{

    class Nokta
    {
        private int x, y;
        private static int noktaSayisi = 0;

        public Nokta()
        {
            this.x = 0;
            this.y = 0;
            noktaSayisi++;
        }
        public Nokta(int x, int y)
        {
            this.x = x;
            this.y = y;
            noktaSayisi++;
        }
        public static int NoktaSayisi()
        {
            return noktaSayisi;
        }
    }

    static void Main(string[] args)
    {
        Nokta nokta1 = new Nokta();
        Nokta nokta2 = new Nokta(5, 10);
        Nokta nokta3 = new Nokta(20, 30);

        Console.WriteLine("nokta sayısı: " + Nokta.NoktaSayisi());

    }
}