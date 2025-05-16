class Program
{

    class Bisiklet
    {

        private int vites;
        private int hiz;
        public int VitesSayisi; 
        public Bisiklet()
        {
            vites = 1;
            hiz = 0;
            VitesSayisi = 18; 
        }
        public Bisiklet(int vitesSayisi)
        {
            vites = 1;
            hiz = 0;
            VitesSayisi = vitesSayisi;
        }
        public void Vites(int yeniVites)
        {
            if (yeniVites >= 1 && yeniVites <= VitesSayisi)
            {
                vites = yeniVites;
            }
            else
            {
                Console.WriteLine("Geçersiz vites!");
            }
        }
        public void Hizlan(int artis)
        {
            if (artis > 0)
            {
                hiz += artis;
            }
        }
        public void Fren(int azalis)
        {
            if (azalis > 0)
            {
                hiz -= azalis;
                if (hiz < 0) hiz = 0;
            }
        }
        public void Bilgiler()
        {
            Console.WriteLine($"Vites: {vites}, Hız: {hiz}, Vites Sayısı: {VitesSayisi}");
        }

        public int Vitess
        {
            get { return vites; }
            set
            {
                if (value >= 1 && value <= VitesSayisi)
                    vites = value;
            }
        }

        public int Hiz
        {
            get { return hiz; }
            set
            {
                if (value >= 0)
                    hiz = value;
            }
        }
    }

    static void Main(string[] args)
    {
        Bisiklet bisiklet1 = new Bisiklet();
        Bisiklet bisiklet2 = new Bisiklet(21);

        bisiklet1.Vites(5);
        bisiklet1.Hizlan(20);
        bisiklet1.Fren(5);
        bisiklet1.Bilgiler();

        bisiklet2.Vites(10);
        bisiklet2.Hizlan(35);
        bisiklet2.Fren(10);
        bisiklet2.Bilgiler();

        bisiklet1.Vitess = 3;  
        bisiklet1.Hiz = 15;
        bisiklet1.Bilgiler();

    }
}