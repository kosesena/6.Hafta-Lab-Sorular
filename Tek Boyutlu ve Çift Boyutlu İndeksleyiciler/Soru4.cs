/*Tek Boyutlu ve Çift Boyutlu İndeksleyiciler
1. Özel Bir Kitaplık Yönetim Sistemi
Bir sınıf oluşturun:
 Sınıf, bir kitap koleksiyonunu (dizi) depolasın.
 Kullanıcı, indeksleyici aracılığıyla belirli bir indekste hangi kitabın olduğunu
öğrenebilsin ve kitap adını değiştirebilsin.
 Eğer kullanıcı geçersiz bir indeks ile erişim yaparsa uygun bir hata mesajı döndürsün. */

using System;

public class Kitaplik
{
    private string[] kitaplar;

    public Kitaplik(int kapasite)
    {
        // Belirtilen kapasiteye göre kitap koleksiyonu oluşturulur.
        kitaplar = new string[kapasite];
        for (int i = 0; i < kapasite; i++)
        {
            kitaplar[i] = "Boş"; // Varsayılan olarak "Boş" ataması yapılır.
        }
    }

    // İndeksleyici: Kitapları okumak ve değiştirmek için kullanılır.
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

    // Tüm kitapları listeleyen bir yöntem.
    public void KitaplariListele()
    {
        Console.WriteLine("Kitap Listesi:");
        for (int i = 0; i < kitaplar.Length; i++)
        {
            Console.WriteLine($"İndeks {i}: {kitaplar[i]}");
        }
    }
}

// Ana program
class Program
{
    static void Main(string[] args)
    {
        Kitaplik kitaplik = new Kitaplik(5); // 5 kitap kapasiteli bir kitaplık oluşturuluyor.

        // Kitap ekleme
        kitaplik[0] = "Sefiller";
        kitaplik[1] = "Suç ve Ceza";
        kitaplik[2] = "1984";

        // Kitapları listeleme
        kitaplik.KitaplariListele();

        // Geçerli bir indeks üzerinden erişim
        Console.WriteLine("\nİndeks 1'deki kitap: " + kitaplik[1]);

        // Geçersiz bir indeks üzerinden erişim
        Console.WriteLine("\nİndeks 10'daki kitap: " + kitaplik[10]);

        // Bir kitabı güncelleme
        kitaplik[2] = "Hayvan Çiftliği";
        Console.WriteLine("\nGüncellenmiş Kitaplar:");
        kitaplik.KitaplariListele();

        // Geçersiz bir indeksle kitap değiştirme
        kitaplik[6] = "Silmarillion";
    }
}
