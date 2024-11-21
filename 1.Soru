/* 
Overloading ile ilgili ilk örneğimiz:

1. Matematiksel İşlemleri Çeşitlendiren Bir Fonksiyon
- Aynı adla ama farklı parametrelerle toplam işlemi yapacak,
- İlk sürümü iki tam sayıyı toplasın,
- İkinci sürümü üç tam sayıyı toplasın,
- Üçüncü sürümü bir dizi (array) tam sayıyı toplasın.
*/

using System;

class Program
{
    // İki tam sayı toplama
    static int Sum(int a, int b)
    {
        return a + b;
    }

    // Üç tam sayı toplama
    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    // Bir dizi (array) içerisindeki tüm elemanları toplama
    static int Sum(int[] numbers)
    {
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        return total;
    }

    static void Main(string[] args)
    {
        // İki sayı ile toplama
        Console.WriteLine("İki sayının toplamı: " + Sum(5, 10));

        // Üç sayı ile toplama
        Console.WriteLine("Üç sayının toplamı: " + Sum(5, 10, 15));

        // Bir dizi ile toplama
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Dizideki sayıların toplamı: " + Sum(numbers));
    }
}

/* 
Çıktı:    İki sayının toplamı: 15
          Üç sayının toplamı: 30
          Dizideki sayıların toplamı: 15
*/

/* Bu soruda üç farklı Sum fonksiyonunu overload edip yazdırdık. */
