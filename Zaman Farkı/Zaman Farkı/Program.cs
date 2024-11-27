using System;

class Program
{
    // Gün cinsinden farkı hesaplayan fonksiyon
    static int TarihFarkiGün(DateTime tarih1, DateTime tarih2)
    {
        return (int)(tarih2 - tarih1).TotalDays;
    }

    // Saat cinsinden farkı hesaplayan fonksiyon
    static double TarihFarkiSaat(DateTime tarih1, DateTime tarih2)
    {
        return (tarih2 - tarih1).TotalHours;
    }

    // Yıl, ay ve gün cinsinden farkı hesaplayan fonksiyon
    static (int Yillar, int Aylar, int Gunler) TarihFarkiDetayli(DateTime tarih1, DateTime tarih2)
    {
        int yillar = tarih2.Year - tarih1.Year;
        int aylar = tarih2.Month - tarih1.Month;
        int gunler = tarih2.Day - tarih1.Day;

        // Eğer gün farkı negatifse, aylar ve günler düzeltilecek
        if (gunler < 0)
        {
            aylar--;
            gunler += DateTime.DaysInMonth(tarih1.Year, tarih1.Month);
        }

        // Eğer ay farkı negatifse, yıllar ve aylar düzeltilecek
        if (aylar < 0)
        {
            yillar--;
            aylar += 12;
        }

        return (yillar, aylar, gunler);
    }

    static void Main(string[] args)
    {
        // Örnek tarihler
        DateTime tarih1 = new DateTime(2020, 1, 1);
        DateTime tarih2 = new DateTime(2023, 11, 27);

        // Gün cinsinden fark
        Console.WriteLine("Gün cinsinden fark: " + TarihFarkiGün(tarih1, tarih2));

        // Saat cinsinden fark
        Console.WriteLine("Saat cinsinden fark: " + TarihFarkiSaat(tarih1, tarih2));

        // Yıl, ay ve gün cinsinden fark
        var detayliFark = TarihFarkiDetayli(tarih1, tarih2);
        Console.WriteLine($"Yıl: {detayliFark.Yillar}, Ay: {detayliFark.Aylar}, Gün: {detayliFark.Gunler}");

        // Konsol ekranını açık tutmak için
        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
