using System;

enum TrafikIsigiDurumu
{
    Kirmizi,  // Kırmızı ışık
    Sarı,     // Sarı ışık
    Yesil     // Yeşil ışık
}

class TrafikIsigi
{
    // Trafik ışığının durumuna göre yapılacak işlemi döndüren metot
    public string IsikDurumuYap(TrafikIsigiDurumu durum)
    {
        switch (durum)
        {
            case TrafikIsigiDurumu.Kirmizi:
                return "Dur! Işık kırmızı, bekleyin.";
            case TrafikIsigiDurumu.Sarı:
                return "Dikkat! Işık sarı, hızla geçmeye çalışmayın.";
            case TrafikIsigiDurumu.Yesil:
                return "Geçebilirsiniz! Işık yeşil.";
            default:
                return "Bilinmeyen ışık durumu.";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Trafik ışığı nesnesi oluşturuluyor
        TrafikIsigi trafikIsigi = new TrafikIsigi();

        // Kırmızı ışık durumu
        Console.WriteLine(trafikIsigi.IsikDurumuYap(TrafikIsigiDurumu.Kirmizi));

        // Sarı ışık durumu
        Console.WriteLine(trafikIsigi.IsikDurumuYap(TrafikIsigiDurumu.Sarı));

        // Yeşil ışık durumu
        Console.WriteLine(trafikIsigi.IsikDurumuYap(TrafikIsigiDurumu.Yesil));

        // Konsol ekranını açık tutmak için
        Console.WriteLine("\nÇıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
