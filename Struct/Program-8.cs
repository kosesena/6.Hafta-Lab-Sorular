using System;

public struct Zaman
{
    public int Hour { get; set; }
    public int Minute { get; set; }

    // Yapıcı (constructor) metot
    public Zaman(int hour, int minute)
    {
        // Geçerli aralıkta olup olmadığını kontrol et
        if (hour >= 0 && hour < 24)
            Hour = hour;
        else
            Hour = 0;

        if (minute >= 0 && minute < 60)
            Minute = minute;
        else
            Minute = 0;
    }

    // Zamanın toplam dakika değerini döndüren metot
    public int ToplamDakika()
    {
        return (Hour * 60) + Minute;
    }

    // İki zaman arasındaki farkı dakika olarak hesaplayan metot
    public int Fark(Zaman digerZaman)
    {
        int buZamanDakika = this.ToplamDakika();
        int digerZamanDakika = digerZaman.ToplamDakika();

        return Math.Abs(buZamanDakika - digerZamanDakika);
    }

    // Zaman bilgisini string olarak döndüren metot
    public override string ToString()
    {
        return $"{Hour:D2}:{Minute:D2}"; // Saat ve dakikayı "HH:MM" formatında döndürür
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Zaman nesneleri oluştur
        Zaman zaman1 = new Zaman(10, 45);
        Zaman zaman2 = new Zaman(14, 30);

        // Toplam dakika hesaplama
        Console.WriteLine($"Zaman 1: {zaman1}, Toplam Dakika: {zaman1.ToplamDakika()}");
        Console.WriteLine($"Zaman 2: {zaman2}, Toplam Dakika: {zaman2.ToplamDakika()}");

        // Zamanlar arasındaki fark
        Console.WriteLine($"İki zaman arasındaki fark: {zaman1.Fark(zaman2)} dakika");

        // Geçersiz bir zaman nesnesi
        Zaman zaman3 = new Zaman(25, 70); // Geçersiz değerler girildi
        Console.WriteLine($"Zaman 3: {zaman3} (Geçersiz değerler 0'a ayarlandı)");
    }
}