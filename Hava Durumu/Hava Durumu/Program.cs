using System;

enum HavaDurumu
{
    Gunesli,  // Güneşli hava
    Yagmurlu, // Yağmurlu hava
    Bulutlu,  // Bulutlu hava
    Firtinali  // Fırtınalı hava
}

class HavaDurumuTavsiyesi
{
    // Hava durumu türüne göre tavsiye veren metot
    public string TavsiyeVer(HavaDurumu durum)
    {
        switch (durum)
        {
            case HavaDurumu.Gunesli:
                return "Hava çok güzel! Şapka takmayı unutmayın.";
            case HavaDurumu.Yagmurlu:
                return "Yağmur yağıyor, şemsiye alın.";
            case HavaDurumu.Bulutlu:
                return "Bulutlu hava, dışarıda rahatça gezebilirsiniz.";
            case HavaDurumu.Firtinali:
                return "Dikkat! Fırtına var, güvenli bir yere sığının.";
            default:
                return "Bilinmeyen hava durumu.";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Hava durumu tavsiyesi nesnesi oluşturuluyor
        HavaDurumuTavsiyesi tavsiye = new HavaDurumuTavsiyesi();

        // Güneşli hava durumu tavsiyesi
        Console.WriteLine(tavsiye.TavsiyeVer(HavaDurumu.Gunesli));

        // Yağmurlu hava durumu tavsiyesi
        Console.WriteLine(tavsiye.TavsiyeVer(HavaDurumu.Yagmurlu));

        // Bulutlu hava durumu tavsiyesi
        Console.WriteLine(tavsiye.TavsiyeVer(HavaDurumu.Bulutlu));

        // Fırtınalı hava durumu tavsiyesi
        Console.WriteLine(tavsiye.TavsiyeVer(HavaDurumu.Firtinali));

        // Konsol ekranını açık tutmak için
        Console.WriteLine("\nÇıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
