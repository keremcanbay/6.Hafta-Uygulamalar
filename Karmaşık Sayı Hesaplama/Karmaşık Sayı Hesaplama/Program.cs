using System;

struct KarmasikSayi
{
    public double Gercek { get; set; } // Reel (Gerçek) kısmı
    public double Sanal { get; set; } // Sanal kısmı

    // Yapıcı metot
    public KarmasikSayi(double gercek, double sanal)
    {
        Gercek = gercek;
        Sanal = sanal;
    }

    // Karmaşık sayılar toplama metodu
    public KarmasikSayi Topla(KarmasikSayi diger)
    {
        return new KarmasikSayi(this.Gercek + diger.Gercek, this.Sanal + diger.Sanal);
    }

    // Karmaşık sayılar çıkarma metodu
    public KarmasikSayi Cikar(KarmasikSayi diger)
    {
        return new KarmasikSayi(this.Gercek - diger.Gercek, this.Sanal - diger.Sanal);
    }

    // Karmaşık sayıyı (a + bi) formatında döndüren ToString metodu
    public override string ToString()
    {
        string sanalKisim = Sanal >= 0 ? $"+ {Sanal}i" : $"- {-Sanal}i";
        return $"{Gercek} {sanalKisim}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Karmaşık sayılar oluşturma
        KarmasikSayi sayi1 = new KarmasikSayi(3, 4);  // 3 + 4i
        KarmasikSayi sayi2 = new KarmasikSayi(1, -2); // 1 - 2i

        // Karmaşık sayıları ekrana yazdırma
        Console.WriteLine($"Sayı 1: {sayi1}");
        Console.WriteLine($"Sayı 2: {sayi2}");

        // Toplama işlemi
        KarmasikSayi toplam = sayi1.Topla(sayi2);
        Console.WriteLine($"\nToplam: {toplam}");

        // Çıkarma işlemi
        KarmasikSayi fark = sayi1.Cikar(sayi2);
        Console.WriteLine($"Fark: {fark}");

        // Konsol ekranını açık tutmak için
        Console.WriteLine("\nÇıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
