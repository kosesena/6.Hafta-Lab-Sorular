using System;

class Program
{
    // İlk sürüm: İki tam sayıyı toplayan metod
    public static int Topla(int a, int b)
    {
        return a + b;
    }

    // İkinci sürüm: Üç tam sayıyı toplayan metod
    public static int Topla(int a, int b, int c)
    {
        return a + b + c;
    }

    // Üçüncü sürüm: Bir dizi tam sayıyı toplayan metod
    public static int Topla(int[] sayilar)
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
        // İlk sürümün testi
        Console.WriteLine("İki tam sayının toplamı: " + Topla(5, 10));

        // İkinci sürümün testi
        Console.WriteLine("Üç tam sayının toplamı: " + Topla(3, 6, 9));

        // Üçüncü sürümün testi
        int[] dizi = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Dizinin elemanlarının toplamı: " + Topla(dizi));
    }
}