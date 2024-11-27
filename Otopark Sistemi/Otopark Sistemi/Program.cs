using System;

class Otopark
{
    private string[,] parkYerleri;

    // Yapıcı metot: Kat ve park yeri sayısını belirleyerek başlatır
    public Otopark(int katSayisi, int parkYeriSayisi)
    {
        parkYerleri = new string[katSayisi, parkYeriSayisi];
        for (int i = 0; i < katSayisi; i++)
        {
            for (int j = 0; j < parkYeriSayisi; j++)
            {
                parkYerleri[i, j] = "Empty"; // Tüm park yerleri başlangıçta boş
            }
        }
    }

    // İndeksleyici: Kat ve park yeri kombinasyonuna erişim sağlar
    public string this[int kat, int parkYeri]
    {
        get
        {
            if (kat < 0 || kat >= parkYerleri.GetLength(0) || parkYeri < 0 || parkYeri >= parkYerleri.GetLength(1))
            {
                return "Hata: Geçersiz kat veya park yeri!";
            }
            return parkYerleri[kat, parkYeri];
        }
        set
        {
            if (kat < 0 || kat >= parkYerleri.GetLength(0) || parkYeri < 0 || parkYeri >= parkYerleri.GetLength(1))
            {
                Console.WriteLine("Hata: Geçersiz kat veya park yeri!");
            }
            else
            {
                parkYerleri[kat, parkYeri] = value;
            }
        }
    }

    // Tüm otopark durumunu gösteren metot
    public void OtoparkDurumu()
    {
        Console.WriteLine("\nOtopark Durumu:");
        for (int i = 0; i < parkYerleri.GetLength(0); i++)
        {
            Console.WriteLine($"Kat {i + 1}:");
            for (int j = 0; j < parkYerleri.GetLength(1); j++)
            {
                Console.WriteLine($"  Park Yeri {j + 1}: {parkYerleri[i, j]}");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 3 katlı, her katta 5 park yeri olan bir otopark oluşturma
        Otopark otopark = new Otopark(3, 5);

        // Araçları park etme
        otopark[0, 0] = "34ABC123";
        otopark[1, 2] = "34XYZ456";
        otopark[2, 4] = "06DEF789";

        // Tüm otopark durumunu gösterme
        otopark.OtoparkDurumu();

        // Belirli bir park yerindeki aracı sorgulama
        Console.WriteLine("\n1. kat, 1. park yerindeki durum: " + otopark[0, 0]);
        Console.WriteLine("2. kat, 3. park yerindeki durum: " + otopark[1, 2]);
        Console.WriteLine("3. kat, 5. park yerindeki durum: " + otopark[2, 4]);

        // Boş bir park yeri sorgulama
        Console.WriteLine("1. kat, 2. park yerindeki durum: " + otopark[0, 1]);

        // Geçersiz bir park yeri sorgulama
        Console.WriteLine("\nGeçersiz park yeri sorgusu: " + otopark[3, 5]);

        // Konsol ekranını açık tutmak için
        Console.WriteLine("\nÇıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
