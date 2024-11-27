using System;

struct Zaman
{
    private int saat;
    private int dakika;

    // Saat özelliği
    public int Saat
    {
        get => saat;
        set => saat = (value >= 0 && value < 24) ? value : 0;
    }

    // Dakika özelliği
    public int Dakika
    {
        get => dakika;
        set => dakika = (value >= 0 && value < 60) ? value : 0;
    }

    // Yapıcı metot
    public Zaman(int saat, int dakika)
    {
        this.saat = (saat >= 0 && saat < 24) ? saat : 0;
        this.dakika = (dakika >= 0 && dakika < 60) ? dakika : 0;
    }

    // Toplam dakika değerini döndüren metot
    public int ToplamDakika()
    {
        return saat * 60 + dakika;
    }

    // İki zaman arasındaki farkı (dakika olarak) hesaplayan metot
    public int Fark(Zaman diger)
    {
        return Math.Abs(this.ToplamDakika() - diger.ToplamDakika());
    }

    // Zamanın string formatında gösterimi
    public override string ToString()
    {
        return $"{saat:D2}:{dakika:D2}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Geçerli bir zaman nesnesi oluşturma
        Zaman zaman1 = new Zaman(14, 30);
        Console.WriteLine($"Zaman 1: {zaman1}");

        // Geçersiz bir zaman nesnesi oluşturma (saat ve dakika otomatik 0 yapılır)
        Zaman zaman2 = new Zaman(25, 70);
        Console.WriteLine($"Zaman 2: {zaman2}");

        // Toplam dakika değerini alma
        Console.WriteLine($"\nZaman 1 toplam dakika: {zaman1.ToplamDakika()}");
        Console.WriteLine($"Zaman 2 toplam dakika: {zaman2.ToplamDakika()}");

        // İki zaman arasındaki farkı hesaplama
        int fark = zaman1.Fark(zaman2);
        Console.WriteLine($"\nZamanlar arasındaki fark: {fark} dakika");

        // Konsol ekranını açık tutmak için
        Console.WriteLine("\nÇıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
