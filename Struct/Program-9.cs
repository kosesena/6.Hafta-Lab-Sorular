using System;

public struct KarmasikSayi
{
    public double Real { get; set; }       // Gerçek kısmı
    public double Imaginary { get; set; } // İmajiner kısmı

    // Yapıcı (constructor) metot
    public KarmasikSayi(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Karmaşık sayıları toplama
    public KarmasikSayi Topla(KarmasikSayi diger)
    {
        return new KarmasikSayi(this.Real + diger.Real, this.Imaginary + diger.Imaginary);
    }

    // Karmaşık sayıları çıkarma
    public KarmasikSayi Cikar(KarmasikSayi diger)
    {
        return new KarmasikSayi(this.Real - diger.Real, this.Imaginary - diger.Imaginary);
    }

    // Karmaşık sayıyı "a + bi" formatında döndürme
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Karmaşık sayılar oluştur
        KarmasikSayi sayi1 = new KarmasikSayi(3, 4); // 3 + 4i
        KarmasikSayi sayi2 = new KarmasikSayi(1, -2); // 1 - 2i

        // Toplama işlemi
        KarmasikSayi toplam = sayi1.Topla(sayi2);
        Console.WriteLine($"Toplam: {toplam}");

        // Çıkarma işlemi
        KarmasikSayi fark = sayi1.Cikar(sayi2);
        Console.WriteLine($"Fark: {fark}");
    }
}