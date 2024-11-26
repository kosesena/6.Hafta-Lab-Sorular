using System;
using System.Collections.Generic;

public class OgrenciNotSistemi
{
    private Dictionary<string, int> dersNotlari;

    public OgrenciNotSistemi()
    {
        dersNotlari = new Dictionary<string, int>();
    }

    // Not ekleme metodu
    public void DersEkle(string dersAdi, int not)
    {
        if (!dersNotlari.ContainsKey(dersAdi))
        {
            dersNotlari[dersAdi] = not;
        }
        else
        {
            Console.WriteLine("Bu ders zaten ekli. Notunu güncellemek için GüncelleNot metodunu kullanın.");
        }
    }

    // Not güncelleme metodu
    public void NotGuncelle(string dersAdi, int yeniNot)
    {
        if (dersNotlari.ContainsKey(dersAdi))
        {
            dersNotlari[dersAdi] = yeniNot;
        }
        else
        {
            Console.WriteLine("Ders bulunamadı! Önce dersi eklemelisiniz.");
        }
    }

    // İndeksleme operatörünü override ediyoruz
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
                Console.WriteLine("Hata: Ders bulunamadı!");
                return -1; // Hata durumunda -1 döndürülür
            }
        }
        set
        {
            if (dersNotlari.ContainsKey(dersAdi))
            {
                dersNotlari[dersAdi] = value;
            }
            else
            {
                Console.WriteLine("Hata: Ders bulunamadı! Önce dersi ekleyin.");
            }
        }
    }

    // Dersleri listeleme
    public void DersleriListele()
    {
        Console.WriteLine("Dersler ve Notlar:");
        foreach (var ders in dersNotlari)
        {
            Console.WriteLine($"{ders.Key}: {ders.Value}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        OgrenciNotSistemi notSistemi = new OgrenciNotSistemi();

        // Ders ekleme
        notSistemi.DersEkle("Matematik", 85);
        notSistemi.DersEkle("Fizik", 90);
        notSistemi.DersEkle("Kimya", 78);

        // Notları listeleme
        notSistemi.DersleriListele();

        // İndeksleyici ile bir dersin notunu alma
        Console.WriteLine("Fizik Notu: " + notSistemi["Fizik"]);

        // Hata mesajı denemesi (bulunamayan ders)
        Console.WriteLine("Tarih Notu: " + notSistemi["Tarih"]);

        // Not güncelleme
        notSistemi["Fizik"] = 95;
        Console.WriteLine("Fizik Notu Güncellendi: " + notSistemi["Fizik"]);

        // Güncel dersleri listeleme
        notSistemi.DersleriListele();
    }
}
