using System;

class Kitaplik
{
    private string[] kitaplar;

    // Kitaplık yapıcı metodu (kütüphaneyi başlatır)
    public Kitaplik(int kapasite)
    {
        kitaplar = new string[kapasite];
        for (int i = 0; i < kapasite; i++)
        {
            kitaplar[i] = "Boş"; // Başlangıçta her slot "Boş" olarak ayarlanır
        }
    }

    // İndeksleyici
    public string this[int indeks]
    {
        get
        {
            if (indeks < 0 || indeks >= kitaplar.Length)
            {
                return "Hata: Geçersiz indeks!";
            }
            return kitaplar[indeks];
        }
        set
        {
            if (indeks < 0 || indeks >= kitaplar.Length)
            {
                Console.WriteLine("Hata: Geçersiz indeks!");
            }
            else
            {
                kitaplar[indeks] = value;
            }
        }
    }

    // Tüm kitapları listeleme metodu
    public void Listele()
    {
        Console.WriteLine("Kitaplık İçeriği:");
        for (int i = 0; i < kitaplar.Length; i++)
        {
            Console.WriteLine($"İndeks {i}: {kitaplar[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Kitaplık oluşturma
        Kitaplik kitaplik = new Kitaplik(5);

        // Kitap ekleme
        kitaplik[0] = "Simyacı";
        kitaplik[1] = "Sefiller";
        kitaplik[2] = "1984";

        // Tüm kitapları listeleme
        kitaplik.Listele();

        // Belirli bir indeksteki kitabı alma
        Console.WriteLine("\nİndeks 1'deki kitap: " + kitaplik[1]);

        // Geçersiz bir indeks kullanma
        Console.WriteLine("\nGeçersiz indeks kontrolü: " + kitaplik[10]);

        // Kitap adı değiştirme
        kitaplik[1] = "Hayvan Çiftliği";

        // Güncellenmiş kitaplığı listeleme
        Console.WriteLine();
        kitaplik.Listele();

        // Konsol ekranını açık tutmak için
        Console.WriteLine("\nÇıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
