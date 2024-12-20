/*
2. Farklı Şekillerin Alanını Hesaplayan Bir Fonksiyon
Bir fonksiyon yazın:
 Aynı adla ama farklı parametrelerle farklı şekillerin alanını hesaplasın.
 İlk sürüm, bir karenin alanını hesaplasın (bir kenar uzunluğu verilerek).
 İkinci sürüm, bir dikdörtgenin alanını hesaplasın (iki kenar uzunluğu verilerek).
 Üçüncü sürüm, bir dairenin alanını hesaplasın (yarıçap verilerek).
*/

using System;

class Program
{
    // İlk sürüm: Karenin alanını hesaplayan metod
    public static double AlanHesapla(double kenar)
    {
        return kenar * kenar;
    }

    // İkinci sürüm: Dikdörtgenin alanını hesaplayan metod
    public static double AlanHesapla(double uzunluk, double genislik)
    {
        return uzunluk * genislik;
    }

    // Üçüncü sürüm: Dairenin alanını hesaplayan metod
    public static double AlanHesapla(double yaricap, bool daire)
    {
        // Dairenin alanını hesapla: πr²
        return Math.PI * yaricap * yaricap;
    }

    static void Main(string[] args)
    {
        // Karenin alanını hesaplama
        Console.WriteLine("Karenin Alanı: " + AlanHesapla(5));

        // Dikdörtgenin alanını hesaplama
        Console.WriteLine("Dikdörtgenin Alanı: " + AlanHesapla(4, 6));

        // Dairenin alanını hesaplama
        Console.WriteLine("Dairenin Alanı: " + AlanHesapla(3, true));
    }
}
