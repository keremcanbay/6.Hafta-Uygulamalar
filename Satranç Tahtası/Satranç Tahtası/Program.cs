using System;

class SatrancTahtasi
{
    private string[,] tahtadakiTaslar = new string[8, 8];

    // Yapıcı metot: Başlangıçta tüm kareler boş
    public SatrancTahtasi()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                tahtadakiTaslar[i, j] = "Boş";
            }
        }
    }

    // İndeksleyici: Satır ve sütuna göre taş bilgisi alma veya koyma
    public string this[int satir, int sutun]
    {
        get
        {
            if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
            {
                return "Hata: Geçersiz kare!";
            }
            return tahtadakiTaslar[satir, sutun];
        }
        set
        {
            if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
            {
                Console.WriteLine("Hata: Geçersiz kare!");
            }
            else
            {
                tahtadakiTaslar[satir, sutun] = value;
            }
        }
    }

    // Tahtayı yazdıran metot
    public void TahtayiGoster()
    {
        Console.WriteLine("Satranç Tahtası Durumu:");
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(tahtadakiTaslar[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Satranç tahtası oluşturma
        SatrancTahtasi tahtasi = new SatrancTahtasi();

        // Taş ekleme
        tahtasi[0, 0] = "Kale";
        tahtasi[0, 1] = "At";
        tahtasi[0, 2] = "Fil";
        tahtasi[7, 7] = "Şah";

        // Tahtayı gösterme
        tahtasi.TahtayiGoster();

        // Belirli bir karenin taşını öğrenme
        Console.WriteLine("\n(0, 0) karesindeki taş: " + tahtasi[0, 0]);

        // Geçersiz kare kontrolü
        Console.WriteLine("\n(8, 8) karesindeki taş: " + tahtasi[8, 8]);

        // Taş değiştirme
        tahtasi[0, 0] = "Vezir";

        // Güncellenmiş tahtayı gösterme
        Console.WriteLine();
        tahtasi.TahtayiGoster();

        // Konsol ekranını açık tutmak için
        Console.WriteLine("\nÇıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
