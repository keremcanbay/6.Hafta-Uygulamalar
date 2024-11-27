using System;

enum CalisanRol
{
    Manager,   // Yönetici
    Developer, // Yazılımcı
    Designer,  // Tasarımcı
    Tester     // Test Uzmanı
}

class MaaşHesaplayıcı
{
    // Çalışan rolüne göre maaş hesaplayan metot
    public double MaasHesapla(CalisanRol rol)
    {
        switch (rol)
        {
            case CalisanRol.Manager:
                return 8000; // Yöneticiler için maaş
            case CalisanRol.Developer:
                return 6000; // Yazılımcılar için maaş
            case CalisanRol.Designer:
                return 5000; // Tasarımcılar için maaş
            case CalisanRol.Tester:
                return 4000; // Test uzmanları için maaş
            default:
                return 0; // Tanımlanmamış bir rol için maaş
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Maaş hesaplayıcı nesnesi oluşturuluyor
        MaaşHesaplayıcı maasHesaplayici = new MaaşHesaplayıcı();

        // Çeşitli roller için maaş hesaplama
        double managerMaas = maasHesaplayici.MaasHesapla(CalisanRol.Manager);
        double developerMaas = maasHesaplayici.MaasHesapla(CalisanRol.Developer);
        double designerMaas = maasHesaplayici.MaasHesapla(CalisanRol.Designer);
        double testerMaas = maasHesaplayici.MaasHesapla(CalisanRol.Tester);

        // Hesaplanan maaşları ekrana yazdırma
        Console.WriteLine($"Yönetici Maaşı: {managerMaas} TL");
        Console.WriteLine($"Yazılımcı Maaşı: {developerMaas} TL");
        Console.WriteLine($"Tasarımcı Maaşı: {designerMaas} TL");
        Console.WriteLine($"Test Uzmanı Maaşı: {testerMaas} TL");

        // Konsol ekranını açık tutmak için
        Console.WriteLine("\nÇıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}

