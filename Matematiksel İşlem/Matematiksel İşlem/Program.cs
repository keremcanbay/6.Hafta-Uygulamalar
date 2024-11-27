using System;

class Program
{
    // İki tam sayı için toplama işlemi
    static int Topla(int a, int b)
    {
        return a + b;
    }

    // Üç tam sayı için toplama işlemi
    static int Topla(int a, int b, int c)
    {
        return a + b + c;
    }

    // Dizi (array) içindeki tüm tam sayıları toplayan fonksiyon
    static int Topla(int[] sayilar)
    {
        int toplam = 0;
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam;
    }

    static void Main(string[] args)
    {
        // Fonksiyonların kullanım örnekleri
        Console.WriteLine("2 sayının toplamı: " + Topla(5, 10));
        Console.WriteLine("3 sayının toplamı: " + Topla(5, 10, 15));
        Console.WriteLine("Dizi elemanlarının toplamı: " + Topla(new int[] { 5, 10, 15, 20 }));

        // Konsol ekranını açık tutmak için
        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
