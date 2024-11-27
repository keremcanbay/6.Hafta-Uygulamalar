using System;
using System.Collections.Generic;

class OgrenciNotSistemi
{
    // Ders ve notları depolayan sözlük
    private Dictionary<string, int> dersNotlari = new Dictionary<string, int>();

    // İndeksleyici
    public int this[string dersAdi]
    {
        get
        {
            if (dersNotlari.ContainsKey(dersAdi))
            {
                return dersNotlari[dersAdi];
            }
            else
            {
                Console.WriteLine($"Hata: '{dersAdi}' adlı ders bulunamadı.");
                return -1; // Geçersiz bir değer döndürür
            }
        }
        set
        {
            if (dersNotlari.ContainsKey(dersAdi))
            {
                dersNotlari[dersAdi] = value; // Mevcut bir dersin notunu güncelle
            }
            else
            {
                Console.WriteLine($"Hata: '{dersAdi}' adlı ders bulunamadı.");
            }
        }
    }

    // Ders ve not ekleme metodu
    public void DersEkle(string dersAdi, int not)
    {
        if (!dersNotlari.ContainsKey(dersAdi))
        {
            dersNotlari.Add(dersAdi, not);
            Console.WriteLine($"'{dersAdi}' dersi eklendi. Not: {not}");
        }
        else
        {
            Console.WriteLine($"Hata: '{dersAdi}' adlı ders zaten mevcut.");
        }
    }

    // Tüm dersleri listeleme metodu
    public void Listele()
    {
        Console.WriteLine("\nÖğrenci Ders Notları:");
        foreach (var ders in dersNotlari)
        {
            Console.WriteLine($"Ders: {ders.Key}, Not: {ders.Value}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Öğrenci not sistemi oluşturma
        OgrenciNotSistemi ogrenci = new OgrenciNotSistemi();

        // Ders ve not ekleme
        ogrenci.DersEkle("Matematik", 90);
        ogrenci.DersEkle("Fizik", 85);
        ogrenci.DersEkle("Kimya", 78);

        // Tüm dersleri listeleme
        ogrenci.Listele();

        // Bir dersin notunu alma
        Console.WriteLine("\nFizik dersinin notu: " + ogrenci["Fizik"]);

        // Geçersiz ders kontrolü
        Console.WriteLine("\nTarih dersinin notu: " + ogrenci["Tarih"]);

        // Bir dersin notunu güncelleme
        ogrenci["Matematik"] = 95;

        // Güncellenmiş notları listeleme
        Console.WriteLine();
        ogrenci.Listele();

        // Konsol ekranını açık tutmak için
        Console.WriteLine("\nÇıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
