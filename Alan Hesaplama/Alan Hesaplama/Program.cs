using System;

class Program
{
    // Karenin alanını hesaplayan fonksiyon
    static double Alan(double kenar)
    {
        return kenar * kenar;
    }

    // Dikdörtgenin alanını hesaplayan fonksiyon
    static double Alan(double uzunKenar, double kisaKenar)
    {
        return uzunKenar * kisaKenar;
    }

    // Dairenin alanını hesaplayan fonksiyon
    static double Alan(double yaricap, bool daire)
    {
        const double Pi = 3.14159;
        return Pi * yaricap * yaricap;
    }

    static void Main(string[] args)
    {
        // Karenin alanını hesaplama
        Console.WriteLine("Karenin alanı: " + Alan(5));

        // Dikdörtgenin alanını hesaplama
        Console.WriteLine("Dikdörtgenin alanı: " + Alan(5, 10));

        // Dairenin alanını hesaplama
        Console.WriteLine("Dairenin alanı: " + Alan(7, true));

        // Konsol ekranını açık tutmak için
        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
