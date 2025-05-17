class Urun
{
    public string Ad { get; set; }
    public decimal Fiyat { get; set; }
}

class Sepet
{
    public List<Urun> Urunler { get; private set; } = new List<Urun>();
    public event EventHandler UrunEklendi;

    public void UrunEkle(Urun urun)
    {
        Urunler.Add(urun);
        UrunEklendi?.Invoke(this, EventArgs.Empty);
    }

    public decimal ToplamTutar()
    {
        decimal toplam = 0;
        foreach (var urun in Urunler)
        {
            toplam += urun.Fiyat;
        }
        return toplam;
    }

}
class Makine
{
    public event EventHandler AsiriIsinma;

    private int _sicaklik;
    public int Sicaklik
    {
        get => _sicaklik;
        set
        {
            _sicaklik = value;
            if (_sicaklik > 1000)
            {
                AsiriIsinma?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    public void Kapat()
    {
        Console.WriteLine("[Olay] Sıcaklık çok yüksek! Makine kapatılıyor...");
    }
}
class Program
{
    static void Main()
    {
        Sepet sepet = new Sepet();
        sepet.UrunEklendi += Sepet_UrunEklendi;

        Console.WriteLine("Kaç ürün eklemek istiyorsunuz?");
        int adet = int.Parse(Console.ReadLine());

        for (int i = 0; i < adet; i++)
        {
            Urun urun = new Urun();
            Console.Write($"Ürün {i + 1} adı: ");
            urun.Ad = Console.ReadLine();

            Console.Write($"Ürün {i + 1} fiyatı: ");
            urun.Fiyat = decimal.Parse(Console.ReadLine());

            sepet.UrunEkle(urun);
            Makine makine = new Makine();
            makine.AsiriIsinma += Makine_AsiriIsinma;

            Random rnd = new Random();
            while (true)
            {
                int yeniSicaklik = rnd.Next(900, 1100);
                Console.WriteLine($"Anlık sıcaklık: {yeniSicaklik} °C");
                makine.Sicaklik = yeniSicaklik;

                if (yeniSicaklik > 1000)
                    break;

                Thread.Sleep(1000);
            }
        }

        Console.WriteLine("Tüm ürünler başarıyla eklendi.");
    }

    static void Sepet_UrunEklendi(object sender, EventArgs e)
    {
        Sepet sepet = sender as Sepet;
        Console.WriteLine($"[Olay] Toplam tutar: {sepet.ToplamTutar()} ₺");
    }
    static void Makine_AsiriIsinma(object sender, EventArgs e)
    {
        Makine makine = sender as Makine;
        makine.Kapat();
    }
}
