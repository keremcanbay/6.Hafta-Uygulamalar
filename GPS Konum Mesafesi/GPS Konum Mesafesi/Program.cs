using System;

struct GPSKonum
{
    public double Enlem { get; set; }  // Enlem (Latitude)
    public double Boylam { get; set; } // Boylam (Longitude)

    // Yapıcı metot
    public GPSKonum(double enlem, double boylam)
    {
        Enlem = enlem;
        Boylam = boylam;
    }

    // İki GPS konumu arasındaki mesafeyi kilometre olarak hesaplayan metot
    public double MesafeHesapla(GPSKonum diger)
    {
        const double R = 6371; // Dünya'nın yarıçapı (km cinsinden)

        // Enlem ve boylamları dereceyi radiana çevirelim
        double enlem1 = DegreToRadian(this.Enlem);
        double boylam1 = DegreToRadian(this.Boylam);
        double enlem2 = DegreToRadian(diger.Enlem);
        double boylam2 = DegreToRadian(diger.Boylam);

        // Haversine formülü
        double deltaEnlem = enlem2 - enlem1;
        double deltaBoylam = boylam2 - boylam1;

        double a = Math.Sin(deltaEnlem / 2) * Math.Sin(deltaEnlem / 2) +
                   Math.Cos(enlem1) * Math.Cos(enlem2) *
                   Math.Sin(deltaBoylam / 2) * Math.Sin(deltaBoylam / 2);
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        // Mesafeyi hesapla
        double mesafe = R * c;

        return mesafe;
    }

    // Dereceyi radiana çeviren yardımcı metot
    private double DegreToRadian(double derece)
    {
        return derece * (Math.PI / 180);
    }

    // GPS konumunu yazdırmak için ToString metodu
    public override string ToString()
    {
        return $"Enlem: {Enlem}, Boylam: {Boylam}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // İki GPS konumu oluşturma
        GPSKonum konum1 = new GPSKonum(40.7128, -74.0060); // New York (Enlem: 40.7128, Boylam: -74.0060)
        GPSKonum konum2 = new GPSKonum(34.0522, -118.2437); // Los Angeles (Enlem: 34.0522, Boylam: -118.2437)

        // Konumları ekrana yazdırma
        Console.WriteLine($"Konum 1: {konum1}");
        Console.WriteLine($"Konum 2: {konum2}");

        // Mesafeyi hesaplama
        double mesafe = konum1.MesafeHesapla(konum2);
        Console.WriteLine($"\nMesafe: {mesafe:F2} km");

        // Konsol ekranını açık tutmak için
        Console.WriteLine("\nÇıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
